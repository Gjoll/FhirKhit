using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "ChargeItemDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition",
      "version": "4.0.0",
      "name": "ChargeItemDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "The ChargeItemDefinition resource provides the properties that apply to the (billing) codes necessary to calculate costs and prices. The properties may differ largely depending on type and realm, therefore this resource gives only a rough structure and requires profiling for each type of billing code system.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ChargeItemDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "_baseDefinition": {
        "extension": [
          {
            "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-codegen-super",
            "valueString": "MetadataResource"
          }
        ]
      },
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ChargeItemDefinition",
            "path": "ChargeItemDefinition",
            "short": "Definition of properties and rules about how the price and the applicability of a ChargeItem can be determined",
            "definition": "The ChargeItemDefinition resource provides the properties that apply to the (billing) codes necessary to calculate costs and prices. The properties may differ largely depending on type and realm, therefore this resource gives only a rough structure and requires profiling for each type of billing code system.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ChargeItemDefinition.url",
            "path": "ChargeItemDefinition.url",
            "short": "Canonical identifier for this charge item definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this charge item definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this charge item definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the charge item definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the charge item definition to be referenced by a single globally unique identifier.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.identifier",
            "path": "ChargeItemDefinition.identifier",
            "short": "Additional identifier for the charge item definition",
            "definition": "A formal identifier that is used to identify this charge item definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this charge item definition outside of FHIR, where it is not possible to use the logical URI.",
            "requirements": "Allows externally provided and/or usable business identifiers to be easily associated with the module.",
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
            "id": "ChargeItemDefinition.version",
            "path": "ChargeItemDefinition.version",
            "short": "Business version of the charge item definition",
            "definition": "The identifier that is used to identify this version of the charge item definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the charge item definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active assets.",
            "comment": "There may be different charge item definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the charge item definition with the format [url]|[version].",
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
            "id": "ChargeItemDefinition.title",
            "path": "ChargeItemDefinition.title",
            "short": "Name for this charge item definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the charge item definition.",
            "comment": "This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc.",
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
            "id": "ChargeItemDefinition.derivedFromUri",
            "path": "ChargeItemDefinition.derivedFromUri",
            "short": "Underlying externally-defined charge item definition",
            "definition": "The URL pointing to an externally-defined charge item definition that is adhered to in whole or in part by this definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.partOf",
            "path": "ChargeItemDefinition.partOf",
            "short": "A larger definition of which this particular definition is a component or step",
            "definition": "A larger definition of which this particular definition is a component or step.",
            "alias": [
              "container"
            ],
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
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.replaces",
            "path": "ChargeItemDefinition.replaces",
            "short": "Completed or terminated request(s) whose function is taken by this new request",
            "definition": "As new versions of a protocol or guideline are defined, allows identification of what versions are replaced by a new instance.",
            "alias": [
              "supersedes",
              "prior",
              "renewed order"
            ],
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
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.status",
            "path": "ChargeItemDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The current state of the ChargeItemDefinition.",
            "comment": "Allows filtering of charge item definitions that are appropriate for use versus not.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not use a retired {{title}} without due consideration",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PublicationStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The lifecycle status of an artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/publication-status|4.0.0"
            }
          },
          {
            "id": "ChargeItemDefinition.experimental",
            "path": "ChargeItemDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this charge item definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of charge item definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level charge item definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.date",
            "path": "ChargeItemDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the charge item definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the charge item definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the charge item definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
            "alias": [
              "Revision Date"
            ],
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
            "id": "ChargeItemDefinition.publisher",
            "path": "ChargeItemDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the charge item definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the charge item definition is the organization or individual primarily responsible for the maintenance and upkeep of the charge item definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the charge item definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the charge item definition.  May also allow for contact.",
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
            "id": "ChargeItemDefinition.contact",
            "path": "ChargeItemDefinition.contact",
            "short": "Contact details for the publisher",
            "definition": "Contact details to assist a user in finding and communicating with the publisher.",
            "comment": "May be a web site, an email address, a telephone number, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.description",
            "path": "ChargeItemDefinition.description",
            "short": "Natural language description of the charge item definition",
            "definition": "A free text natural language description of the charge item definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the charge item definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the charge item definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the charge item definition is presumed to be the predominant language in the place the charge item definition was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.useContext",
            "path": "ChargeItemDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate charge item definition instances.",
            "comment": "When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.",
            "requirements": "Assist in searching for appropriate content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "UsageContext"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ChargeItemDefinition.jurisdiction",
            "path": "ChargeItemDefinition.jurisdiction",
            "short": "Intended jurisdiction for charge item definition (if applicable)",
            "definition": "A legal or geographic region in which the charge item definition is intended to be used.",
            "comment": "It may be possible for the charge item definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
                  "valueString": "Jurisdiction"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Countries and regions within which this artifact is targeted for use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/jurisdiction"
            }
          },
          {
            "id": "ChargeItemDefinition.copyright",
            "path": "ChargeItemDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the charge item definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the charge item definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the charge item definition and/or its content.",
            "alias": [
              "License",
              "Restrictions"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.approvalDate",
            "path": "ChargeItemDefinition.approvalDate",
            "short": "When the charge item definition was approved by publisher",
            "definition": "The date on which the resource content was approved by the publisher. Approval happens once when the content is officially approved for usage.",
            "comment": "The 'date' element may be more recent than the approval date because of minor changes or editorial corrections.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.lastReviewDate",
            "path": "ChargeItemDefinition.lastReviewDate",
            "short": "When the charge item definition was last reviewed",
            "definition": "The date on which the resource content was last reviewed. Review happens periodically after approval but does not change the original approval date.",
            "comment": "If specified, this date follows the original approval date.",
            "requirements": "Gives a sense of how \"current\" the content is.  Resources that have not been reviewed in a long time may have a risk of being less appropriate/relevant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.effectivePeriod",
            "path": "ChargeItemDefinition.effectivePeriod",
            "short": "When the charge item definition is expected to be used",
            "definition": "The period during which the charge item definition content was or is planned to be in active use.",
            "comment": "The effective period for a charge item definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the charge item definition are or are expected to be used instead.",
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
            "id": "ChargeItemDefinition.code",
            "path": "ChargeItemDefinition.code",
            "short": "Billing codes or product types this definition applies to",
            "definition": "The defined billing details in this resource pertain to the given billing code.",
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
                  "valueString": "ChargeItemDefinitionCode"
                }
              ],
              "strength": "example",
              "description": "Billing Code defined by this ChargeItemDefinition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/chargeitem-billingcodes"
            }
          },
          {
            "id": "ChargeItemDefinition.instance",
            "path": "ChargeItemDefinition.instance",
            "short": "Instances this definition applies to",
            "definition": "The defined billing details in this resource pertain to the given product instance(s).",
            "comment": "In case of highly customized, individually produced or fitted devices/substances, the pricing information may be different for each instance of the product. This reference links pricing details to specific product instances.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.applicability",
            "path": "ChargeItemDefinition.applicability",
            "short": "Whether or not the billing code is applicable",
            "definition": "Expressions that describe applicability criteria for the billing code.",
            "comment": "The applicability conditions can be used to ascertain whether a billing item is allowed in a specific context. E.g. some billing codes may only be applicable in out-patient settings, only to male/female patients or only to children.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.applicability.description",
            "path": "ChargeItemDefinition.applicability.description",
            "short": "Natural language description of the condition",
            "definition": "A brief, natural language description of the condition that effectively communicates the intended semantics.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.applicability.language",
            "path": "ChargeItemDefinition.applicability.language",
            "short": "Language of the expression",
            "definition": "The media type of the language for the expression, e.g. \"text/cql\" for Clinical Query Language expressions or \"text/fhirpath\" for FHIRPath expressions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.applicability.expression",
            "path": "ChargeItemDefinition.applicability.expression",
            "short": "Boolean-valued expression",
            "definition": "An expression that returns true or false, indicating whether the condition is satisfied. When using FHIRPath expressions, the %context environment variable must be replaced at runtime with the ChargeItem resource to which this definition is applied.",
            "comment": "Please note that FHIRPath Expressions can only be evaluated in the scope of the current ChargeItem resource to which this definition is being applied.\nFHIRPath expressions can traverse into other resources linked from the ChargeItem resource, however, testing rules such as that a billing code may be billed only once per encounter need a wider scope. In such scenarios, CQL may be the appropriate choice.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.propertyGroup",
            "path": "ChargeItemDefinition.propertyGroup",
            "short": "Group of properties which are applicable under the same conditions",
            "definition": "Group of properties which are applicable under the same conditions. If no applicability rules are established for the group, then all properties always apply.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.applicability",
            "path": "ChargeItemDefinition.propertyGroup.applicability",
            "short": "Conditions under which the priceComponent is applicable",
            "definition": "Expressions that describe applicability criteria for the priceComponent.",
            "comment": "The applicability conditions can be used to ascertain whether a billing item is allowed in a specific context. E.g. some billing codes may only be applicable in out-patient settings, only to male/female patients or only to children.",
            "min": 0,
            "max": "*",
            "contentReference": "#ChargeItemDefinition.applicability"
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.priceComponent",
            "path": "ChargeItemDefinition.propertyGroup.priceComponent",
            "short": "Components of total line item price",
            "definition": "The price for a ChargeItem may be calculated as a base price with surcharges/deductions that apply in certain conditions. A ChargeItemDefinition resource that defines the prices, factors and conditions that apply to a billing code is currently under development. The priceComponent element can be used to offer transparency to the recipient of the Invoice of how the prices have been calculated.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.priceComponent.type",
            "path": "ChargeItemDefinition.propertyGroup.priceComponent.type",
            "short": "base | surcharge | deduction | discount | tax | informational",
            "definition": "This code identifies the type of the component.",
            "min": 1,
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
                  "valueString": "ChargeItemDefinitionPriceComponentType"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the kind of the price component.",
              "valueSet": "http://hl7.org/fhir/ValueSet/invoice-priceComponentType|4.0.0"
            }
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.priceComponent.code",
            "path": "ChargeItemDefinition.propertyGroup.priceComponent.code",
            "short": "Code identifying the specific component",
            "definition": "A code that identifies the component. Codes may be used to differentiate between kinds of taxes, surcharges, discounts etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.priceComponent.factor",
            "path": "ChargeItemDefinition.propertyGroup.priceComponent.factor",
            "short": "Factor used for calculating this component",
            "definition": "The factor that has been applied on the base price for calculating this component.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ChargeItemDefinition.propertyGroup.priceComponent.amount",
            "path": "ChargeItemDefinition.propertyGroup.priceComponent.amount",
            "short": "Monetary amount associated with this component",
            "definition": "The amount calculated for this component.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'ChargeItemDefinition'
    /// </summary>
    // 0. ChargeItemDefinition
    public class ChargeItemDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class ChargeItemDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 22. ChargeItemDefinition.applicability
            public class Type_Applicability : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Applicability_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 23. ChargeItemDefinition.applicability.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 24. ChargeItemDefinition.applicability.language
                    public ElementDefinitionInfo Language;                                                                                  // MakerGen.cs:211
                    // 25. ChargeItemDefinition.applicability.expression
                    public ElementDefinitionInfo Expression;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Applicability_Elements()                                                                                    // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. ChargeItemDefinition.applicability.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "ChargeItemDefinition.applicability.description",                                                     // MakerGen.cs:231
                                Id = "ChargeItemDefinition.applicability.description",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. ChargeItemDefinition.applicability.language
                            this.Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Language",                                                                                          // MakerGen.cs:230
                                Path= "ChargeItemDefinition.applicability.language",                                                        // MakerGen.cs:231
                                Id = "ChargeItemDefinition.applicability.language",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. ChargeItemDefinition.applicability.expression
                            this.Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Expression",                                                                                        // MakerGen.cs:230
                                Path= "ChargeItemDefinition.applicability.expression",                                                      // MakerGen.cs:231
                                Id = "ChargeItemDefinition.applicability.expression",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Language.Write(sDef);                                                                                               // MakerGen.cs:215
                        Expression.Write(sDef);                                                                                             // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Applicability_Elements Elements                                                                                 // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Applicability_Elements();                                                              // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Applicability_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Applicability()                                                                                                 // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ChargeItemDefinition.applicability",                                                                        // MakerGen.cs:423
                        ElementId = "ChargeItemDefinition.applicability"                                                                    // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 26. ChargeItemDefinition.propertyGroup
            public class Type_PropertyGroup : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_PropertyGroup_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 28. ChargeItemDefinition.propertyGroup.priceComponent
                    public class Type_PriceComponent : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_PriceComponent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 29. ChargeItemDefinition.propertyGroup.priceComponent.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:211
                            // 30. ChargeItemDefinition.propertyGroup.priceComponent.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 31. ChargeItemDefinition.propertyGroup.priceComponent.factor
                            public ElementDefinitionInfo Factor;                                                                            // MakerGen.cs:211
                            // 32. ChargeItemDefinition.propertyGroup.priceComponent.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_PriceComponent_Elements()                                                                           // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 29. ChargeItemDefinition.propertyGroup.priceComponent.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Type",                                                                                      // MakerGen.cs:230
                                        Path= "ChargeItemDefinition.propertyGroup.priceComponent.type",                                     // MakerGen.cs:231
                                        Id = "ChargeItemDefinition.propertyGroup.priceComponent.type",                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 30. ChargeItemDefinition.propertyGroup.priceComponent.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "ChargeItemDefinition.propertyGroup.priceComponent.code",                                     // MakerGen.cs:231
                                        Id = "ChargeItemDefinition.propertyGroup.priceComponent.code",                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 31. ChargeItemDefinition.propertyGroup.priceComponent.factor
                                    this.Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Factor",                                                                                    // MakerGen.cs:230
                                        Path= "ChargeItemDefinition.propertyGroup.priceComponent.factor",                                   // MakerGen.cs:231
                                        Id = "ChargeItemDefinition.propertyGroup.priceComponent.factor",                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 32. ChargeItemDefinition.propertyGroup.priceComponent.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Amount",                                                                                    // MakerGen.cs:230
                                        Path= "ChargeItemDefinition.propertyGroup.priceComponent.amount",                                   // MakerGen.cs:231
                                        Id = "ChargeItemDefinition.propertyGroup.priceComponent.amount",                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Type.Write(sDef);                                                                                           // MakerGen.cs:215
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                Factor.Write(sDef);                                                                                         // MakerGen.cs:215
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_PriceComponent_Elements Elements                                                                        // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_PriceComponent_Elements();                                                     // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_PriceComponent_Elements elements;                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_PriceComponent()                                                                                        // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ChargeItemDefinition.propertyGroup.priceComponent",                                                 // MakerGen.cs:423
                                ElementId = "ChargeItemDefinition.propertyGroup.priceComponent"                                             // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 27. ChargeItemDefinition.propertyGroup.applicability
                    public ElementDefinitionInfo Applicability;                                                                             // MakerGen.cs:211
                    // 28. ChargeItemDefinition.propertyGroup.priceComponent
                    public ElementDefinitionInfo PriceComponent;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_PropertyGroup_Elements()                                                                                    // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. ChargeItemDefinition.propertyGroup.applicability
                            this.Applicability = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Applicability",                                                                                     // MakerGen.cs:230
                                Path= "ChargeItemDefinition.propertyGroup.applicability",                                                   // MakerGen.cs:231
                                Id = "ChargeItemDefinition.propertyGroup.applicability",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. ChargeItemDefinition.propertyGroup.priceComponent
                            this.PriceComponent = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "PriceComponent",                                                                                    // MakerGen.cs:230
                                Path= "ChargeItemDefinition.propertyGroup.priceComponent",                                                  // MakerGen.cs:231
                                Id = "ChargeItemDefinition.propertyGroup.priceComponent",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_PriceComponent                                                                                 // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Applicability.Write(sDef);                                                                                          // MakerGen.cs:215
                        PriceComponent.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_PropertyGroup_Elements Elements                                                                                 // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_PropertyGroup_Elements();                                                              // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_PropertyGroup_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_PropertyGroup()                                                                                                 // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ChargeItemDefinition.propertyGroup",                                                                        // MakerGen.cs:423
                        ElementId = "ChargeItemDefinition.propertyGroup"                                                                    // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. ChargeItemDefinition.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. ChargeItemDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 3. ChargeItemDefinition.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 4. ChargeItemDefinition.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 5. ChargeItemDefinition.derivedFromUri
            public ElementDefinitionInfo DerivedFromUri;                                                                                    // MakerGen.cs:211
            // 6. ChargeItemDefinition.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:211
            // 7. ChargeItemDefinition.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:211
            // 8. ChargeItemDefinition.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 9. ChargeItemDefinition.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:211
            // 10. ChargeItemDefinition.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 11. ChargeItemDefinition.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 12. ChargeItemDefinition.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 13. ChargeItemDefinition.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 14. ChargeItemDefinition.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 15. ChargeItemDefinition.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 16. ChargeItemDefinition.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 17. ChargeItemDefinition.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:211
            // 18. ChargeItemDefinition.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:211
            // 19. ChargeItemDefinition.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:211
            // 20. ChargeItemDefinition.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:211
            // 21. ChargeItemDefinition.instance
            public ElementDefinitionInfo Instance;                                                                                          // MakerGen.cs:211
            // 22. ChargeItemDefinition.applicability
            public ElementDefinitionInfo Applicability;                                                                                     // MakerGen.cs:211
            // 26. ChargeItemDefinition.propertyGroup
            public ElementDefinitionInfo PropertyGroup;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public ChargeItemDefinition_Elements()                                                                                          // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ChargeItemDefinition.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "ChargeItemDefinition.url",                                                                                   // MakerGen.cs:231
                        Id = "ChargeItemDefinition.url",                                                                                    // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ChargeItemDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "ChargeItemDefinition.identifier",                                                                            // MakerGen.cs:231
                        Id = "ChargeItemDefinition.identifier",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ChargeItemDefinition.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "ChargeItemDefinition.version",                                                                               // MakerGen.cs:231
                        Id = "ChargeItemDefinition.version",                                                                                // MakerGen.cs:232
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
                    // 4. ChargeItemDefinition.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "ChargeItemDefinition.title",                                                                                 // MakerGen.cs:231
                        Id = "ChargeItemDefinition.title",                                                                                  // MakerGen.cs:232
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
                    // 5. ChargeItemDefinition.derivedFromUri
                    this.DerivedFromUri = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "DerivedFromUri",                                                                                            // MakerGen.cs:230
                        Path= "ChargeItemDefinition.derivedFromUri",                                                                        // MakerGen.cs:231
                        Id = "ChargeItemDefinition.derivedFromUri",                                                                         // MakerGen.cs:232
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
                    // 6. ChargeItemDefinition.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PartOf",                                                                                                    // MakerGen.cs:230
                        Path= "ChargeItemDefinition.partOf",                                                                                // MakerGen.cs:231
                        Id = "ChargeItemDefinition.partOf",                                                                                 // MakerGen.cs:232
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
                    // 7. ChargeItemDefinition.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Replaces",                                                                                                  // MakerGen.cs:230
                        Path= "ChargeItemDefinition.replaces",                                                                              // MakerGen.cs:231
                        Id = "ChargeItemDefinition.replaces",                                                                               // MakerGen.cs:232
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
                    // 8. ChargeItemDefinition.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "ChargeItemDefinition.status",                                                                                // MakerGen.cs:231
                        Id = "ChargeItemDefinition.status",                                                                                 // MakerGen.cs:232
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
                    // 9. ChargeItemDefinition.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Experimental",                                                                                              // MakerGen.cs:230
                        Path= "ChargeItemDefinition.experimental",                                                                          // MakerGen.cs:231
                        Id = "ChargeItemDefinition.experimental",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ChargeItemDefinition.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "ChargeItemDefinition.date",                                                                                  // MakerGen.cs:231
                        Id = "ChargeItemDefinition.date",                                                                                   // MakerGen.cs:232
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
                    // 11. ChargeItemDefinition.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "ChargeItemDefinition.publisher",                                                                             // MakerGen.cs:231
                        Id = "ChargeItemDefinition.publisher",                                                                              // MakerGen.cs:232
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
                    // 12. ChargeItemDefinition.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "ChargeItemDefinition.contact",                                                                               // MakerGen.cs:231
                        Id = "ChargeItemDefinition.contact",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ChargeItemDefinition.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "ChargeItemDefinition.description",                                                                           // MakerGen.cs:231
                        Id = "ChargeItemDefinition.description",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ChargeItemDefinition.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "ChargeItemDefinition.useContext",                                                                            // MakerGen.cs:231
                        Id = "ChargeItemDefinition.useContext",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. ChargeItemDefinition.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "ChargeItemDefinition.jurisdiction",                                                                          // MakerGen.cs:231
                        Id = "ChargeItemDefinition.jurisdiction",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ChargeItemDefinition.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "ChargeItemDefinition.copyright",                                                                             // MakerGen.cs:231
                        Id = "ChargeItemDefinition.copyright",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. ChargeItemDefinition.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:230
                        Path= "ChargeItemDefinition.approvalDate",                                                                          // MakerGen.cs:231
                        Id = "ChargeItemDefinition.approvalDate",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. ChargeItemDefinition.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:230
                        Path= "ChargeItemDefinition.lastReviewDate",                                                                        // MakerGen.cs:231
                        Id = "ChargeItemDefinition.lastReviewDate",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. ChargeItemDefinition.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:230
                        Path= "ChargeItemDefinition.effectivePeriod",                                                                       // MakerGen.cs:231
                        Id = "ChargeItemDefinition.effectivePeriod",                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. ChargeItemDefinition.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Code",                                                                                                      // MakerGen.cs:230
                        Path= "ChargeItemDefinition.code",                                                                                  // MakerGen.cs:231
                        Id = "ChargeItemDefinition.code",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. ChargeItemDefinition.instance
                    this.Instance = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Instance",                                                                                                  // MakerGen.cs:230
                        Path= "ChargeItemDefinition.instance",                                                                              // MakerGen.cs:231
                        Id = "ChargeItemDefinition.instance",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. ChargeItemDefinition.applicability
                    this.Applicability = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Applicability",                                                                                             // MakerGen.cs:230
                        Path= "ChargeItemDefinition.applicability",                                                                         // MakerGen.cs:231
                        Id = "ChargeItemDefinition.applicability",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Applicability                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. ChargeItemDefinition.propertyGroup
                    this.PropertyGroup = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PropertyGroup",                                                                                             // MakerGen.cs:230
                        Path= "ChargeItemDefinition.propertyGroup",                                                                         // MakerGen.cs:231
                        Id = "ChargeItemDefinition.propertyGroup",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_PropertyGroup                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Url.Write(sDef);                                                                                                            // MakerGen.cs:215
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Version.Write(sDef);                                                                                                        // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                DerivedFromUri.Write(sDef);                                                                                                 // MakerGen.cs:215
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:215
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:215
                ApprovalDate.Write(sDef);                                                                                                   // MakerGen.cs:215
                LastReviewDate.Write(sDef);                                                                                                 // MakerGen.cs:215
                EffectivePeriod.Write(sDef);                                                                                                // MakerGen.cs:215
                Code.Write(sDef);                                                                                                           // MakerGen.cs:215
                Instance.Write(sDef);                                                                                                       // MakerGen.cs:215
                Applicability.Write(sDef);                                                                                                  // MakerGen.cs:215
                PropertyGroup.Write(sDef);                                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public ChargeItemDefinition_Elements Elements                                                                                       // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new ChargeItemDefinition_Elements();                                                                    // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        ChargeItemDefinition_Elements elements;                                                                                             // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public ChargeItemDefinition()                                                                                                       // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "ChargeItemDefinition";                                                                                             // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition";                                                      // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "ChargeItemDefinition",                                                                                              // MakerGen.cs:423
                ElementId = "ChargeItemDefinition"                                                                                          // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
