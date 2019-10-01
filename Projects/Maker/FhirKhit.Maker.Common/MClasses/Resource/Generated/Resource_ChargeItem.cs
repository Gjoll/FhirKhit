using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'ChargeItem'
    /// </summary>
    // 0. ChargeItem
    public class Resource_ChargeItem : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_ChargeItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 10. ChargeItem.performer
            public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Performer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 11. ChargeItem.performer.function
                    public ElementDefinitionInfo Element_Function;                                                                          // MakerGen.cs:211
                    // 12. ChargeItem.performer.actor
                    public ElementDefinitionInfo Element_Actor;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Performer_Elements()                                                                                        // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. ChargeItem.performer.function
                            this.Element_Function = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Function",                                                                                  // MakerGen.cs:230
                                Path= "ChargeItem.performer.function",                                                                      // MakerGen.cs:231
                                Id = "ChargeItem.performer.function",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. ChargeItem.performer.actor
                            this.Element_Actor = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Actor",                                                                                     // MakerGen.cs:230
                                Path= "ChargeItem.performer.actor",                                                                         // MakerGen.cs:231
                                Id = "ChargeItem.performer.actor",                                                                          // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/CareTeam",                                             // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Function.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Actor.Write(sDef);                                                                                          // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Performer_Elements Elements                                                                                     // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Performer_Elements();                                                                  // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Performer_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Performer()                                                                                                     // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ChargeItem.performer",                                                                                      // MakerGen.cs:420
                        ElementId = "ChargeItem.performer"                                                                                  // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. ChargeItem.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. ChargeItem.definitionUri
            public ElementDefinitionInfo Element_DefinitionUri;                                                                             // MakerGen.cs:211
            // 3. ChargeItem.definitionCanonical
            public ElementDefinitionInfo Element_DefinitionCanonical;                                                                       // MakerGen.cs:211
            // 4. ChargeItem.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 5. ChargeItem.partOf
            public ElementDefinitionInfo Element_PartOf;                                                                                    // MakerGen.cs:211
            // 6. ChargeItem.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
            // 7. ChargeItem.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 8. ChargeItem.context
            public ElementDefinitionInfo Element_Context;                                                                                   // MakerGen.cs:211
            // 9. ChargeItem.occurrence[x]
            public ElementDefinitionInfo Element_Occurrence;                                                                                // MakerGen.cs:211
            // 10. ChargeItem.performer
            public ElementDefinitionInfo Element_Performer;                                                                                 // MakerGen.cs:211
            // 13. ChargeItem.performingOrganization
            public ElementDefinitionInfo Element_PerformingOrganization;                                                                    // MakerGen.cs:211
            // 14. ChargeItem.requestingOrganization
            public ElementDefinitionInfo Element_RequestingOrganization;                                                                    // MakerGen.cs:211
            // 15. ChargeItem.costCenter
            public ElementDefinitionInfo Element_CostCenter;                                                                                // MakerGen.cs:211
            // 16. ChargeItem.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:211
            // 17. ChargeItem.bodysite
            public ElementDefinitionInfo Element_Bodysite;                                                                                  // MakerGen.cs:211
            // 18. ChargeItem.factorOverride
            public ElementDefinitionInfo Element_FactorOverride;                                                                            // MakerGen.cs:211
            // 19. ChargeItem.priceOverride
            public ElementDefinitionInfo Element_PriceOverride;                                                                             // MakerGen.cs:211
            // 20. ChargeItem.overrideReason
            public ElementDefinitionInfo Element_OverrideReason;                                                                            // MakerGen.cs:211
            // 21. ChargeItem.enterer
            public ElementDefinitionInfo Element_Enterer;                                                                                   // MakerGen.cs:211
            // 22. ChargeItem.enteredDate
            public ElementDefinitionInfo Element_EnteredDate;                                                                               // MakerGen.cs:211
            // 23. ChargeItem.reason
            public ElementDefinitionInfo Element_Reason;                                                                                    // MakerGen.cs:211
            // 24. ChargeItem.service
            public ElementDefinitionInfo Element_Service;                                                                                   // MakerGen.cs:211
            // 25. ChargeItem.product[x]
            public ElementDefinitionInfo Element_Product;                                                                                   // MakerGen.cs:211
            // 26. ChargeItem.account
            public ElementDefinitionInfo Element_Account;                                                                                   // MakerGen.cs:211
            // 27. ChargeItem.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:211
            // 28. ChargeItem.supportingInformation
            public ElementDefinitionInfo Element_SupportingInformation;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_ChargeItem_Elements()                                                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ChargeItem.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "ChargeItem.identifier",                                                                                      // MakerGen.cs:231
                        Id = "ChargeItem.identifier",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ChargeItem.definitionUri
                    this.Element_DefinitionUri = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DefinitionUri",                                                                                     // MakerGen.cs:230
                        Path= "ChargeItem.definitionUri",                                                                                   // MakerGen.cs:231
                        Id = "ChargeItem.definitionUri",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ChargeItem.definitionCanonical
                    this.Element_DefinitionCanonical = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DefinitionCanonical",                                                                               // MakerGen.cs:230
                        Path= "ChargeItem.definitionCanonical",                                                                             // MakerGen.cs:231
                        Id = "ChargeItem.definitionCanonical",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition"                                          // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ChargeItem.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "ChargeItem.status",                                                                                          // MakerGen.cs:231
                        Id = "ChargeItem.status",                                                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ChargeItem.partOf
                    this.Element_PartOf = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PartOf",                                                                                            // MakerGen.cs:230
                        Path= "ChargeItem.partOf",                                                                                          // MakerGen.cs:231
                        Id = "ChargeItem.partOf",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ChargeItem"                                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ChargeItem.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "ChargeItem.code",                                                                                            // MakerGen.cs:231
                        Id = "ChargeItem.code",                                                                                             // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ChargeItem.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.subject",                                                                                         // MakerGen.cs:231
                        Id = "ChargeItem.subject",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ChargeItem.context
                    this.Element_Context = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Context",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.context",                                                                                         // MakerGen.cs:231
                        Id = "ChargeItem.context",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ChargeItem.occurrence[x]
                    this.Element_Occurrence = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Occurrence",                                                                                        // MakerGen.cs:230
                        Path= "ChargeItem.occurrence[x]",                                                                                   // MakerGen.cs:231
                        Id = "ChargeItem.occurrence[x]",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Timing                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ChargeItem.performer
                    this.Element_Performer = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Performer",                                                                                         // MakerGen.cs:230
                        Path= "ChargeItem.performer",                                                                                       // MakerGen.cs:231
                        Id = "ChargeItem.performer",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Performer                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ChargeItem.performingOrganization
                    this.Element_PerformingOrganization = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PerformingOrganization",                                                                            // MakerGen.cs:230
                        Path= "ChargeItem.performingOrganization",                                                                          // MakerGen.cs:231
                        Id = "ChargeItem.performingOrganization",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ChargeItem.requestingOrganization
                    this.Element_RequestingOrganization = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RequestingOrganization",                                                                            // MakerGen.cs:230
                        Path= "ChargeItem.requestingOrganization",                                                                          // MakerGen.cs:231
                        Id = "ChargeItem.requestingOrganization",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. ChargeItem.costCenter
                    this.Element_CostCenter = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_CostCenter",                                                                                        // MakerGen.cs:230
                        Path= "ChargeItem.costCenter",                                                                                      // MakerGen.cs:231
                        Id = "ChargeItem.costCenter",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ChargeItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:230
                        Path= "ChargeItem.quantity",                                                                                        // MakerGen.cs:231
                        Id = "ChargeItem.quantity",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. ChargeItem.bodysite
                    this.Element_Bodysite = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Bodysite",                                                                                          // MakerGen.cs:230
                        Path= "ChargeItem.bodysite",                                                                                        // MakerGen.cs:231
                        Id = "ChargeItem.bodysite",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. ChargeItem.factorOverride
                    this.Element_FactorOverride = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_FactorOverride",                                                                                    // MakerGen.cs:230
                        Path= "ChargeItem.factorOverride",                                                                                  // MakerGen.cs:231
                        Id = "ChargeItem.factorOverride",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. ChargeItem.priceOverride
                    this.Element_PriceOverride = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PriceOverride",                                                                                     // MakerGen.cs:230
                        Path= "ChargeItem.priceOverride",                                                                                   // MakerGen.cs:231
                        Id = "ChargeItem.priceOverride",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Money                                                                    // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. ChargeItem.overrideReason
                    this.Element_OverrideReason = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OverrideReason",                                                                                    // MakerGen.cs:230
                        Path= "ChargeItem.overrideReason",                                                                                  // MakerGen.cs:231
                        Id = "ChargeItem.overrideReason",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. ChargeItem.enterer
                    this.Element_Enterer = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Enterer",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.enterer",                                                                                         // MakerGen.cs:231
                        Id = "ChargeItem.enterer",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. ChargeItem.enteredDate
                    this.Element_EnteredDate = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_EnteredDate",                                                                                       // MakerGen.cs:230
                        Path= "ChargeItem.enteredDate",                                                                                     // MakerGen.cs:231
                        Id = "ChargeItem.enteredDate",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. ChargeItem.reason
                    this.Element_Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Reason",                                                                                            // MakerGen.cs:230
                        Path= "ChargeItem.reason",                                                                                          // MakerGen.cs:231
                        Id = "ChargeItem.reason",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. ChargeItem.service
                    this.Element_Service = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Service",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.service",                                                                                         // MakerGen.cs:231
                        Id = "ChargeItem.service",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/ImagingStudy",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",                                     // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/MedicationDispense",                                           // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"                                                // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. ChargeItem.product[x]
                    this.Element_Product = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Product",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.product[x]",                                                                                      // MakerGen.cs:231
                        Id = "ChargeItem.product[x]",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:342
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. ChargeItem.account
                    this.Element_Account = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Account",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItem.account",                                                                                         // MakerGen.cs:231
                        Id = "ChargeItem.account",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Account"                                                       // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 27. ChargeItem.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Note",                                                                                              // MakerGen.cs:230
                        Path= "ChargeItem.note",                                                                                            // MakerGen.cs:231
                        Id = "ChargeItem.note",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 28. ChargeItem.supportingInformation
                    this.Element_SupportingInformation = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_SupportingInformation",                                                                             // MakerGen.cs:230
                        Path= "ChargeItem.supportingInformation",                                                                           // MakerGen.cs:231
                        Id = "ChargeItem.supportingInformation",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_DefinitionUri.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_DefinitionCanonical.Write(sDef);                                                                                    // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_PartOf.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Context.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Occurrence.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Performer.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_PerformingOrganization.Write(sDef);                                                                                 // MakerGen.cs:215
                Element_RequestingOrganization.Write(sDef);                                                                                 // MakerGen.cs:215
                Element_CostCenter.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Bodysite.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_FactorOverride.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_PriceOverride.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_OverrideReason.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_Enterer.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_EnteredDate.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Reason.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Service.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Product.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Account.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_SupportingInformation.Write(sDef);                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_ChargeItem_Elements Elements                                                                                        // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_ChargeItem_Elements();                                                                     // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_ChargeItem_Elements elements;                                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_ChargeItem()                                                                                                        // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "ChargeItem";                                                                                                       // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ChargeItem";                                                                // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ChargeItem",                                                                                                        // MakerGen.cs:420
                ElementId = "ChargeItem"                                                                                                    // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
