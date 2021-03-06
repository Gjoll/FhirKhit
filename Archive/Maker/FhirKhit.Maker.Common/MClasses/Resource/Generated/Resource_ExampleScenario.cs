using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'ExampleScenario'
    /// </summary>
    // 0. ExampleScenario
    public partial class Resource_ExampleScenario : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                  // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 14. ExampleScenario.actor
        public partial class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 15. ExampleScenario.actor.actorId
            public ElementDefinitionInfo Element_ActorId;                                                                                   // MakerGen.cs:217
            // 16. ExampleScenario.actor.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 17. ExampleScenario.actor.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 18. ExampleScenario.actor.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "ExampleScenario.actor",                                                                                         // MakerGen.cs:393
                    ElementId = "ExampleScenario.actor"                                                                                     // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_ActorId.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Actor()                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 15. ExampleScenario.actor.actorId
                    this.Element_ActorId = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ActorId",                                                                                           // MakerGen.cs:236
                        Path= "ExampleScenario.actor.actorId",                                                                              // MakerGen.cs:237
                        Id = "ExampleScenario.actor.actorId",                                                                               // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. ExampleScenario.actor.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "ExampleScenario.actor.type",                                                                                 // MakerGen.cs:237
                        Id = "ExampleScenario.actor.type",                                                                                  // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. ExampleScenario.actor.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "ExampleScenario.actor.name",                                                                                 // MakerGen.cs:237
                        Id = "ExampleScenario.actor.name",                                                                                  // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 18. ExampleScenario.actor.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "ExampleScenario.actor.description",                                                                          // MakerGen.cs:237
                        Id = "ExampleScenario.actor.description",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 19. ExampleScenario.instance
        public partial class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 24. ExampleScenario.instance.version
            public partial class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 25. ExampleScenario.instance.version.versionId
                public ElementDefinitionInfo Element_VersionId;                                                                             // MakerGen.cs:217
                // 26. ExampleScenario.instance.version.description
                public ElementDefinitionInfo Element_Description;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "ExampleScenario.instance.version",                                                                          // MakerGen.cs:393
                        ElementId = "ExampleScenario.instance.version"                                                                      // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_VersionId.Write(sDef);                                                                                          // MakerGen.cs:221
                    Element_Description.Write(sDef);                                                                                        // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Version()                                                                                                       // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 25. ExampleScenario.instance.version.versionId
                        this.Element_VersionId = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_VersionId",                                                                                     // MakerGen.cs:236
                            Path= "ExampleScenario.instance.version.versionId",                                                             // MakerGen.cs:237
                            Id = "ExampleScenario.instance.version.versionId",                                                              // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 26. ExampleScenario.instance.version.description
                        this.Element_Description = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Description",                                                                                   // MakerGen.cs:236
                            Path= "ExampleScenario.instance.version.description",                                                           // MakerGen.cs:237
                            Id = "ExampleScenario.instance.version.description",                                                            // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                      // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 27. ExampleScenario.instance.containedInstance
            public partial class Type_ContainedInstance : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 28. ExampleScenario.instance.containedInstance.resourceId
                public ElementDefinitionInfo Element_ResourceId;                                                                            // MakerGen.cs:217
                // 29. ExampleScenario.instance.containedInstance.versionId
                public ElementDefinitionInfo Element_VersionId;                                                                             // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "ExampleScenario.instance.containedInstance",                                                                // MakerGen.cs:393
                        ElementId = "ExampleScenario.instance.containedInstance"                                                            // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_ResourceId.Write(sDef);                                                                                         // MakerGen.cs:221
                    Element_VersionId.Write(sDef);                                                                                          // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_ContainedInstance()                                                                                             // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 28. ExampleScenario.instance.containedInstance.resourceId
                        this.Element_ResourceId = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ResourceId",                                                                                    // MakerGen.cs:236
                            Path= "ExampleScenario.instance.containedInstance.resourceId",                                                  // MakerGen.cs:237
                            Id = "ExampleScenario.instance.containedInstance.resourceId",                                                   // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 29. ExampleScenario.instance.containedInstance.versionId
                        this.Element_VersionId = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_VersionId",                                                                                     // MakerGen.cs:236
                            Path= "ExampleScenario.instance.containedInstance.versionId",                                                   // MakerGen.cs:237
                            Id = "ExampleScenario.instance.containedInstance.versionId",                                                    // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 20. ExampleScenario.instance.resourceId
            public ElementDefinitionInfo Element_ResourceId;                                                                                // MakerGen.cs:217
            // 21. ExampleScenario.instance.resourceType
            public ElementDefinitionInfo Element_ResourceType;                                                                              // MakerGen.cs:217
            // 22. ExampleScenario.instance.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 23. ExampleScenario.instance.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
            // 24. ExampleScenario.instance.version
            public ElementDefinitionInfo Element_Version;                                                                                   // MakerGen.cs:217
            // 27. ExampleScenario.instance.containedInstance
            public ElementDefinitionInfo Element_ContainedInstance;                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "ExampleScenario.instance",                                                                                      // MakerGen.cs:393
                    ElementId = "ExampleScenario.instance"                                                                                  // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_ResourceId.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_ResourceType.Write(sDef);                                                                                           // MakerGen.cs:221
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Version.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_ContainedInstance.Write(sDef);                                                                                      // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Instance()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 20. ExampleScenario.instance.resourceId
                    this.Element_ResourceId = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ResourceId",                                                                                        // MakerGen.cs:236
                        Path= "ExampleScenario.instance.resourceId",                                                                        // MakerGen.cs:237
                        Id = "ExampleScenario.instance.resourceId",                                                                         // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 21. ExampleScenario.instance.resourceType
                    this.Element_ResourceType = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ResourceType",                                                                                      // MakerGen.cs:236
                        Path= "ExampleScenario.instance.resourceType",                                                                      // MakerGen.cs:237
                        Id = "ExampleScenario.instance.resourceType",                                                                       // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. ExampleScenario.instance.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "ExampleScenario.instance.name",                                                                              // MakerGen.cs:237
                        Id = "ExampleScenario.instance.name",                                                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 23. ExampleScenario.instance.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "ExampleScenario.instance.description",                                                                       // MakerGen.cs:237
                        Id = "ExampleScenario.instance.description",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 24. ExampleScenario.instance.version
                    this.Element_Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Version",                                                                                           // MakerGen.cs:236
                        Path= "ExampleScenario.instance.version",                                                                           // MakerGen.cs:237
                        Id = "ExampleScenario.instance.version",                                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Version                                                                                                // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 27. ExampleScenario.instance.containedInstance
                    this.Element_ContainedInstance = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ContainedInstance",                                                                                 // MakerGen.cs:236
                        Path= "ExampleScenario.instance.containedInstance",                                                                 // MakerGen.cs:237
                        Id = "ExampleScenario.instance.containedInstance",                                                                  // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_ContainedInstance                                                                                      // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 30. ExampleScenario.process
        public partial class Type_Process : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 35. ExampleScenario.process.step
            public partial class Type_Step : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 38. ExampleScenario.process.step.operation
                public partial class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 39. ExampleScenario.process.step.operation.number
                    public ElementDefinitionInfo Element_Number;                                                                            // MakerGen.cs:217
                    // 40. ExampleScenario.process.step.operation.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:217
                    // 41. ExampleScenario.process.step.operation.name
                    public ElementDefinitionInfo Element_Name;                                                                              // MakerGen.cs:217
                    // 42. ExampleScenario.process.step.operation.initiator
                    public ElementDefinitionInfo Element_Initiator;                                                                         // MakerGen.cs:217
                    // 43. ExampleScenario.process.step.operation.receiver
                    public ElementDefinitionInfo Element_Receiver;                                                                          // MakerGen.cs:217
                    // 44. ExampleScenario.process.step.operation.description
                    public ElementDefinitionInfo Element_Description;                                                                       // MakerGen.cs:217
                    // 45. ExampleScenario.process.step.operation.initiatorActive
                    public ElementDefinitionInfo Element_InitiatorActive;                                                                   // MakerGen.cs:217
                    // 46. ExampleScenario.process.step.operation.receiverActive
                    public ElementDefinitionInfo Element_ReceiverActive;                                                                    // MakerGen.cs:217
                    // 47. ExampleScenario.process.step.operation.request
                    public ElementDefinitionInfo Element_Request;                                                                           // MakerGen.cs:217
                    // 48. ExampleScenario.process.step.operation.response
                    public ElementDefinitionInfo Element_Response;                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "ExampleScenario.process.step.operation",                                                                // MakerGen.cs:393
                            ElementId = "ExampleScenario.process.step.operation"                                                            // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Number.Write(sDef);                                                                                         // MakerGen.cs:221
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Name.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Initiator.Write(sDef);                                                                                      // MakerGen.cs:221
                        Element_Receiver.Write(sDef);                                                                                       // MakerGen.cs:221
                        Element_Description.Write(sDef);                                                                                    // MakerGen.cs:221
                        Element_InitiatorActive.Write(sDef);                                                                                // MakerGen.cs:221
                        Element_ReceiverActive.Write(sDef);                                                                                 // MakerGen.cs:221
                        Element_Request.Write(sDef);                                                                                        // MakerGen.cs:221
                        Element_Response.Write(sDef);                                                                                       // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_Operation()                                                                                                 // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 39. ExampleScenario.process.step.operation.number
                            this.Element_Number = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Number",                                                                                    // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.number",                                                      // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.number",                                                       // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 40. ExampleScenario.process.step.operation.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Type",                                                                                      // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.type",                                                        // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.type",                                                         // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 41. ExampleScenario.process.step.operation.name
                            this.Element_Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Name",                                                                                      // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.name",                                                        // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.name",                                                         // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 42. ExampleScenario.process.step.operation.initiator
                            this.Element_Initiator = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Initiator",                                                                                 // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.initiator",                                                   // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.initiator",                                                    // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 43. ExampleScenario.process.step.operation.receiver
                            this.Element_Receiver = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Receiver",                                                                                  // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.receiver",                                                    // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.receiver",                                                     // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 44. ExampleScenario.process.step.operation.description
                            this.Element_Description = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Description",                                                                               // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.description",                                                 // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.description",                                                  // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 45. ExampleScenario.process.step.operation.initiatorActive
                            this.Element_InitiatorActive = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_InitiatorActive",                                                                           // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.initiatorActive",                                             // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.initiatorActive",                                              // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                   // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 46. ExampleScenario.process.step.operation.receiverActive
                            this.Element_ReceiverActive = new ElementDefinitionInfo                                                         // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_ReceiverActive",                                                                            // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.receiverActive",                                              // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.receiverActive",                                               // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                   // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 47. ExampleScenario.process.step.operation.request
                            this.Element_Request = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Request",                                                                                   // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.request",                                                     // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.request",                                                      // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 48. ExampleScenario.process.step.operation.response
                            this.Element_Response = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Response",                                                                                  // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.operation.response",                                                    // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.operation.response",                                                     // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 49. ExampleScenario.process.step.alternative
                public partial class Type_Alternative : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 50. ExampleScenario.process.step.alternative.title
                    public ElementDefinitionInfo Element_Title;                                                                             // MakerGen.cs:217
                    // 51. ExampleScenario.process.step.alternative.description
                    public ElementDefinitionInfo Element_Description;                                                                       // MakerGen.cs:217
                    // 52. ExampleScenario.process.step.alternative.step
                    public ElementDefinitionInfo Element_Step;                                                                              // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "ExampleScenario.process.step.alternative",                                                              // MakerGen.cs:393
                            ElementId = "ExampleScenario.process.step.alternative"                                                          // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Title.Write(sDef);                                                                                          // MakerGen.cs:221
                        Element_Description.Write(sDef);                                                                                    // MakerGen.cs:221
                        Element_Step.Write(sDef);                                                                                           // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_Alternative()                                                                                               // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 50. ExampleScenario.process.step.alternative.title
                            this.Element_Title = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Title",                                                                                     // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.alternative.title",                                                     // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.alternative.title",                                                      // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 51. ExampleScenario.process.step.alternative.description
                            this.Element_Description = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Description",                                                                               // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.alternative.description",                                               // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.alternative.description",                                                // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 52. ExampleScenario.process.step.alternative.step
                            this.Element_Step = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Step",                                                                                      // MakerGen.cs:236
                                Path= "ExampleScenario.process.step.alternative.step",                                                      // MakerGen.cs:237
                                Id = "ExampleScenario.process.step.alternative.step",                                                       // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = -1,                                                                                                   // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 36. ExampleScenario.process.step.process
                public ElementDefinitionInfo Element_Process;                                                                               // MakerGen.cs:217
                // 37. ExampleScenario.process.step.pause
                public ElementDefinitionInfo Element_Pause;                                                                                 // MakerGen.cs:217
                // 38. ExampleScenario.process.step.operation
                public ElementDefinitionInfo Element_Operation;                                                                             // MakerGen.cs:217
                // 49. ExampleScenario.process.step.alternative
                public ElementDefinitionInfo Element_Alternative;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "ExampleScenario.process.step",                                                                              // MakerGen.cs:393
                        ElementId = "ExampleScenario.process.step"                                                                          // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Process.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Pause.Write(sDef);                                                                                              // MakerGen.cs:221
                    Element_Operation.Write(sDef);                                                                                          // MakerGen.cs:221
                    Element_Alternative.Write(sDef);                                                                                        // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Step()                                                                                                          // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 36. ExampleScenario.process.step.process
                        this.Element_Process = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Process",                                                                                       // MakerGen.cs:236
                            Path= "ExampleScenario.process.step.process",                                                                   // MakerGen.cs:237
                            Id = "ExampleScenario.process.step.process",                                                                    // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 37. ExampleScenario.process.step.pause
                        this.Element_Pause = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Pause",                                                                                         // MakerGen.cs:236
                            Path= "ExampleScenario.process.step.pause",                                                                     // MakerGen.cs:237
                            Id = "ExampleScenario.process.step.pause",                                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 38. ExampleScenario.process.step.operation
                        this.Element_Operation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:236
                            Path= "ExampleScenario.process.step.operation",                                                                 // MakerGen.cs:237
                            Id = "ExampleScenario.process.step.operation",                                                                  // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_Operation                                                                                          // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 49. ExampleScenario.process.step.alternative
                        this.Element_Alternative = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Alternative",                                                                                   // MakerGen.cs:236
                            Path= "ExampleScenario.process.step.alternative",                                                               // MakerGen.cs:237
                            Id = "ExampleScenario.process.step.alternative",                                                                // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_Alternative                                                                                        // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 31. ExampleScenario.process.title
            public ElementDefinitionInfo Element_Title;                                                                                     // MakerGen.cs:217
            // 32. ExampleScenario.process.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
            // 33. ExampleScenario.process.preConditions
            public ElementDefinitionInfo Element_PreConditions;                                                                             // MakerGen.cs:217
            // 34. ExampleScenario.process.postConditions
            public ElementDefinitionInfo Element_PostConditions;                                                                            // MakerGen.cs:217
            // 35. ExampleScenario.process.step
            public ElementDefinitionInfo Element_Step;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "ExampleScenario.process",                                                                                       // MakerGen.cs:393
                    ElementId = "ExampleScenario.process"                                                                                   // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Title.Write(sDef);                                                                                                  // MakerGen.cs:221
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_PreConditions.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_PostConditions.Write(sDef);                                                                                         // MakerGen.cs:221
                Element_Step.Write(sDef);                                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Process()                                                                                                           // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 31. ExampleScenario.process.title
                    this.Element_Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Title",                                                                                             // MakerGen.cs:236
                        Path= "ExampleScenario.process.title",                                                                              // MakerGen.cs:237
                        Id = "ExampleScenario.process.title",                                                                               // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 32. ExampleScenario.process.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "ExampleScenario.process.description",                                                                        // MakerGen.cs:237
                        Id = "ExampleScenario.process.description",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 33. ExampleScenario.process.preConditions
                    this.Element_PreConditions = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_PreConditions",                                                                                     // MakerGen.cs:236
                        Path= "ExampleScenario.process.preConditions",                                                                      // MakerGen.cs:237
                        Id = "ExampleScenario.process.preConditions",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 34. ExampleScenario.process.postConditions
                    this.Element_PostConditions = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_PostConditions",                                                                                    // MakerGen.cs:236
                        Path= "ExampleScenario.process.postConditions",                                                                     // MakerGen.cs:237
                        Id = "ExampleScenario.process.postConditions",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 35. ExampleScenario.process.step
                    this.Element_Step = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Step",                                                                                              // MakerGen.cs:236
                        Path= "ExampleScenario.process.step",                                                                               // MakerGen.cs:237
                        Id = "ExampleScenario.process.step",                                                                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Step                                                                                                   // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. ExampleScenario.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 2. ExampleScenario.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 3. ExampleScenario.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:217
        // 4. ExampleScenario.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 5. ExampleScenario.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 6. ExampleScenario.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:217
        // 7. ExampleScenario.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:217
        // 8. ExampleScenario.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:217
        // 9. ExampleScenario.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 10. ExampleScenario.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:217
        // 11. ExampleScenario.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:217
        // 12. ExampleScenario.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:217
        // 13. ExampleScenario.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:217
        // 14. ExampleScenario.actor
        public ElementDefinitionInfo Element_Actor;                                                                                         // MakerGen.cs:217
        // 19. ExampleScenario.instance
        public ElementDefinitionInfo Element_Instance;                                                                                      // MakerGen.cs:217
        // 30. ExampleScenario.process
        public ElementDefinitionInfo Element_Process;                                                                                       // MakerGen.cs:217
        // 53. ExampleScenario.workflow
        public ElementDefinitionInfo Element_Workflow;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "ExampleScenario",                                                                                                   // MakerGen.cs:393
                ElementId = "ExampleScenario"                                                                                               // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Experimental.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Copyright.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Actor.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Instance.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Process.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Workflow.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_ExampleScenario()                                                                                                   // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. ExampleScenario.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "ExampleScenario.url",                                                                                            // MakerGen.cs:237
                    Id = "ExampleScenario.url",                                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. ExampleScenario.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "ExampleScenario.identifier",                                                                                     // MakerGen.cs:237
                    Id = "ExampleScenario.identifier",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. ExampleScenario.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Version",                                                                                               // MakerGen.cs:236
                    Path= "ExampleScenario.version",                                                                                        // MakerGen.cs:237
                    Id = "ExampleScenario.version",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. ExampleScenario.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "ExampleScenario.name",                                                                                           // MakerGen.cs:237
                    Id = "ExampleScenario.name",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. ExampleScenario.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "ExampleScenario.status",                                                                                         // MakerGen.cs:237
                    Id = "ExampleScenario.status",                                                                                          // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. ExampleScenario.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:236
                    Path= "ExampleScenario.experimental",                                                                                   // MakerGen.cs:237
                    Id = "ExampleScenario.experimental",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. ExampleScenario.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:236
                    Path= "ExampleScenario.date",                                                                                           // MakerGen.cs:237
                    Id = "ExampleScenario.date",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. ExampleScenario.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:236
                    Path= "ExampleScenario.publisher",                                                                                      // MakerGen.cs:237
                    Id = "ExampleScenario.publisher",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. ExampleScenario.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "ExampleScenario.contact",                                                                                        // MakerGen.cs:237
                    Id = "ExampleScenario.contact",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. ExampleScenario.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:236
                    Path= "ExampleScenario.useContext",                                                                                     // MakerGen.cs:237
                    Id = "ExampleScenario.useContext",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. ExampleScenario.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:236
                    Path= "ExampleScenario.jurisdiction",                                                                                   // MakerGen.cs:237
                    Id = "ExampleScenario.jurisdiction",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. ExampleScenario.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:236
                    Path= "ExampleScenario.copyright",                                                                                      // MakerGen.cs:237
                    Id = "ExampleScenario.copyright",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. ExampleScenario.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:236
                    Path= "ExampleScenario.purpose",                                                                                        // MakerGen.cs:237
                    Id = "ExampleScenario.purpose",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. ExampleScenario.actor
                this.Element_Actor = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Actor",                                                                                                 // MakerGen.cs:236
                    Path= "ExampleScenario.actor",                                                                                          // MakerGen.cs:237
                    Id = "ExampleScenario.actor",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Actor                                                                                                      // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 19. ExampleScenario.instance
                this.Element_Instance = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Instance",                                                                                              // MakerGen.cs:236
                    Path= "ExampleScenario.instance",                                                                                       // MakerGen.cs:237
                    Id = "ExampleScenario.instance",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Instance                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 30. ExampleScenario.process
                this.Element_Process = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Process",                                                                                               // MakerGen.cs:236
                    Path= "ExampleScenario.process",                                                                                        // MakerGen.cs:237
                    Id = "ExampleScenario.process",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Process                                                                                                    // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 53. ExampleScenario.workflow
                this.Element_Workflow = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Workflow",                                                                                              // MakerGen.cs:236
                    Path= "ExampleScenario.workflow",                                                                                       // MakerGen.cs:237
                    Id = "ExampleScenario.workflow",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ExampleScenario"                                                   // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "ExampleScenario";                                                                                                  // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ExampleScenario";                                                           // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
