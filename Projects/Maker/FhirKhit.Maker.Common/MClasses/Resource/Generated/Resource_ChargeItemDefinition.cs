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
    #endregion
    /// <summary>
    /// Fhir resource 'ChargeItemDefinition'
    /// </summary>
    // 0. ChargeItemDefinition
    public partial class Resource_ChargeItemDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 22. ChargeItemDefinition.applicability
        public partial class Type_Applicability : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. ChargeItemDefinition.applicability.description
            public ElementDefinitionInfo Element_Description;
            // 24. ChargeItemDefinition.applicability.language
            public ElementDefinitionInfo Element_Language;
            // 25. ChargeItemDefinition.applicability.expression
            public ElementDefinitionInfo Element_Expression;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ChargeItemDefinition.applicability",
                    ElementId = "ChargeItemDefinition.applicability"
                });
                Element_Description.Write(sDef);
                Element_Language.Write(sDef);
                Element_Expression.Write(sDef);
            }
            
            public Type_Applicability()
            {
                {
                    // 23. ChargeItemDefinition.applicability.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ChargeItemDefinition.applicability.description",
                        Id = "ChargeItemDefinition.applicability.description",
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
                    // 24. ChargeItemDefinition.applicability.language
                    this.Element_Language = new ElementDefinitionInfo
                    {
                        Name = "Element_Language",
                        Path= "ChargeItemDefinition.applicability.language",
                        Id = "ChargeItemDefinition.applicability.language",
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
                    // 25. ChargeItemDefinition.applicability.expression
                    this.Element_Expression = new ElementDefinitionInfo
                    {
                        Name = "Element_Expression",
                        Path= "ChargeItemDefinition.applicability.expression",
                        Id = "ChargeItemDefinition.applicability.expression",
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
        // 26. ChargeItemDefinition.propertyGroup
        public partial class Type_PropertyGroup : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. ChargeItemDefinition.propertyGroup.priceComponent
            public partial class Type_PriceComponent : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 29. ChargeItemDefinition.propertyGroup.priceComponent.type
                public ElementDefinitionInfo Element_Type;
                // 30. ChargeItemDefinition.propertyGroup.priceComponent.code
                public ElementDefinitionInfo Element_Code;
                // 31. ChargeItemDefinition.propertyGroup.priceComponent.factor
                public ElementDefinitionInfo Element_Factor;
                // 32. ChargeItemDefinition.propertyGroup.priceComponent.amount
                public ElementDefinitionInfo Element_Amount;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ChargeItemDefinition.propertyGroup.priceComponent",
                        ElementId = "ChargeItemDefinition.propertyGroup.priceComponent"
                    });
                    Element_Type.Write(sDef);
                    Element_Code.Write(sDef);
                    Element_Factor.Write(sDef);
                    Element_Amount.Write(sDef);
                }
                
                public Type_PriceComponent()
                {
                    {
                        // 29. ChargeItemDefinition.propertyGroup.priceComponent.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "ChargeItemDefinition.propertyGroup.priceComponent.type",
                            Id = "ChargeItemDefinition.propertyGroup.priceComponent.type",
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
                        // 30. ChargeItemDefinition.propertyGroup.priceComponent.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ChargeItemDefinition.propertyGroup.priceComponent.code",
                            Id = "ChargeItemDefinition.propertyGroup.priceComponent.code",
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
                        // 31. ChargeItemDefinition.propertyGroup.priceComponent.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "ChargeItemDefinition.propertyGroup.priceComponent.factor",
                            Id = "ChargeItemDefinition.propertyGroup.priceComponent.factor",
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
                        // 32. ChargeItemDefinition.propertyGroup.priceComponent.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "ChargeItemDefinition.propertyGroup.priceComponent.amount",
                            Id = "ChargeItemDefinition.propertyGroup.priceComponent.amount",
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
            // 27. ChargeItemDefinition.propertyGroup.applicability
            public ElementDefinitionInfo Element_Applicability;
            // 28. ChargeItemDefinition.propertyGroup.priceComponent
            public ElementDefinitionInfo Element_PriceComponent;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ChargeItemDefinition.propertyGroup",
                    ElementId = "ChargeItemDefinition.propertyGroup"
                });
                Element_Applicability.Write(sDef);
                Element_PriceComponent.Write(sDef);
            }
            
            public Type_PropertyGroup()
            {
                {
                    // 27. ChargeItemDefinition.propertyGroup.applicability
                    this.Element_Applicability = new ElementDefinitionInfo
                    {
                        Name = "Element_Applicability",
                        Path= "ChargeItemDefinition.propertyGroup.applicability",
                        Id = "ChargeItemDefinition.propertyGroup.applicability",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 28. ChargeItemDefinition.propertyGroup.priceComponent
                    this.Element_PriceComponent = new ElementDefinitionInfo
                    {
                        Name = "Element_PriceComponent",
                        Path= "ChargeItemDefinition.propertyGroup.priceComponent",
                        Id = "ChargeItemDefinition.propertyGroup.priceComponent",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_PriceComponent
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. ChargeItemDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. ChargeItemDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. ChargeItemDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 4. ChargeItemDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 5. ChargeItemDefinition.derivedFromUri
        public ElementDefinitionInfo Element_DerivedFromUri;
        // 6. ChargeItemDefinition.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 7. ChargeItemDefinition.replaces
        public ElementDefinitionInfo Element_Replaces;
        // 8. ChargeItemDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 9. ChargeItemDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 10. ChargeItemDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 11. ChargeItemDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 12. ChargeItemDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 13. ChargeItemDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 14. ChargeItemDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 15. ChargeItemDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 16. ChargeItemDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 17. ChargeItemDefinition.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 18. ChargeItemDefinition.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 19. ChargeItemDefinition.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 20. ChargeItemDefinition.code
        public ElementDefinitionInfo Element_Code;
        // 21. ChargeItemDefinition.instance
        public ElementDefinitionInfo Element_Instance;
        // 22. ChargeItemDefinition.applicability
        public ElementDefinitionInfo Element_Applicability;
        // 26. ChargeItemDefinition.propertyGroup
        public ElementDefinitionInfo Element_PropertyGroup;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ChargeItemDefinition",
                ElementId = "ChargeItemDefinition"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Title.Write(sDef);
            Element_DerivedFromUri.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Replaces.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Copyright.Write(sDef);
            Element_ApprovalDate.Write(sDef);
            Element_LastReviewDate.Write(sDef);
            Element_EffectivePeriod.Write(sDef);
            Element_Code.Write(sDef);
            Element_Instance.Write(sDef);
            Element_Applicability.Write(sDef);
            Element_PropertyGroup.Write(sDef);
        }
        
        public Resource_ChargeItemDefinition()
        {
            {
                // 1. ChargeItemDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ChargeItemDefinition.url",
                    Id = "ChargeItemDefinition.url",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 2. ChargeItemDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ChargeItemDefinition.identifier",
                    Id = "ChargeItemDefinition.identifier",
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
                // 3. ChargeItemDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ChargeItemDefinition.version",
                    Id = "ChargeItemDefinition.version",
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
                // 4. ChargeItemDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ChargeItemDefinition.title",
                    Id = "ChargeItemDefinition.title",
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
                // 5. ChargeItemDefinition.derivedFromUri
                this.Element_DerivedFromUri = new ElementDefinitionInfo
                {
                    Name = "Element_DerivedFromUri",
                    Path= "ChargeItemDefinition.derivedFromUri",
                    Id = "ChargeItemDefinition.derivedFromUri",
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
                // 6. ChargeItemDefinition.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "ChargeItemDefinition.partOf",
                    Id = "ChargeItemDefinition.partOf",
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
                // 7. ChargeItemDefinition.replaces
                this.Element_Replaces = new ElementDefinitionInfo
                {
                    Name = "Element_Replaces",
                    Path= "ChargeItemDefinition.replaces",
                    Id = "ChargeItemDefinition.replaces",
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
                // 8. ChargeItemDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ChargeItemDefinition.status",
                    Id = "ChargeItemDefinition.status",
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
                // 9. ChargeItemDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ChargeItemDefinition.experimental",
                    Id = "ChargeItemDefinition.experimental",
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
                // 10. ChargeItemDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ChargeItemDefinition.date",
                    Id = "ChargeItemDefinition.date",
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
                // 11. ChargeItemDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ChargeItemDefinition.publisher",
                    Id = "ChargeItemDefinition.publisher",
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
                // 12. ChargeItemDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ChargeItemDefinition.contact",
                    Id = "ChargeItemDefinition.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                        {
                        }
                    }
                };
            }
            {
                // 13. ChargeItemDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ChargeItemDefinition.description",
                    Id = "ChargeItemDefinition.description",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 14. ChargeItemDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ChargeItemDefinition.useContext",
                    Id = "ChargeItemDefinition.useContext",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext
                        {
                        }
                    }
                };
            }
            {
                // 15. ChargeItemDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ChargeItemDefinition.jurisdiction",
                    Id = "ChargeItemDefinition.jurisdiction",
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
                // 16. ChargeItemDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ChargeItemDefinition.copyright",
                    Id = "ChargeItemDefinition.copyright",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 17. ChargeItemDefinition.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "ChargeItemDefinition.approvalDate",
                    Id = "ChargeItemDefinition.approvalDate",
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
                // 18. ChargeItemDefinition.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "ChargeItemDefinition.lastReviewDate",
                    Id = "ChargeItemDefinition.lastReviewDate",
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
                // 19. ChargeItemDefinition.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "ChargeItemDefinition.effectivePeriod",
                    Id = "ChargeItemDefinition.effectivePeriod",
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
                // 20. ChargeItemDefinition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ChargeItemDefinition.code",
                    Id = "ChargeItemDefinition.code",
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
                // 21. ChargeItemDefinition.instance
                this.Element_Instance = new ElementDefinitionInfo
                {
                    Name = "Element_Instance",
                    Path= "ChargeItemDefinition.instance",
                    Id = "ChargeItemDefinition.instance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Medication",
                                "http://hl7.org/fhir/StructureDefinition/Substance",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 22. ChargeItemDefinition.applicability
                this.Element_Applicability = new ElementDefinitionInfo
                {
                    Name = "Element_Applicability",
                    Path= "ChargeItemDefinition.applicability",
                    Id = "ChargeItemDefinition.applicability",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Applicability
                        {
                        }
                    }
                };
            }
            {
                // 26. ChargeItemDefinition.propertyGroup
                this.Element_PropertyGroup = new ElementDefinitionInfo
                {
                    Name = "Element_PropertyGroup",
                    Path= "ChargeItemDefinition.propertyGroup",
                    Id = "ChargeItemDefinition.propertyGroup",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_PropertyGroup
                        {
                        }
                    }
                };
            }
            this.Name = "ChargeItemDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition";
        }
    }
}
