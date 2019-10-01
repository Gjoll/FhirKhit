using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'MessageDefinition'
    /// </summary>
    // 0. MessageDefinition
    public class MessageDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 21. MessageDefinition.focus
        public class Type_Focus : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 22. MessageDefinition.focus.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 23. MessageDefinition.focus.profile
            public MakerElementInstance Element_Profile;                                                                                    // MakerGen.cs:232
            // 24. MessageDefinition.focus.min
            public MakerElementInstance Element_Min;                                                                                        // MakerGen.cs:232
            // 25. MessageDefinition.focus.max
            public MakerElementInstance Element_Max;                                                                                        // MakerGen.cs:232
            public Type_Focus()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 22. MessageDefinition.focus.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 23. MessageDefinition.focus.profile
                    this.Element_Profile = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Profile",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical()                                                                 // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 24. MessageDefinition.focus.min
                    this.Element_Min = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Min",                                                                                               // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. MessageDefinition.focus.max
                    this.Element_Max = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Max",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 27. MessageDefinition.allowedResponse
        public class Type_AllowedResponse : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 28. MessageDefinition.allowedResponse.message
            public MakerElementInstance Element_Message;                                                                                    // MakerGen.cs:232
            // 29. MessageDefinition.allowedResponse.situation
            public MakerElementInstance Element_Situation;                                                                                  // MakerGen.cs:232
            public Type_AllowedResponse()                                                                                                   // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 28. MessageDefinition.allowedResponse.message
                    this.Element_Message = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Message",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical()                                                                 // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 29. MessageDefinition.allowedResponse.situation
                    this.Element_Situation = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Situation",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Markdown()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. MessageDefinition.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. MessageDefinition.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 3. MessageDefinition.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 4. MessageDefinition.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 5. MessageDefinition.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 6. MessageDefinition.replaces
        public MakerElementInstance Element_Replaces;                                                                                       // MakerGen.cs:232
        // 7. MessageDefinition.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 8. MessageDefinition.experimental
        public MakerElementInstance Element_Experimental;                                                                                   // MakerGen.cs:232
        // 9. MessageDefinition.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 10. MessageDefinition.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 11. MessageDefinition.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 12. MessageDefinition.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 13. MessageDefinition.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 14. MessageDefinition.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 15. MessageDefinition.purpose
        public MakerElementInstance Element_Purpose;                                                                                        // MakerGen.cs:232
        // 16. MessageDefinition.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 17. MessageDefinition.base
        public MakerElementInstance Element_Base;                                                                                           // MakerGen.cs:232
        // 18. MessageDefinition.parent
        public MakerElementInstance Element_Parent;                                                                                         // MakerGen.cs:232
        // 19. MessageDefinition.event[x]
        public MakerElementInstance Element_Event;                                                                                          // MakerGen.cs:232
        // 20. MessageDefinition.category
        public MakerElementInstance Element_Category;                                                                                       // MakerGen.cs:232
        // 26. MessageDefinition.responseRequired
        public MakerElementInstance Element_ResponseRequired;                                                                               // MakerGen.cs:232
        // 30. MessageDefinition.graph
        public MakerElementInstance Element_Graph;                                                                                          // MakerGen.cs:232
        public MessageDefinition()                                                                                                          // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. MessageDefinition.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. MessageDefinition.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. MessageDefinition.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. MessageDefinition.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. MessageDefinition.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. MessageDefinition.replaces
                this.Element_Replaces = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Replaces",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. MessageDefinition.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. MessageDefinition.experimental
                this.Element_Experimental = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. MessageDefinition.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. MessageDefinition.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. MessageDefinition.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. MessageDefinition.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. MessageDefinition.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. MessageDefinition.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. MessageDefinition.purpose
                this.Element_Purpose = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. MessageDefinition.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. MessageDefinition.base
                this.Element_Base = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Base",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. MessageDefinition.parent
                this.Element_Parent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. MessageDefinition.event[x]
                this.Element_Event = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Event",                                                                                                 // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Coding(),                                                                         // MakerGen.cs:292
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. MessageDefinition.category
                this.Element_Category = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Category",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 26. MessageDefinition.responseRequired
                this.Element_ResponseRequired = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ResponseRequired",                                                                                      // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 30. MessageDefinition.graph
                this.Element_Graph = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Graph",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
