using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "ExampleScenario",
      "url": "http://hl7.org/fhir/StructureDefinition/ExampleScenario",
      "version": "4.0.0",
      "name": "ExampleScenario",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "Example of workflow instance.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ExampleScenario",
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
            "id": "ExampleScenario",
            "path": "ExampleScenario",
            "short": "Example of workflow instance",
            "definition": "Example of workflow instance.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ExampleScenario.url",
            "path": "ExampleScenario.url",
            "short": "Canonical identifier for this example scenario, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this example scenario when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this example scenario is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the example scenario is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the example scenario to be referenced by a single globally unique identifier.",
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
            "id": "ExampleScenario.identifier",
            "path": "ExampleScenario.identifier",
            "short": "Additional identifier for the example scenario",
            "definition": "A formal identifier that is used to identify this example scenario when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this example scenario outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ExampleScenario.version",
            "path": "ExampleScenario.version",
            "short": "Business version of the example scenario",
            "definition": "The identifier that is used to identify this version of the example scenario when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the example scenario author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different example scenario instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the example scenario with the format [url]|[version].",
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
            "id": "ExampleScenario.name",
            "path": "ExampleScenario.name",
            "short": "Name for this example scenario (computer friendly)",
            "definition": "A natural language name identifying the example scenario. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ExampleScenario.status",
            "path": "ExampleScenario.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this example scenario. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of example scenarios that are appropriate for use versus not.",
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
            "id": "ExampleScenario.experimental",
            "path": "ExampleScenario.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this example scenario is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of example scenarios that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level example scenario.",
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
            "id": "ExampleScenario.date",
            "path": "ExampleScenario.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the example scenario was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the example scenario changes. (e.g. the 'content logical definition').",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the example scenario. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ExampleScenario.publisher",
            "path": "ExampleScenario.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the example scenario.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the example scenario is the organization or individual primarily responsible for the maintenance and upkeep of the example scenario. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the example scenario. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the example scenario.  May also allow for contact.",
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
            "id": "ExampleScenario.contact",
            "path": "ExampleScenario.contact",
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
            "id": "ExampleScenario.useContext",
            "path": "ExampleScenario.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate example scenario instances.",
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
            "id": "ExampleScenario.jurisdiction",
            "path": "ExampleScenario.jurisdiction",
            "short": "Intended jurisdiction for example scenario (if applicable)",
            "definition": "A legal or geographic region in which the example scenario is intended to be used.",
            "comment": "It may be possible for the example scenario to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ExampleScenario.copyright",
            "path": "ExampleScenario.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the example scenario and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the example scenario.",
            "comment": "nullFrequently, the copyright differs between the value set and the codes that are included. The copyright statement should clearly differentiate between these when required.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the example scenario and/or its content.",
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
            "id": "ExampleScenario.purpose",
            "path": "ExampleScenario.purpose",
            "short": "The purpose of the example, e.g. to illustrate a scenario",
            "definition": "What the example scenario resource is created for. This should not be used to show the business purpose of the scenario itself, but the purpose of documenting a scenario.",
            "comment": "This element does not describe the usage of the example scenario. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this example scenario.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.actor",
            "path": "ExampleScenario.actor",
            "short": "Actor participating in the resource",
            "definition": "Actor participating in the resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.actor.actorId",
            "path": "ExampleScenario.actor.actorId",
            "short": "ID or acronym of the actor",
            "definition": "ID or acronym of actor.",
            "comment": "should this be called ID or acronym?",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.actor.type",
            "path": "ExampleScenario.actor.type",
            "short": "person | entity",
            "definition": "The type of actor - person or system.",
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
                  "valueString": "ExampleScenarioActorType"
                }
              ],
              "strength": "required",
              "description": "The type of actor - system or human.",
              "valueSet": "http://hl7.org/fhir/ValueSet/examplescenario-actor-type|4.0.0"
            }
          },
          {
            "id": "ExampleScenario.actor.name",
            "path": "ExampleScenario.actor.name",
            "short": "The name of the actor as shown in the page",
            "definition": "The name of the actor as shown in the page.",
            "comment": "Cardinality: is name and description 1..1?",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.actor.description",
            "path": "ExampleScenario.actor.description",
            "short": "The description of the actor",
            "definition": "The description of the actor.",
            "comment": "Cardinality: is name and description 1..1?",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance",
            "path": "ExampleScenario.instance",
            "short": "Each resource and each version that is present in the workflow",
            "definition": "Each resource and each version that is present in the workflow.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.resourceId",
            "path": "ExampleScenario.instance.resourceId",
            "short": "The id of the resource for referencing",
            "definition": "The id of the resource for referencing.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.resourceType",
            "path": "ExampleScenario.instance.resourceType",
            "short": "The type of the resource",
            "definition": "The type of the resource.",
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
                  "valueString": "FHIRResourceType"
                }
              ],
              "strength": "required",
              "description": "The type of resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-types|4.0.0"
            }
          },
          {
            "id": "ExampleScenario.instance.name",
            "path": "ExampleScenario.instance.name",
            "short": "A short name for the resource instance",
            "definition": "A short name for the resource instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.description",
            "path": "ExampleScenario.instance.description",
            "short": "Human-friendly description of the resource instance",
            "definition": "Human-friendly description of the resource instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.version",
            "path": "ExampleScenario.instance.version",
            "short": "A specific version of the resource",
            "definition": "A specific version of the resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.version.versionId",
            "path": "ExampleScenario.instance.version.versionId",
            "short": "The identifier of a specific version of a resource",
            "definition": "The identifier of a specific version of a resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.version.description",
            "path": "ExampleScenario.instance.version.description",
            "short": "The description of the resource version",
            "definition": "The description of the resource version.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.containedInstance",
            "path": "ExampleScenario.instance.containedInstance",
            "short": "Resources contained in the instance",
            "definition": "Resources contained in the instance (e.g. the observations contained in a bundle).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.containedInstance.resourceId",
            "path": "ExampleScenario.instance.containedInstance.resourceId",
            "short": "Each resource contained in the instance",
            "definition": "Each resource contained in the instance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.instance.containedInstance.versionId",
            "path": "ExampleScenario.instance.containedInstance.versionId",
            "short": "A specific version of a resource contained in the instance",
            "definition": "A specific version of a resource contained in the instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process",
            "path": "ExampleScenario.process",
            "short": "Each major process - a group of operations",
            "definition": "Each major process - a group of operations.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.title",
            "path": "ExampleScenario.process.title",
            "short": "The diagram title of the group of operations",
            "definition": "The diagram title of the group of operations.",
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
            "id": "ExampleScenario.process.description",
            "path": "ExampleScenario.process.description",
            "short": "A longer description of the group of operations",
            "definition": "A longer description of the group of operations.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.preConditions",
            "path": "ExampleScenario.process.preConditions",
            "short": "Description of initial status before the process starts",
            "definition": "Description of initial status before the process starts.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.postConditions",
            "path": "ExampleScenario.process.postConditions",
            "short": "Description of final status after the process ends",
            "definition": "Description of final status after the process ends.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step",
            "path": "ExampleScenario.process.step",
            "short": "Each step of the process",
            "definition": "Each step of the process.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.process",
            "path": "ExampleScenario.process.step.process",
            "short": "Nested process",
            "definition": "Nested process.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExampleScenario.process"
          },
          {
            "id": "ExampleScenario.process.step.pause",
            "path": "ExampleScenario.process.step.pause",
            "short": "If there is a pause in the flow",
            "definition": "If there is a pause in the flow.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation",
            "path": "ExampleScenario.process.step.operation",
            "short": "Each interaction or action",
            "definition": "Each interaction or action.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.number",
            "path": "ExampleScenario.process.step.operation.number",
            "short": "The sequential number of the interaction",
            "definition": "The sequential number of the interaction, e.g. 1.2.5.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.type",
            "path": "ExampleScenario.process.step.operation.type",
            "short": "The type of operation - CRUD",
            "definition": "The type of operation - CRUD.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.name",
            "path": "ExampleScenario.process.step.operation.name",
            "short": "The human-friendly name of the interaction",
            "definition": "The human-friendly name of the interaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.initiator",
            "path": "ExampleScenario.process.step.operation.initiator",
            "short": "Who starts the transaction",
            "definition": "Who starts the transaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.receiver",
            "path": "ExampleScenario.process.step.operation.receiver",
            "short": "Who receives the transaction",
            "definition": "Who receives the transaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.description",
            "path": "ExampleScenario.process.step.operation.description",
            "short": "A comment to be inserted in the diagram",
            "definition": "A comment to be inserted in the diagram.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.initiatorActive",
            "path": "ExampleScenario.process.step.operation.initiatorActive",
            "short": "Whether the initiator is deactivated right after the transaction",
            "definition": "Whether the initiator is deactivated right after the transaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.receiverActive",
            "path": "ExampleScenario.process.step.operation.receiverActive",
            "short": "Whether the receiver is deactivated right after the transaction",
            "definition": "Whether the receiver is deactivated right after the transaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.operation.request",
            "path": "ExampleScenario.process.step.operation.request",
            "short": "Each resource instance used by the initiator",
            "definition": "Each resource instance used by the initiator.",
            "min": 0,
            "max": "1",
            "contentReference": "#ExampleScenario.instance.containedInstance"
          },
          {
            "id": "ExampleScenario.process.step.operation.response",
            "path": "ExampleScenario.process.step.operation.response",
            "short": "Each resource instance used by the responder",
            "definition": "Each resource instance used by the responder.",
            "min": 0,
            "max": "1",
            "contentReference": "#ExampleScenario.instance.containedInstance"
          },
          {
            "id": "ExampleScenario.process.step.alternative",
            "path": "ExampleScenario.process.step.alternative",
            "short": "Alternate non-typical step action",
            "definition": "Indicates an alternative step that can be taken instead of the operations on the base step in exceptional/atypical circumstances.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.alternative.title",
            "path": "ExampleScenario.process.step.alternative.title",
            "short": "Label for alternative",
            "definition": "The label to display for the alternative that gives a sense of the circumstance in which the alternative should be invoked.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.alternative.description",
            "path": "ExampleScenario.process.step.alternative.description",
            "short": "A human-readable description of each option",
            "definition": "A human-readable description of the alternative explaining when the alternative should occur rather than the base step.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ExampleScenario.process.step.alternative.step",
            "path": "ExampleScenario.process.step.alternative.step",
            "short": "What happens in each alternative option",
            "definition": "What happens in each alternative option.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExampleScenario.process.step"
          },
          {
            "id": "ExampleScenario.workflow",
            "path": "ExampleScenario.workflow",
            "short": "Another nested workflow",
            "definition": "Another nested workflow.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ExampleScenario"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ExampleScenario'
    /// </summary>
    // 0. ExampleScenario
    public class ExampleScenario : FhirKhit.Maker.Common.Resource.ResourceBase                                                              // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ExampleScenario_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 14. ExampleScenario.actor
            public class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Actor_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 15. ExampleScenario.actor.actorId
                    public ElementDefinitionInfo ActorId;                                                                                   // MakerGen.cs:216
                    // 16. ExampleScenario.actor.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 17. ExampleScenario.actor.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 18. ExampleScenario.actor.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Actor_Elements()                                                                                            // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. ExampleScenario.actor.actorId
                            this.ActorId = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ActorId",                                                                                           // MakerGen.cs:235
                                Path= "ExampleScenario.actor.actorId",                                                                      // MakerGen.cs:236
                                Id = "ExampleScenario.actor.actorId",                                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. ExampleScenario.actor.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "ExampleScenario.actor.type",                                                                         // MakerGen.cs:236
                                Id = "ExampleScenario.actor.type",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. ExampleScenario.actor.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "ExampleScenario.actor.name",                                                                         // MakerGen.cs:236
                                Id = "ExampleScenario.actor.name",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. ExampleScenario.actor.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "ExampleScenario.actor.description",                                                                  // MakerGen.cs:236
                                Id = "ExampleScenario.actor.description",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        ActorId.Write(sDef);                                                                                                // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Actor_Elements Elements                                                                                         // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Actor_Elements();                                                                      // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Actor_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Actor()                                                                                                         // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ExampleScenario.actor",                                                                                     // MakerGen.cs:428
                        ElementId = "ExampleScenario.actor"                                                                                 // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 19. ExampleScenario.instance
            public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Instance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 24. ExampleScenario.instance.version
                    public class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Version_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 25. ExampleScenario.instance.version.versionId
                            public ElementDefinitionInfo VersionId;                                                                         // MakerGen.cs:216
                            // 26. ExampleScenario.instance.version.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Version_Elements()                                                                                  // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 25. ExampleScenario.instance.version.versionId
                                    this.VersionId = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "VersionId",                                                                                 // MakerGen.cs:235
                                        Path= "ExampleScenario.instance.version.versionId",                                                 // MakerGen.cs:236
                                        Id = "ExampleScenario.instance.version.versionId",                                                  // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 26. ExampleScenario.instance.version.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Description",                                                                               // MakerGen.cs:235
                                        Path= "ExampleScenario.instance.version.description",                                               // MakerGen.cs:236
                                        Id = "ExampleScenario.instance.version.description",                                                // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Markdown                                                    // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                VersionId.Write(sDef);                                                                                      // MakerGen.cs:220
                                Description.Write(sDef);                                                                                    // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Version_Elements Elements                                                                               // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Version_Elements();                                                            // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Version_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Version()                                                                                               // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ExampleScenario.instance.version",                                                                  // MakerGen.cs:428
                                ElementId = "ExampleScenario.instance.version"                                                              // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 27. ExampleScenario.instance.containedInstance
                    public class Type_ContainedInstance : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_ContainedInstance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 28. ExampleScenario.instance.containedInstance.resourceId
                            public ElementDefinitionInfo ResourceId;                                                                        // MakerGen.cs:216
                            // 29. ExampleScenario.instance.containedInstance.versionId
                            public ElementDefinitionInfo VersionId;                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_ContainedInstance_Elements()                                                                        // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 28. ExampleScenario.instance.containedInstance.resourceId
                                    this.ResourceId = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ResourceId",                                                                                // MakerGen.cs:235
                                        Path= "ExampleScenario.instance.containedInstance.resourceId",                                      // MakerGen.cs:236
                                        Id = "ExampleScenario.instance.containedInstance.resourceId",                                       // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 29. ExampleScenario.instance.containedInstance.versionId
                                    this.VersionId = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "VersionId",                                                                                 // MakerGen.cs:235
                                        Path= "ExampleScenario.instance.containedInstance.versionId",                                       // MakerGen.cs:236
                                        Id = "ExampleScenario.instance.containedInstance.versionId",                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                ResourceId.Write(sDef);                                                                                     // MakerGen.cs:220
                                VersionId.Write(sDef);                                                                                      // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_ContainedInstance_Elements Elements                                                                     // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_ContainedInstance_Elements();                                                  // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_ContainedInstance_Elements elements;                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_ContainedInstance()                                                                                     // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ExampleScenario.instance.containedInstance",                                                        // MakerGen.cs:428
                                ElementId = "ExampleScenario.instance.containedInstance"                                                    // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 20. ExampleScenario.instance.resourceId
                    public ElementDefinitionInfo ResourceId;                                                                                // MakerGen.cs:216
                    // 21. ExampleScenario.instance.resourceType
                    public ElementDefinitionInfo ResourceType;                                                                              // MakerGen.cs:216
                    // 22. ExampleScenario.instance.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 23. ExampleScenario.instance.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 24. ExampleScenario.instance.version
                    public ElementDefinitionInfo Version;                                                                                   // MakerGen.cs:216
                    // 27. ExampleScenario.instance.containedInstance
                    public ElementDefinitionInfo ContainedInstance;                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Instance_Elements()                                                                                         // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. ExampleScenario.instance.resourceId
                            this.ResourceId = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ResourceId",                                                                                        // MakerGen.cs:235
                                Path= "ExampleScenario.instance.resourceId",                                                                // MakerGen.cs:236
                                Id = "ExampleScenario.instance.resourceId",                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. ExampleScenario.instance.resourceType
                            this.ResourceType = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ResourceType",                                                                                      // MakerGen.cs:235
                                Path= "ExampleScenario.instance.resourceType",                                                              // MakerGen.cs:236
                                Id = "ExampleScenario.instance.resourceType",                                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. ExampleScenario.instance.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "ExampleScenario.instance.name",                                                                      // MakerGen.cs:236
                                Id = "ExampleScenario.instance.name",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. ExampleScenario.instance.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "ExampleScenario.instance.description",                                                               // MakerGen.cs:236
                                Id = "ExampleScenario.instance.description",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. ExampleScenario.instance.version
                            this.Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Version",                                                                                           // MakerGen.cs:235
                                Path= "ExampleScenario.instance.version",                                                                   // MakerGen.cs:236
                                Id = "ExampleScenario.instance.version",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Version                                                                                        // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. ExampleScenario.instance.containedInstance
                            this.ContainedInstance = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ContainedInstance",                                                                                 // MakerGen.cs:235
                                Path= "ExampleScenario.instance.containedInstance",                                                         // MakerGen.cs:236
                                Id = "ExampleScenario.instance.containedInstance",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_ContainedInstance                                                                              // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        ResourceId.Write(sDef);                                                                                             // MakerGen.cs:220
                        ResourceType.Write(sDef);                                                                                           // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Version.Write(sDef);                                                                                                // MakerGen.cs:220
                        ContainedInstance.Write(sDef);                                                                                      // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Instance_Elements Elements                                                                                      // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Instance_Elements();                                                                   // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Instance_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Instance()                                                                                                      // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ExampleScenario.instance",                                                                                  // MakerGen.cs:428
                        ElementId = "ExampleScenario.instance"                                                                              // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 30. ExampleScenario.process
            public class Type_Process : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Process_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 35. ExampleScenario.process.step
                    public class Type_Step : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Step_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 38. ExampleScenario.process.step.operation
                            public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_Operation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 39. ExampleScenario.process.step.operation.number
                                    public ElementDefinitionInfo Number;                                                                    // MakerGen.cs:216
                                    // 40. ExampleScenario.process.step.operation.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:216
                                    // 41. ExampleScenario.process.step.operation.name
                                    public ElementDefinitionInfo Name;                                                                      // MakerGen.cs:216
                                    // 42. ExampleScenario.process.step.operation.initiator
                                    public ElementDefinitionInfo Initiator;                                                                 // MakerGen.cs:216
                                    // 43. ExampleScenario.process.step.operation.receiver
                                    public ElementDefinitionInfo Receiver;                                                                  // MakerGen.cs:216
                                    // 44. ExampleScenario.process.step.operation.description
                                    public ElementDefinitionInfo Description;                                                               // MakerGen.cs:216
                                    // 45. ExampleScenario.process.step.operation.initiatorActive
                                    public ElementDefinitionInfo InitiatorActive;                                                           // MakerGen.cs:216
                                    // 46. ExampleScenario.process.step.operation.receiverActive
                                    public ElementDefinitionInfo ReceiverActive;                                                            // MakerGen.cs:216
                                    // 47. ExampleScenario.process.step.operation.request
                                    public ElementDefinitionInfo Request;                                                                   // MakerGen.cs:216
                                    // 48. ExampleScenario.process.step.operation.response
                                    public ElementDefinitionInfo Response;                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_Operation_Elements()                                                                        // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 39. ExampleScenario.process.step.operation.number
                                            this.Number = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Number",                                                                            // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.number",                                      // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.number",                                       // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 40. ExampleScenario.process.step.operation.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Type",                                                                              // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.type",                                        // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.type",                                         // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 41. ExampleScenario.process.step.operation.name
                                            this.Name = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Name",                                                                              // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.name",                                        // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.name",                                         // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 42. ExampleScenario.process.step.operation.initiator
                                            this.Initiator = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Initiator",                                                                         // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.initiator",                                   // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.initiator",                                    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 43. ExampleScenario.process.step.operation.receiver
                                            this.Receiver = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Receiver",                                                                          // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.receiver",                                    // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.receiver",                                     // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 44. ExampleScenario.process.step.operation.description
                                            this.Description = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Description",                                                                       // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.description",                                 // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.description",                                  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Markdown                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 45. ExampleScenario.process.step.operation.initiatorActive
                                            this.InitiatorActive = new ElementDefinitionInfo                                                // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "InitiatorActive",                                                                   // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.initiatorActive",                             // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.initiatorActive",                              // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 46. ExampleScenario.process.step.operation.receiverActive
                                            this.ReceiverActive = new ElementDefinitionInfo                                                 // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ReceiverActive",                                                                    // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.receiverActive",                              // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.receiverActive",                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 47. ExampleScenario.process.step.operation.request
                                            this.Request = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Request",                                                                           // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.request",                                     // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.request",                                      // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 48. ExampleScenario.process.step.operation.response
                                            this.Response = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Response",                                                                          // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.operation.response",                                    // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.operation.response",                                     // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Number.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Name.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Initiator.Write(sDef);                                                                              // MakerGen.cs:220
                                        Receiver.Write(sDef);                                                                               // MakerGen.cs:220
                                        Description.Write(sDef);                                                                            // MakerGen.cs:220
                                        InitiatorActive.Write(sDef);                                                                        // MakerGen.cs:220
                                        ReceiverActive.Write(sDef);                                                                         // MakerGen.cs:220
                                        Request.Write(sDef);                                                                                // MakerGen.cs:220
                                        Response.Write(sDef);                                                                               // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_Operation_Elements Elements                                                                     // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_Operation_Elements();                                                  // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_Operation_Elements elements;                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_Operation()                                                                                     // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "ExampleScenario.process.step.operation",                                                    // MakerGen.cs:428
                                        ElementId = "ExampleScenario.process.step.operation"                                                // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 49. ExampleScenario.process.step.alternative
                            public class Type_Alternative : FhirKhit.Maker.Common.Complex.ComplexBase                                       // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_Alternative_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                        // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 50. ExampleScenario.process.step.alternative.title
                                    public ElementDefinitionInfo Title;                                                                     // MakerGen.cs:216
                                    // 51. ExampleScenario.process.step.alternative.description
                                    public ElementDefinitionInfo Description;                                                               // MakerGen.cs:216
                                    // 52. ExampleScenario.process.step.alternative.step
                                    public ElementDefinitionInfo Step;                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_Alternative_Elements()                                                                      // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 50. ExampleScenario.process.step.alternative.title
                                            this.Title = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Title",                                                                             // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.alternative.title",                                     // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.alternative.title",                                      // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 51. ExampleScenario.process.step.alternative.description
                                            this.Description = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Description",                                                                       // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.alternative.description",                               // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.alternative.description",                                // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Markdown                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 52. ExampleScenario.process.step.alternative.step
                                            this.Step = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Step",                                                                              // MakerGen.cs:235
                                                Path= "ExampleScenario.process.step.alternative.step",                                      // MakerGen.cs:236
                                                Id = "ExampleScenario.process.step.alternative.step",                                       // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Title.Write(sDef);                                                                                  // MakerGen.cs:220
                                        Description.Write(sDef);                                                                            // MakerGen.cs:220
                                        Step.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_Alternative_Elements Elements                                                                   // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_Alternative_Elements();                                                // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_Alternative_Elements elements;                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_Alternative()                                                                                   // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "ExampleScenario.process.step.alternative",                                                  // MakerGen.cs:428
                                        ElementId = "ExampleScenario.process.step.alternative"                                              // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 36. ExampleScenario.process.step.process
                            public ElementDefinitionInfo Process;                                                                           // MakerGen.cs:216
                            // 37. ExampleScenario.process.step.pause
                            public ElementDefinitionInfo Pause;                                                                             // MakerGen.cs:216
                            // 38. ExampleScenario.process.step.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:216
                            // 49. ExampleScenario.process.step.alternative
                            public ElementDefinitionInfo Alternative;                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Step_Elements()                                                                                     // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 36. ExampleScenario.process.step.process
                                    this.Process = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Process",                                                                                   // MakerGen.cs:235
                                        Path= "ExampleScenario.process.step.process",                                                       // MakerGen.cs:236
                                        Id = "ExampleScenario.process.step.process",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 37. ExampleScenario.process.step.pause
                                    this.Pause = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Pause",                                                                                     // MakerGen.cs:235
                                        Path= "ExampleScenario.process.step.pause",                                                         // MakerGen.cs:236
                                        Id = "ExampleScenario.process.step.pause",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 38. ExampleScenario.process.step.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Operation",                                                                                 // MakerGen.cs:235
                                        Path= "ExampleScenario.process.step.operation",                                                     // MakerGen.cs:236
                                        Id = "ExampleScenario.process.step.operation",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Operation                                                                              // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 49. ExampleScenario.process.step.alternative
                                    this.Alternative = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Alternative",                                                                               // MakerGen.cs:235
                                        Path= "ExampleScenario.process.step.alternative",                                                   // MakerGen.cs:236
                                        Id = "ExampleScenario.process.step.alternative",                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Alternative                                                                            // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Process.Write(sDef);                                                                                        // MakerGen.cs:220
                                Pause.Write(sDef);                                                                                          // MakerGen.cs:220
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:220
                                Alternative.Write(sDef);                                                                                    // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Step_Elements Elements                                                                                  // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Step_Elements();                                                               // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Step_Elements elements;                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Step()                                                                                                  // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ExampleScenario.process.step",                                                                      // MakerGen.cs:428
                                ElementId = "ExampleScenario.process.step"                                                                  // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 31. ExampleScenario.process.title
                    public ElementDefinitionInfo Title;                                                                                     // MakerGen.cs:216
                    // 32. ExampleScenario.process.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 33. ExampleScenario.process.preConditions
                    public ElementDefinitionInfo PreConditions;                                                                             // MakerGen.cs:216
                    // 34. ExampleScenario.process.postConditions
                    public ElementDefinitionInfo PostConditions;                                                                            // MakerGen.cs:216
                    // 35. ExampleScenario.process.step
                    public ElementDefinitionInfo Step;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Process_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. ExampleScenario.process.title
                            this.Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Title",                                                                                             // MakerGen.cs:235
                                Path= "ExampleScenario.process.title",                                                                      // MakerGen.cs:236
                                Id = "ExampleScenario.process.title",                                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. ExampleScenario.process.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "ExampleScenario.process.description",                                                                // MakerGen.cs:236
                                Id = "ExampleScenario.process.description",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. ExampleScenario.process.preConditions
                            this.PreConditions = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PreConditions",                                                                                     // MakerGen.cs:235
                                Path= "ExampleScenario.process.preConditions",                                                              // MakerGen.cs:236
                                Id = "ExampleScenario.process.preConditions",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. ExampleScenario.process.postConditions
                            this.PostConditions = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PostConditions",                                                                                    // MakerGen.cs:235
                                Path= "ExampleScenario.process.postConditions",                                                             // MakerGen.cs:236
                                Id = "ExampleScenario.process.postConditions",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. ExampleScenario.process.step
                            this.Step = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Step",                                                                                              // MakerGen.cs:235
                                Path= "ExampleScenario.process.step",                                                                       // MakerGen.cs:236
                                Id = "ExampleScenario.process.step",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Step                                                                                           // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Title.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        PreConditions.Write(sDef);                                                                                          // MakerGen.cs:220
                        PostConditions.Write(sDef);                                                                                         // MakerGen.cs:220
                        Step.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Process_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Process_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Process_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Process()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ExampleScenario.process",                                                                                   // MakerGen.cs:428
                        ElementId = "ExampleScenario.process"                                                                               // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. ExampleScenario.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. ExampleScenario.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. ExampleScenario.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. ExampleScenario.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. ExampleScenario.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 6. ExampleScenario.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 7. ExampleScenario.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 8. ExampleScenario.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 9. ExampleScenario.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 10. ExampleScenario.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 11. ExampleScenario.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 12. ExampleScenario.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 13. ExampleScenario.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 14. ExampleScenario.actor
            public ElementDefinitionInfo Actor;                                                                                             // MakerGen.cs:216
            // 19. ExampleScenario.instance
            public ElementDefinitionInfo Instance;                                                                                          // MakerGen.cs:216
            // 30. ExampleScenario.process
            public ElementDefinitionInfo Process;                                                                                           // MakerGen.cs:216
            // 53. ExampleScenario.workflow
            public ElementDefinitionInfo Workflow;                                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ExampleScenario_Elements()                                                                                               // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ExampleScenario.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "ExampleScenario.url",                                                                                        // MakerGen.cs:236
                        Id = "ExampleScenario.url",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. ExampleScenario.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ExampleScenario.identifier",                                                                                 // MakerGen.cs:236
                        Id = "ExampleScenario.identifier",                                                                                  // MakerGen.cs:237
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
                    // 3. ExampleScenario.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "ExampleScenario.version",                                                                                    // MakerGen.cs:236
                        Id = "ExampleScenario.version",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. ExampleScenario.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "ExampleScenario.name",                                                                                       // MakerGen.cs:236
                        Id = "ExampleScenario.name",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. ExampleScenario.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ExampleScenario.status",                                                                                     // MakerGen.cs:236
                        Id = "ExampleScenario.status",                                                                                      // MakerGen.cs:237
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
                    // 6. ExampleScenario.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "ExampleScenario.experimental",                                                                               // MakerGen.cs:236
                        Id = "ExampleScenario.experimental",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. ExampleScenario.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "ExampleScenario.date",                                                                                       // MakerGen.cs:236
                        Id = "ExampleScenario.date",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 8. ExampleScenario.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "ExampleScenario.publisher",                                                                                  // MakerGen.cs:236
                        Id = "ExampleScenario.publisher",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. ExampleScenario.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "ExampleScenario.contact",                                                                                    // MakerGen.cs:236
                        Id = "ExampleScenario.contact",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. ExampleScenario.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "ExampleScenario.useContext",                                                                                 // MakerGen.cs:236
                        Id = "ExampleScenario.useContext",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. ExampleScenario.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "ExampleScenario.jurisdiction",                                                                               // MakerGen.cs:236
                        Id = "ExampleScenario.jurisdiction",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. ExampleScenario.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "ExampleScenario.copyright",                                                                                  // MakerGen.cs:236
                        Id = "ExampleScenario.copyright",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. ExampleScenario.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "ExampleScenario.purpose",                                                                                    // MakerGen.cs:236
                        Id = "ExampleScenario.purpose",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. ExampleScenario.actor
                    this.Actor = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Actor",                                                                                                     // MakerGen.cs:235
                        Path= "ExampleScenario.actor",                                                                                      // MakerGen.cs:236
                        Id = "ExampleScenario.actor",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Actor                                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. ExampleScenario.instance
                    this.Instance = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Instance",                                                                                                  // MakerGen.cs:235
                        Path= "ExampleScenario.instance",                                                                                   // MakerGen.cs:236
                        Id = "ExampleScenario.instance",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Instance                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 30. ExampleScenario.process
                    this.Process = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Process",                                                                                                   // MakerGen.cs:235
                        Path= "ExampleScenario.process",                                                                                    // MakerGen.cs:236
                        Id = "ExampleScenario.process",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Process                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 53. ExampleScenario.workflow
                    this.Workflow = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Workflow",                                                                                                  // MakerGen.cs:235
                        Path= "ExampleScenario.workflow",                                                                                   // MakerGen.cs:236
                        Id = "ExampleScenario.workflow",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ExampleScenario"                                               // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:220
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:220
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:220
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Actor.Write(sDef);                                                                                                          // MakerGen.cs:220
                Instance.Write(sDef);                                                                                                       // MakerGen.cs:220
                Process.Write(sDef);                                                                                                        // MakerGen.cs:220
                Workflow.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ExampleScenario_Elements Elements                                                                                            // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ExampleScenario_Elements();                                                                         // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ExampleScenario_Elements elements;                                                                                                  // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ExampleScenario()                                                                                                            // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ExampleScenario";                                                                                                  // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ExampleScenario";                                                           // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ExampleScenario",                                                                                                   // MakerGen.cs:428
                ElementId = "ExampleScenario"                                                                                               // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
