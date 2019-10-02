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
    #endregion
    /// <summary>
    /// Fhir resource 'Contract'
    /// </summary>
    // 0. Contract
    public class Resource_Contract : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 25. Contract.contentDefinition
        public class Type_ContentDefinition : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. Contract.contentDefinition.type
            public ElementDefinitionInfo Element_Type;
            // 27. Contract.contentDefinition.subType
            public ElementDefinitionInfo Element_SubType;
            // 28. Contract.contentDefinition.publisher
            public ElementDefinitionInfo Element_Publisher;
            // 29. Contract.contentDefinition.publicationDate
            public ElementDefinitionInfo Element_PublicationDate;
            // 30. Contract.contentDefinition.publicationStatus
            public ElementDefinitionInfo Element_PublicationStatus;
            // 31. Contract.contentDefinition.copyright
            public ElementDefinitionInfo Element_Copyright;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.contentDefinition",
                    ElementId = "Contract.contentDefinition"
                });
                Element_Type.Write(sDef);
                Element_SubType.Write(sDef);
                Element_Publisher.Write(sDef);
                Element_PublicationDate.Write(sDef);
                Element_PublicationStatus.Write(sDef);
                Element_Copyright.Write(sDef);
            }
            
            public Type_ContentDefinition()
            {
                {
                    // 26. Contract.contentDefinition.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Contract.contentDefinition.type",
                        Id = "Contract.contentDefinition.type",
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
                    // 27. Contract.contentDefinition.subType
                    this.Element_SubType = new ElementDefinitionInfo
                    {
                        Name = "Element_SubType",
                        Path= "Contract.contentDefinition.subType",
                        Id = "Contract.contentDefinition.subType",
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
                    // 28. Contract.contentDefinition.publisher
                    this.Element_Publisher = new ElementDefinitionInfo
                    {
                        Name = "Element_Publisher",
                        Path= "Contract.contentDefinition.publisher",
                        Id = "Contract.contentDefinition.publisher",
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
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 29. Contract.contentDefinition.publicationDate
                    this.Element_PublicationDate = new ElementDefinitionInfo
                    {
                        Name = "Element_PublicationDate",
                        Path= "Contract.contentDefinition.publicationDate",
                        Id = "Contract.contentDefinition.publicationDate",
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
                    // 30. Contract.contentDefinition.publicationStatus
                    this.Element_PublicationStatus = new ElementDefinitionInfo
                    {
                        Name = "Element_PublicationStatus",
                        Path= "Contract.contentDefinition.publicationStatus",
                        Id = "Contract.contentDefinition.publicationStatus",
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
                    // 31. Contract.contentDefinition.copyright
                    this.Element_Copyright = new ElementDefinitionInfo
                    {
                        Name = "Element_Copyright",
                        Path= "Contract.contentDefinition.copyright",
                        Id = "Contract.contentDefinition.copyright",
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
        // 32. Contract.term
        public class Type_Term : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 40. Contract.term.securityLabel
            public class Type_SecurityLabel : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 41. Contract.term.securityLabel.number
                public ElementDefinitionInfo Element_Number;
                // 42. Contract.term.securityLabel.classification
                public ElementDefinitionInfo Element_Classification;
                // 43. Contract.term.securityLabel.category
                public ElementDefinitionInfo Element_Category;
                // 44. Contract.term.securityLabel.control
                public ElementDefinitionInfo Element_Control;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Contract.term.securityLabel",
                        ElementId = "Contract.term.securityLabel"
                    });
                    Element_Number.Write(sDef);
                    Element_Classification.Write(sDef);
                    Element_Category.Write(sDef);
                    Element_Control.Write(sDef);
                }
                
                public Type_SecurityLabel()
                {
                    {
                        // 41. Contract.term.securityLabel.number
                        this.Element_Number = new ElementDefinitionInfo
                        {
                            Name = "Element_Number",
                            Path= "Contract.term.securityLabel.number",
                            Id = "Contract.term.securityLabel.number",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                {
                                }
                            }
                        };
                    }
                    {
                        // 42. Contract.term.securityLabel.classification
                        this.Element_Classification = new ElementDefinitionInfo
                        {
                            Name = "Element_Classification",
                            Path= "Contract.term.securityLabel.classification",
                            Id = "Contract.term.securityLabel.classification",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                    {
                        // 43. Contract.term.securityLabel.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "Contract.term.securityLabel.category",
                            Id = "Contract.term.securityLabel.category",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                    {
                        // 44. Contract.term.securityLabel.control
                        this.Element_Control = new ElementDefinitionInfo
                        {
                            Name = "Element_Control",
                            Path= "Contract.term.securityLabel.control",
                            Id = "Contract.term.securityLabel.control",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 45. Contract.term.offer
            public class Type_Offer : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 47. Contract.term.offer.party
                public class Type_Party : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 48. Contract.term.offer.party.reference
                    public ElementDefinitionInfo Element_Reference;
                    // 49. Contract.term.offer.party.role
                    public ElementDefinitionInfo Element_Role;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Contract.term.offer.party",
                            ElementId = "Contract.term.offer.party"
                        });
                        Element_Reference.Write(sDef);
                        Element_Role.Write(sDef);
                    }
                    
                    public Type_Party()
                    {
                        {
                            // 48. Contract.term.offer.party.reference
                            this.Element_Reference = new ElementDefinitionInfo
                            {
                                Name = "Element_Reference",
                                Path= "Contract.term.offer.party.reference",
                                Id = "Contract.term.offer.party.reference",
                                Min = 1,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                        TargetProfile = new String[]
                                        {
                                            "http://hl7.org/fhir/StructureDefinition/Patient",
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                            "http://hl7.org/fhir/StructureDefinition/Device",
                                            "http://hl7.org/fhir/StructureDefinition/Group",
                                            "http://hl7.org/fhir/StructureDefinition/Organization"
                                        }
                                    }
                                }
                            };
                        }
                        {
                            // 49. Contract.term.offer.party.role
                            this.Element_Role = new ElementDefinitionInfo
                            {
                                Name = "Element_Role",
                                Path= "Contract.term.offer.party.role",
                                Id = "Contract.term.offer.party.role",
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
                    }
                }
                // 54. Contract.term.offer.answer
                public class Type_Answer : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 55. Contract.term.offer.answer.value[x]
                    public ElementDefinitionInfo Element_Value;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Contract.term.offer.answer",
                            ElementId = "Contract.term.offer.answer"
                        });
                        Element_Value.Write(sDef);
                    }
                    
                    public Type_Answer()
                    {
                        {
                            // 55. Contract.term.offer.answer.value[x]
                            this.Element_Value = new ElementDefinitionInfo
                            {
                                Name = "Element_Value",
                                Path= "Contract.term.offer.answer.value[x]",
                                Id = "Contract.term.offer.answer.value[x]",
                                Min = 1,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Date
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Time
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Coding
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity
                                    {
                                    },
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
                    }
                }
                // 46. Contract.term.offer.identifier
                public ElementDefinitionInfo Element_Identifier;
                // 47. Contract.term.offer.party
                public ElementDefinitionInfo Element_Party;
                // 50. Contract.term.offer.topic
                public ElementDefinitionInfo Element_Topic;
                // 51. Contract.term.offer.type
                public ElementDefinitionInfo Element_Type;
                // 52. Contract.term.offer.decision
                public ElementDefinitionInfo Element_Decision;
                // 53. Contract.term.offer.decisionMode
                public ElementDefinitionInfo Element_DecisionMode;
                // 54. Contract.term.offer.answer
                public ElementDefinitionInfo Element_Answer;
                // 56. Contract.term.offer.text
                public ElementDefinitionInfo Element_Text;
                // 57. Contract.term.offer.linkId
                public ElementDefinitionInfo Element_LinkId;
                // 58. Contract.term.offer.securityLabelNumber
                public ElementDefinitionInfo Element_SecurityLabelNumber;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Contract.term.offer",
                        ElementId = "Contract.term.offer"
                    });
                    Element_Identifier.Write(sDef);
                    Element_Party.Write(sDef);
                    Element_Topic.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_Decision.Write(sDef);
                    Element_DecisionMode.Write(sDef);
                    Element_Answer.Write(sDef);
                    Element_Text.Write(sDef);
                    Element_LinkId.Write(sDef);
                    Element_SecurityLabelNumber.Write(sDef);
                }
                
                public Type_Offer()
                {
                    {
                        // 46. Contract.term.offer.identifier
                        this.Element_Identifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Identifier",
                            Path= "Contract.term.offer.identifier",
                            Id = "Contract.term.offer.identifier",
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
                        // 47. Contract.term.offer.party
                        this.Element_Party = new ElementDefinitionInfo
                        {
                            Name = "Element_Party",
                            Path= "Contract.term.offer.party",
                            Id = "Contract.term.offer.party",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Party
                                {
                                }
                            }
                        };
                    }
                    {
                        // 50. Contract.term.offer.topic
                        this.Element_Topic = new ElementDefinitionInfo
                        {
                            Name = "Element_Topic",
                            Path= "Contract.term.offer.topic",
                            Id = "Contract.term.offer.topic",
                            Min = 0,
                            Max = 1,
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
                    {
                        // 51. Contract.term.offer.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "Contract.term.offer.type",
                            Id = "Contract.term.offer.type",
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
                        // 52. Contract.term.offer.decision
                        this.Element_Decision = new ElementDefinitionInfo
                        {
                            Name = "Element_Decision",
                            Path= "Contract.term.offer.decision",
                            Id = "Contract.term.offer.decision",
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
                        // 53. Contract.term.offer.decisionMode
                        this.Element_DecisionMode = new ElementDefinitionInfo
                        {
                            Name = "Element_DecisionMode",
                            Path= "Contract.term.offer.decisionMode",
                            Id = "Contract.term.offer.decisionMode",
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
                        // 54. Contract.term.offer.answer
                        this.Element_Answer = new ElementDefinitionInfo
                        {
                            Name = "Element_Answer",
                            Path= "Contract.term.offer.answer",
                            Id = "Contract.term.offer.answer",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Answer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 56. Contract.term.offer.text
                        this.Element_Text = new ElementDefinitionInfo
                        {
                            Name = "Element_Text",
                            Path= "Contract.term.offer.text",
                            Id = "Contract.term.offer.text",
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
                        // 57. Contract.term.offer.linkId
                        this.Element_LinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_LinkId",
                            Path= "Contract.term.offer.linkId",
                            Id = "Contract.term.offer.linkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 58. Contract.term.offer.securityLabelNumber
                        this.Element_SecurityLabelNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_SecurityLabelNumber",
                            Path= "Contract.term.offer.securityLabelNumber",
                            Id = "Contract.term.offer.securityLabelNumber",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 59. Contract.term.asset
            public class Type_Asset : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 65. Contract.term.asset.context
                public class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 66. Contract.term.asset.context.reference
                    public ElementDefinitionInfo Element_Reference;
                    // 67. Contract.term.asset.context.code
                    public ElementDefinitionInfo Element_Code;
                    // 68. Contract.term.asset.context.text
                    public ElementDefinitionInfo Element_Text;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Contract.term.asset.context",
                            ElementId = "Contract.term.asset.context"
                        });
                        Element_Reference.Write(sDef);
                        Element_Code.Write(sDef);
                        Element_Text.Write(sDef);
                    }
                    
                    public Type_Context()
                    {
                        {
                            // 66. Contract.term.asset.context.reference
                            this.Element_Reference = new ElementDefinitionInfo
                            {
                                Name = "Element_Reference",
                                Path= "Contract.term.asset.context.reference",
                                Id = "Contract.term.asset.context.reference",
                                Min = 0,
                                Max = 1,
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
                        {
                            // 67. Contract.term.asset.context.code
                            this.Element_Code = new ElementDefinitionInfo
                            {
                                Name = "Element_Code",
                                Path= "Contract.term.asset.context.code",
                                Id = "Contract.term.asset.context.code",
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
                            // 68. Contract.term.asset.context.text
                            this.Element_Text = new ElementDefinitionInfo
                            {
                                Name = "Element_Text",
                                Path= "Contract.term.asset.context.text",
                                Id = "Contract.term.asset.context.text",
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
                // 77. Contract.term.asset.valuedItem
                public class Type_ValuedItem : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 78. Contract.term.asset.valuedItem.entity[x]
                    public ElementDefinitionInfo Element_Entity;
                    // 79. Contract.term.asset.valuedItem.identifier
                    public ElementDefinitionInfo Element_Identifier;
                    // 80. Contract.term.asset.valuedItem.effectiveTime
                    public ElementDefinitionInfo Element_EffectiveTime;
                    // 81. Contract.term.asset.valuedItem.quantity
                    public ElementDefinitionInfo Element_Quantity;
                    // 82. Contract.term.asset.valuedItem.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;
                    // 83. Contract.term.asset.valuedItem.factor
                    public ElementDefinitionInfo Element_Factor;
                    // 84. Contract.term.asset.valuedItem.points
                    public ElementDefinitionInfo Element_Points;
                    // 85. Contract.term.asset.valuedItem.net
                    public ElementDefinitionInfo Element_Net;
                    // 86. Contract.term.asset.valuedItem.payment
                    public ElementDefinitionInfo Element_Payment;
                    // 87. Contract.term.asset.valuedItem.paymentDate
                    public ElementDefinitionInfo Element_PaymentDate;
                    // 88. Contract.term.asset.valuedItem.responsible
                    public ElementDefinitionInfo Element_Responsible;
                    // 89. Contract.term.asset.valuedItem.recipient
                    public ElementDefinitionInfo Element_Recipient;
                    // 90. Contract.term.asset.valuedItem.linkId
                    public ElementDefinitionInfo Element_LinkId;
                    // 91. Contract.term.asset.valuedItem.securityLabelNumber
                    public ElementDefinitionInfo Element_SecurityLabelNumber;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Contract.term.asset.valuedItem",
                            ElementId = "Contract.term.asset.valuedItem"
                        });
                        Element_Entity.Write(sDef);
                        Element_Identifier.Write(sDef);
                        Element_EffectiveTime.Write(sDef);
                        Element_Quantity.Write(sDef);
                        Element_UnitPrice.Write(sDef);
                        Element_Factor.Write(sDef);
                        Element_Points.Write(sDef);
                        Element_Net.Write(sDef);
                        Element_Payment.Write(sDef);
                        Element_PaymentDate.Write(sDef);
                        Element_Responsible.Write(sDef);
                        Element_Recipient.Write(sDef);
                        Element_LinkId.Write(sDef);
                        Element_SecurityLabelNumber.Write(sDef);
                    }
                    
                    public Type_ValuedItem()
                    {
                        {
                            // 78. Contract.term.asset.valuedItem.entity[x]
                            this.Element_Entity = new ElementDefinitionInfo
                            {
                                Name = "Element_Entity",
                                Path= "Contract.term.asset.valuedItem.entity[x]",
                                Id = "Contract.term.asset.valuedItem.entity[x]",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                    {
                                    },
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
                        {
                            // 79. Contract.term.asset.valuedItem.identifier
                            this.Element_Identifier = new ElementDefinitionInfo
                            {
                                Name = "Element_Identifier",
                                Path= "Contract.term.asset.valuedItem.identifier",
                                Id = "Contract.term.asset.valuedItem.identifier",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Identifier
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 80. Contract.term.asset.valuedItem.effectiveTime
                            this.Element_EffectiveTime = new ElementDefinitionInfo
                            {
                                Name = "Element_EffectiveTime",
                                Path= "Contract.term.asset.valuedItem.effectiveTime",
                                Id = "Contract.term.asset.valuedItem.effectiveTime",
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
                            // 81. Contract.term.asset.valuedItem.quantity
                            this.Element_Quantity = new ElementDefinitionInfo
                            {
                                Name = "Element_Quantity",
                                Path= "Contract.term.asset.valuedItem.quantity",
                                Id = "Contract.term.asset.valuedItem.quantity",
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
                            // 82. Contract.term.asset.valuedItem.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo
                            {
                                Name = "Element_UnitPrice",
                                Path= "Contract.term.asset.valuedItem.unitPrice",
                                Id = "Contract.term.asset.valuedItem.unitPrice",
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
                            // 83. Contract.term.asset.valuedItem.factor
                            this.Element_Factor = new ElementDefinitionInfo
                            {
                                Name = "Element_Factor",
                                Path= "Contract.term.asset.valuedItem.factor",
                                Id = "Contract.term.asset.valuedItem.factor",
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
                            // 84. Contract.term.asset.valuedItem.points
                            this.Element_Points = new ElementDefinitionInfo
                            {
                                Name = "Element_Points",
                                Path= "Contract.term.asset.valuedItem.points",
                                Id = "Contract.term.asset.valuedItem.points",
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
                            // 85. Contract.term.asset.valuedItem.net
                            this.Element_Net = new ElementDefinitionInfo
                            {
                                Name = "Element_Net",
                                Path= "Contract.term.asset.valuedItem.net",
                                Id = "Contract.term.asset.valuedItem.net",
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
                            // 86. Contract.term.asset.valuedItem.payment
                            this.Element_Payment = new ElementDefinitionInfo
                            {
                                Name = "Element_Payment",
                                Path= "Contract.term.asset.valuedItem.payment",
                                Id = "Contract.term.asset.valuedItem.payment",
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
                            // 87. Contract.term.asset.valuedItem.paymentDate
                            this.Element_PaymentDate = new ElementDefinitionInfo
                            {
                                Name = "Element_PaymentDate",
                                Path= "Contract.term.asset.valuedItem.paymentDate",
                                Id = "Contract.term.asset.valuedItem.paymentDate",
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
                            // 88. Contract.term.asset.valuedItem.responsible
                            this.Element_Responsible = new ElementDefinitionInfo
                            {
                                Name = "Element_Responsible",
                                Path= "Contract.term.asset.valuedItem.responsible",
                                Id = "Contract.term.asset.valuedItem.responsible",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                        TargetProfile = new String[]
                                        {
                                            "http://hl7.org/fhir/StructureDefinition/Organization",
                                            "http://hl7.org/fhir/StructureDefinition/Patient",
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                        }
                                    }
                                }
                            };
                        }
                        {
                            // 89. Contract.term.asset.valuedItem.recipient
                            this.Element_Recipient = new ElementDefinitionInfo
                            {
                                Name = "Element_Recipient",
                                Path= "Contract.term.asset.valuedItem.recipient",
                                Id = "Contract.term.asset.valuedItem.recipient",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                        TargetProfile = new String[]
                                        {
                                            "http://hl7.org/fhir/StructureDefinition/Organization",
                                            "http://hl7.org/fhir/StructureDefinition/Patient",
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                        }
                                    }
                                }
                            };
                        }
                        {
                            // 90. Contract.term.asset.valuedItem.linkId
                            this.Element_LinkId = new ElementDefinitionInfo
                            {
                                Name = "Element_LinkId",
                                Path= "Contract.term.asset.valuedItem.linkId",
                                Id = "Contract.term.asset.valuedItem.linkId",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 91. Contract.term.asset.valuedItem.securityLabelNumber
                            this.Element_SecurityLabelNumber = new ElementDefinitionInfo
                            {
                                Name = "Element_SecurityLabelNumber",
                                Path= "Contract.term.asset.valuedItem.securityLabelNumber",
                                Id = "Contract.term.asset.valuedItem.securityLabelNumber",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 60. Contract.term.asset.scope
                public ElementDefinitionInfo Element_Scope;
                // 61. Contract.term.asset.type
                public ElementDefinitionInfo Element_Type;
                // 62. Contract.term.asset.typeReference
                public ElementDefinitionInfo Element_TypeReference;
                // 63. Contract.term.asset.subtype
                public ElementDefinitionInfo Element_Subtype;
                // 64. Contract.term.asset.relationship
                public ElementDefinitionInfo Element_Relationship;
                // 65. Contract.term.asset.context
                public ElementDefinitionInfo Element_Context;
                // 69. Contract.term.asset.condition
                public ElementDefinitionInfo Element_Condition;
                // 70. Contract.term.asset.periodType
                public ElementDefinitionInfo Element_PeriodType;
                // 71. Contract.term.asset.period
                public ElementDefinitionInfo Element_Period;
                // 72. Contract.term.asset.usePeriod
                public ElementDefinitionInfo Element_UsePeriod;
                // 73. Contract.term.asset.text
                public ElementDefinitionInfo Element_Text;
                // 74. Contract.term.asset.linkId
                public ElementDefinitionInfo Element_LinkId;
                // 75. Contract.term.asset.answer
                public ElementDefinitionInfo Element_Answer;
                // 76. Contract.term.asset.securityLabelNumber
                public ElementDefinitionInfo Element_SecurityLabelNumber;
                // 77. Contract.term.asset.valuedItem
                public ElementDefinitionInfo Element_ValuedItem;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Contract.term.asset",
                        ElementId = "Contract.term.asset"
                    });
                    Element_Scope.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_TypeReference.Write(sDef);
                    Element_Subtype.Write(sDef);
                    Element_Relationship.Write(sDef);
                    Element_Context.Write(sDef);
                    Element_Condition.Write(sDef);
                    Element_PeriodType.Write(sDef);
                    Element_Period.Write(sDef);
                    Element_UsePeriod.Write(sDef);
                    Element_Text.Write(sDef);
                    Element_LinkId.Write(sDef);
                    Element_Answer.Write(sDef);
                    Element_SecurityLabelNumber.Write(sDef);
                    Element_ValuedItem.Write(sDef);
                }
                
                public Type_Asset()
                {
                    {
                        // 60. Contract.term.asset.scope
                        this.Element_Scope = new ElementDefinitionInfo
                        {
                            Name = "Element_Scope",
                            Path= "Contract.term.asset.scope",
                            Id = "Contract.term.asset.scope",
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
                        // 61. Contract.term.asset.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "Contract.term.asset.type",
                            Id = "Contract.term.asset.type",
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
                        // 62. Contract.term.asset.typeReference
                        this.Element_TypeReference = new ElementDefinitionInfo
                        {
                            Name = "Element_TypeReference",
                            Path= "Contract.term.asset.typeReference",
                            Id = "Contract.term.asset.typeReference",
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
                    {
                        // 63. Contract.term.asset.subtype
                        this.Element_Subtype = new ElementDefinitionInfo
                        {
                            Name = "Element_Subtype",
                            Path= "Contract.term.asset.subtype",
                            Id = "Contract.term.asset.subtype",
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
                        // 64. Contract.term.asset.relationship
                        this.Element_Relationship = new ElementDefinitionInfo
                        {
                            Name = "Element_Relationship",
                            Path= "Contract.term.asset.relationship",
                            Id = "Contract.term.asset.relationship",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                    {
                        // 65. Contract.term.asset.context
                        this.Element_Context = new ElementDefinitionInfo
                        {
                            Name = "Element_Context",
                            Path= "Contract.term.asset.context",
                            Id = "Contract.term.asset.context",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Context
                                {
                                }
                            }
                        };
                    }
                    {
                        // 69. Contract.term.asset.condition
                        this.Element_Condition = new ElementDefinitionInfo
                        {
                            Name = "Element_Condition",
                            Path= "Contract.term.asset.condition",
                            Id = "Contract.term.asset.condition",
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
                        // 70. Contract.term.asset.periodType
                        this.Element_PeriodType = new ElementDefinitionInfo
                        {
                            Name = "Element_PeriodType",
                            Path= "Contract.term.asset.periodType",
                            Id = "Contract.term.asset.periodType",
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
                        // 71. Contract.term.asset.period
                        this.Element_Period = new ElementDefinitionInfo
                        {
                            Name = "Element_Period",
                            Path= "Contract.term.asset.period",
                            Id = "Contract.term.asset.period",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Period
                                {
                                }
                            }
                        };
                    }
                    {
                        // 72. Contract.term.asset.usePeriod
                        this.Element_UsePeriod = new ElementDefinitionInfo
                        {
                            Name = "Element_UsePeriod",
                            Path= "Contract.term.asset.usePeriod",
                            Id = "Contract.term.asset.usePeriod",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Period
                                {
                                }
                            }
                        };
                    }
                    {
                        // 73. Contract.term.asset.text
                        this.Element_Text = new ElementDefinitionInfo
                        {
                            Name = "Element_Text",
                            Path= "Contract.term.asset.text",
                            Id = "Contract.term.asset.text",
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
                        // 74. Contract.term.asset.linkId
                        this.Element_LinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_LinkId",
                            Path= "Contract.term.asset.linkId",
                            Id = "Contract.term.asset.linkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 75. Contract.term.asset.answer
                        this.Element_Answer = new ElementDefinitionInfo
                        {
                            Name = "Element_Answer",
                            Path= "Contract.term.asset.answer",
                            Id = "Contract.term.asset.answer",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 76. Contract.term.asset.securityLabelNumber
                        this.Element_SecurityLabelNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_SecurityLabelNumber",
                            Path= "Contract.term.asset.securityLabelNumber",
                            Id = "Contract.term.asset.securityLabelNumber",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                {
                                }
                            }
                        };
                    }
                    {
                        // 77. Contract.term.asset.valuedItem
                        this.Element_ValuedItem = new ElementDefinitionInfo
                        {
                            Name = "Element_ValuedItem",
                            Path= "Contract.term.asset.valuedItem",
                            Id = "Contract.term.asset.valuedItem",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_ValuedItem
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 92. Contract.term.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 95. Contract.term.action.subject
                public class Type_Subject : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 96. Contract.term.action.subject.reference
                    public ElementDefinitionInfo Element_Reference;
                    // 97. Contract.term.action.subject.role
                    public ElementDefinitionInfo Element_Role;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Contract.term.action.subject",
                            ElementId = "Contract.term.action.subject"
                        });
                        Element_Reference.Write(sDef);
                        Element_Role.Write(sDef);
                    }
                    
                    public Type_Subject()
                    {
                        {
                            // 96. Contract.term.action.subject.reference
                            this.Element_Reference = new ElementDefinitionInfo
                            {
                                Name = "Element_Reference",
                                Path= "Contract.term.action.subject.reference",
                                Id = "Contract.term.action.subject.reference",
                                Min = 1,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                        TargetProfile = new String[]
                                        {
                                            "http://hl7.org/fhir/StructureDefinition/Patient",
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                            "http://hl7.org/fhir/StructureDefinition/Device",
                                            "http://hl7.org/fhir/StructureDefinition/Group",
                                            "http://hl7.org/fhir/StructureDefinition/Organization"
                                        }
                                    }
                                }
                            };
                        }
                        {
                            // 97. Contract.term.action.subject.role
                            this.Element_Role = new ElementDefinitionInfo
                            {
                                Name = "Element_Role",
                                Path= "Contract.term.action.subject.role",
                                Id = "Contract.term.action.subject.role",
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
                    }
                }
                // 93. Contract.term.action.doNotPerform
                public ElementDefinitionInfo Element_DoNotPerform;
                // 94. Contract.term.action.type
                public ElementDefinitionInfo Element_Type;
                // 95. Contract.term.action.subject
                public ElementDefinitionInfo Element_Subject;
                // 98. Contract.term.action.intent
                public ElementDefinitionInfo Element_Intent;
                // 99. Contract.term.action.linkId
                public ElementDefinitionInfo Element_LinkId;
                // 100. Contract.term.action.status
                public ElementDefinitionInfo Element_Status;
                // 101. Contract.term.action.context
                public ElementDefinitionInfo Element_Context;
                // 102. Contract.term.action.contextLinkId
                public ElementDefinitionInfo Element_ContextLinkId;
                // 103. Contract.term.action.occurrence[x]
                public ElementDefinitionInfo Element_Occurrence;
                // 104. Contract.term.action.requester
                public ElementDefinitionInfo Element_Requester;
                // 105. Contract.term.action.requesterLinkId
                public ElementDefinitionInfo Element_RequesterLinkId;
                // 106. Contract.term.action.performerType
                public ElementDefinitionInfo Element_PerformerType;
                // 107. Contract.term.action.performerRole
                public ElementDefinitionInfo Element_PerformerRole;
                // 108. Contract.term.action.performer
                public ElementDefinitionInfo Element_Performer;
                // 109. Contract.term.action.performerLinkId
                public ElementDefinitionInfo Element_PerformerLinkId;
                // 110. Contract.term.action.reasonCode
                public ElementDefinitionInfo Element_ReasonCode;
                // 111. Contract.term.action.reasonReference
                public ElementDefinitionInfo Element_ReasonReference;
                // 112. Contract.term.action.reason
                public ElementDefinitionInfo Element_Reason;
                // 113. Contract.term.action.reasonLinkId
                public ElementDefinitionInfo Element_ReasonLinkId;
                // 114. Contract.term.action.note
                public ElementDefinitionInfo Element_Note;
                // 115. Contract.term.action.securityLabelNumber
                public ElementDefinitionInfo Element_SecurityLabelNumber;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Contract.term.action",
                        ElementId = "Contract.term.action"
                    });
                    Element_DoNotPerform.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_Subject.Write(sDef);
                    Element_Intent.Write(sDef);
                    Element_LinkId.Write(sDef);
                    Element_Status.Write(sDef);
                    Element_Context.Write(sDef);
                    Element_ContextLinkId.Write(sDef);
                    Element_Occurrence.Write(sDef);
                    Element_Requester.Write(sDef);
                    Element_RequesterLinkId.Write(sDef);
                    Element_PerformerType.Write(sDef);
                    Element_PerformerRole.Write(sDef);
                    Element_Performer.Write(sDef);
                    Element_PerformerLinkId.Write(sDef);
                    Element_ReasonCode.Write(sDef);
                    Element_ReasonReference.Write(sDef);
                    Element_Reason.Write(sDef);
                    Element_ReasonLinkId.Write(sDef);
                    Element_Note.Write(sDef);
                    Element_SecurityLabelNumber.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 93. Contract.term.action.doNotPerform
                        this.Element_DoNotPerform = new ElementDefinitionInfo
                        {
                            Name = "Element_DoNotPerform",
                            Path= "Contract.term.action.doNotPerform",
                            Id = "Contract.term.action.doNotPerform",
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
                        // 94. Contract.term.action.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "Contract.term.action.type",
                            Id = "Contract.term.action.type",
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
                        // 95. Contract.term.action.subject
                        this.Element_Subject = new ElementDefinitionInfo
                        {
                            Name = "Element_Subject",
                            Path= "Contract.term.action.subject",
                            Id = "Contract.term.action.subject",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Subject
                                {
                                }
                            }
                        };
                    }
                    {
                        // 98. Contract.term.action.intent
                        this.Element_Intent = new ElementDefinitionInfo
                        {
                            Name = "Element_Intent",
                            Path= "Contract.term.action.intent",
                            Id = "Contract.term.action.intent",
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
                        // 99. Contract.term.action.linkId
                        this.Element_LinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_LinkId",
                            Path= "Contract.term.action.linkId",
                            Id = "Contract.term.action.linkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 100. Contract.term.action.status
                        this.Element_Status = new ElementDefinitionInfo
                        {
                            Name = "Element_Status",
                            Path= "Contract.term.action.status",
                            Id = "Contract.term.action.status",
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
                        // 101. Contract.term.action.context
                        this.Element_Context = new ElementDefinitionInfo
                        {
                            Name = "Element_Context",
                            Path= "Contract.term.action.context",
                            Id = "Contract.term.action.context",
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
                        // 102. Contract.term.action.contextLinkId
                        this.Element_ContextLinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_ContextLinkId",
                            Path= "Contract.term.action.contextLinkId",
                            Id = "Contract.term.action.contextLinkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 103. Contract.term.action.occurrence[x]
                        this.Element_Occurrence = new ElementDefinitionInfo
                        {
                            Name = "Element_Occurrence",
                            Path= "Contract.term.action.occurrence[x]",
                            Id = "Contract.term.action.occurrence[x]",
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
                        // 104. Contract.term.action.requester
                        this.Element_Requester = new ElementDefinitionInfo
                        {
                            Name = "Element_Requester",
                            Path= "Contract.term.action.requester",
                            Id = "Contract.term.action.requester",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Patient",
                                        "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                        "http://hl7.org/fhir/StructureDefinition/Device",
                                        "http://hl7.org/fhir/StructureDefinition/Group",
                                        "http://hl7.org/fhir/StructureDefinition/Organization"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 105. Contract.term.action.requesterLinkId
                        this.Element_RequesterLinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_RequesterLinkId",
                            Path= "Contract.term.action.requesterLinkId",
                            Id = "Contract.term.action.requesterLinkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 106. Contract.term.action.performerType
                        this.Element_PerformerType = new ElementDefinitionInfo
                        {
                            Name = "Element_PerformerType",
                            Path= "Contract.term.action.performerType",
                            Id = "Contract.term.action.performerType",
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
                        // 107. Contract.term.action.performerRole
                        this.Element_PerformerRole = new ElementDefinitionInfo
                        {
                            Name = "Element_PerformerRole",
                            Path= "Contract.term.action.performerRole",
                            Id = "Contract.term.action.performerRole",
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
                        // 108. Contract.term.action.performer
                        this.Element_Performer = new ElementDefinitionInfo
                        {
                            Name = "Element_Performer",
                            Path= "Contract.term.action.performer",
                            Id = "Contract.term.action.performer",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                        "http://hl7.org/fhir/StructureDefinition/Patient",
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                        "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                        "http://hl7.org/fhir/StructureDefinition/Device",
                                        "http://hl7.org/fhir/StructureDefinition/Substance",
                                        "http://hl7.org/fhir/StructureDefinition/Organization",
                                        "http://hl7.org/fhir/StructureDefinition/Location"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 109. Contract.term.action.performerLinkId
                        this.Element_PerformerLinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_PerformerLinkId",
                            Path= "Contract.term.action.performerLinkId",
                            Id = "Contract.term.action.performerLinkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 110. Contract.term.action.reasonCode
                        this.Element_ReasonCode = new ElementDefinitionInfo
                        {
                            Name = "Element_ReasonCode",
                            Path= "Contract.term.action.reasonCode",
                            Id = "Contract.term.action.reasonCode",
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
                        // 111. Contract.term.action.reasonReference
                        this.Element_ReasonReference = new ElementDefinitionInfo
                        {
                            Name = "Element_ReasonReference",
                            Path= "Contract.term.action.reasonReference",
                            Id = "Contract.term.action.reasonReference",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Condition",
                                        "http://hl7.org/fhir/StructureDefinition/Observation",
                                        "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                        "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                        "http://hl7.org/fhir/StructureDefinition/Questionnaire",
                                        "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 112. Contract.term.action.reason
                        this.Element_Reason = new ElementDefinitionInfo
                        {
                            Name = "Element_Reason",
                            Path= "Contract.term.action.reason",
                            Id = "Contract.term.action.reason",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 113. Contract.term.action.reasonLinkId
                        this.Element_ReasonLinkId = new ElementDefinitionInfo
                        {
                            Name = "Element_ReasonLinkId",
                            Path= "Contract.term.action.reasonLinkId",
                            Id = "Contract.term.action.reasonLinkId",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 114. Contract.term.action.note
                        this.Element_Note = new ElementDefinitionInfo
                        {
                            Name = "Element_Note",
                            Path= "Contract.term.action.note",
                            Id = "Contract.term.action.note",
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
                        // 115. Contract.term.action.securityLabelNumber
                        this.Element_SecurityLabelNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_SecurityLabelNumber",
                            Path= "Contract.term.action.securityLabelNumber",
                            Id = "Contract.term.action.securityLabelNumber",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 33. Contract.term.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 34. Contract.term.issued
            public ElementDefinitionInfo Element_Issued;
            // 35. Contract.term.applies
            public ElementDefinitionInfo Element_Applies;
            // 36. Contract.term.topic[x]
            public ElementDefinitionInfo Element_Topic;
            // 37. Contract.term.type
            public ElementDefinitionInfo Element_Type;
            // 38. Contract.term.subType
            public ElementDefinitionInfo Element_SubType;
            // 39. Contract.term.text
            public ElementDefinitionInfo Element_Text;
            // 40. Contract.term.securityLabel
            public ElementDefinitionInfo Element_SecurityLabel;
            // 45. Contract.term.offer
            public ElementDefinitionInfo Element_Offer;
            // 59. Contract.term.asset
            public ElementDefinitionInfo Element_Asset;
            // 92. Contract.term.action
            public ElementDefinitionInfo Element_Action;
            // 116. Contract.term.group
            public ElementDefinitionInfo Element_Group;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.term",
                    ElementId = "Contract.term"
                });
                Element_Identifier.Write(sDef);
                Element_Issued.Write(sDef);
                Element_Applies.Write(sDef);
                Element_Topic.Write(sDef);
                Element_Type.Write(sDef);
                Element_SubType.Write(sDef);
                Element_Text.Write(sDef);
                Element_SecurityLabel.Write(sDef);
                Element_Offer.Write(sDef);
                Element_Asset.Write(sDef);
                Element_Action.Write(sDef);
                Element_Group.Write(sDef);
            }
            
            public Type_Term()
            {
                {
                    // 33. Contract.term.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "Contract.term.identifier",
                        Id = "Contract.term.identifier",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 34. Contract.term.issued
                    this.Element_Issued = new ElementDefinitionInfo
                    {
                        Name = "Element_Issued",
                        Path= "Contract.term.issued",
                        Id = "Contract.term.issued",
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
                    // 35. Contract.term.applies
                    this.Element_Applies = new ElementDefinitionInfo
                    {
                        Name = "Element_Applies",
                        Path= "Contract.term.applies",
                        Id = "Contract.term.applies",
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
                    // 36. Contract.term.topic[x]
                    this.Element_Topic = new ElementDefinitionInfo
                    {
                        Name = "Element_Topic",
                        Path= "Contract.term.topic[x]",
                        Id = "Contract.term.topic[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
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
                {
                    // 37. Contract.term.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Contract.term.type",
                        Id = "Contract.term.type",
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
                    // 38. Contract.term.subType
                    this.Element_SubType = new ElementDefinitionInfo
                    {
                        Name = "Element_SubType",
                        Path= "Contract.term.subType",
                        Id = "Contract.term.subType",
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
                    // 39. Contract.term.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "Contract.term.text",
                        Id = "Contract.term.text",
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
                    // 40. Contract.term.securityLabel
                    this.Element_SecurityLabel = new ElementDefinitionInfo
                    {
                        Name = "Element_SecurityLabel",
                        Path= "Contract.term.securityLabel",
                        Id = "Contract.term.securityLabel",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_SecurityLabel
                            {
                            }
                        }
                    };
                }
                {
                    // 45. Contract.term.offer
                    this.Element_Offer = new ElementDefinitionInfo
                    {
                        Name = "Element_Offer",
                        Path= "Contract.term.offer",
                        Id = "Contract.term.offer",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Offer
                            {
                            }
                        }
                    };
                }
                {
                    // 59. Contract.term.asset
                    this.Element_Asset = new ElementDefinitionInfo
                    {
                        Name = "Element_Asset",
                        Path= "Contract.term.asset",
                        Id = "Contract.term.asset",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Asset
                            {
                            }
                        }
                    };
                }
                {
                    // 92. Contract.term.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "Contract.term.action",
                        Id = "Contract.term.action",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
                {
                    // 116. Contract.term.group
                    this.Element_Group = new ElementDefinitionInfo
                    {
                        Name = "Element_Group",
                        Path= "Contract.term.group",
                        Id = "Contract.term.group",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 119. Contract.signer
        public class Type_Signer : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 120. Contract.signer.type
            public ElementDefinitionInfo Element_Type;
            // 121. Contract.signer.party
            public ElementDefinitionInfo Element_Party;
            // 122. Contract.signer.signature
            public ElementDefinitionInfo Element_Signature;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.signer",
                    ElementId = "Contract.signer"
                });
                Element_Type.Write(sDef);
                Element_Party.Write(sDef);
                Element_Signature.Write(sDef);
            }
            
            public Type_Signer()
            {
                {
                    // 120. Contract.signer.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Contract.signer.type",
                        Id = "Contract.signer.type",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 121. Contract.signer.party
                    this.Element_Party = new ElementDefinitionInfo
                    {
                        Name = "Element_Party",
                        Path= "Contract.signer.party",
                        Id = "Contract.signer.party",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
                {
                    // 122. Contract.signer.signature
                    this.Element_Signature = new ElementDefinitionInfo
                    {
                        Name = "Element_Signature",
                        Path= "Contract.signer.signature",
                        Id = "Contract.signer.signature",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Signature
                            {
                            }
                        }
                    };
                }
            }
        }
        // 123. Contract.friendly
        public class Type_Friendly : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 124. Contract.friendly.content[x]
            public ElementDefinitionInfo Element_Content;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.friendly",
                    ElementId = "Contract.friendly"
                });
                Element_Content.Write(sDef);
            }
            
            public Type_Friendly()
            {
                {
                    // 124. Contract.friendly.content[x]
                    this.Element_Content = new ElementDefinitionInfo
                    {
                        Name = "Element_Content",
                        Path= "Contract.friendly.content[x]",
                        Id = "Contract.friendly.content[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Composition",
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 125. Contract.legal
        public class Type_Legal : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 126. Contract.legal.content[x]
            public ElementDefinitionInfo Element_Content;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.legal",
                    ElementId = "Contract.legal"
                });
                Element_Content.Write(sDef);
            }
            
            public Type_Legal()
            {
                {
                    // 126. Contract.legal.content[x]
                    this.Element_Content = new ElementDefinitionInfo
                    {
                        Name = "Element_Content",
                        Path= "Contract.legal.content[x]",
                        Id = "Contract.legal.content[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Composition",
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 127. Contract.rule
        public class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 128. Contract.rule.content[x]
            public ElementDefinitionInfo Element_Content;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Contract.rule",
                    ElementId = "Contract.rule"
                });
                Element_Content.Write(sDef);
            }
            
            public Type_Rule()
            {
                {
                    // 128. Contract.rule.content[x]
                    this.Element_Content = new ElementDefinitionInfo
                    {
                        Name = "Element_Content",
                        Path= "Contract.rule.content[x]",
                        Id = "Contract.rule.content[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. Contract.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Contract.url
        public ElementDefinitionInfo Element_Url;
        // 3. Contract.version
        public ElementDefinitionInfo Element_Version;
        // 4. Contract.status
        public ElementDefinitionInfo Element_Status;
        // 5. Contract.legalState
        public ElementDefinitionInfo Element_LegalState;
        // 6. Contract.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 7. Contract.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 8. Contract.contentDerivative
        public ElementDefinitionInfo Element_ContentDerivative;
        // 9. Contract.issued
        public ElementDefinitionInfo Element_Issued;
        // 10. Contract.applies
        public ElementDefinitionInfo Element_Applies;
        // 11. Contract.expirationType
        public ElementDefinitionInfo Element_ExpirationType;
        // 12. Contract.subject
        public ElementDefinitionInfo Element_Subject;
        // 13. Contract.authority
        public ElementDefinitionInfo Element_Authority;
        // 14. Contract.domain
        public ElementDefinitionInfo Element_Domain;
        // 15. Contract.site
        public ElementDefinitionInfo Element_Site;
        // 16. Contract.name
        public ElementDefinitionInfo Element_Name;
        // 17. Contract.title
        public ElementDefinitionInfo Element_Title;
        // 18. Contract.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 19. Contract.alias
        public ElementDefinitionInfo Element_Alias;
        // 20. Contract.author
        public ElementDefinitionInfo Element_Author;
        // 21. Contract.scope
        public ElementDefinitionInfo Element_Scope;
        // 22. Contract.topic[x]
        public ElementDefinitionInfo Element_Topic;
        // 23. Contract.type
        public ElementDefinitionInfo Element_Type;
        // 24. Contract.subType
        public ElementDefinitionInfo Element_SubType;
        // 25. Contract.contentDefinition
        public ElementDefinitionInfo Element_ContentDefinition;
        // 32. Contract.term
        public ElementDefinitionInfo Element_Term;
        // 117. Contract.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 118. Contract.relevantHistory
        public ElementDefinitionInfo Element_RelevantHistory;
        // 119. Contract.signer
        public ElementDefinitionInfo Element_Signer;
        // 123. Contract.friendly
        public ElementDefinitionInfo Element_Friendly;
        // 125. Contract.legal
        public ElementDefinitionInfo Element_Legal;
        // 127. Contract.rule
        public ElementDefinitionInfo Element_Rule;
        // 129. Contract.legallyBinding[x]
        public ElementDefinitionInfo Element_LegallyBinding;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Contract",
                ElementId = "Contract"
            });
            Element_Identifier.Write(sDef);
            Element_Url.Write(sDef);
            Element_Version.Write(sDef);
            Element_Status.Write(sDef);
            Element_LegalState.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_ContentDerivative.Write(sDef);
            Element_Issued.Write(sDef);
            Element_Applies.Write(sDef);
            Element_ExpirationType.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Authority.Write(sDef);
            Element_Domain.Write(sDef);
            Element_Site.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Subtitle.Write(sDef);
            Element_Alias.Write(sDef);
            Element_Author.Write(sDef);
            Element_Scope.Write(sDef);
            Element_Topic.Write(sDef);
            Element_Type.Write(sDef);
            Element_SubType.Write(sDef);
            Element_ContentDefinition.Write(sDef);
            Element_Term.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_RelevantHistory.Write(sDef);
            Element_Signer.Write(sDef);
            Element_Friendly.Write(sDef);
            Element_Legal.Write(sDef);
            Element_Rule.Write(sDef);
            Element_LegallyBinding.Write(sDef);
        }
        
        public Resource_Contract()
        {
            {
                // 1. Contract.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Contract.identifier",
                    Id = "Contract.identifier",
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
                // 2. Contract.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "Contract.url",
                    Id = "Contract.url",
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
                // 3. Contract.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "Contract.version",
                    Id = "Contract.version",
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
                // 4. Contract.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Contract.status",
                    Id = "Contract.status",
                    Min = 0,
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
                // 5. Contract.legalState
                this.Element_LegalState = new ElementDefinitionInfo
                {
                    Name = "Element_LegalState",
                    Path= "Contract.legalState",
                    Id = "Contract.legalState",
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
                // 6. Contract.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "Contract.instantiatesCanonical",
                    Id = "Contract.instantiatesCanonical",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Contract"
                            }
                        }
                    }
                };
            }
            {
                // 7. Contract.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "Contract.instantiatesUri",
                    Id = "Contract.instantiatesUri",
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
                // 8. Contract.contentDerivative
                this.Element_ContentDerivative = new ElementDefinitionInfo
                {
                    Name = "Element_ContentDerivative",
                    Path= "Contract.contentDerivative",
                    Id = "Contract.contentDerivative",
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
                // 9. Contract.issued
                this.Element_Issued = new ElementDefinitionInfo
                {
                    Name = "Element_Issued",
                    Path= "Contract.issued",
                    Id = "Contract.issued",
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
                // 10. Contract.applies
                this.Element_Applies = new ElementDefinitionInfo
                {
                    Name = "Element_Applies",
                    Path= "Contract.applies",
                    Id = "Contract.applies",
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
                // 11. Contract.expirationType
                this.Element_ExpirationType = new ElementDefinitionInfo
                {
                    Name = "Element_ExpirationType",
                    Path= "Contract.expirationType",
                    Id = "Contract.expirationType",
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
                // 12. Contract.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Contract.subject",
                    Id = "Contract.subject",
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
            {
                // 13. Contract.authority
                this.Element_Authority = new ElementDefinitionInfo
                {
                    Name = "Element_Authority",
                    Path= "Contract.authority",
                    Id = "Contract.authority",
                    Min = 0,
                    Max = -1,
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
                // 14. Contract.domain
                this.Element_Domain = new ElementDefinitionInfo
                {
                    Name = "Element_Domain",
                    Path= "Contract.domain",
                    Id = "Contract.domain",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 15. Contract.site
                this.Element_Site = new ElementDefinitionInfo
                {
                    Name = "Element_Site",
                    Path= "Contract.site",
                    Id = "Contract.site",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 16. Contract.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Contract.name",
                    Id = "Contract.name",
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
                // 17. Contract.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "Contract.title",
                    Id = "Contract.title",
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
                // 18. Contract.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "Contract.subtitle",
                    Id = "Contract.subtitle",
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
                // 19. Contract.alias
                this.Element_Alias = new ElementDefinitionInfo
                {
                    Name = "Element_Alias",
                    Path= "Contract.alias",
                    Id = "Contract.alias",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 20. Contract.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "Contract.author",
                    Id = "Contract.author",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 21. Contract.scope
                this.Element_Scope = new ElementDefinitionInfo
                {
                    Name = "Element_Scope",
                    Path= "Contract.scope",
                    Id = "Contract.scope",
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
                // 22. Contract.topic[x]
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "Contract.topic[x]",
                    Id = "Contract.topic[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        },
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
            {
                // 23. Contract.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Contract.type",
                    Id = "Contract.type",
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
                // 24. Contract.subType
                this.Element_SubType = new ElementDefinitionInfo
                {
                    Name = "Element_SubType",
                    Path= "Contract.subType",
                    Id = "Contract.subType",
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
                // 25. Contract.contentDefinition
                this.Element_ContentDefinition = new ElementDefinitionInfo
                {
                    Name = "Element_ContentDefinition",
                    Path= "Contract.contentDefinition",
                    Id = "Contract.contentDefinition",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_ContentDefinition
                        {
                        }
                    }
                };
            }
            {
                // 32. Contract.term
                this.Element_Term = new ElementDefinitionInfo
                {
                    Name = "Element_Term",
                    Path= "Contract.term",
                    Id = "Contract.term",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Term
                        {
                        }
                    }
                };
            }
            {
                // 117. Contract.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "Contract.supportingInfo",
                    Id = "Contract.supportingInfo",
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
            {
                // 118. Contract.relevantHistory
                this.Element_RelevantHistory = new ElementDefinitionInfo
                {
                    Name = "Element_RelevantHistory",
                    Path= "Contract.relevantHistory",
                    Id = "Contract.relevantHistory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Provenance"
                            }
                        }
                    }
                };
            }
            {
                // 119. Contract.signer
                this.Element_Signer = new ElementDefinitionInfo
                {
                    Name = "Element_Signer",
                    Path= "Contract.signer",
                    Id = "Contract.signer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Signer
                        {
                        }
                    }
                };
            }
            {
                // 123. Contract.friendly
                this.Element_Friendly = new ElementDefinitionInfo
                {
                    Name = "Element_Friendly",
                    Path= "Contract.friendly",
                    Id = "Contract.friendly",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Friendly
                        {
                        }
                    }
                };
            }
            {
                // 125. Contract.legal
                this.Element_Legal = new ElementDefinitionInfo
                {
                    Name = "Element_Legal",
                    Path= "Contract.legal",
                    Id = "Contract.legal",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Legal
                        {
                        }
                    }
                };
            }
            {
                // 127. Contract.rule
                this.Element_Rule = new ElementDefinitionInfo
                {
                    Name = "Element_Rule",
                    Path= "Contract.rule",
                    Id = "Contract.rule",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Rule
                        {
                        }
                    }
                };
            }
            {
                // 129. Contract.legallyBinding[x]
                this.Element_LegallyBinding = new ElementDefinitionInfo
                {
                    Name = "Element_LegallyBinding",
                    Path= "Contract.legallyBinding[x]",
                    Id = "Contract.legallyBinding[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Composition",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                "http://hl7.org/fhir/StructureDefinition/Contract"
                            }
                        }
                    }
                };
            }
            this.Name = "Contract";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Contract";
        }
    }
}
