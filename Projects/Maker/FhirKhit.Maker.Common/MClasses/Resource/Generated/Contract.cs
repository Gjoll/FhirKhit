using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "Contract",
      "url": "http://hl7.org/fhir/StructureDefinition/Contract",
      "version": "4.0.0",
      "name": "Contract",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Contract",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Contract",
            "path": "Contract",
            "short": "Legal Agreement",
            "definition": "Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Contract.identifier",
            "path": "Contract.identifier",
            "short": "Contract number",
            "definition": "Unique identifier for this Contract or a derivative that references a Source Contract.",
            "requirements": "This is the business identifier of the contract content conveyed.  It may be a derivative of the legally binding contract, in which case, the identifier of the basal contract is  contained in the Contract.binding referenced Contract.",
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
            "id": "Contract.url",
            "path": "Contract.url",
            "short": "Basal definition",
            "definition": "Canonical identifier for this contract, represented as a URI (globally unique).",
            "comment": "Used in a domain that uses a supplied contract repository.",
            "requirements": "An absolute URI that is used to identify this contract when it is referenced in a specification, model, design, instance or a contract derivative; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which this plan definition is (or will be) published.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Contract.version",
            "path": "Contract.version",
            "short": "Business edition",
            "definition": "An edition identifier used for business purposes to label business significant variants.",
            "comment": "Note -  This is a business versionId, not a resource version id (see discussion http://build.fhir.org/resource.html#versions) \rComments - There may be different contract instances that have the same identifier but different versions. The version can be appended to the url in a reference to allow a reference to a particular business version of the plan definition with the format [url]|[version].",
            "requirements": "The identifier that is used to identify this version of the contract when it is referenced in a specification, model, design, instance, or contract derivative. This is an arbitrary value managed by the contract author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
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
            "id": "Contract.status",
            "path": "Contract.status",
            "short": "draft | active | suspended | cancelled | completed | entered-in-error | unknown",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the contract as not currently valid or active.",
            "requirements": "This is the Contract Business Workflow Status.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-status|4.0.0"
            }
          },
          {
            "id": "Contract.legalState",
            "path": "Contract.legalState",
            "short": "Negotiation status",
            "definition": "Legal states of the formation of a legal instrument, which is a formally executed written document that can be formally attributed to its author, records and formally expresses a legally enforceable act, process, or contractual duty, obligation, or right, and therefore evidences that act, process, or agreement.",
            "requirements": "The legal state of a contract follows a prescribed flow as defined by the legal community and these state may be indepenedent of the workflow state.",
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
                  "valueString": "ContractLegalState"
                }
              ],
              "strength": "extensible",
              "description": "Detailed codes for the legal state of a contract.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-legalstate"
            }
          },
          {
            "id": "Contract.instantiatesCanonical",
            "path": "Contract.instantiatesCanonical",
            "short": "Source Contract Definition",
            "definition": "The URL pointing to a FHIR-defined Contract Definition that is adhered to in whole or part by this Contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Contract"
                ]
              }
            ]
          },
          {
            "id": "Contract.instantiatesUri",
            "path": "Contract.instantiatesUri",
            "short": "External Contract Definition",
            "definition": "The URL pointing to an externally maintained definition that is adhered to in whole or in part by this Contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Contract.contentDerivative",
            "path": "Contract.contentDerivative",
            "short": "Content derived from the basal information",
            "definition": "The minimal content derived from the basal information source at a specific stage in its lifecycle.",
            "requirements": "In the context of a contract, the information source of the content derivative shall be the information referenced by the contract.binding.\rThe Contract Resource may function simply as the computable representation of the executed contract, which may be the attached to the Contract Resource as the “binding” or as the “friendly” electronic form.  For example, a Contract Resource may be automatically populated with the values expressed in a related QuestionnaireResponse. \rHowever, the Contract Resource may be considered the legally binding contract if it is the only “executed” form of this contract, and includes the signatures as *The Contract Resource may function as the computable representation of an application or offer in a pre-executed Contract if the grantor has not entered any values.  In this case, it is populated with values in a “legal” form of the application or offer or by the values in an associated Questionnaire.  If the grantor has filled in the legal form or the associated Questionnaire Response, then these values are used to populate a pre-executed Contract Resource.\rIf the Contract.topic is considered an application or offer, then the policy is often required to be attached as the “legal” basis for the application to ensure “informed consent” to the contract, and that any discrepancy between the application and the policy are interpreted against the policy.  Implementers should check organizational and jurisdictional policies to determine the relationship among multiple representations of a contract pre- and post-execution.",
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
                  "valueString": "ContractContentDerivative"
                }
              ],
              "strength": "example",
              "description": "This is an example set of Content Derivative type codes, which represent the minimal content derived from the basal information source.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-content-derivative"
            }
          },
          {
            "id": "Contract.issued",
            "path": "Contract.issued",
            "short": "When this Contract was issued",
            "definition": "When this  Contract was issued.",
            "requirements": "The Contract issuance dateTime often precedes the Contract effective dateTime.",
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
            "id": "Contract.applies",
            "path": "Contract.applies",
            "short": "Effective time",
            "definition": "Relevant time or time-period when this Contract is applicable.",
            "requirements": "The dateTime upon which the Contract is binding.",
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
            "id": "Contract.expirationType",
            "path": "Contract.expirationType",
            "short": "Contract cessation cause",
            "definition": "Event resulting in discontinuation or termination of this Contract instance by one or more parties to the contract.",
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
                  "valueString": "ContractExpiration"
                }
              ],
              "strength": "example",
              "description": "Codes for the Cessation of Contracts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-expiration-type"
            }
          },
          {
            "id": "Contract.subject",
            "path": "Contract.subject",
            "short": "Contract Target Entity",
            "definition": "The target entity impacted by or of interest to parties to the agreement.",
            "comment": "The Contract.subject is an entity that has some role with respect to the Contract.topic and Contract.topic.term, which is of focal interest to the parties to the contract and likely impacted in a significant way by the Contract.action/Contract.action.reason and the Contract.term.action/Contract.action.reason. \rIn many cases, the Contract.subject is a Contract.signer if the subject is an adult; has a legal interest in the contract; and incompetent to participate in the contract agreement.",
            "requirements": "The Contract.subject is an entity that has some role with respect to the Contract.topic and Contract.topic.term, which is of focal interest to the parties to the contract and likely impacted in a significant way by the Contract.action/Contract.action.reason and the Contract.term.action/Contract.action.reason.  In many cases, the Contract.subject is a Contract.signer if the subject is an adult; has a legal interest in the contract; and incompetent to participate in the contract agreement.",
            "alias": [
              "Patient"
            ],
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
            "isSummary": true
          },
          {
            "id": "Contract.authority",
            "path": "Contract.authority",
            "short": "Authority under which this Contract has standing",
            "definition": "A formally or informally recognized grouping of people, principals, organizations, or jurisdictions formed for the purpose of achieving some form of collective action such as the promulgation, administration and enforcement of contracts and policies.",
            "requirements": "The governance framework responsible for ensuring compliance with or enforcement of the contract or policy.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.domain",
            "path": "Contract.domain",
            "short": "A sphere of control governed by an authoritative jurisdiction, organization, or person",
            "definition": "Recognized governance framework or system operating with a circumscribed scope in accordance with specified principles, policies, processes or procedures for managing rights, actions, or behaviors of parties or principals relative to resources.",
            "requirements": "The entities bound by governance to comply with the enforcement of contracts or policies by a recognized authority.",
            "alias": [
              "scope of governance jurisdiction"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Contract.site",
            "path": "Contract.site",
            "short": "Specific Location",
            "definition": "Sites in which the contract is complied with,  exercised, or in force.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Contract.name",
            "path": "Contract.name",
            "short": "Computer friendly designation",
            "definition": "A natural language name identifying this Contract definition, derivative, or instance in any legal state. Provides additional information about its content. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.",
            "requirements": "Support human navigation and code generation.",
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
            "id": "Contract.title",
            "path": "Contract.title",
            "short": "Human Friendly name",
            "definition": "A short, descriptive, user-friendly title for this Contract definition, derivative, or instance in any legal state.t giving additional information about its content.",
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
            "id": "Contract.subtitle",
            "path": "Contract.subtitle",
            "short": "Subordinate Friendly name",
            "definition": "An explanatory or alternate user-friendly title for this Contract definition, derivative, or instance in any legal state.t giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.alias",
            "path": "Contract.alias",
            "short": "Acronym or short name",
            "definition": "Alternative representation of the title for this Contract definition, derivative, or instance in any legal state., e.g., a domain specific contract number related to legislation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.author",
            "path": "Contract.author",
            "short": "Source of Contract",
            "definition": "The individual or organization that authored the Contract definition, derivative, or instance in any legal state.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.scope",
            "path": "Contract.scope",
            "short": "Range of Legal Concerns",
            "definition": "A selector of legal concerns for this Contract definition, derivative, or instance in any legal state.",
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
                  "valueString": "ContractScope"
                }
              ],
              "strength": "example",
              "description": "Codes for the range of legal concerns.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-scope"
            }
          },
          {
            "id": "Contract.topic[x]",
            "path": "Contract.topic[x]",
            "short": "Focus of contract interest",
            "definition": "Narrows the range of legal concerns to focus on the achievement of specific contractual objectives.",
            "requirements": "Requirement:  May be used to focus the topic of a Contract definition, derivative, or instance in any legal state.\rComment: Contractual areas of concern are very broad. This element supports narrowing the area of concern to more specific term topics within this Contract. Given the wide range of contract topics, implementers need to be cognizant of the business use case for which they are designing a FHIR Contract, and narrowly specify the topic being represented with respect to the Contract.type and any specializing Contract.subtype. The same topic, e.g., an asset such as a good or service, such as a real property, medical supply, insurance, information, a procedure or employment, or a manner of conduct, such adherence to a privacy, trust, or security policy, may be the topic of multiple types of contracts. \rOne way to determine the Contract.topic is to answer the question: “What is the overall objective of this legal instrument. The Contract.topic is described with more detail by the terms of the Contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.type",
            "path": "Contract.type",
            "short": "Legal instrument category",
            "definition": "A high-level category for the legal instrument, whether constructed as a Contract definition, derivative, or instance in any legal state.  Provides additional information about its content within the context of the Contract's scope to distinguish the kinds of systems that would be interested in the contract.",
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
                  "valueString": "ContractType"
                }
              ],
              "strength": "example",
              "description": "List of overall contract codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-type"
            }
          },
          {
            "id": "Contract.subType",
            "path": "Contract.subType",
            "short": "Subtype within the context of type",
            "definition": "Sub-category for the Contract that distinguishes the kinds of systems that would be interested in the Contract within the context of the Contract's scope.",
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
                  "valueString": "ContractSubtype"
                }
              ],
              "strength": "example",
              "description": "Detailed codes within the above.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-subtype"
            }
          },
          {
            "id": "Contract.contentDefinition",
            "path": "Contract.contentDefinition",
            "short": "Contract precursor content",
            "definition": "Precusory content developed with a focus and intent of supporting the formation a Contract instance, which may be associated with and transformable into a Contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.contentDefinition.type",
            "path": "Contract.contentDefinition.type",
            "short": "Content structure and use",
            "definition": "Precusory content structure and use, i.e., a boilerplate, template, application for a contract such as an insurance policy or benefits under a program, e.g., workers compensation.",
            "min": 1,
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
                  "valueString": "ContractDefinitionType"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the definition of contracts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-definition-type"
            }
          },
          {
            "id": "Contract.contentDefinition.subType",
            "path": "Contract.contentDefinition.subType",
            "short": "Detailed Content Type Definition",
            "definition": "Detailed Precusory content type.",
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
                  "valueString": "ContractDefinitionSubtype"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the additional definition of contracts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-definition-subtype"
            }
          },
          {
            "id": "Contract.contentDefinition.publisher",
            "path": "Contract.contentDefinition.publisher",
            "short": "Publisher Entity",
            "definition": "The  individual or organization that published the Contract precursor content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.contentDefinition.publicationDate",
            "path": "Contract.contentDefinition.publicationDate",
            "short": "When published",
            "definition": "The date (and optionally time) when the contract was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the contract changes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Contract.contentDefinition.publicationStatus",
            "path": "Contract.contentDefinition.publicationStatus",
            "short": "draft | active | retired | unknown",
            "definition": "draft | active | retired | unknown.",
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
                  "valueString": "ContractPublicationStatus"
                }
              ],
              "strength": "required",
              "description": "Status of the publication of contract content.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-publicationstatus|4.0.0"
            }
          },
          {
            "id": "Contract.contentDefinition.copyright",
            "path": "Contract.contentDefinition.copyright",
            "short": "Publication Ownership",
            "definition": "A copyright statement relating to Contract precursor content. Copyright statements are generally legal restrictions on the use and publishing of the Contract precursor content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "Contract.term",
            "path": "Contract.term",
            "short": "Contract Term List",
            "definition": "One or more Contract Provisions, which may be related and conveyed as a group, and may contain nested groups.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.identifier",
            "path": "Contract.term.identifier",
            "short": "Contract Term Number",
            "definition": "Unique identifier for this particular Contract Provision.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Contract.term.issued",
            "path": "Contract.term.issued",
            "short": "Contract Term Issue Date Time",
            "definition": "When this Contract Provision was issued.",
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
            "id": "Contract.term.applies",
            "path": "Contract.term.applies",
            "short": "Contract Term Effective Time",
            "definition": "Relevant time or time-period when this Contract Provision is applicable.",
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
            "id": "Contract.term.topic[x]",
            "path": "Contract.term.topic[x]",
            "short": "Term Concern",
            "definition": "The entity that the term applies to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.type",
            "path": "Contract.term.type",
            "short": "Contract Term Type or Form",
            "definition": "A legal clause or condition contained within a contract that requires one or both parties to perform a particular requirement by some specified time or prevents one or both parties from performing a particular requirement by some specified time.",
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
                  "valueString": "ContractTermType"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the types of contract provisions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-term-type"
            }
          },
          {
            "id": "Contract.term.subType",
            "path": "Contract.term.subType",
            "short": "Contract Term Type specific classification",
            "definition": "A specialized legal clause or condition based on overarching contract type.",
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
                  "valueString": "ContractTermSubType"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the subtypes of contract provisions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-term-subtype"
            }
          },
          {
            "id": "Contract.term.text",
            "path": "Contract.term.text",
            "short": "Term Statement",
            "definition": "Statement of a provision in a policy or a contract.",
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
            "id": "Contract.term.securityLabel",
            "path": "Contract.term.securityLabel",
            "short": "Protection for the Term",
            "definition": "Security labels that protect the handling of information about the term and its elements, which may be specifically identified..",
            "requirements": "Requirement -  Within a Contract, a security label may apply to the one to many nested group of terms or to a term, whether inside a group or a singleton.  This security label protects the term and its contained provision elements.  The security label on the entire set of term provision elements may be different from the security labels on a contained offer, asset, valuedItem, or data such as sensitive information, and must be the high water mark of all security labels within the term. Rationale is that a labelled term, which may be disaggregated from the Contract, and must persist the label on the term and on contained elements within other contexts. \rRequirement - If more than one policy dictates a level of confidentiality of the term, then each applicable policy may be represented by a security label specific to its requirements.\rComment - A Security Label is comprised of 1..1 confidentiality code and 0..* other security label codes (aka \"privacy tags\". A Security Label is metadata assigned (aka \"tagged\") to Resources and Resource elements, which specify the confidentiality and sensitivity of the Resource or element and their related attributes, the purposes for which tagged items may be collected, access, used or disclosed, any limitation on the type of entities authorized to engage in permitted purposes, and handling instructions that obligate or prohibit certain actions on the tagged items.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.securityLabel.number",
            "path": "Contract.term.securityLabel.number",
            "short": "Link to Security Labels",
            "definition": "Number used to link this term or term element to the applicable Security Label.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Contract.term.securityLabel.classification",
            "path": "Contract.term.securityLabel.classification",
            "short": "Confidentiality Protection",
            "definition": "Security label privacy tag that species the level of confidentiality protection required for this term and/or term elements.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractSecurityClassification"
                }
              ],
              "strength": "example",
              "description": "Codes for confidentiality protection.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-security-classification"
            }
          },
          {
            "id": "Contract.term.securityLabel.category",
            "path": "Contract.term.securityLabel.category",
            "short": "Applicable Policy",
            "definition": "Security label privacy tag that species the applicable privacy and security policies governing this term and/or term elements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractSecurityCategory"
                }
              ],
              "strength": "example",
              "description": "Codes for policy category.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-security-category"
            }
          },
          {
            "id": "Contract.term.securityLabel.control",
            "path": "Contract.term.securityLabel.control",
            "short": "Handling Instructions",
            "definition": "Security label privacy tag that species the manner in which term and/or term elements are to be protected.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractSecurityControl"
                }
              ],
              "strength": "example",
              "description": "Codes for handling instructions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-security-control"
            }
          },
          {
            "id": "Contract.term.offer",
            "path": "Contract.term.offer",
            "short": "Context of the Contract term",
            "definition": "The matter of concern in the context of this provision of the agrement.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.offer.identifier",
            "path": "Contract.term.offer.identifier",
            "short": "Offer business ID",
            "definition": "Unique identifier for this particular Contract Provision.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Contract.term.offer.party",
            "path": "Contract.term.offer.party",
            "short": "Offer Recipient",
            "definition": "Offer Recipient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.offer.party.reference",
            "path": "Contract.term.offer.party.reference",
            "short": "Referenced entity",
            "definition": "Participant in the offer.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.offer.party.role",
            "path": "Contract.term.offer.party.role",
            "short": "Participant engagement type",
            "definition": "How the party participates in the offer.",
            "min": 1,
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
                  "valueString": "ContractPartyRole"
                }
              ],
              "strength": "example",
              "description": "Codes for offer participant roles.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-party-role"
            }
          },
          {
            "id": "Contract.term.offer.topic",
            "path": "Contract.term.offer.topic",
            "short": "Negotiable offer asset",
            "definition": "The owner of an asset has the residual control rights over the asset: the right to decide all usages of the asset in any way not inconsistent with a prior contract, custom, or law (Hart, 1995, p. 30).",
            "comment": "The Contract.topic may be an application for or offer of a policy or service (e.g., uri to a consent directive form or a health insurance policy), which becomes the Contract once accepted by both the grantor and grantee. \rThe Contract Resource may function simply as the computable representation of the executed contract, which may be the attached to the Contract Resource as the “binding” or as the “friendly” electronic form.  For example, a Contract Resource may be automatically populated with the values expressed in a related QuestionnaireResponse. \rHowever, the Contract Resource may be considered the legally binding contract if it is the only “executed” form of this contract, and includes the signatures as *The Contract Resource may function as the computable representation of an application or offer in a pre-executed Contract if the grantor has not entered any values.  In this case, it is populated with values in a “legal” form of the application or offer or by the values in an associated Questionnaire.  If the grantor has filled in the legal form or the associated Questionnaire Response, then these values are used to populate a pre-executed Contract Resource.\rIf the Contract.topic is considered an application or offer, then the policy is often required to be attached as the “legal” basis for the application to ensure “informed consent” to the contract, and that any discrepancy between the application and the policy are interpreted against the policy.  Implementers should check organizational and jurisdictional policies to determine the relationship among multiple representations of a contract pre- and post-execution.",
            "requirements": "In the context of a contract, the topic is the matter under consideration in regards to which specific rights, privileges, obligations, restrictions, and prohibitions are binding on any grantor and grantee parties upon the execution of the contract. \rGiven the wide range of contract topics, implementers need to be cognizant of the business use case for which they are designing a FHIR Contract, and narrowly specify the topic being represented with respect to the Contract.type and any specializing Contract.subtype. \rThe same topic, e.g., an asset such as a good or service, such as a real property, medical supply, insurance, information, a procedure or employment, or a manner of conduct, such adherence to a privacy, trust, or security policy, may be the topic of multiple types of contracts. \rOne way to determine the Contract.topic is to answer the question: “What is the object of negotiation?”\rAnswer: The Contract.topic, which may be described with more detail in the [0..*]Contract.valuedItem @ [0..1] Contract.valuedItem.entity[x] Definition: Specific type of Contract Valued Item that may be priced. CodeableConcept|Reference(Any)\rContract.topic is “the what” that a grantor is exchanging with a grantee in return for some benefit. \rContract.topic is “the what” to which any Contract.action is being applied for any stipulated Contract.action.reason. \rAContract.topic is “the what” governed by the execution of the contract to which any party’s rights, privileges, obligations, restrictions, and prohibitions apply.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Contract.term.offer.type",
            "path": "Contract.term.offer.type",
            "short": "Contract Offer Type or Form",
            "definition": "Type of Contract Provision such as specific requirements, purposes for actions, obligations, prohibitions, e.g. life time maximum benefit.",
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
                  "valueString": "ContractTermType"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the types of contract provisions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-term-type"
            }
          },
          {
            "id": "Contract.term.offer.decision",
            "path": "Contract.term.offer.decision",
            "short": "Accepting party choice",
            "definition": "Type of choice made by accepting party with respect to an offer made by an offeror/ grantee.",
            "requirements": "In some policy or contract contexts, the \"offer\" is made by an offeror wishing to be the \"grantee\" of the offer topic by the grantor.  From this perspective, the grantor is the \"offeree\".",
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
                  "valueString": "ContractDecisionType"
                }
              ],
              "strength": "extensible",
              "description": "The type of decision made by a grantor with respect to an offer made by a grantee.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActConsentDirective"
            }
          },
          {
            "id": "Contract.term.offer.decisionMode",
            "path": "Contract.term.offer.decisionMode",
            "short": "How decision is conveyed",
            "definition": "How the decision about a Contract was conveyed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractDecisionMode"
                }
              ],
              "strength": "example",
              "description": "Codes for conveying a decision.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-decision-mode"
            }
          },
          {
            "id": "Contract.term.offer.answer",
            "path": "Contract.term.offer.answer",
            "short": "Response to offer text",
            "definition": "Response to offer text.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.offer.answer.value[x]",
            "path": "Contract.term.offer.answer.value[x]",
            "short": "The actual answer response",
            "definition": "Response to an offer clause or question text,  which enables selection of values to be agreed to, e.g., the period of participation, the date of occupancy of a rental, warrently duration, or whether biospecimen may be used for further research.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "decimal"
              },
              {
                "code": "integer"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "time"
              },
              {
                "code": "string"
              },
              {
                "code": "uri"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "Coding"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.offer.text",
            "path": "Contract.term.offer.text",
            "short": "Human readable offer text",
            "definition": "Human readable form of this Contract Offer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.offer.linkId",
            "path": "Contract.term.offer.linkId",
            "short": "Pointer to text",
            "definition": "The id of the clause or question text of the offer in the referenced questionnaire/response.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.offer.securityLabelNumber",
            "path": "Contract.term.offer.securityLabelNumber",
            "short": "Offer restriction numbers",
            "definition": "Security labels that protects the offer.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Contract.term.asset",
            "path": "Contract.term.asset",
            "short": "Contract Term Asset List",
            "definition": "Contract Term Asset List.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.asset.scope",
            "path": "Contract.term.asset.scope",
            "short": "Range of asset",
            "definition": "Differentiates the kind of the asset .",
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
                  "valueString": "ContractAssetScope"
                }
              ],
              "strength": "example",
              "description": "Codes for scoping an asset.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-assetscope"
            }
          },
          {
            "id": "Contract.term.asset.type",
            "path": "Contract.term.asset.type",
            "short": "Asset category",
            "definition": "Target entity type about which the term may be concerned.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractAssetType"
                }
              ],
              "strength": "example",
              "description": "Condes for the type of an asset.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-assettype"
            }
          },
          {
            "id": "Contract.term.asset.typeReference",
            "path": "Contract.term.asset.typeReference",
            "short": "Associated entities",
            "definition": "Associated entities.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.subtype",
            "path": "Contract.term.asset.subtype",
            "short": "Asset sub-category",
            "definition": "May be a subtype or part of an offered asset.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractAssetSubtype"
                }
              ],
              "strength": "example",
              "description": "Condes for the sub-type of an asset.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-assetsubtype"
            }
          },
          {
            "id": "Contract.term.asset.relationship",
            "path": "Contract.term.asset.relationship",
            "short": "Kinship of the asset",
            "definition": "Specifies the applicability of the term to an asset resource instance, and instances it refers to orinstances that refer to it, and/or are owned by the offeree.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConsentContentClass"
                }
              ],
              "strength": "extensible",
              "description": "The class (type) of information a consent rule covers.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-content-class"
            }
          },
          {
            "id": "Contract.term.asset.context",
            "path": "Contract.term.asset.context",
            "short": "Circumstance of the asset",
            "definition": "Circumstance of the asset.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.asset.context.reference",
            "path": "Contract.term.asset.context.reference",
            "short": "Creator,custodian or owner",
            "definition": "Asset context reference may include the creator, custodian, or owning Person or Organization (e.g., bank, repository),  location held, e.g., building,  jurisdiction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.context.code",
            "path": "Contract.term.asset.context.code",
            "short": "Codeable asset context",
            "definition": "Coded representation of the context generally or of the Referenced entity, such as the asset holder type or location.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractAssetContext"
                }
              ],
              "strength": "example",
              "description": "Codes for the context of the asset.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-assetcontext"
            }
          },
          {
            "id": "Contract.term.asset.context.text",
            "path": "Contract.term.asset.context.text",
            "short": "Context description",
            "definition": "Context description.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.condition",
            "path": "Contract.term.asset.condition",
            "short": "Quality desctiption of asset",
            "definition": "Description of the quality and completeness of the asset that imay be a factor in its valuation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.periodType",
            "path": "Contract.term.asset.periodType",
            "short": "Asset availability types",
            "definition": "Type of Asset availability for use or ownership.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AssetAvailabilityType"
                }
              ],
              "strength": "example",
              "description": "Codes for asset availability.",
              "valueSet": "http://hl7.org/fhir/ValueSet/asset-availability"
            }
          },
          {
            "id": "Contract.term.asset.period",
            "path": "Contract.term.asset.period",
            "short": "Time period of the asset",
            "definition": "Asset relevant contractual time period.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Contract.term.asset.usePeriod",
            "path": "Contract.term.asset.usePeriod",
            "short": "Time period",
            "definition": "Time period of asset use.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Contract.term.asset.text",
            "path": "Contract.term.asset.text",
            "short": "Asset clause or question text",
            "definition": "Clause or question text (Prose Object) concerning the asset in a linked form, such as a QuestionnaireResponse used in the formation of the contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.linkId",
            "path": "Contract.term.asset.linkId",
            "short": "Pointer to asset text",
            "definition": "Id [identifier??] of the clause or question text about the asset in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.answer",
            "path": "Contract.term.asset.answer",
            "short": "Response to assets",
            "definition": "Response to assets.",
            "min": 0,
            "max": "*",
            "contentReference": "#Contract.term.offer.answer"
          },
          {
            "id": "Contract.term.asset.securityLabelNumber",
            "path": "Contract.term.asset.securityLabelNumber",
            "short": "Asset restriction numbers",
            "definition": "Security labels that protects the asset.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem",
            "path": "Contract.term.asset.valuedItem",
            "short": "Contract Valued Item List",
            "definition": "Contract Valued Item List.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.entity[x]",
            "path": "Contract.term.asset.valuedItem.entity[x]",
            "short": "Contract Valued Item Type",
            "definition": "Specific type of Contract Valued Item that may be priced.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.identifier",
            "path": "Contract.term.asset.valuedItem.identifier",
            "short": "Contract Valued Item Number",
            "definition": "Identifies a Contract Valued Item instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.effectiveTime",
            "path": "Contract.term.asset.valuedItem.effectiveTime",
            "short": "Contract Valued Item Effective Tiem",
            "definition": "Indicates the time during which this Contract ValuedItem information is effective.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.quantity",
            "path": "Contract.term.asset.valuedItem.quantity",
            "short": "Count of Contract Valued Items",
            "definition": "Specifies the units by which the Contract Valued Item is measured or counted, and quantifies the countable or measurable Contract Valued Item instances.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.unitPrice",
            "path": "Contract.term.asset.valuedItem.unitPrice",
            "short": "Contract Valued Item fee, charge, or cost",
            "definition": "A Contract Valued Item unit valuation measure.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.factor",
            "path": "Contract.term.asset.valuedItem.factor",
            "short": "Contract Valued Item Price Scaling Factor",
            "definition": "A real number that represents a multiplier used in determining the overall value of the Contract Valued Item delivered. The concept of a Factor allows for a discount or surcharge multiplier to be applied to a monetary amount.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.points",
            "path": "Contract.term.asset.valuedItem.points",
            "short": "Contract Valued Item Difficulty Scaling Factor",
            "definition": "An amount that expresses the weighting (based on difficulty, cost and/or resource intensiveness) associated with the Contract Valued Item delivered. The concept of Points allows for assignment of point values for a Contract Valued Item, such that a monetary amount can be assigned to each point.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.net",
            "path": "Contract.term.asset.valuedItem.net",
            "short": "Total Contract Valued Item Value",
            "definition": "Expresses the product of the Contract Valued Item unitQuantity and the unitPriceAmt. For example, the formula: unit Quantity * unit Price (Cost per Point) * factor Number  * points = net Amount. Quantity, factor and points are assumed to be 1 if not supplied.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.payment",
            "path": "Contract.term.asset.valuedItem.payment",
            "short": "Terms of valuation",
            "definition": "Terms of valuation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.paymentDate",
            "path": "Contract.term.asset.valuedItem.paymentDate",
            "short": "When payment is due",
            "definition": "When payment is due.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.responsible",
            "path": "Contract.term.asset.valuedItem.responsible",
            "short": "Who will make payment",
            "definition": "Who will make payment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.recipient",
            "path": "Contract.term.asset.valuedItem.recipient",
            "short": "Who will receive payment",
            "definition": "Who will receive payment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.linkId",
            "path": "Contract.term.asset.valuedItem.linkId",
            "short": "Pointer to specific item",
            "definition": "Id  of the clause or question text related to the context of this valuedItem in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.asset.valuedItem.securityLabelNumber",
            "path": "Contract.term.asset.valuedItem.securityLabelNumber",
            "short": "Security Labels that define affected terms",
            "definition": "A set of security labels that define which terms are controlled by this condition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Contract.term.action",
            "path": "Contract.term.action",
            "short": "Entity being ascribed responsibility",
            "definition": "An actor taking a role in an activity for which it can be assigned some degree of responsibility for the activity taking place.",
            "comment": "Several agents may be associated (i.e. has some responsibility for an activity) with an activity and vice-versa.\rFor example, in cases of actions initiated by one user for other users, or in events that involve more than one user, hardware device, software, or system process. However, only one user may be the initiator/requestor for the event.",
            "requirements": "An agent can be a person, an organization, software, device, or other entities that may be ascribed responsibility.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.action.doNotPerform",
            "path": "Contract.term.action.doNotPerform",
            "short": "True if the term prohibits the  action",
            "definition": "True if the term prohibits the  action.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If true this element negates the specified action. For Example, instead of a dictate to perform an action, it is a dictate not to perform the action."
          },
          {
            "id": "Contract.term.action.type",
            "path": "Contract.term.action.type",
            "short": "Type or form of the action",
            "definition": "Activity or service obligation to be done or not done, performed or not performed, effectuated or not by this Contract term.",
            "min": 1,
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
                  "valueString": "ContractAction"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the contract action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-action"
            }
          },
          {
            "id": "Contract.term.action.subject",
            "path": "Contract.term.action.subject",
            "short": "Entity of the action",
            "definition": "Entity of the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.term.action.subject.reference",
            "path": "Contract.term.action.subject.reference",
            "short": "Entity of the action",
            "definition": "The entity the action is performed or not performed on or for.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.action.subject.role",
            "path": "Contract.term.action.subject.role",
            "short": "Role type of the agent",
            "definition": "Role type of agent assigned roles in this Contract.",
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
                  "valueString": "ContractActorRole"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the contract actor role.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-actorrole"
            }
          },
          {
            "id": "Contract.term.action.intent",
            "path": "Contract.term.action.intent",
            "short": "Purpose for the Contract Term Action",
            "definition": "Reason or purpose for the action stipulated by this Contract Provision.",
            "min": 1,
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
                  "valueString": "ContractActionReason"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the contract action reason.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "Contract.term.action.linkId",
            "path": "Contract.term.action.linkId",
            "short": "Pointer to specific item",
            "definition": "Id [identifier??] of the clause or question text related to this action in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.status",
            "path": "Contract.term.action.status",
            "short": "State of the action",
            "definition": "Current state of the term action.",
            "min": 1,
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
                  "valueString": "ContractActionStatus"
                }
              ],
              "strength": "example",
              "description": "Codes for the status of an term action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-actionstatus"
            }
          },
          {
            "id": "Contract.term.action.context",
            "path": "Contract.term.action.context",
            "short": "Episode associated with action",
            "definition": "Encounter or Episode with primary association to specified term activity.",
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
            ]
          },
          {
            "id": "Contract.term.action.contextLinkId",
            "path": "Contract.term.action.contextLinkId",
            "short": "Pointer to specific item",
            "definition": "Id [identifier??] of the clause or question text related to the requester of this action in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.occurrence[x]",
            "path": "Contract.term.action.occurrence[x]",
            "short": "When action happens",
            "definition": "When action happens.",
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
            ]
          },
          {
            "id": "Contract.term.action.requester",
            "path": "Contract.term.action.requester",
            "short": "Who asked for action",
            "definition": "Who or what initiated the action and has responsibility for its activation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.action.requesterLinkId",
            "path": "Contract.term.action.requesterLinkId",
            "short": "Pointer to specific item",
            "definition": "Id [identifier??] of the clause or question text related to the requester of this action in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.performerType",
            "path": "Contract.term.action.performerType",
            "short": "Kind of service performer",
            "definition": "The type of individual that is desired or required to perform or not perform the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractActionPerformerType"
                }
              ],
              "strength": "example",
              "description": "Codes for the types of action perfomer.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provenance-agent-type"
            }
          },
          {
            "id": "Contract.term.action.performerRole",
            "path": "Contract.term.action.performerRole",
            "short": "Competency of the performer",
            "definition": "The type of role or competency of an individual desired or required to perform or not perform the action.",
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
                  "valueString": "ContractActionPerformerRole"
                }
              ],
              "strength": "example",
              "description": "Codes for the role of the action performer.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provenance-agent-role"
            }
          },
          {
            "id": "Contract.term.action.performer",
            "path": "Contract.term.action.performer",
            "short": "Actor that wil execute (or not) the action",
            "definition": "Indicates who or what is being asked to perform (or not perform) the ction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.action.performerLinkId",
            "path": "Contract.term.action.performerLinkId",
            "short": "Pointer to specific item",
            "definition": "Id [identifier??] of the clause or question text related to the reason type or reference of this  action in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.reasonCode",
            "path": "Contract.term.action.reasonCode",
            "short": "Why is action (not) needed?",
            "definition": "Rationale for the action to be performed or not performed. Describes why the action is permitted or prohibited.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractActionReason"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the contract action reason.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "Contract.term.action.reasonReference",
            "path": "Contract.term.action.reasonReference",
            "short": "Why is action (not) needed?",
            "definition": "Indicates another resource whose existence justifies permitting or not permitting this action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                ]
              }
            ]
          },
          {
            "id": "Contract.term.action.reason",
            "path": "Contract.term.action.reason",
            "short": "Why action is to be performed",
            "definition": "Describes why the action is to be performed or not performed in textual form.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.reasonLinkId",
            "path": "Contract.term.action.reasonLinkId",
            "short": "Pointer to specific item",
            "definition": "Id [identifier??] of the clause or question text related to the reason type or reference of this  action in the referenced form or QuestionnaireResponse.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Contract.term.action.note",
            "path": "Contract.term.action.note",
            "short": "Comments about the action",
            "definition": "Comments made about the term action made by the requester, performer, subject or other participants.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Contract.term.action.securityLabelNumber",
            "path": "Contract.term.action.securityLabelNumber",
            "short": "Action restriction numbers",
            "definition": "Security labels that protects the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Contract.term.group",
            "path": "Contract.term.group",
            "short": "Nested Contract Term Group",
            "definition": "Nested group of Contract Provisions.",
            "min": 0,
            "max": "*",
            "contentReference": "#Contract.term"
          },
          {
            "id": "Contract.supportingInfo",
            "path": "Contract.supportingInfo",
            "short": "Extra Information",
            "definition": "Information that may be needed by/relevant to the performer in their execution of this term action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "Contract.relevantHistory",
            "path": "Contract.relevantHistory",
            "short": "Key event in Contract History",
            "definition": "Links to Provenance records for past versions of this Contract definition, derivative, or instance, which identify key state transitions or updates that are likely to be relevant to a user looking at the current version of the Contract.  The Provence.entity indicates the target that was changed in the update. http://build.fhir.org/provenance-definitions.html#Provenance.entity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Provenance"
                ]
              }
            ]
          },
          {
            "id": "Contract.signer",
            "path": "Contract.signer",
            "short": "Contract Signatory",
            "definition": "Parties with legal standing in the Contract, including the principal parties, the grantor(s) and grantee(s), which are any person or organization bound by the contract, and any ancillary parties, which facilitate the execution of the contract such as a notary or witness.",
            "comment": "Signers who are principal parties to the contract are bound by the Contract.activity related to the Contract.topic, and the Contract.term(s), which either extend or restrict the overall action on the topic by, for example, stipulating specific policies or obligations constraining actions, action reason, or agents with respect to some or all of the topic.\rFor example, specifying how policies or obligations shall constrain actions and action reasons permitted or denied on all or a subset of the Contract.topic (e.g., all or a portion of property being transferred by the contract), agents (e.g., who can resell, assign interests, or alter the property being transferred by the contract), actions, and action reasons; or with respect to Contract.terms, stipulating, extending, or limiting the Contract.period of applicability or valuation of items under consideration.",
            "requirements": "The Contract.signer applies a signature to the Contract.binding referenced resource, which is the documentation that is the legal \"source of truth\". The Contract.signer may delegate, such as a legally recognized personal representative, or have a delegate assigned e.g., by a court of law, to actually sign the Contract, such as a trustee in the case of incompetence.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.signer.type",
            "path": "Contract.signer.type",
            "short": "Contract Signatory Role",
            "definition": "Role of this Contract signer, e.g. notary, grantee.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContractSignerType"
                }
              ],
              "strength": "preferred",
              "description": "List of parties who may be signing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contract-signer-type"
            }
          },
          {
            "id": "Contract.signer.party",
            "path": "Contract.signer.party",
            "short": "Contract Signatory Party",
            "definition": "Party which is a signator to this Contract.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "Contract.signer.signature",
            "path": "Contract.signer.signature",
            "short": "Contract Documentation Signature",
            "definition": "Legally binding Contract DSIG signature contents in Base64.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Signature"
              }
            ]
          },
          {
            "id": "Contract.friendly",
            "path": "Contract.friendly",
            "short": "Contract Friendly Language",
            "definition": "The \"patient friendly language\" versionof the Contract in whole or in parts. \"Patient friendly language\" means the representation of the Contract and Contract Provisions in a manner that is readily accessible and understandable by a layperson in accordance with best practices for communication styles that ensure that those agreeing to or signing the Contract understand the roles, actions, obligations, responsibilities, and implication of the agreement.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.friendly.content[x]",
            "path": "Contract.friendly.content[x]",
            "short": "Easily comprehended representation of this Contract",
            "definition": "Human readable rendering of this Contract in a format and representation intended to enhance comprehension and ensure understandability.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Composition",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                ]
              }
            ]
          },
          {
            "id": "Contract.legal",
            "path": "Contract.legal",
            "short": "Contract Legal Language",
            "definition": "List of Legal expressions or representations of this Contract.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.legal.content[x]",
            "path": "Contract.legal.content[x]",
            "short": "Contract Legal Text",
            "definition": "Contract legal text in human renderable form.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Composition",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                ]
              }
            ]
          },
          {
            "id": "Contract.rule",
            "path": "Contract.rule",
            "short": "Computable Contract Language",
            "definition": "List of Computable Policy Rule Language Representations of this Contract.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Contract.rule.content[x]",
            "path": "Contract.rule.content[x]",
            "short": "Computable Contract Rules",
            "definition": "Computable Contract conveyed using a policy rule language (e.g. XACML, DKAL, SecPal).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ]
          },
          {
            "id": "Contract.legallyBinding[x]",
            "path": "Contract.legallyBinding[x]",
            "short": "Binding Contract",
            "definition": "Legally binding Contract: This is the signed and legally recognized representation of the Contract, which is considered the \"source of truth\" and which would be the basis for legal action related to enforcement of this Contract.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Composition",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/Contract"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'Contract'
    /// </summary>
    // 0. Contract
    public class Contract : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Contract_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 25. Contract.contentDefinition
            public class Type_ContentDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_ContentDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 26. Contract.contentDefinition.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 27. Contract.contentDefinition.subType
                    public ElementDefinitionInfo SubType;                                                                                   // MakerGen.cs:216
                    // 28. Contract.contentDefinition.publisher
                    public ElementDefinitionInfo Publisher;                                                                                 // MakerGen.cs:216
                    // 29. Contract.contentDefinition.publicationDate
                    public ElementDefinitionInfo PublicationDate;                                                                           // MakerGen.cs:216
                    // 30. Contract.contentDefinition.publicationStatus
                    public ElementDefinitionInfo PublicationStatus;                                                                         // MakerGen.cs:216
                    // 31. Contract.contentDefinition.copyright
                    public ElementDefinitionInfo Copyright;                                                                                 // MakerGen.cs:216
                    public Type_ContentDefinition_Elements()                                                                                // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. Contract.contentDefinition.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Contract.contentDefinition.type",                                                                    // MakerGen.cs:236
                                Id = "Contract.contentDefinition.type",                                                                     // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. Contract.contentDefinition.subType
                            this.SubType = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SubType",                                                                                           // MakerGen.cs:235
                                Path= "Contract.contentDefinition.subType",                                                                 // MakerGen.cs:236
                                Id = "Contract.contentDefinition.subType",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. Contract.contentDefinition.publisher
                            this.Publisher = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Publisher",                                                                                         // MakerGen.cs:235
                                Path= "Contract.contentDefinition.publisher",                                                               // MakerGen.cs:236
                                Id = "Contract.contentDefinition.publisher",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. Contract.contentDefinition.publicationDate
                            this.PublicationDate = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PublicationDate",                                                                                   // MakerGen.cs:235
                                Path= "Contract.contentDefinition.publicationDate",                                                         // MakerGen.cs:236
                                Id = "Contract.contentDefinition.publicationDate",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. Contract.contentDefinition.publicationStatus
                            this.PublicationStatus = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PublicationStatus",                                                                                 // MakerGen.cs:235
                                Path= "Contract.contentDefinition.publicationStatus",                                                       // MakerGen.cs:236
                                Id = "Contract.contentDefinition.publicationStatus",                                                        // MakerGen.cs:237
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
                            // 31. Contract.contentDefinition.copyright
                            this.Copyright = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Copyright",                                                                                         // MakerGen.cs:235
                                Path= "Contract.contentDefinition.copyright",                                                               // MakerGen.cs:236
                                Id = "Contract.contentDefinition.copyright",                                                                // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        SubType.Write(sDef);                                                                                                // MakerGen.cs:220
                        Publisher.Write(sDef);                                                                                              // MakerGen.cs:220
                        PublicationDate.Write(sDef);                                                                                        // MakerGen.cs:220
                        PublicationStatus.Write(sDef);                                                                                      // MakerGen.cs:220
                        Copyright.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_ContentDefinition_Elements Elements { get; }                                                                    // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_ContentDefinition()                                                                                             // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_ContentDefinition_Elements();                                                                  // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 32. Contract.term
            public class Type_Term : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Term_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 40. Contract.term.securityLabel
                    public class Type_SecurityLabel : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_SecurityLabel_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 41. Contract.term.securityLabel.number
                            public ElementDefinitionInfo Number;                                                                            // MakerGen.cs:216
                            // 42. Contract.term.securityLabel.classification
                            public ElementDefinitionInfo Classification;                                                                    // MakerGen.cs:216
                            // 43. Contract.term.securityLabel.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:216
                            // 44. Contract.term.securityLabel.control
                            public ElementDefinitionInfo Control;                                                                           // MakerGen.cs:216
                            public Type_SecurityLabel_Elements()                                                                            // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 41. Contract.term.securityLabel.number
                                    this.Number = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Number",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.securityLabel.number",                                                         // MakerGen.cs:236
                                        Id = "Contract.term.securityLabel.number",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 42. Contract.term.securityLabel.classification
                                    this.Classification = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Classification",                                                                            // MakerGen.cs:235
                                        Path= "Contract.term.securityLabel.classification",                                                 // MakerGen.cs:236
                                        Id = "Contract.term.securityLabel.classification",                                                  // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 43. Contract.term.securityLabel.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Category",                                                                                  // MakerGen.cs:235
                                        Path= "Contract.term.securityLabel.category",                                                       // MakerGen.cs:236
                                        Id = "Contract.term.securityLabel.category",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 44. Contract.term.securityLabel.control
                                    this.Control = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Control",                                                                                   // MakerGen.cs:235
                                        Path= "Contract.term.securityLabel.control",                                                        // MakerGen.cs:236
                                        Id = "Contract.term.securityLabel.control",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Number.Write(sDef);                                                                                         // MakerGen.cs:220
                                Classification.Write(sDef);                                                                                 // MakerGen.cs:220
                                Category.Write(sDef);                                                                                       // MakerGen.cs:220
                                Control.Write(sDef);                                                                                        // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_SecurityLabel_Elements Elements { get; }                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_SecurityLabel()                                                                                         // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_SecurityLabel_Elements();                                                              // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 45. Contract.term.offer
                    public class Type_Offer : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Offer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 47. Contract.term.offer.party
                            public class Type_Party : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Party_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 48. Contract.term.offer.party.reference
                                    public ElementDefinitionInfo Reference;                                                                 // MakerGen.cs:216
                                    // 49. Contract.term.offer.party.role
                                    public ElementDefinitionInfo Role;                                                                      // MakerGen.cs:216
                                    public Type_Party_Elements()                                                                            // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 48. Contract.term.offer.party.reference
                                            this.Reference = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Reference",                                                                         // MakerGen.cs:235
                                                Path= "Contract.term.offer.party.reference",                                                // MakerGen.cs:236
                                                Id = "Contract.term.offer.party.reference",                                                 // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Patient",                              // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                        // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                     // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Device",                               // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Group",                                // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Organization"                          // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 49. Contract.term.offer.party.role
                                            this.Role = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Role",                                                                              // MakerGen.cs:235
                                                Path= "Contract.term.offer.party.role",                                                     // MakerGen.cs:236
                                                Id = "Contract.term.offer.party.role",                                                      // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Reference.Write(sDef);                                                                              // MakerGen.cs:220
                                        Role.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Party_Elements Elements { get; }                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Party()                                                                                         // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Party_Elements();                                                              // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 54. Contract.term.offer.answer
                            public class Type_Answer : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Answer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 55. Contract.term.offer.answer.value[x]
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:216
                                    public Type_Answer_Elements()                                                                           // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 55. Contract.term.offer.answer.value[x]
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Value",                                                                             // MakerGen.cs:235
                                                Path= "Contract.term.offer.answer.value[x]",                                                // MakerGen.cs:236
                                                Id = "Contract.term.offer.answer.value[x]",                                                 // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Integer                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Date                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.DateTime                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Time                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Uri                                                 // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Complex.Attachment                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Coding                                                // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    },                                                                                      // MakerGen.cs:319
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Resource"                              // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Answer_Elements Elements { get; }                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Answer()                                                                                        // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Answer_Elements();                                                             // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 46. Contract.term.offer.identifier
                            public ElementDefinitionInfo Identifier;                                                                        // MakerGen.cs:216
                            // 47. Contract.term.offer.party
                            public ElementDefinitionInfo Party;                                                                             // MakerGen.cs:216
                            // 50. Contract.term.offer.topic
                            public ElementDefinitionInfo Topic;                                                                             // MakerGen.cs:216
                            // 51. Contract.term.offer.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 52. Contract.term.offer.decision
                            public ElementDefinitionInfo Decision;                                                                          // MakerGen.cs:216
                            // 53. Contract.term.offer.decisionMode
                            public ElementDefinitionInfo DecisionMode;                                                                      // MakerGen.cs:216
                            // 54. Contract.term.offer.answer
                            public ElementDefinitionInfo Answer;                                                                            // MakerGen.cs:216
                            // 56. Contract.term.offer.text
                            public ElementDefinitionInfo Text;                                                                              // MakerGen.cs:216
                            // 57. Contract.term.offer.linkId
                            public ElementDefinitionInfo LinkId;                                                                            // MakerGen.cs:216
                            // 58. Contract.term.offer.securityLabelNumber
                            public ElementDefinitionInfo SecurityLabelNumber;                                                               // MakerGen.cs:216
                            public Type_Offer_Elements()                                                                                    // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 46. Contract.term.offer.identifier
                                    this.Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Identifier",                                                                                // MakerGen.cs:235
                                        Path= "Contract.term.offer.identifier",                                                             // MakerGen.cs:236
                                        Id = "Contract.term.offer.identifier",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Identifier                                                    // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 47. Contract.term.offer.party
                                    this.Party = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Party",                                                                                     // MakerGen.cs:235
                                        Path= "Contract.term.offer.party",                                                                  // MakerGen.cs:236
                                        Id = "Contract.term.offer.party",                                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Party                                                                                  // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 50. Contract.term.offer.topic
                                    this.Topic = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Topic",                                                                                     // MakerGen.cs:235
                                        Path= "Contract.term.offer.topic",                                                                  // MakerGen.cs:236
                                        Id = "Contract.term.offer.topic",                                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 51. Contract.term.offer.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.offer.type",                                                                   // MakerGen.cs:236
                                        Id = "Contract.term.offer.type",                                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 52. Contract.term.offer.decision
                                    this.Decision = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Decision",                                                                                  // MakerGen.cs:235
                                        Path= "Contract.term.offer.decision",                                                               // MakerGen.cs:236
                                        Id = "Contract.term.offer.decision",                                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 53. Contract.term.offer.decisionMode
                                    this.DecisionMode = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "DecisionMode",                                                                              // MakerGen.cs:235
                                        Path= "Contract.term.offer.decisionMode",                                                           // MakerGen.cs:236
                                        Id = "Contract.term.offer.decisionMode",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 54. Contract.term.offer.answer
                                    this.Answer = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Answer",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.offer.answer",                                                                 // MakerGen.cs:236
                                        Id = "Contract.term.offer.answer",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Answer                                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 56. Contract.term.offer.text
                                    this.Text = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Text",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.offer.text",                                                                   // MakerGen.cs:236
                                        Id = "Contract.term.offer.text",                                                                    // MakerGen.cs:237
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
                                {                                                                                                           // MakerGen.cs:231
                                    // 57. Contract.term.offer.linkId
                                    this.LinkId = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "LinkId",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.offer.linkId",                                                                 // MakerGen.cs:236
                                        Id = "Contract.term.offer.linkId",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 58. Contract.term.offer.securityLabelNumber
                                    this.SecurityLabelNumber = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "SecurityLabelNumber",                                                                       // MakerGen.cs:235
                                        Path= "Contract.term.offer.securityLabelNumber",                                                    // MakerGen.cs:236
                                        Id = "Contract.term.offer.securityLabelNumber",                                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Identifier.Write(sDef);                                                                                     // MakerGen.cs:220
                                Party.Write(sDef);                                                                                          // MakerGen.cs:220
                                Topic.Write(sDef);                                                                                          // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Decision.Write(sDef);                                                                                       // MakerGen.cs:220
                                DecisionMode.Write(sDef);                                                                                   // MakerGen.cs:220
                                Answer.Write(sDef);                                                                                         // MakerGen.cs:220
                                Text.Write(sDef);                                                                                           // MakerGen.cs:220
                                LinkId.Write(sDef);                                                                                         // MakerGen.cs:220
                                SecurityLabelNumber.Write(sDef);                                                                            // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Offer_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Offer()                                                                                                 // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Offer_Elements();                                                                      // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 59. Contract.term.asset
                    public class Type_Asset : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Asset_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 65. Contract.term.asset.context
                            public class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Context_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 66. Contract.term.asset.context.reference
                                    public ElementDefinitionInfo Reference;                                                                 // MakerGen.cs:216
                                    // 67. Contract.term.asset.context.code
                                    public ElementDefinitionInfo Code;                                                                      // MakerGen.cs:216
                                    // 68. Contract.term.asset.context.text
                                    public ElementDefinitionInfo Text;                                                                      // MakerGen.cs:216
                                    public Type_Context_Elements()                                                                          // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 66. Contract.term.asset.context.reference
                                            this.Reference = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Reference",                                                                         // MakerGen.cs:235
                                                Path= "Contract.term.asset.context.reference",                                              // MakerGen.cs:236
                                                Id = "Contract.term.asset.context.reference",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Resource"                              // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 67. Contract.term.asset.context.code
                                            this.Code = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Code",                                                                              // MakerGen.cs:235
                                                Path= "Contract.term.asset.context.code",                                                   // MakerGen.cs:236
                                                Id = "Contract.term.asset.context.code",                                                    // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 68. Contract.term.asset.context.text
                                            this.Text = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Text",                                                                              // MakerGen.cs:235
                                                Path= "Contract.term.asset.context.text",                                                   // MakerGen.cs:236
                                                Id = "Contract.term.asset.context.text",                                                    // MakerGen.cs:237
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
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Reference.Write(sDef);                                                                              // MakerGen.cs:220
                                        Code.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Text.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Context_Elements Elements { get; }                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Context()                                                                                       // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Context_Elements();                                                            // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 77. Contract.term.asset.valuedItem
                            public class Type_ValuedItem : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_ValuedItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                         // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 78. Contract.term.asset.valuedItem.entity[x]
                                    public ElementDefinitionInfo Entity;                                                                    // MakerGen.cs:216
                                    // 79. Contract.term.asset.valuedItem.identifier
                                    public ElementDefinitionInfo Identifier;                                                                // MakerGen.cs:216
                                    // 80. Contract.term.asset.valuedItem.effectiveTime
                                    public ElementDefinitionInfo EffectiveTime;                                                             // MakerGen.cs:216
                                    // 81. Contract.term.asset.valuedItem.quantity
                                    public ElementDefinitionInfo Quantity;                                                                  // MakerGen.cs:216
                                    // 82. Contract.term.asset.valuedItem.unitPrice
                                    public ElementDefinitionInfo UnitPrice;                                                                 // MakerGen.cs:216
                                    // 83. Contract.term.asset.valuedItem.factor
                                    public ElementDefinitionInfo Factor;                                                                    // MakerGen.cs:216
                                    // 84. Contract.term.asset.valuedItem.points
                                    public ElementDefinitionInfo Points;                                                                    // MakerGen.cs:216
                                    // 85. Contract.term.asset.valuedItem.net
                                    public ElementDefinitionInfo Net;                                                                       // MakerGen.cs:216
                                    // 86. Contract.term.asset.valuedItem.payment
                                    public ElementDefinitionInfo Payment;                                                                   // MakerGen.cs:216
                                    // 87. Contract.term.asset.valuedItem.paymentDate
                                    public ElementDefinitionInfo PaymentDate;                                                               // MakerGen.cs:216
                                    // 88. Contract.term.asset.valuedItem.responsible
                                    public ElementDefinitionInfo Responsible;                                                               // MakerGen.cs:216
                                    // 89. Contract.term.asset.valuedItem.recipient
                                    public ElementDefinitionInfo Recipient;                                                                 // MakerGen.cs:216
                                    // 90. Contract.term.asset.valuedItem.linkId
                                    public ElementDefinitionInfo LinkId;                                                                    // MakerGen.cs:216
                                    // 91. Contract.term.asset.valuedItem.securityLabelNumber
                                    public ElementDefinitionInfo SecurityLabelNumber;                                                       // MakerGen.cs:216
                                    public Type_ValuedItem_Elements()                                                                       // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 78. Contract.term.asset.valuedItem.entity[x]
                                            this.Entity = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Entity",                                                                            // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.entity[x]",                                           // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.entity[x]",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    },                                                                                      // MakerGen.cs:319
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Resource"                              // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 79. Contract.term.asset.valuedItem.identifier
                                            this.Identifier = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Identifier",                                                                        // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.identifier",                                          // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.identifier",                                           // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Identifier                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 80. Contract.term.asset.valuedItem.effectiveTime
                                            this.EffectiveTime = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "EffectiveTime",                                                                     // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.effectiveTime",                                       // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.effectiveTime",                                        // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.DateTime                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 81. Contract.term.asset.valuedItem.quantity
                                            this.Quantity = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Quantity",                                                                          // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.quantity",                                            // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.quantity",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 82. Contract.term.asset.valuedItem.unitPrice
                                            this.UnitPrice = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "UnitPrice",                                                                         // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.unitPrice",                                           // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.unitPrice",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 83. Contract.term.asset.valuedItem.factor
                                            this.Factor = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Factor",                                                                            // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.factor",                                              // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.factor",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 84. Contract.term.asset.valuedItem.points
                                            this.Points = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Points",                                                                            // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.points",                                              // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.points",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 85. Contract.term.asset.valuedItem.net
                                            this.Net = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Net",                                                                               // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.net",                                                 // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.net",                                                  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 86. Contract.term.asset.valuedItem.payment
                                            this.Payment = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Payment",                                                                           // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.payment",                                             // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.payment",                                              // MakerGen.cs:237
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
                                            // 87. Contract.term.asset.valuedItem.paymentDate
                                            this.PaymentDate = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "PaymentDate",                                                                       // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.paymentDate",                                         // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.paymentDate",                                          // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.DateTime                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 88. Contract.term.asset.valuedItem.responsible
                                            this.Responsible = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Responsible",                                                                       // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.responsible",                                         // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.responsible",                                          // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Organization",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Patient",                              // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                     // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                         // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 89. Contract.term.asset.valuedItem.recipient
                                            this.Recipient = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Recipient",                                                                         // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.recipient",                                           // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.recipient",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Organization",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Patient",                              // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                     // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                         // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 90. Contract.term.asset.valuedItem.linkId
                                            this.LinkId = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "LinkId",                                                                            // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.linkId",                                              // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.linkId",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 91. Contract.term.asset.valuedItem.securityLabelNumber
                                            this.SecurityLabelNumber = new ElementDefinitionInfo                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "SecurityLabelNumber",                                                               // MakerGen.cs:235
                                                Path= "Contract.term.asset.valuedItem.securityLabelNumber",                                 // MakerGen.cs:236
                                                Id = "Contract.term.asset.valuedItem.securityLabelNumber",                                  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                         // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Entity.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Identifier.Write(sDef);                                                                             // MakerGen.cs:220
                                        EffectiveTime.Write(sDef);                                                                          // MakerGen.cs:220
                                        Quantity.Write(sDef);                                                                               // MakerGen.cs:220
                                        UnitPrice.Write(sDef);                                                                              // MakerGen.cs:220
                                        Factor.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Points.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Net.Write(sDef);                                                                                    // MakerGen.cs:220
                                        Payment.Write(sDef);                                                                                // MakerGen.cs:220
                                        PaymentDate.Write(sDef);                                                                            // MakerGen.cs:220
                                        Responsible.Write(sDef);                                                                            // MakerGen.cs:220
                                        Recipient.Write(sDef);                                                                              // MakerGen.cs:220
                                        LinkId.Write(sDef);                                                                                 // MakerGen.cs:220
                                        SecurityLabelNumber.Write(sDef);                                                                    // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_ValuedItem_Elements Elements { get; }                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_ValuedItem()                                                                                    // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_ValuedItem_Elements();                                                         // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 60. Contract.term.asset.scope
                            public ElementDefinitionInfo Scope;                                                                             // MakerGen.cs:216
                            // 61. Contract.term.asset.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 62. Contract.term.asset.typeReference
                            public ElementDefinitionInfo TypeReference;                                                                     // MakerGen.cs:216
                            // 63. Contract.term.asset.subtype
                            public ElementDefinitionInfo Subtype;                                                                           // MakerGen.cs:216
                            // 64. Contract.term.asset.relationship
                            public ElementDefinitionInfo Relationship;                                                                      // MakerGen.cs:216
                            // 65. Contract.term.asset.context
                            public ElementDefinitionInfo Context;                                                                           // MakerGen.cs:216
                            // 69. Contract.term.asset.condition
                            public ElementDefinitionInfo Condition;                                                                         // MakerGen.cs:216
                            // 70. Contract.term.asset.periodType
                            public ElementDefinitionInfo PeriodType;                                                                        // MakerGen.cs:216
                            // 71. Contract.term.asset.period
                            public ElementDefinitionInfo Period;                                                                            // MakerGen.cs:216
                            // 72. Contract.term.asset.usePeriod
                            public ElementDefinitionInfo UsePeriod;                                                                         // MakerGen.cs:216
                            // 73. Contract.term.asset.text
                            public ElementDefinitionInfo Text;                                                                              // MakerGen.cs:216
                            // 74. Contract.term.asset.linkId
                            public ElementDefinitionInfo LinkId;                                                                            // MakerGen.cs:216
                            // 75. Contract.term.asset.answer
                            public ElementDefinitionInfo Answer;                                                                            // MakerGen.cs:216
                            // 76. Contract.term.asset.securityLabelNumber
                            public ElementDefinitionInfo SecurityLabelNumber;                                                               // MakerGen.cs:216
                            // 77. Contract.term.asset.valuedItem
                            public ElementDefinitionInfo ValuedItem;                                                                        // MakerGen.cs:216
                            public Type_Asset_Elements()                                                                                    // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 60. Contract.term.asset.scope
                                    this.Scope = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Scope",                                                                                     // MakerGen.cs:235
                                        Path= "Contract.term.asset.scope",                                                                  // MakerGen.cs:236
                                        Id = "Contract.term.asset.scope",                                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 61. Contract.term.asset.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.asset.type",                                                                   // MakerGen.cs:236
                                        Id = "Contract.term.asset.type",                                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 62. Contract.term.asset.typeReference
                                    this.TypeReference = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "TypeReference",                                                                             // MakerGen.cs:235
                                        Path= "Contract.term.asset.typeReference",                                                          // MakerGen.cs:236
                                        Id = "Contract.term.asset.typeReference",                                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 63. Contract.term.asset.subtype
                                    this.Subtype = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Subtype",                                                                                   // MakerGen.cs:235
                                        Path= "Contract.term.asset.subtype",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.asset.subtype",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 64. Contract.term.asset.relationship
                                    this.Relationship = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Relationship",                                                                              // MakerGen.cs:235
                                        Path= "Contract.term.asset.relationship",                                                           // MakerGen.cs:236
                                        Id = "Contract.term.asset.relationship",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 65. Contract.term.asset.context
                                    this.Context = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Context",                                                                                   // MakerGen.cs:235
                                        Path= "Contract.term.asset.context",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.asset.context",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Context                                                                                // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 69. Contract.term.asset.condition
                                    this.Condition = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Condition",                                                                                 // MakerGen.cs:235
                                        Path= "Contract.term.asset.condition",                                                              // MakerGen.cs:236
                                        Id = "Contract.term.asset.condition",                                                               // MakerGen.cs:237
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
                                {                                                                                                           // MakerGen.cs:231
                                    // 70. Contract.term.asset.periodType
                                    this.PeriodType = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PeriodType",                                                                                // MakerGen.cs:235
                                        Path= "Contract.term.asset.periodType",                                                             // MakerGen.cs:236
                                        Id = "Contract.term.asset.periodType",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 71. Contract.term.asset.period
                                    this.Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Period",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.asset.period",                                                                 // MakerGen.cs:236
                                        Id = "Contract.term.asset.period",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Period                                                        // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 72. Contract.term.asset.usePeriod
                                    this.UsePeriod = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "UsePeriod",                                                                                 // MakerGen.cs:235
                                        Path= "Contract.term.asset.usePeriod",                                                              // MakerGen.cs:236
                                        Id = "Contract.term.asset.usePeriod",                                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Period                                                        // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 73. Contract.term.asset.text
                                    this.Text = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Text",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.asset.text",                                                                   // MakerGen.cs:236
                                        Id = "Contract.term.asset.text",                                                                    // MakerGen.cs:237
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
                                {                                                                                                           // MakerGen.cs:231
                                    // 74. Contract.term.asset.linkId
                                    this.LinkId = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "LinkId",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.asset.linkId",                                                                 // MakerGen.cs:236
                                        Id = "Contract.term.asset.linkId",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 75. Contract.term.asset.answer
                                    this.Answer = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Answer",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.asset.answer",                                                                 // MakerGen.cs:236
                                        Id = "Contract.term.asset.answer",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 76. Contract.term.asset.securityLabelNumber
                                    this.SecurityLabelNumber = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "SecurityLabelNumber",                                                                       // MakerGen.cs:235
                                        Path= "Contract.term.asset.securityLabelNumber",                                                    // MakerGen.cs:236
                                        Id = "Contract.term.asset.securityLabelNumber",                                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 77. Contract.term.asset.valuedItem
                                    this.ValuedItem = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ValuedItem",                                                                                // MakerGen.cs:235
                                        Path= "Contract.term.asset.valuedItem",                                                             // MakerGen.cs:236
                                        Id = "Contract.term.asset.valuedItem",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_ValuedItem                                                                             // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Scope.Write(sDef);                                                                                          // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                TypeReference.Write(sDef);                                                                                  // MakerGen.cs:220
                                Subtype.Write(sDef);                                                                                        // MakerGen.cs:220
                                Relationship.Write(sDef);                                                                                   // MakerGen.cs:220
                                Context.Write(sDef);                                                                                        // MakerGen.cs:220
                                Condition.Write(sDef);                                                                                      // MakerGen.cs:220
                                PeriodType.Write(sDef);                                                                                     // MakerGen.cs:220
                                Period.Write(sDef);                                                                                         // MakerGen.cs:220
                                UsePeriod.Write(sDef);                                                                                      // MakerGen.cs:220
                                Text.Write(sDef);                                                                                           // MakerGen.cs:220
                                LinkId.Write(sDef);                                                                                         // MakerGen.cs:220
                                Answer.Write(sDef);                                                                                         // MakerGen.cs:220
                                SecurityLabelNumber.Write(sDef);                                                                            // MakerGen.cs:220
                                ValuedItem.Write(sDef);                                                                                     // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Asset_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Asset()                                                                                                 // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Asset_Elements();                                                                      // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 92. Contract.term.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 95. Contract.term.action.subject
                            public class Type_Subject : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Subject_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 96. Contract.term.action.subject.reference
                                    public ElementDefinitionInfo Reference;                                                                 // MakerGen.cs:216
                                    // 97. Contract.term.action.subject.role
                                    public ElementDefinitionInfo Role;                                                                      // MakerGen.cs:216
                                    public Type_Subject_Elements()                                                                          // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 96. Contract.term.action.subject.reference
                                            this.Reference = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Reference",                                                                         // MakerGen.cs:235
                                                Path= "Contract.term.action.subject.reference",                                             // MakerGen.cs:236
                                                Id = "Contract.term.action.subject.reference",                                              // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Patient",                              // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                        // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                         // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                     // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Device",                               // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Group",                                // MakerGen.cs:349
                                                            "http://hl7.org/fhir/StructureDefinition/Organization"                          // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 97. Contract.term.action.subject.role
                                            this.Role = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Role",                                                                              // MakerGen.cs:235
                                                Path= "Contract.term.action.subject.role",                                                  // MakerGen.cs:236
                                                Id = "Contract.term.action.subject.role",                                                   // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Reference.Write(sDef);                                                                              // MakerGen.cs:220
                                        Role.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Subject_Elements Elements { get; }                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Subject()                                                                                       // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Subject_Elements();                                                            // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 93. Contract.term.action.doNotPerform
                            public ElementDefinitionInfo DoNotPerform;                                                                      // MakerGen.cs:216
                            // 94. Contract.term.action.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 95. Contract.term.action.subject
                            public ElementDefinitionInfo Subject;                                                                           // MakerGen.cs:216
                            // 98. Contract.term.action.intent
                            public ElementDefinitionInfo Intent;                                                                            // MakerGen.cs:216
                            // 99. Contract.term.action.linkId
                            public ElementDefinitionInfo LinkId;                                                                            // MakerGen.cs:216
                            // 100. Contract.term.action.status
                            public ElementDefinitionInfo Status;                                                                            // MakerGen.cs:216
                            // 101. Contract.term.action.context
                            public ElementDefinitionInfo Context;                                                                           // MakerGen.cs:216
                            // 102. Contract.term.action.contextLinkId
                            public ElementDefinitionInfo ContextLinkId;                                                                     // MakerGen.cs:216
                            // 103. Contract.term.action.occurrence[x]
                            public ElementDefinitionInfo Occurrence;                                                                        // MakerGen.cs:216
                            // 104. Contract.term.action.requester
                            public ElementDefinitionInfo Requester;                                                                         // MakerGen.cs:216
                            // 105. Contract.term.action.requesterLinkId
                            public ElementDefinitionInfo RequesterLinkId;                                                                   // MakerGen.cs:216
                            // 106. Contract.term.action.performerType
                            public ElementDefinitionInfo PerformerType;                                                                     // MakerGen.cs:216
                            // 107. Contract.term.action.performerRole
                            public ElementDefinitionInfo PerformerRole;                                                                     // MakerGen.cs:216
                            // 108. Contract.term.action.performer
                            public ElementDefinitionInfo Performer;                                                                         // MakerGen.cs:216
                            // 109. Contract.term.action.performerLinkId
                            public ElementDefinitionInfo PerformerLinkId;                                                                   // MakerGen.cs:216
                            // 110. Contract.term.action.reasonCode
                            public ElementDefinitionInfo ReasonCode;                                                                        // MakerGen.cs:216
                            // 111. Contract.term.action.reasonReference
                            public ElementDefinitionInfo ReasonReference;                                                                   // MakerGen.cs:216
                            // 112. Contract.term.action.reason
                            public ElementDefinitionInfo Reason;                                                                            // MakerGen.cs:216
                            // 113. Contract.term.action.reasonLinkId
                            public ElementDefinitionInfo ReasonLinkId;                                                                      // MakerGen.cs:216
                            // 114. Contract.term.action.note
                            public ElementDefinitionInfo Note;                                                                              // MakerGen.cs:216
                            // 115. Contract.term.action.securityLabelNumber
                            public ElementDefinitionInfo SecurityLabelNumber;                                                               // MakerGen.cs:216
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 93. Contract.term.action.doNotPerform
                                    this.DoNotPerform = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "DoNotPerform",                                                                              // MakerGen.cs:235
                                        Path= "Contract.term.action.doNotPerform",                                                          // MakerGen.cs:236
                                        Id = "Contract.term.action.doNotPerform",                                                           // MakerGen.cs:237
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
                                    // 94. Contract.term.action.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.action.type",                                                                  // MakerGen.cs:236
                                        Id = "Contract.term.action.type",                                                                   // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 95. Contract.term.action.subject
                                    this.Subject = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Subject",                                                                                   // MakerGen.cs:235
                                        Path= "Contract.term.action.subject",                                                               // MakerGen.cs:236
                                        Id = "Contract.term.action.subject",                                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Subject                                                                                // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 98. Contract.term.action.intent
                                    this.Intent = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Intent",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.action.intent",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.action.intent",                                                                 // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 99. Contract.term.action.linkId
                                    this.LinkId = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "LinkId",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.action.linkId",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.action.linkId",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 100. Contract.term.action.status
                                    this.Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Status",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.action.status",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.action.status",                                                                 // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 101. Contract.term.action.context
                                    this.Context = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Context",                                                                                   // MakerGen.cs:235
                                        Path= "Contract.term.action.context",                                                               // MakerGen.cs:236
                                        Id = "Contract.term.action.context",                                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Encounter",                                    // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                 // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 102. Contract.term.action.contextLinkId
                                    this.ContextLinkId = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ContextLinkId",                                                                             // MakerGen.cs:235
                                        Path= "Contract.term.action.contextLinkId",                                                         // MakerGen.cs:236
                                        Id = "Contract.term.action.contextLinkId",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 103. Contract.term.action.occurrence[x]
                                    this.Occurrence = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Occurrence",                                                                                // MakerGen.cs:235
                                        Path= "Contract.term.action.occurrence[x]",                                                         // MakerGen.cs:236
                                        Id = "Contract.term.action.occurrence[x]",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Complex.Period                                                        // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            },                                                                                              // MakerGen.cs:360
                                            new FhirKhit.Maker.Common.Complex.Timing                                                        // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 104. Contract.term.action.requester
                                    this.Requester = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Requester",                                                                                 // MakerGen.cs:235
                                        Path= "Contract.term.action.requester",                                                             // MakerGen.cs:236
                                        Id = "Contract.term.action.requester",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                      // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                             // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Device",                                       // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Group",                                        // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                  // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 105. Contract.term.action.requesterLinkId
                                    this.RequesterLinkId = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "RequesterLinkId",                                                                           // MakerGen.cs:235
                                        Path= "Contract.term.action.requesterLinkId",                                                       // MakerGen.cs:236
                                        Id = "Contract.term.action.requesterLinkId",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 106. Contract.term.action.performerType
                                    this.PerformerType = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PerformerType",                                                                             // MakerGen.cs:235
                                        Path= "Contract.term.action.performerType",                                                         // MakerGen.cs:236
                                        Id = "Contract.term.action.performerType",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 107. Contract.term.action.performerRole
                                    this.PerformerRole = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PerformerRole",                                                                             // MakerGen.cs:235
                                        Path= "Contract.term.action.performerRole",                                                         // MakerGen.cs:236
                                        Id = "Contract.term.action.performerRole",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 108. Contract.term.action.performer
                                    this.Performer = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Performer",                                                                                 // MakerGen.cs:235
                                        Path= "Contract.term.action.performer",                                                             // MakerGen.cs:236
                                        Id = "Contract.term.action.performer",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                      // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                             // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                     // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Device",                                       // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                    // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Location"                                      // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 109. Contract.term.action.performerLinkId
                                    this.PerformerLinkId = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PerformerLinkId",                                                                           // MakerGen.cs:235
                                        Path= "Contract.term.action.performerLinkId",                                                       // MakerGen.cs:236
                                        Id = "Contract.term.action.performerLinkId",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 110. Contract.term.action.reasonCode
                                    this.ReasonCode = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ReasonCode",                                                                                // MakerGen.cs:235
                                        Path= "Contract.term.action.reasonCode",                                                            // MakerGen.cs:236
                                        Id = "Contract.term.action.reasonCode",                                                             // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 111. Contract.term.action.reasonReference
                                    this.ReasonReference = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ReasonReference",                                                                           // MakerGen.cs:235
                                        Path= "Contract.term.action.reasonReference",                                                       // MakerGen.cs:236
                                        Id = "Contract.term.action.reasonReference",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                    // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                  // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                             // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",                            // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire",                                // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"                         // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 112. Contract.term.action.reason
                                    this.Reason = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Reason",                                                                                    // MakerGen.cs:235
                                        Path= "Contract.term.action.reason",                                                                // MakerGen.cs:236
                                        Id = "Contract.term.action.reason",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 113. Contract.term.action.reasonLinkId
                                    this.ReasonLinkId = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ReasonLinkId",                                                                              // MakerGen.cs:235
                                        Path= "Contract.term.action.reasonLinkId",                                                          // MakerGen.cs:236
                                        Id = "Contract.term.action.reasonLinkId",                                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 114. Contract.term.action.note
                                    this.Note = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Note",                                                                                      // MakerGen.cs:235
                                        Path= "Contract.term.action.note",                                                                  // MakerGen.cs:236
                                        Id = "Contract.term.action.note",                                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Annotation                                                    // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 115. Contract.term.action.securityLabelNumber
                                    this.SecurityLabelNumber = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "SecurityLabelNumber",                                                                       // MakerGen.cs:235
                                        Path= "Contract.term.action.securityLabelNumber",                                                   // MakerGen.cs:236
                                        Id = "Contract.term.action.securityLabelNumber",                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                DoNotPerform.Write(sDef);                                                                                   // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Subject.Write(sDef);                                                                                        // MakerGen.cs:220
                                Intent.Write(sDef);                                                                                         // MakerGen.cs:220
                                LinkId.Write(sDef);                                                                                         // MakerGen.cs:220
                                Status.Write(sDef);                                                                                         // MakerGen.cs:220
                                Context.Write(sDef);                                                                                        // MakerGen.cs:220
                                ContextLinkId.Write(sDef);                                                                                  // MakerGen.cs:220
                                Occurrence.Write(sDef);                                                                                     // MakerGen.cs:220
                                Requester.Write(sDef);                                                                                      // MakerGen.cs:220
                                RequesterLinkId.Write(sDef);                                                                                // MakerGen.cs:220
                                PerformerType.Write(sDef);                                                                                  // MakerGen.cs:220
                                PerformerRole.Write(sDef);                                                                                  // MakerGen.cs:220
                                Performer.Write(sDef);                                                                                      // MakerGen.cs:220
                                PerformerLinkId.Write(sDef);                                                                                // MakerGen.cs:220
                                ReasonCode.Write(sDef);                                                                                     // MakerGen.cs:220
                                ReasonReference.Write(sDef);                                                                                // MakerGen.cs:220
                                Reason.Write(sDef);                                                                                         // MakerGen.cs:220
                                ReasonLinkId.Write(sDef);                                                                                   // MakerGen.cs:220
                                Note.Write(sDef);                                                                                           // MakerGen.cs:220
                                SecurityLabelNumber.Write(sDef);                                                                            // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Action()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 33. Contract.term.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 34. Contract.term.issued
                    public ElementDefinitionInfo Issued;                                                                                    // MakerGen.cs:216
                    // 35. Contract.term.applies
                    public ElementDefinitionInfo Applies;                                                                                   // MakerGen.cs:216
                    // 36. Contract.term.topic[x]
                    public ElementDefinitionInfo Topic;                                                                                     // MakerGen.cs:216
                    // 37. Contract.term.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 38. Contract.term.subType
                    public ElementDefinitionInfo SubType;                                                                                   // MakerGen.cs:216
                    // 39. Contract.term.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:216
                    // 40. Contract.term.securityLabel
                    public ElementDefinitionInfo SecurityLabel;                                                                             // MakerGen.cs:216
                    // 45. Contract.term.offer
                    public ElementDefinitionInfo Offer;                                                                                     // MakerGen.cs:216
                    // 59. Contract.term.asset
                    public ElementDefinitionInfo Asset;                                                                                     // MakerGen.cs:216
                    // 92. Contract.term.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:216
                    // 116. Contract.term.group
                    public ElementDefinitionInfo Group;                                                                                     // MakerGen.cs:216
                    public Type_Term_Elements()                                                                                             // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. Contract.term.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "Contract.term.identifier",                                                                           // MakerGen.cs:236
                                Id = "Contract.term.identifier",                                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. Contract.term.issued
                            this.Issued = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Issued",                                                                                            // MakerGen.cs:235
                                Path= "Contract.term.issued",                                                                               // MakerGen.cs:236
                                Id = "Contract.term.issued",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. Contract.term.applies
                            this.Applies = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Applies",                                                                                           // MakerGen.cs:235
                                Path= "Contract.term.applies",                                                                              // MakerGen.cs:236
                                Id = "Contract.term.applies",                                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. Contract.term.topic[x]
                            this.Topic = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Topic",                                                                                             // MakerGen.cs:235
                                Path= "Contract.term.topic[x]",                                                                             // MakerGen.cs:236
                                Id = "Contract.term.topic[x]",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. Contract.term.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Contract.term.type",                                                                                 // MakerGen.cs:236
                                Id = "Contract.term.type",                                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 38. Contract.term.subType
                            this.SubType = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SubType",                                                                                           // MakerGen.cs:235
                                Path= "Contract.term.subType",                                                                              // MakerGen.cs:236
                                Id = "Contract.term.subType",                                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 39. Contract.term.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Text",                                                                                              // MakerGen.cs:235
                                Path= "Contract.term.text",                                                                                 // MakerGen.cs:236
                                Id = "Contract.term.text",                                                                                  // MakerGen.cs:237
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
                            // 40. Contract.term.securityLabel
                            this.SecurityLabel = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SecurityLabel",                                                                                     // MakerGen.cs:235
                                Path= "Contract.term.securityLabel",                                                                        // MakerGen.cs:236
                                Id = "Contract.term.securityLabel",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_SecurityLabel                                                                                  // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 45. Contract.term.offer
                            this.Offer = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Offer",                                                                                             // MakerGen.cs:235
                                Path= "Contract.term.offer",                                                                                // MakerGen.cs:236
                                Id = "Contract.term.offer",                                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Offer                                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 59. Contract.term.asset
                            this.Asset = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Asset",                                                                                             // MakerGen.cs:235
                                Path= "Contract.term.asset",                                                                                // MakerGen.cs:236
                                Id = "Contract.term.asset",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Asset                                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 92. Contract.term.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Action",                                                                                            // MakerGen.cs:235
                                Path= "Contract.term.action",                                                                               // MakerGen.cs:236
                                Id = "Contract.term.action",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Action                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 116. Contract.term.group
                            this.Group = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Group",                                                                                             // MakerGen.cs:235
                                Path= "Contract.term.group",                                                                                // MakerGen.cs:236
                                Id = "Contract.term.group",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Issued.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Applies.Write(sDef);                                                                                                // MakerGen.cs:220
                        Topic.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        SubType.Write(sDef);                                                                                                // MakerGen.cs:220
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:220
                        SecurityLabel.Write(sDef);                                                                                          // MakerGen.cs:220
                        Offer.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Asset.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Group.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Term_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Term()                                                                                                          // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Term_Elements();                                                                               // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 119. Contract.signer
            public class Type_Signer : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Signer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 120. Contract.signer.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 121. Contract.signer.party
                    public ElementDefinitionInfo Party;                                                                                     // MakerGen.cs:216
                    // 122. Contract.signer.signature
                    public ElementDefinitionInfo Signature;                                                                                 // MakerGen.cs:216
                    public Type_Signer_Elements()                                                                                           // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 120. Contract.signer.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Contract.signer.type",                                                                               // MakerGen.cs:236
                                Id = "Contract.signer.type",                                                                                // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 121. Contract.signer.party
                            this.Party = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Party",                                                                                             // MakerGen.cs:235
                                Path= "Contract.signer.party",                                                                              // MakerGen.cs:236
                                Id = "Contract.signer.party",                                                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 122. Contract.signer.signature
                            this.Signature = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Signature",                                                                                         // MakerGen.cs:235
                                Path= "Contract.signer.signature",                                                                          // MakerGen.cs:236
                                Id = "Contract.signer.signature",                                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Party.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Signature.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Signer_Elements Elements { get; }                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Signer()                                                                                                        // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Signer_Elements();                                                                             // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 123. Contract.friendly
            public class Type_Friendly : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Friendly_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 124. Contract.friendly.content[x]
                    public ElementDefinitionInfo Content;                                                                                   // MakerGen.cs:216
                    public Type_Friendly_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 124. Contract.friendly.content[x]
                            this.Content = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Content",                                                                                           // MakerGen.cs:235
                                Path= "Contract.friendly.content[x]",                                                                       // MakerGen.cs:236
                                Id = "Contract.friendly.content[x]",                                                                        // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Composition",                                          // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                    // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Content.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Friendly_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Friendly()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Friendly_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 125. Contract.legal
            public class Type_Legal : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Legal_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 126. Contract.legal.content[x]
                    public ElementDefinitionInfo Content;                                                                                   // MakerGen.cs:216
                    public Type_Legal_Elements()                                                                                            // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 126. Contract.legal.content[x]
                            this.Content = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Content",                                                                                           // MakerGen.cs:235
                                Path= "Contract.legal.content[x]",                                                                          // MakerGen.cs:236
                                Id = "Contract.legal.content[x]",                                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Composition",                                          // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                    // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Content.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Legal_Elements Elements { get; }                                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Legal()                                                                                                         // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Legal_Elements();                                                                              // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 127. Contract.rule
            public class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Rule_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 128. Contract.rule.content[x]
                    public ElementDefinitionInfo Content;                                                                                   // MakerGen.cs:216
                    public Type_Rule_Elements()                                                                                             // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 128. Contract.rule.content[x]
                            this.Content = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Content",                                                                                           // MakerGen.cs:235
                                Path= "Contract.rule.content[x]",                                                                           // MakerGen.cs:236
                                Id = "Contract.rule.content[x]",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Content.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Rule_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Rule()                                                                                                          // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Rule_Elements();                                                                               // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. Contract.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. Contract.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 3. Contract.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. Contract.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 5. Contract.legalState
            public ElementDefinitionInfo LegalState;                                                                                        // MakerGen.cs:216
            // 6. Contract.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:216
            // 7. Contract.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:216
            // 8. Contract.contentDerivative
            public ElementDefinitionInfo ContentDerivative;                                                                                 // MakerGen.cs:216
            // 9. Contract.issued
            public ElementDefinitionInfo Issued;                                                                                            // MakerGen.cs:216
            // 10. Contract.applies
            public ElementDefinitionInfo Applies;                                                                                           // MakerGen.cs:216
            // 11. Contract.expirationType
            public ElementDefinitionInfo ExpirationType;                                                                                    // MakerGen.cs:216
            // 12. Contract.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 13. Contract.authority
            public ElementDefinitionInfo Authority;                                                                                         // MakerGen.cs:216
            // 14. Contract.domain
            public ElementDefinitionInfo Domain;                                                                                            // MakerGen.cs:216
            // 15. Contract.site
            public ElementDefinitionInfo Site;                                                                                              // MakerGen.cs:216
            // 16. Contract.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 17. Contract.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 18. Contract.subtitle
            public ElementDefinitionInfo Subtitle;                                                                                          // MakerGen.cs:216
            // 19. Contract.alias
            public ElementDefinitionInfo Alias;                                                                                             // MakerGen.cs:216
            // 20. Contract.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 21. Contract.scope
            public ElementDefinitionInfo Scope;                                                                                             // MakerGen.cs:216
            // 22. Contract.topic[x]
            public ElementDefinitionInfo Topic;                                                                                             // MakerGen.cs:216
            // 23. Contract.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 24. Contract.subType
            public ElementDefinitionInfo SubType;                                                                                           // MakerGen.cs:216
            // 25. Contract.contentDefinition
            public ElementDefinitionInfo ContentDefinition;                                                                                 // MakerGen.cs:216
            // 32. Contract.term
            public ElementDefinitionInfo Term;                                                                                              // MakerGen.cs:216
            // 117. Contract.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:216
            // 118. Contract.relevantHistory
            public ElementDefinitionInfo RelevantHistory;                                                                                   // MakerGen.cs:216
            // 119. Contract.signer
            public ElementDefinitionInfo Signer;                                                                                            // MakerGen.cs:216
            // 123. Contract.friendly
            public ElementDefinitionInfo Friendly;                                                                                          // MakerGen.cs:216
            // 125. Contract.legal
            public ElementDefinitionInfo Legal;                                                                                             // MakerGen.cs:216
            // 127. Contract.rule
            public ElementDefinitionInfo Rule;                                                                                              // MakerGen.cs:216
            // 129. Contract.legallyBinding[x]
            public ElementDefinitionInfo LegallyBinding;                                                                                    // MakerGen.cs:216
            public Contract_Elements()                                                                                                      // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Contract.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "Contract.identifier",                                                                                        // MakerGen.cs:236
                        Id = "Contract.identifier",                                                                                         // MakerGen.cs:237
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
                    // 2. Contract.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "Contract.url",                                                                                               // MakerGen.cs:236
                        Id = "Contract.url",                                                                                                // MakerGen.cs:237
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
                    // 3. Contract.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "Contract.version",                                                                                           // MakerGen.cs:236
                        Id = "Contract.version",                                                                                            // MakerGen.cs:237
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
                    // 4. Contract.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Contract.status",                                                                                            // MakerGen.cs:236
                        Id = "Contract.status",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 5. Contract.legalState
                    this.LegalState = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LegalState",                                                                                                // MakerGen.cs:235
                        Path= "Contract.legalState",                                                                                        // MakerGen.cs:236
                        Id = "Contract.legalState",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. Contract.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:235
                        Path= "Contract.instantiatesCanonical",                                                                             // MakerGen.cs:236
                        Id = "Contract.instantiatesCanonical",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Contract"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. Contract.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:235
                        Path= "Contract.instantiatesUri",                                                                                   // MakerGen.cs:236
                        Id = "Contract.instantiatesUri",                                                                                    // MakerGen.cs:237
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
                    // 8. Contract.contentDerivative
                    this.ContentDerivative = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ContentDerivative",                                                                                         // MakerGen.cs:235
                        Path= "Contract.contentDerivative",                                                                                 // MakerGen.cs:236
                        Id = "Contract.contentDerivative",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. Contract.issued
                    this.Issued = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Issued",                                                                                                    // MakerGen.cs:235
                        Path= "Contract.issued",                                                                                            // MakerGen.cs:236
                        Id = "Contract.issued",                                                                                             // MakerGen.cs:237
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
                    // 10. Contract.applies
                    this.Applies = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Applies",                                                                                                   // MakerGen.cs:235
                        Path= "Contract.applies",                                                                                           // MakerGen.cs:236
                        Id = "Contract.applies",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. Contract.expirationType
                    this.ExpirationType = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ExpirationType",                                                                                            // MakerGen.cs:235
                        Path= "Contract.expirationType",                                                                                    // MakerGen.cs:236
                        Id = "Contract.expirationType",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. Contract.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "Contract.subject",                                                                                           // MakerGen.cs:236
                        Id = "Contract.subject",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. Contract.authority
                    this.Authority = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Authority",                                                                                                 // MakerGen.cs:235
                        Path= "Contract.authority",                                                                                         // MakerGen.cs:236
                        Id = "Contract.authority",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. Contract.domain
                    this.Domain = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Domain",                                                                                                    // MakerGen.cs:235
                        Path= "Contract.domain",                                                                                            // MakerGen.cs:236
                        Id = "Contract.domain",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. Contract.site
                    this.Site = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Site",                                                                                                      // MakerGen.cs:235
                        Path= "Contract.site",                                                                                              // MakerGen.cs:236
                        Id = "Contract.site",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. Contract.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "Contract.name",                                                                                              // MakerGen.cs:236
                        Id = "Contract.name",                                                                                               // MakerGen.cs:237
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
                    // 17. Contract.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "Contract.title",                                                                                             // MakerGen.cs:236
                        Id = "Contract.title",                                                                                              // MakerGen.cs:237
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
                    // 18. Contract.subtitle
                    this.Subtitle = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subtitle",                                                                                                  // MakerGen.cs:235
                        Path= "Contract.subtitle",                                                                                          // MakerGen.cs:236
                        Id = "Contract.subtitle",                                                                                           // MakerGen.cs:237
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
                    // 19. Contract.alias
                    this.Alias = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Alias",                                                                                                     // MakerGen.cs:235
                        Path= "Contract.alias",                                                                                             // MakerGen.cs:236
                        Id = "Contract.alias",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. Contract.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "Contract.author",                                                                                            // MakerGen.cs:236
                        Id = "Contract.author",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. Contract.scope
                    this.Scope = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Scope",                                                                                                     // MakerGen.cs:235
                        Path= "Contract.scope",                                                                                             // MakerGen.cs:236
                        Id = "Contract.scope",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. Contract.topic[x]
                    this.Topic = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Topic",                                                                                                     // MakerGen.cs:235
                        Path= "Contract.topic[x]",                                                                                          // MakerGen.cs:236
                        Id = "Contract.topic[x]",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. Contract.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "Contract.type",                                                                                              // MakerGen.cs:236
                        Id = "Contract.type",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. Contract.subType
                    this.SubType = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SubType",                                                                                                   // MakerGen.cs:235
                        Path= "Contract.subType",                                                                                           // MakerGen.cs:236
                        Id = "Contract.subType",                                                                                            // MakerGen.cs:237
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
                    // 25. Contract.contentDefinition
                    this.ContentDefinition = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ContentDefinition",                                                                                         // MakerGen.cs:235
                        Path= "Contract.contentDefinition",                                                                                 // MakerGen.cs:236
                        Id = "Contract.contentDefinition",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_ContentDefinition                                                                                      // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 32. Contract.term
                    this.Term = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Term",                                                                                                      // MakerGen.cs:235
                        Path= "Contract.term",                                                                                              // MakerGen.cs:236
                        Id = "Contract.term",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Term                                                                                                   // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 117. Contract.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:235
                        Path= "Contract.supportingInfo",                                                                                    // MakerGen.cs:236
                        Id = "Contract.supportingInfo",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 118. Contract.relevantHistory
                    this.RelevantHistory = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelevantHistory",                                                                                           // MakerGen.cs:235
                        Path= "Contract.relevantHistory",                                                                                   // MakerGen.cs:236
                        Id = "Contract.relevantHistory",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Provenance"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 119. Contract.signer
                    this.Signer = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Signer",                                                                                                    // MakerGen.cs:235
                        Path= "Contract.signer",                                                                                            // MakerGen.cs:236
                        Id = "Contract.signer",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Signer                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 123. Contract.friendly
                    this.Friendly = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Friendly",                                                                                                  // MakerGen.cs:235
                        Path= "Contract.friendly",                                                                                          // MakerGen.cs:236
                        Id = "Contract.friendly",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Friendly                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 125. Contract.legal
                    this.Legal = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Legal",                                                                                                     // MakerGen.cs:235
                        Path= "Contract.legal",                                                                                             // MakerGen.cs:236
                        Id = "Contract.legal",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Legal                                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 127. Contract.rule
                    this.Rule = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Rule",                                                                                                      // MakerGen.cs:235
                        Path= "Contract.rule",                                                                                              // MakerGen.cs:236
                        Id = "Contract.rule",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Rule                                                                                                   // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 129. Contract.legallyBinding[x]
                    this.LegallyBinding = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LegallyBinding",                                                                                            // MakerGen.cs:235
                        Path= "Contract.legallyBinding[x]",                                                                                 // MakerGen.cs:236
                        Id = "Contract.legallyBinding[x]",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Composition",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Contract"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                LegalState.Write(sDef);                                                                                                     // MakerGen.cs:220
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:220
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:220
                ContentDerivative.Write(sDef);                                                                                              // MakerGen.cs:220
                Issued.Write(sDef);                                                                                                         // MakerGen.cs:220
                Applies.Write(sDef);                                                                                                        // MakerGen.cs:220
                ExpirationType.Write(sDef);                                                                                                 // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Authority.Write(sDef);                                                                                                      // MakerGen.cs:220
                Domain.Write(sDef);                                                                                                         // MakerGen.cs:220
                Site.Write(sDef);                                                                                                           // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Title.Write(sDef);                                                                                                          // MakerGen.cs:220
                Subtitle.Write(sDef);                                                                                                       // MakerGen.cs:220
                Alias.Write(sDef);                                                                                                          // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Scope.Write(sDef);                                                                                                          // MakerGen.cs:220
                Topic.Write(sDef);                                                                                                          // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                SubType.Write(sDef);                                                                                                        // MakerGen.cs:220
                ContentDefinition.Write(sDef);                                                                                              // MakerGen.cs:220
                Term.Write(sDef);                                                                                                           // MakerGen.cs:220
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:220
                RelevantHistory.Write(sDef);                                                                                                // MakerGen.cs:220
                Signer.Write(sDef);                                                                                                         // MakerGen.cs:220
                Friendly.Write(sDef);                                                                                                       // MakerGen.cs:220
                Legal.Write(sDef);                                                                                                          // MakerGen.cs:220
                Rule.Write(sDef);                                                                                                           // MakerGen.cs:220
                LegallyBinding.Write(sDef);                                                                                                 // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Contract_Elements Elements { get; }                                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Contract()                                                                                                                   // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Contract_Elements();                                                                                        // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
