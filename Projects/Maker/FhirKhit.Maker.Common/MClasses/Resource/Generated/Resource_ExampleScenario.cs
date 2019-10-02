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
    #endregion
    /// <summary>
    /// Fhir resource 'ExampleScenario'
    /// </summary>
    // 0. ExampleScenario
    public partial class Resource_ExampleScenario : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 14. ExampleScenario.actor
        public partial class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 15. ExampleScenario.actor.actorId
            public ElementDefinitionInfo Element_ActorId;
            // 16. ExampleScenario.actor.type
            public ElementDefinitionInfo Element_Type;
            // 17. ExampleScenario.actor.name
            public ElementDefinitionInfo Element_Name;
            // 18. ExampleScenario.actor.description
            public ElementDefinitionInfo Element_Description;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExampleScenario.actor",
                    ElementId = "ExampleScenario.actor"
                });
                Element_ActorId.Write(sDef);
                Element_Type.Write(sDef);
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
            }
            
            public Type_Actor()
            {
                {
                    // 15. ExampleScenario.actor.actorId
                    this.Element_ActorId = new ElementDefinitionInfo
                    {
                        Name = "Element_ActorId",
                        Path= "ExampleScenario.actor.actorId",
                        Id = "ExampleScenario.actor.actorId",
                        Min = 1,
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
                    // 16. ExampleScenario.actor.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExampleScenario.actor.type",
                        Id = "ExampleScenario.actor.type",
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
                    // 17. ExampleScenario.actor.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "ExampleScenario.actor.name",
                        Id = "ExampleScenario.actor.name",
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
                    // 18. ExampleScenario.actor.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ExampleScenario.actor.description",
                        Id = "ExampleScenario.actor.description",
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
            }
        }
        // 19. ExampleScenario.instance
        public partial class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. ExampleScenario.instance.version
            public partial class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 25. ExampleScenario.instance.version.versionId
                public ElementDefinitionInfo Element_VersionId;
                // 26. ExampleScenario.instance.version.description
                public ElementDefinitionInfo Element_Description;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExampleScenario.instance.version",
                        ElementId = "ExampleScenario.instance.version"
                    });
                    Element_VersionId.Write(sDef);
                    Element_Description.Write(sDef);
                }
                
                public Type_Version()
                {
                    {
                        // 25. ExampleScenario.instance.version.versionId
                        this.Element_VersionId = new ElementDefinitionInfo
                        {
                            Name = "Element_VersionId",
                            Path= "ExampleScenario.instance.version.versionId",
                            Id = "ExampleScenario.instance.version.versionId",
                            Min = 1,
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
                        // 26. ExampleScenario.instance.version.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "ExampleScenario.instance.version.description",
                            Id = "ExampleScenario.instance.version.description",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 27. ExampleScenario.instance.containedInstance
            public partial class Type_ContainedInstance : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 28. ExampleScenario.instance.containedInstance.resourceId
                public ElementDefinitionInfo Element_ResourceId;
                // 29. ExampleScenario.instance.containedInstance.versionId
                public ElementDefinitionInfo Element_VersionId;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExampleScenario.instance.containedInstance",
                        ElementId = "ExampleScenario.instance.containedInstance"
                    });
                    Element_ResourceId.Write(sDef);
                    Element_VersionId.Write(sDef);
                }
                
                public Type_ContainedInstance()
                {
                    {
                        // 28. ExampleScenario.instance.containedInstance.resourceId
                        this.Element_ResourceId = new ElementDefinitionInfo
                        {
                            Name = "Element_ResourceId",
                            Path= "ExampleScenario.instance.containedInstance.resourceId",
                            Id = "ExampleScenario.instance.containedInstance.resourceId",
                            Min = 1,
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
                        // 29. ExampleScenario.instance.containedInstance.versionId
                        this.Element_VersionId = new ElementDefinitionInfo
                        {
                            Name = "Element_VersionId",
                            Path= "ExampleScenario.instance.containedInstance.versionId",
                            Id = "ExampleScenario.instance.containedInstance.versionId",
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
            // 20. ExampleScenario.instance.resourceId
            public ElementDefinitionInfo Element_ResourceId;
            // 21. ExampleScenario.instance.resourceType
            public ElementDefinitionInfo Element_ResourceType;
            // 22. ExampleScenario.instance.name
            public ElementDefinitionInfo Element_Name;
            // 23. ExampleScenario.instance.description
            public ElementDefinitionInfo Element_Description;
            // 24. ExampleScenario.instance.version
            public ElementDefinitionInfo Element_Version;
            // 27. ExampleScenario.instance.containedInstance
            public ElementDefinitionInfo Element_ContainedInstance;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExampleScenario.instance",
                    ElementId = "ExampleScenario.instance"
                });
                Element_ResourceId.Write(sDef);
                Element_ResourceType.Write(sDef);
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
                Element_Version.Write(sDef);
                Element_ContainedInstance.Write(sDef);
            }
            
            public Type_Instance()
            {
                {
                    // 20. ExampleScenario.instance.resourceId
                    this.Element_ResourceId = new ElementDefinitionInfo
                    {
                        Name = "Element_ResourceId",
                        Path= "ExampleScenario.instance.resourceId",
                        Id = "ExampleScenario.instance.resourceId",
                        Min = 1,
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
                    // 21. ExampleScenario.instance.resourceType
                    this.Element_ResourceType = new ElementDefinitionInfo
                    {
                        Name = "Element_ResourceType",
                        Path= "ExampleScenario.instance.resourceType",
                        Id = "ExampleScenario.instance.resourceType",
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
                    // 22. ExampleScenario.instance.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "ExampleScenario.instance.name",
                        Id = "ExampleScenario.instance.name",
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
                    // 23. ExampleScenario.instance.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ExampleScenario.instance.description",
                        Id = "ExampleScenario.instance.description",
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
                    // 24. ExampleScenario.instance.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "ExampleScenario.instance.version",
                        Id = "ExampleScenario.instance.version",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Version
                            {
                            }
                        }
                    };
                }
                {
                    // 27. ExampleScenario.instance.containedInstance
                    this.Element_ContainedInstance = new ElementDefinitionInfo
                    {
                        Name = "Element_ContainedInstance",
                        Path= "ExampleScenario.instance.containedInstance",
                        Id = "ExampleScenario.instance.containedInstance",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_ContainedInstance
                            {
                            }
                        }
                    };
                }
            }
        }
        // 30. ExampleScenario.process
        public partial class Type_Process : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. ExampleScenario.process.step
            public partial class Type_Step : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 38. ExampleScenario.process.step.operation
                public partial class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 39. ExampleScenario.process.step.operation.number
                    public ElementDefinitionInfo Element_Number;
                    // 40. ExampleScenario.process.step.operation.type
                    public ElementDefinitionInfo Element_Type;
                    // 41. ExampleScenario.process.step.operation.name
                    public ElementDefinitionInfo Element_Name;
                    // 42. ExampleScenario.process.step.operation.initiator
                    public ElementDefinitionInfo Element_Initiator;
                    // 43. ExampleScenario.process.step.operation.receiver
                    public ElementDefinitionInfo Element_Receiver;
                    // 44. ExampleScenario.process.step.operation.description
                    public ElementDefinitionInfo Element_Description;
                    // 45. ExampleScenario.process.step.operation.initiatorActive
                    public ElementDefinitionInfo Element_InitiatorActive;
                    // 46. ExampleScenario.process.step.operation.receiverActive
                    public ElementDefinitionInfo Element_ReceiverActive;
                    // 47. ExampleScenario.process.step.operation.request
                    public ElementDefinitionInfo Element_Request;
                    // 48. ExampleScenario.process.step.operation.response
                    public ElementDefinitionInfo Element_Response;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ExampleScenario.process.step.operation",
                            ElementId = "ExampleScenario.process.step.operation"
                        });
                        Element_Number.Write(sDef);
                        Element_Type.Write(sDef);
                        Element_Name.Write(sDef);
                        Element_Initiator.Write(sDef);
                        Element_Receiver.Write(sDef);
                        Element_Description.Write(sDef);
                        Element_InitiatorActive.Write(sDef);
                        Element_ReceiverActive.Write(sDef);
                        Element_Request.Write(sDef);
                        Element_Response.Write(sDef);
                    }
                    
                    public Type_Operation()
                    {
                        {
                            // 39. ExampleScenario.process.step.operation.number
                            this.Element_Number = new ElementDefinitionInfo
                            {
                                Name = "Element_Number",
                                Path= "ExampleScenario.process.step.operation.number",
                                Id = "ExampleScenario.process.step.operation.number",
                                Min = 1,
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
                            // 40. ExampleScenario.process.step.operation.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "ExampleScenario.process.step.operation.type",
                                Id = "ExampleScenario.process.step.operation.type",
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
                            // 41. ExampleScenario.process.step.operation.name
                            this.Element_Name = new ElementDefinitionInfo
                            {
                                Name = "Element_Name",
                                Path= "ExampleScenario.process.step.operation.name",
                                Id = "ExampleScenario.process.step.operation.name",
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
                            // 42. ExampleScenario.process.step.operation.initiator
                            this.Element_Initiator = new ElementDefinitionInfo
                            {
                                Name = "Element_Initiator",
                                Path= "ExampleScenario.process.step.operation.initiator",
                                Id = "ExampleScenario.process.step.operation.initiator",
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
                            // 43. ExampleScenario.process.step.operation.receiver
                            this.Element_Receiver = new ElementDefinitionInfo
                            {
                                Name = "Element_Receiver",
                                Path= "ExampleScenario.process.step.operation.receiver",
                                Id = "ExampleScenario.process.step.operation.receiver",
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
                            // 44. ExampleScenario.process.step.operation.description
                            this.Element_Description = new ElementDefinitionInfo
                            {
                                Name = "Element_Description",
                                Path= "ExampleScenario.process.step.operation.description",
                                Id = "ExampleScenario.process.step.operation.description",
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
                            // 45. ExampleScenario.process.step.operation.initiatorActive
                            this.Element_InitiatorActive = new ElementDefinitionInfo
                            {
                                Name = "Element_InitiatorActive",
                                Path= "ExampleScenario.process.step.operation.initiatorActive",
                                Id = "ExampleScenario.process.step.operation.initiatorActive",
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
                            // 46. ExampleScenario.process.step.operation.receiverActive
                            this.Element_ReceiverActive = new ElementDefinitionInfo
                            {
                                Name = "Element_ReceiverActive",
                                Path= "ExampleScenario.process.step.operation.receiverActive",
                                Id = "ExampleScenario.process.step.operation.receiverActive",
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
                            // 47. ExampleScenario.process.step.operation.request
                            this.Element_Request = new ElementDefinitionInfo
                            {
                                Name = "Element_Request",
                                Path= "ExampleScenario.process.step.operation.request",
                                Id = "ExampleScenario.process.step.operation.request",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                        {
                            // 48. ExampleScenario.process.step.operation.response
                            this.Element_Response = new ElementDefinitionInfo
                            {
                                Name = "Element_Response",
                                Path= "ExampleScenario.process.step.operation.response",
                                Id = "ExampleScenario.process.step.operation.response",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 49. ExampleScenario.process.step.alternative
                public partial class Type_Alternative : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 50. ExampleScenario.process.step.alternative.title
                    public ElementDefinitionInfo Element_Title;
                    // 51. ExampleScenario.process.step.alternative.description
                    public ElementDefinitionInfo Element_Description;
                    // 52. ExampleScenario.process.step.alternative.step
                    public ElementDefinitionInfo Element_Step;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ExampleScenario.process.step.alternative",
                            ElementId = "ExampleScenario.process.step.alternative"
                        });
                        Element_Title.Write(sDef);
                        Element_Description.Write(sDef);
                        Element_Step.Write(sDef);
                    }
                    
                    public Type_Alternative()
                    {
                        {
                            // 50. ExampleScenario.process.step.alternative.title
                            this.Element_Title = new ElementDefinitionInfo
                            {
                                Name = "Element_Title",
                                Path= "ExampleScenario.process.step.alternative.title",
                                Id = "ExampleScenario.process.step.alternative.title",
                                Min = 1,
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
                            // 51. ExampleScenario.process.step.alternative.description
                            this.Element_Description = new ElementDefinitionInfo
                            {
                                Name = "Element_Description",
                                Path= "ExampleScenario.process.step.alternative.description",
                                Id = "ExampleScenario.process.step.alternative.description",
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
                            // 52. ExampleScenario.process.step.alternative.step
                            this.Element_Step = new ElementDefinitionInfo
                            {
                                Name = "Element_Step",
                                Path= "ExampleScenario.process.step.alternative.step",
                                Id = "ExampleScenario.process.step.alternative.step",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 36. ExampleScenario.process.step.process
                public ElementDefinitionInfo Element_Process;
                // 37. ExampleScenario.process.step.pause
                public ElementDefinitionInfo Element_Pause;
                // 38. ExampleScenario.process.step.operation
                public ElementDefinitionInfo Element_Operation;
                // 49. ExampleScenario.process.step.alternative
                public ElementDefinitionInfo Element_Alternative;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExampleScenario.process.step",
                        ElementId = "ExampleScenario.process.step"
                    });
                    Element_Process.Write(sDef);
                    Element_Pause.Write(sDef);
                    Element_Operation.Write(sDef);
                    Element_Alternative.Write(sDef);
                }
                
                public Type_Step()
                {
                    {
                        // 36. ExampleScenario.process.step.process
                        this.Element_Process = new ElementDefinitionInfo
                        {
                            Name = "Element_Process",
                            Path= "ExampleScenario.process.step.process",
                            Id = "ExampleScenario.process.step.process",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 37. ExampleScenario.process.step.pause
                        this.Element_Pause = new ElementDefinitionInfo
                        {
                            Name = "Element_Pause",
                            Path= "ExampleScenario.process.step.pause",
                            Id = "ExampleScenario.process.step.pause",
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
                        // 38. ExampleScenario.process.step.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "ExampleScenario.process.step.operation",
                            Id = "ExampleScenario.process.step.operation",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_Operation
                                {
                                }
                            }
                        };
                    }
                    {
                        // 49. ExampleScenario.process.step.alternative
                        this.Element_Alternative = new ElementDefinitionInfo
                        {
                            Name = "Element_Alternative",
                            Path= "ExampleScenario.process.step.alternative",
                            Id = "ExampleScenario.process.step.alternative",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Alternative
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 31. ExampleScenario.process.title
            public ElementDefinitionInfo Element_Title;
            // 32. ExampleScenario.process.description
            public ElementDefinitionInfo Element_Description;
            // 33. ExampleScenario.process.preConditions
            public ElementDefinitionInfo Element_PreConditions;
            // 34. ExampleScenario.process.postConditions
            public ElementDefinitionInfo Element_PostConditions;
            // 35. ExampleScenario.process.step
            public ElementDefinitionInfo Element_Step;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExampleScenario.process",
                    ElementId = "ExampleScenario.process"
                });
                Element_Title.Write(sDef);
                Element_Description.Write(sDef);
                Element_PreConditions.Write(sDef);
                Element_PostConditions.Write(sDef);
                Element_Step.Write(sDef);
            }
            
            public Type_Process()
            {
                {
                    // 31. ExampleScenario.process.title
                    this.Element_Title = new ElementDefinitionInfo
                    {
                        Name = "Element_Title",
                        Path= "ExampleScenario.process.title",
                        Id = "ExampleScenario.process.title",
                        Min = 1,
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
                    // 32. ExampleScenario.process.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ExampleScenario.process.description",
                        Id = "ExampleScenario.process.description",
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
                    // 33. ExampleScenario.process.preConditions
                    this.Element_PreConditions = new ElementDefinitionInfo
                    {
                        Name = "Element_PreConditions",
                        Path= "ExampleScenario.process.preConditions",
                        Id = "ExampleScenario.process.preConditions",
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
                    // 34. ExampleScenario.process.postConditions
                    this.Element_PostConditions = new ElementDefinitionInfo
                    {
                        Name = "Element_PostConditions",
                        Path= "ExampleScenario.process.postConditions",
                        Id = "ExampleScenario.process.postConditions",
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
                    // 35. ExampleScenario.process.step
                    this.Element_Step = new ElementDefinitionInfo
                    {
                        Name = "Element_Step",
                        Path= "ExampleScenario.process.step",
                        Id = "ExampleScenario.process.step",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Step
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. ExampleScenario.url
        public ElementDefinitionInfo Element_Url;
        // 2. ExampleScenario.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. ExampleScenario.version
        public ElementDefinitionInfo Element_Version;
        // 4. ExampleScenario.name
        public ElementDefinitionInfo Element_Name;
        // 5. ExampleScenario.status
        public ElementDefinitionInfo Element_Status;
        // 6. ExampleScenario.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 7. ExampleScenario.date
        public ElementDefinitionInfo Element_Date;
        // 8. ExampleScenario.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 9. ExampleScenario.contact
        public ElementDefinitionInfo Element_Contact;
        // 10. ExampleScenario.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 11. ExampleScenario.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 12. ExampleScenario.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 13. ExampleScenario.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 14. ExampleScenario.actor
        public ElementDefinitionInfo Element_Actor;
        // 19. ExampleScenario.instance
        public ElementDefinitionInfo Element_Instance;
        // 30. ExampleScenario.process
        public ElementDefinitionInfo Element_Process;
        // 53. ExampleScenario.workflow
        public ElementDefinitionInfo Element_Workflow;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ExampleScenario",
                ElementId = "ExampleScenario"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Copyright.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Actor.Write(sDef);
            Element_Instance.Write(sDef);
            Element_Process.Write(sDef);
            Element_Workflow.Write(sDef);
        }
        
        public Resource_ExampleScenario()
        {
            {
                // 1. ExampleScenario.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ExampleScenario.url",
                    Id = "ExampleScenario.url",
                    Min = 0,
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
                // 2. ExampleScenario.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ExampleScenario.identifier",
                    Id = "ExampleScenario.identifier",
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
                // 3. ExampleScenario.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ExampleScenario.version",
                    Id = "ExampleScenario.version",
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
                // 4. ExampleScenario.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ExampleScenario.name",
                    Id = "ExampleScenario.name",
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
                // 5. ExampleScenario.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ExampleScenario.status",
                    Id = "ExampleScenario.status",
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
                // 6. ExampleScenario.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ExampleScenario.experimental",
                    Id = "ExampleScenario.experimental",
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
                // 7. ExampleScenario.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ExampleScenario.date",
                    Id = "ExampleScenario.date",
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
                // 8. ExampleScenario.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ExampleScenario.publisher",
                    Id = "ExampleScenario.publisher",
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
                // 9. ExampleScenario.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ExampleScenario.contact",
                    Id = "ExampleScenario.contact",
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
                // 10. ExampleScenario.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ExampleScenario.useContext",
                    Id = "ExampleScenario.useContext",
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
                // 11. ExampleScenario.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ExampleScenario.jurisdiction",
                    Id = "ExampleScenario.jurisdiction",
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
                // 12. ExampleScenario.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ExampleScenario.copyright",
                    Id = "ExampleScenario.copyright",
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
                // 13. ExampleScenario.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "ExampleScenario.purpose",
                    Id = "ExampleScenario.purpose",
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
                // 14. ExampleScenario.actor
                this.Element_Actor = new ElementDefinitionInfo
                {
                    Name = "Element_Actor",
                    Path= "ExampleScenario.actor",
                    Id = "ExampleScenario.actor",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Actor
                        {
                        }
                    }
                };
            }
            {
                // 19. ExampleScenario.instance
                this.Element_Instance = new ElementDefinitionInfo
                {
                    Name = "Element_Instance",
                    Path= "ExampleScenario.instance",
                    Id = "ExampleScenario.instance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Instance
                        {
                        }
                    }
                };
            }
            {
                // 30. ExampleScenario.process
                this.Element_Process = new ElementDefinitionInfo
                {
                    Name = "Element_Process",
                    Path= "ExampleScenario.process",
                    Id = "ExampleScenario.process",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Process
                        {
                        }
                    }
                };
            }
            {
                // 53. ExampleScenario.workflow
                this.Element_Workflow = new ElementDefinitionInfo
                {
                    Name = "Element_Workflow",
                    Path= "ExampleScenario.workflow",
                    Id = "ExampleScenario.workflow",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ExampleScenario"
                            }
                        }
                    }
                };
            }
            this.Name = "ExampleScenario";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ExampleScenario";
        }
    }
}
