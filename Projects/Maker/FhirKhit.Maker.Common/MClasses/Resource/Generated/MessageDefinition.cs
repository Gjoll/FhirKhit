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
      "id": "MessageDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/MessageDefinition",
      "version": "4.0.0",
      "name": "MessageDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Infrastructure And Messaging)",
      "description": "Defines the characteristics of a message that can be shared between systems, including the type of event that initiates the message, the content to be transmitted and what response(s), if any, are permitted.",
      "purpose": "Allows messages to be defined once and re-used across systems.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MessageDefinition",
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
            "id": "MessageDefinition",
            "path": "MessageDefinition",
            "short": "A resource that defines a type of message that can be exchanged between systems",
            "definition": "Defines the characteristics of a message that can be shared between systems, including the type of event that initiates the message, the content to be transmitted and what response(s), if any, are permitted.",
            "comment": "This would be a MIF-level artifact.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MessageDefinition.url",
            "path": "MessageDefinition.url",
            "short": "Business Identifier for a given MessageDefinition",
            "definition": "The business identifier that is used to reference the MessageDefinition and *is* expected to be consistent from server to server.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the message definition to be referenced by a single globally unique identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.identifier",
            "path": "MessageDefinition.identifier",
            "short": "Primary key for the message definition on a given server",
            "definition": "A formal identifier that is used to identify this message definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this message definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "MessageDefinition.version",
            "path": "MessageDefinition.version",
            "short": "Business version of the message definition",
            "definition": "The identifier that is used to identify this version of the message definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the message definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different message definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the message definition with the format [url]|[version].",
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
            "id": "MessageDefinition.name",
            "path": "MessageDefinition.name",
            "short": "Name for this message definition (computer friendly)",
            "definition": "A natural language name identifying the message definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.",
            "requirements": "Support human navigation and code generation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "inv-0"
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.title",
            "path": "MessageDefinition.title",
            "short": "Name for this message definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the message definition.",
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
            "id": "MessageDefinition.replaces",
            "path": "MessageDefinition.replaces",
            "short": "Takes the place of",
            "definition": "A MessageDefinition that is superseded by this definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MessageDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.status",
            "path": "MessageDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this message definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of message definitions that are appropriate for use versus not.",
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
            "id": "MessageDefinition.experimental",
            "path": "MessageDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this message definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of message definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level message definition.",
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
            "id": "MessageDefinition.date",
            "path": "MessageDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the message definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the message definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the message definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
            "alias": [
              "Revision Date"
            ],
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
            "id": "MessageDefinition.publisher",
            "path": "MessageDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the message definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the message definition is the organization or individual primarily responsible for the maintenance and upkeep of the message definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the message definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the message definition.  May also allow for contact.",
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
            "id": "MessageDefinition.contact",
            "path": "MessageDefinition.contact",
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
            "id": "MessageDefinition.description",
            "path": "MessageDefinition.description",
            "short": "Natural language description of the message definition",
            "definition": "A free text natural language description of the message definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the message definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the message definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the message definition is presumed to be the predominant language in the place the message definition was created).",
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
            "id": "MessageDefinition.useContext",
            "path": "MessageDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate message definition instances.",
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
            "id": "MessageDefinition.jurisdiction",
            "path": "MessageDefinition.jurisdiction",
            "short": "Intended jurisdiction for message definition (if applicable)",
            "definition": "A legal or geographic region in which the message definition is intended to be used.",
            "comment": "It may be possible for the message definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "MessageDefinition.purpose",
            "path": "MessageDefinition.purpose",
            "short": "Why this message definition is defined",
            "definition": "Explanation of why this message definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the message definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this message definition.",
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
            "id": "MessageDefinition.copyright",
            "path": "MessageDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the message definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the message definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the message definition and/or its content.",
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
            "id": "MessageDefinition.base",
            "path": "MessageDefinition.base",
            "short": "Definition this one is based on",
            "definition": "The MessageDefinition that is the basis for the contents of this resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MessageDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.parent",
            "path": "MessageDefinition.parent",
            "short": "Protocol/workflow this is part of",
            "definition": "Identifies a protocol or workflow that this MessageDefinition represents a step in.",
            "comment": "It should be possible to use MessageDefinition to describe a message to be used by certain steps in a particular protocol as part of a PlanDefinition or ActivityDefinition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.event[x]",
            "path": "MessageDefinition.event[x]",
            "short": "Event code  or link to the EventDefinition",
            "definition": "Event code or link to the EventDefinition.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              },
              {
                "code": "uri"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MessageEvent"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "One of the message events defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/message-events"
            }
          },
          {
            "id": "MessageDefinition.category",
            "path": "MessageDefinition.category",
            "short": "consequence | currency | notification",
            "definition": "The impact of the content of the message.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MessageSignificanceCategory"
                }
              ],
              "strength": "required",
              "description": "The impact of the content of a message.",
              "valueSet": "http://hl7.org/fhir/ValueSet/message-significance-category|4.0.0"
            }
          },
          {
            "id": "MessageDefinition.focus",
            "path": "MessageDefinition.focus",
            "short": "Resource(s) that are the subject of the event",
            "definition": "Identifies the resource (or resources) that are being addressed by the event.  For example, the Encounter for an admit message or two Account records for a merge.",
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
            "id": "MessageDefinition.focus.code",
            "path": "MessageDefinition.focus.code",
            "short": "Type of resource",
            "definition": "The kind of resource that must be the focus for this message.",
            "comment": "Multiple focuses addressing different resources may occasionally occur.  E.g. to link or unlink a resource from a particular account or encounter, etc.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ResourceType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "One of the resource types defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-types|4.0.0"
            }
          },
          {
            "id": "MessageDefinition.focus.profile",
            "path": "MessageDefinition.focus.profile",
            "short": "Profile that must be adhered to by focus",
            "definition": "A profile that reflects constraints for the focal resource (and potentially for related resources).",
            "comment": "This should be present for most message definitions.  However, if the message focus is only a single resource and there is no need to include referenced resources or otherwise enforce the presence of particular elements, it can be omitted.",
            "requirements": "This profile allows setting boundaries for what content must appear within the message bundle vs. outside based on the declared aggregation constraints on referenced resources on this and related profiles.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "MessageDefinition.focus.min",
            "path": "MessageDefinition.focus.min",
            "short": "Minimum number of focuses of this type",
            "definition": "Identifies the minimum number of resources of this type that must be pointed to by a message in order for it to be valid against this MessageDefinition.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageDefinition.focus.max",
            "path": "MessageDefinition.focus.max",
            "short": "Maximum number of focuses of this type",
            "definition": "Identifies the maximum number of resources of this type that must be pointed to by a message in order for it to be valid against this MessageDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "md-1"
            ]
          },
          {
            "id": "MessageDefinition.responseRequired",
            "path": "MessageDefinition.responseRequired",
            "short": "always | on-error | never | on-success",
            "definition": "Declare at a message definition level whether a response is required or only upon error or success, or never.",
            "comment": "This enables the capability currently available through MSH-16 (Application Level acknowledgement) in HL7 Version 2 to declare at a message instance level whether a response is required or only upon error or success, or never.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "always"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "messageheader-response-request"
                }
              ],
              "strength": "required",
              "description": "HL7-defined table of codes which identify conditions under which acknowledgments are required to be returned in response to a message.",
              "valueSet": "http://hl7.org/fhir/ValueSet/messageheader-response-request|4.0.0"
            }
          },
          {
            "id": "MessageDefinition.allowedResponse",
            "path": "MessageDefinition.allowedResponse",
            "short": "Responses to this message",
            "definition": "Indicates what types of messages may be sent as an application-level response to this message.",
            "comment": "This indicates an application level response to \"close\" a transaction implicit in a particular request message.  To define a complete workflow scenario, look to the [[PlanDefinition]] resource which allows the definition of complex orchestrations, conditionality, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MessageDefinition.allowedResponse.message",
            "path": "MessageDefinition.allowedResponse.message",
            "short": "Reference to allowed message definition response",
            "definition": "A reference to the message definition that must be adhered to by this supported response.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MessageDefinition"
                ]
              }
            ]
          },
          {
            "id": "MessageDefinition.allowedResponse.situation",
            "path": "MessageDefinition.allowedResponse.situation",
            "short": "When should this response be used",
            "definition": "Provides a description of the circumstances in which this response should be used (as opposed to one of the alternative responses).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "MessageDefinition.graph",
            "path": "MessageDefinition.graph",
            "short": "Canonical reference to a GraphDefinition",
            "definition": "Canonical reference to a GraphDefinition. If a URL is provided, it is the canonical reference to a [GraphDefinition](graphdefinition.html) that it controls what resources are to be added to the bundle when building the document. The GraphDefinition can also specify profiles that apply to the various resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/GraphDefinition"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'MessageDefinition'
    /// </summary>
    // 0. MessageDefinition
    public class MessageDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class MessageDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 21. MessageDefinition.focus
            public class Type_Focus : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Focus_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 22. MessageDefinition.focus.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 23. MessageDefinition.focus.profile
                    public ElementDefinitionInfo Profile;                                                                                   // MakerGen.cs:211
                    // 24. MessageDefinition.focus.min
                    public ElementDefinitionInfo Min;                                                                                       // MakerGen.cs:211
                    // 25. MessageDefinition.focus.max
                    public ElementDefinitionInfo Max;                                                                                       // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Focus_Elements()                                                                                            // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. MessageDefinition.focus.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "MessageDefinition.focus.code",                                                                       // MakerGen.cs:231
                                Id = "MessageDefinition.focus.code",                                                                        // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. MessageDefinition.focus.profile
                            this.Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Profile",                                                                                           // MakerGen.cs:230
                                Path= "MessageDefinition.focus.profile",                                                                    // MakerGen.cs:231
                                Id = "MessageDefinition.focus.profile",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                   // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. MessageDefinition.focus.min
                            this.Min = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Min",                                                                                               // MakerGen.cs:230
                                Path= "MessageDefinition.focus.min",                                                                        // MakerGen.cs:231
                                Id = "MessageDefinition.focus.min",                                                                         // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. MessageDefinition.focus.max
                            this.Max = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Max",                                                                                               // MakerGen.cs:230
                                Path= "MessageDefinition.focus.max",                                                                        // MakerGen.cs:231
                                Id = "MessageDefinition.focus.max",                                                                         // MakerGen.cs:232
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
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Profile.Write(sDef);                                                                                                // MakerGen.cs:215
                        Min.Write(sDef);                                                                                                    // MakerGen.cs:215
                        Max.Write(sDef);                                                                                                    // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Focus_Elements Elements                                                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Focus_Elements();                                                                      // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Focus_Elements elements;                                                                                               // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Focus()                                                                                                         // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "MessageDefinition.focus",                                                                                   // MakerGen.cs:423
                        ElementId = "MessageDefinition.focus"                                                                               // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 27. MessageDefinition.allowedResponse
            public class Type_AllowedResponse : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_AllowedResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 28. MessageDefinition.allowedResponse.message
                    public ElementDefinitionInfo Message;                                                                                   // MakerGen.cs:211
                    // 29. MessageDefinition.allowedResponse.situation
                    public ElementDefinitionInfo Situation;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_AllowedResponse_Elements()                                                                                  // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. MessageDefinition.allowedResponse.message
                            this.Message = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Message",                                                                                           // MakerGen.cs:230
                                Path= "MessageDefinition.allowedResponse.message",                                                          // MakerGen.cs:231
                                Id = "MessageDefinition.allowedResponse.message",                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                     // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. MessageDefinition.allowedResponse.situation
                            this.Situation = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Situation",                                                                                         // MakerGen.cs:230
                                Path= "MessageDefinition.allowedResponse.situation",                                                        // MakerGen.cs:231
                                Id = "MessageDefinition.allowedResponse.situation",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:295
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
                        Message.Write(sDef);                                                                                                // MakerGen.cs:215
                        Situation.Write(sDef);                                                                                              // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_AllowedResponse_Elements Elements                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_AllowedResponse_Elements();                                                            // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_AllowedResponse_Elements elements;                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_AllowedResponse()                                                                                               // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "MessageDefinition.allowedResponse",                                                                         // MakerGen.cs:423
                        ElementId = "MessageDefinition.allowedResponse"                                                                     // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. MessageDefinition.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. MessageDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 3. MessageDefinition.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 4. MessageDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 5. MessageDefinition.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 6. MessageDefinition.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:211
            // 7. MessageDefinition.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 8. MessageDefinition.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:211
            // 9. MessageDefinition.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 10. MessageDefinition.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 11. MessageDefinition.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 12. MessageDefinition.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 13. MessageDefinition.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 14. MessageDefinition.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 15. MessageDefinition.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:211
            // 16. MessageDefinition.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 17. MessageDefinition.base
            public ElementDefinitionInfo Base;                                                                                              // MakerGen.cs:211
            // 18. MessageDefinition.parent
            public ElementDefinitionInfo Parent;                                                                                            // MakerGen.cs:211
            // 19. MessageDefinition.event[x]
            public ElementDefinitionInfo Event;                                                                                             // MakerGen.cs:211
            // 20. MessageDefinition.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:211
            // 21. MessageDefinition.focus
            public ElementDefinitionInfo Focus;                                                                                             // MakerGen.cs:211
            // 26. MessageDefinition.responseRequired
            public ElementDefinitionInfo ResponseRequired;                                                                                  // MakerGen.cs:211
            // 27. MessageDefinition.allowedResponse
            public ElementDefinitionInfo AllowedResponse;                                                                                   // MakerGen.cs:211
            // 30. MessageDefinition.graph
            public ElementDefinitionInfo Graph;                                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public MessageDefinition_Elements()                                                                                             // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MessageDefinition.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "MessageDefinition.url",                                                                                      // MakerGen.cs:231
                        Id = "MessageDefinition.url",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 2. MessageDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "MessageDefinition.identifier",                                                                               // MakerGen.cs:231
                        Id = "MessageDefinition.identifier",                                                                                // MakerGen.cs:232
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
                    // 3. MessageDefinition.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "MessageDefinition.version",                                                                                  // MakerGen.cs:231
                        Id = "MessageDefinition.version",                                                                                   // MakerGen.cs:232
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
                    // 4. MessageDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "MessageDefinition.name",                                                                                     // MakerGen.cs:231
                        Id = "MessageDefinition.name",                                                                                      // MakerGen.cs:232
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
                    // 5. MessageDefinition.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "MessageDefinition.title",                                                                                    // MakerGen.cs:231
                        Id = "MessageDefinition.title",                                                                                     // MakerGen.cs:232
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
                    // 6. MessageDefinition.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Replaces",                                                                                                  // MakerGen.cs:230
                        Path= "MessageDefinition.replaces",                                                                                 // MakerGen.cs:231
                        Id = "MessageDefinition.replaces",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                             // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. MessageDefinition.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "MessageDefinition.status",                                                                                   // MakerGen.cs:231
                        Id = "MessageDefinition.status",                                                                                    // MakerGen.cs:232
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
                    // 8. MessageDefinition.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Experimental",                                                                                              // MakerGen.cs:230
                        Path= "MessageDefinition.experimental",                                                                             // MakerGen.cs:231
                        Id = "MessageDefinition.experimental",                                                                              // MakerGen.cs:232
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
                    // 9. MessageDefinition.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "MessageDefinition.date",                                                                                     // MakerGen.cs:231
                        Id = "MessageDefinition.date",                                                                                      // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
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
                    // 10. MessageDefinition.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "MessageDefinition.publisher",                                                                                // MakerGen.cs:231
                        Id = "MessageDefinition.publisher",                                                                                 // MakerGen.cs:232
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
                    // 11. MessageDefinition.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "MessageDefinition.contact",                                                                                  // MakerGen.cs:231
                        Id = "MessageDefinition.contact",                                                                                   // MakerGen.cs:232
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
                    // 12. MessageDefinition.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "MessageDefinition.description",                                                                              // MakerGen.cs:231
                        Id = "MessageDefinition.description",                                                                               // MakerGen.cs:232
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
                    // 13. MessageDefinition.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "MessageDefinition.useContext",                                                                               // MakerGen.cs:231
                        Id = "MessageDefinition.useContext",                                                                                // MakerGen.cs:232
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
                    // 14. MessageDefinition.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "MessageDefinition.jurisdiction",                                                                             // MakerGen.cs:231
                        Id = "MessageDefinition.jurisdiction",                                                                              // MakerGen.cs:232
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
                    // 15. MessageDefinition.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Purpose",                                                                                                   // MakerGen.cs:230
                        Path= "MessageDefinition.purpose",                                                                                  // MakerGen.cs:231
                        Id = "MessageDefinition.purpose",                                                                                   // MakerGen.cs:232
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
                    // 16. MessageDefinition.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "MessageDefinition.copyright",                                                                                // MakerGen.cs:231
                        Id = "MessageDefinition.copyright",                                                                                 // MakerGen.cs:232
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
                    // 17. MessageDefinition.base
                    this.Base = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Base",                                                                                                      // MakerGen.cs:230
                        Path= "MessageDefinition.base",                                                                                     // MakerGen.cs:231
                        Id = "MessageDefinition.base",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                             // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. MessageDefinition.parent
                    this.Parent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Parent",                                                                                                    // MakerGen.cs:230
                        Path= "MessageDefinition.parent",                                                                                   // MakerGen.cs:231
                        Id = "MessageDefinition.parent",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                           // MakerGen.cs:298
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition"                                                // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. MessageDefinition.event[x]
                    this.Event = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Event",                                                                                                     // MakerGen.cs:230
                        Path= "MessageDefinition.event[x]",                                                                                 // MakerGen.cs:231
                        Id = "MessageDefinition.event[x]",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            },                                                                                                              // MakerGen.cs:314
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. MessageDefinition.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Category",                                                                                                  // MakerGen.cs:230
                        Path= "MessageDefinition.category",                                                                                 // MakerGen.cs:231
                        Id = "MessageDefinition.category",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 21. MessageDefinition.focus
                    this.Focus = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Focus",                                                                                                     // MakerGen.cs:230
                        Path= "MessageDefinition.focus",                                                                                    // MakerGen.cs:231
                        Id = "MessageDefinition.focus",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Focus                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. MessageDefinition.responseRequired
                    this.ResponseRequired = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ResponseRequired",                                                                                          // MakerGen.cs:230
                        Path= "MessageDefinition.responseRequired",                                                                         // MakerGen.cs:231
                        Id = "MessageDefinition.responseRequired",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 27. MessageDefinition.allowedResponse
                    this.AllowedResponse = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AllowedResponse",                                                                                           // MakerGen.cs:230
                        Path= "MessageDefinition.allowedResponse",                                                                          // MakerGen.cs:231
                        Id = "MessageDefinition.allowedResponse",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_AllowedResponse                                                                                        // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 30. MessageDefinition.graph
                    this.Graph = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Graph",                                                                                                     // MakerGen.cs:230
                        Path= "MessageDefinition.graph",                                                                                    // MakerGen.cs:231
                        Id = "MessageDefinition.graph",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/GraphDefinition"                                               // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
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
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:215
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:215
                Base.Write(sDef);                                                                                                           // MakerGen.cs:215
                Parent.Write(sDef);                                                                                                         // MakerGen.cs:215
                Event.Write(sDef);                                                                                                          // MakerGen.cs:215
                Category.Write(sDef);                                                                                                       // MakerGen.cs:215
                Focus.Write(sDef);                                                                                                          // MakerGen.cs:215
                ResponseRequired.Write(sDef);                                                                                               // MakerGen.cs:215
                AllowedResponse.Write(sDef);                                                                                                // MakerGen.cs:215
                Graph.Write(sDef);                                                                                                          // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public MessageDefinition_Elements Elements                                                                                          // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new MessageDefinition_Elements();                                                                       // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        MessageDefinition_Elements elements;                                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public MessageDefinition()                                                                                                          // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "MessageDefinition";                                                                                                // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MessageDefinition";                                                         // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "MessageDefinition",                                                                                                 // MakerGen.cs:423
                ElementId = "MessageDefinition"                                                                                             // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
