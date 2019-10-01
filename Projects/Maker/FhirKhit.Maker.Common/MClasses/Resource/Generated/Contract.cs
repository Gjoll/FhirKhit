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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'Contract'
    /// </summary>
    // 0. Contract
    public class Contract : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 25. Contract.contentDefinition
        public class Type_ContentDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 26. Contract.contentDefinition.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 27. Contract.contentDefinition.subType
            public MakerElementInstance Element_SubType;                                                                                    // MakerGen.cs:232
            // 28. Contract.contentDefinition.publisher
            public MakerElementInstance Element_Publisher;                                                                                  // MakerGen.cs:232
            // 29. Contract.contentDefinition.publicationDate
            public MakerElementInstance Element_PublicationDate;                                                                            // MakerGen.cs:232
            // 30. Contract.contentDefinition.publicationStatus
            public MakerElementInstance Element_PublicationStatus;                                                                          // MakerGen.cs:232
            // 31. Contract.contentDefinition.copyright
            public MakerElementInstance Element_Copyright;                                                                                  // MakerGen.cs:232
            public Type_ContentDefinition()                                                                                                 // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 26. Contract.contentDefinition.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 27. Contract.contentDefinition.subType
                    this.Element_SubType = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SubType",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 28. Contract.contentDefinition.publisher
                    this.Element_Publisher = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Publisher",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 29. Contract.contentDefinition.publicationDate
                    this.Element_PublicationDate = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PublicationDate",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 30. Contract.contentDefinition.publicationStatus
                    this.Element_PublicationStatus = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PublicationStatus",                                                                                 // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 31. Contract.contentDefinition.copyright
                    this.Element_Copyright = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Copyright",                                                                                         // MakerGen.cs:247
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
        // 32. Contract.term
        public class Type_Term : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 40. Contract.term.securityLabel
            public class Type_SecurityLabel : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 41. Contract.term.securityLabel.number
                public MakerElementInstance Element_Number;                                                                                 // MakerGen.cs:232
                // 42. Contract.term.securityLabel.classification
                public MakerElementInstance Element_Classification;                                                                         // MakerGen.cs:232
                // 43. Contract.term.securityLabel.category
                public MakerElementInstance Element_Category;                                                                               // MakerGen.cs:232
                // 44. Contract.term.securityLabel.control
                public MakerElementInstance Element_Control;                                                                                // MakerGen.cs:232
                public Type_SecurityLabel()                                                                                                 // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 41. Contract.term.securityLabel.number
                        this.Element_Number = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Number",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 42. Contract.term.securityLabel.classification
                        this.Element_Classification = new MakerElementInstance                                                              // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Classification",                                                                                // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 43. Contract.term.securityLabel.category
                        this.Element_Category = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Category",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 44. Contract.term.securityLabel.control
                        this.Element_Control = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Control",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 45. Contract.term.offer
            public class Type_Offer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 47. Contract.term.offer.party
                public class Type_Party : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 48. Contract.term.offer.party.reference
                    public MakerElementInstance Element_Reference;                                                                          // MakerGen.cs:232
                    // 49. Contract.term.offer.party.role
                    public MakerElementInstance Element_Role;                                                                               // MakerGen.cs:232
                    public Type_Party()                                                                                                     // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 48. Contract.term.offer.party.reference
                            this.Element_Reference = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Reference",                                                                                 // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 49. Contract.term.offer.party.role
                            this.Element_Role = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Role",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 54. Contract.term.offer.answer
                public class Type_Answer : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 55. Contract.term.offer.answer.value[x]
                    public MakerElementInstance Element_Value;                                                                              // MakerGen.cs:232
                    public Type_Answer()                                                                                                    // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 55. Contract.term.offer.answer.value[x]
                            this.Element_Value = new MakerElementInstance                                                                   // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Value",                                                                                     // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Boolean(),                                                          // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.Decimal(),                                                          // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.Integer(),                                                          // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.Date(),                                                             // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.DateTime(),                                                         // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.Time(),                                                             // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.String(),                                                           // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Primitive.Uri(),                                                              // MakerGen.cs:286
                                    new FhirKhit.Maker.Common.Complex.Coding(),                                                             // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 46. Contract.term.offer.identifier
                public MakerElementInstance Element_Identifier;                                                                             // MakerGen.cs:232
                // 50. Contract.term.offer.topic
                public MakerElementInstance Element_Topic;                                                                                  // MakerGen.cs:232
                // 51. Contract.term.offer.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 52. Contract.term.offer.decision
                public MakerElementInstance Element_Decision;                                                                               // MakerGen.cs:232
                // 53. Contract.term.offer.decisionMode
                public MakerElementInstance Element_DecisionMode;                                                                           // MakerGen.cs:232
                // 56. Contract.term.offer.text
                public MakerElementInstance Element_Text;                                                                                   // MakerGen.cs:232
                // 57. Contract.term.offer.linkId
                public MakerElementInstance Element_LinkId;                                                                                 // MakerGen.cs:232
                // 58. Contract.term.offer.securityLabelNumber
                public MakerElementInstance Element_SecurityLabelNumber;                                                                    // MakerGen.cs:232
                public Type_Offer()                                                                                                         // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 46. Contract.term.offer.identifier
                        this.Element_Identifier = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Identifier",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 50. Contract.term.offer.topic
                        this.Element_Topic = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Topic",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 51. Contract.term.offer.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 52. Contract.term.offer.decision
                        this.Element_Decision = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Decision",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 53. Contract.term.offer.decisionMode
                        this.Element_DecisionMode = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_DecisionMode",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 56. Contract.term.offer.text
                        this.Element_Text = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Text",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 57. Contract.term.offer.linkId
                        this.Element_LinkId = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_LinkId",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 58. Contract.term.offer.securityLabelNumber
                        this.Element_SecurityLabelNumber = new MakerElementInstance                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SecurityLabelNumber",                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 59. Contract.term.asset
            public class Type_Asset : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 65. Contract.term.asset.context
                public class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 66. Contract.term.asset.context.reference
                    public MakerElementInstance Element_Reference;                                                                          // MakerGen.cs:232
                    // 67. Contract.term.asset.context.code
                    public MakerElementInstance Element_Code;                                                                               // MakerGen.cs:232
                    // 68. Contract.term.asset.context.text
                    public MakerElementInstance Element_Text;                                                                               // MakerGen.cs:232
                    public Type_Context()                                                                                                   // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 66. Contract.term.asset.context.reference
                            this.Element_Reference = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Reference",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 67. Contract.term.asset.context.code
                            this.Element_Code = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Code",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 68. Contract.term.asset.context.text
                            this.Element_Text = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Text",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 77. Contract.term.asset.valuedItem
                public class Type_ValuedItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 78. Contract.term.asset.valuedItem.entity[x]
                    public MakerElementInstance Element_Entity;                                                                             // MakerGen.cs:232
                    // 79. Contract.term.asset.valuedItem.identifier
                    public MakerElementInstance Element_Identifier;                                                                         // MakerGen.cs:232
                    // 80. Contract.term.asset.valuedItem.effectiveTime
                    public MakerElementInstance Element_EffectiveTime;                                                                      // MakerGen.cs:232
                    // 81. Contract.term.asset.valuedItem.quantity
                    public MakerElementInstance Element_Quantity;                                                                           // MakerGen.cs:232
                    // 82. Contract.term.asset.valuedItem.unitPrice
                    public MakerElementInstance Element_UnitPrice;                                                                          // MakerGen.cs:232
                    // 83. Contract.term.asset.valuedItem.factor
                    public MakerElementInstance Element_Factor;                                                                             // MakerGen.cs:232
                    // 84. Contract.term.asset.valuedItem.points
                    public MakerElementInstance Element_Points;                                                                             // MakerGen.cs:232
                    // 85. Contract.term.asset.valuedItem.net
                    public MakerElementInstance Element_Net;                                                                                // MakerGen.cs:232
                    // 86. Contract.term.asset.valuedItem.payment
                    public MakerElementInstance Element_Payment;                                                                            // MakerGen.cs:232
                    // 87. Contract.term.asset.valuedItem.paymentDate
                    public MakerElementInstance Element_PaymentDate;                                                                        // MakerGen.cs:232
                    // 88. Contract.term.asset.valuedItem.responsible
                    public MakerElementInstance Element_Responsible;                                                                        // MakerGen.cs:232
                    // 89. Contract.term.asset.valuedItem.recipient
                    public MakerElementInstance Element_Recipient;                                                                          // MakerGen.cs:232
                    // 90. Contract.term.asset.valuedItem.linkId
                    public MakerElementInstance Element_LinkId;                                                                             // MakerGen.cs:232
                    // 91. Contract.term.asset.valuedItem.securityLabelNumber
                    public MakerElementInstance Element_SecurityLabelNumber;                                                                // MakerGen.cs:232
                    public Type_ValuedItem()                                                                                                // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 78. Contract.term.asset.valuedItem.entity[x]
                            this.Element_Entity = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Entity",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                    // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 79. Contract.term.asset.valuedItem.identifier
                            this.Element_Identifier = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Identifier",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 80. Contract.term.asset.valuedItem.effectiveTime
                            this.Element_EffectiveTime = new MakerElementInstance                                                           // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_EffectiveTime",                                                                             // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.DateTime()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 81. Contract.term.asset.valuedItem.quantity
                            this.Element_Quantity = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 82. Contract.term.asset.valuedItem.unitPrice
                            this.Element_UnitPrice = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_UnitPrice",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 83. Contract.term.asset.valuedItem.factor
                            this.Element_Factor = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Factor",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Decimal()                                                           // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 84. Contract.term.asset.valuedItem.points
                            this.Element_Points = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Points",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Decimal()                                                           // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 85. Contract.term.asset.valuedItem.net
                            this.Element_Net = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Net",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 86. Contract.term.asset.valuedItem.payment
                            this.Element_Payment = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Payment",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 87. Contract.term.asset.valuedItem.paymentDate
                            this.Element_PaymentDate = new MakerElementInstance                                                             // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_PaymentDate",                                                                               // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.DateTime()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 88. Contract.term.asset.valuedItem.responsible
                            this.Element_Responsible = new MakerElementInstance                                                             // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Responsible",                                                                               // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 89. Contract.term.asset.valuedItem.recipient
                            this.Element_Recipient = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Recipient",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 90. Contract.term.asset.valuedItem.linkId
                            this.Element_LinkId = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_LinkId",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 91. Contract.term.asset.valuedItem.securityLabelNumber
                            this.Element_SecurityLabelNumber = new MakerElementInstance                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_SecurityLabelNumber",                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                       // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 60. Contract.term.asset.scope
                public MakerElementInstance Element_Scope;                                                                                  // MakerGen.cs:232
                // 61. Contract.term.asset.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 62. Contract.term.asset.typeReference
                public MakerElementInstance Element_TypeReference;                                                                          // MakerGen.cs:232
                // 63. Contract.term.asset.subtype
                public MakerElementInstance Element_Subtype;                                                                                // MakerGen.cs:232
                // 64. Contract.term.asset.relationship
                public MakerElementInstance Element_Relationship;                                                                           // MakerGen.cs:232
                // 69. Contract.term.asset.condition
                public MakerElementInstance Element_Condition;                                                                              // MakerGen.cs:232
                // 70. Contract.term.asset.periodType
                public MakerElementInstance Element_PeriodType;                                                                             // MakerGen.cs:232
                // 71. Contract.term.asset.period
                public MakerElementInstance Element_Period;                                                                                 // MakerGen.cs:232
                // 72. Contract.term.asset.usePeriod
                public MakerElementInstance Element_UsePeriod;                                                                              // MakerGen.cs:232
                // 73. Contract.term.asset.text
                public MakerElementInstance Element_Text;                                                                                   // MakerGen.cs:232
                // 74. Contract.term.asset.linkId
                public MakerElementInstance Element_LinkId;                                                                                 // MakerGen.cs:232
                // 75. Contract.term.asset.answer
                public MakerElementInstance Element_Answer;                                                                                 // MakerGen.cs:232
                // 76. Contract.term.asset.securityLabelNumber
                public MakerElementInstance Element_SecurityLabelNumber;                                                                    // MakerGen.cs:232
                public Type_Asset()                                                                                                         // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 60. Contract.term.asset.scope
                        this.Element_Scope = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Scope",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 61. Contract.term.asset.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 62. Contract.term.asset.typeReference
                        this.Element_TypeReference = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_TypeReference",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 63. Contract.term.asset.subtype
                        this.Element_Subtype = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Subtype",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 64. Contract.term.asset.relationship
                        this.Element_Relationship = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Relationship",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 69. Contract.term.asset.condition
                        this.Element_Condition = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Condition",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 70. Contract.term.asset.periodType
                        this.Element_PeriodType = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_PeriodType",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 71. Contract.term.asset.period
                        this.Element_Period = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Period",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 72. Contract.term.asset.usePeriod
                        this.Element_UsePeriod = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_UsePeriod",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 73. Contract.term.asset.text
                        this.Element_Text = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Text",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 74. Contract.term.asset.linkId
                        this.Element_LinkId = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_LinkId",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 75. Contract.term.asset.answer
                        this.Element_Answer = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Answer",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 76. Contract.term.asset.securityLabelNumber
                        this.Element_SecurityLabelNumber = new MakerElementInstance                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SecurityLabelNumber",                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 92. Contract.term.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 95. Contract.term.action.subject
                public class Type_Subject : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 96. Contract.term.action.subject.reference
                    public MakerElementInstance Element_Reference;                                                                          // MakerGen.cs:232
                    // 97. Contract.term.action.subject.role
                    public MakerElementInstance Element_Role;                                                                               // MakerGen.cs:232
                    public Type_Subject()                                                                                                   // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 96. Contract.term.action.subject.reference
                            this.Element_Reference = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Reference",                                                                                 // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 97. Contract.term.action.subject.role
                            this.Element_Role = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Role",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 93. Contract.term.action.doNotPerform
                public MakerElementInstance Element_DoNotPerform;                                                                           // MakerGen.cs:232
                // 94. Contract.term.action.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 98. Contract.term.action.intent
                public MakerElementInstance Element_Intent;                                                                                 // MakerGen.cs:232
                // 99. Contract.term.action.linkId
                public MakerElementInstance Element_LinkId;                                                                                 // MakerGen.cs:232
                // 100. Contract.term.action.status
                public MakerElementInstance Element_Status;                                                                                 // MakerGen.cs:232
                // 101. Contract.term.action.context
                public MakerElementInstance Element_Context;                                                                                // MakerGen.cs:232
                // 102. Contract.term.action.contextLinkId
                public MakerElementInstance Element_ContextLinkId;                                                                          // MakerGen.cs:232
                // 103. Contract.term.action.occurrence[x]
                public MakerElementInstance Element_Occurrence;                                                                             // MakerGen.cs:232
                // 104. Contract.term.action.requester
                public MakerElementInstance Element_Requester;                                                                              // MakerGen.cs:232
                // 105. Contract.term.action.requesterLinkId
                public MakerElementInstance Element_RequesterLinkId;                                                                        // MakerGen.cs:232
                // 106. Contract.term.action.performerType
                public MakerElementInstance Element_PerformerType;                                                                          // MakerGen.cs:232
                // 107. Contract.term.action.performerRole
                public MakerElementInstance Element_PerformerRole;                                                                          // MakerGen.cs:232
                // 108. Contract.term.action.performer
                public MakerElementInstance Element_Performer;                                                                              // MakerGen.cs:232
                // 109. Contract.term.action.performerLinkId
                public MakerElementInstance Element_PerformerLinkId;                                                                        // MakerGen.cs:232
                // 110. Contract.term.action.reasonCode
                public MakerElementInstance Element_ReasonCode;                                                                             // MakerGen.cs:232
                // 111. Contract.term.action.reasonReference
                public MakerElementInstance Element_ReasonReference;                                                                        // MakerGen.cs:232
                // 112. Contract.term.action.reason
                public MakerElementInstance Element_Reason;                                                                                 // MakerGen.cs:232
                // 113. Contract.term.action.reasonLinkId
                public MakerElementInstance Element_ReasonLinkId;                                                                           // MakerGen.cs:232
                // 114. Contract.term.action.note
                public MakerElementInstance Element_Note;                                                                                   // MakerGen.cs:232
                // 115. Contract.term.action.securityLabelNumber
                public MakerElementInstance Element_SecurityLabelNumber;                                                                    // MakerGen.cs:232
                public Type_Action()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 93. Contract.term.action.doNotPerform
                        this.Element_DoNotPerform = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_DoNotPerform",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 94. Contract.term.action.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 98. Contract.term.action.intent
                        this.Element_Intent = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Intent",                                                                                        // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 99. Contract.term.action.linkId
                        this.Element_LinkId = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_LinkId",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 100. Contract.term.action.status
                        this.Element_Status = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Status",                                                                                        // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 101. Contract.term.action.context
                        this.Element_Context = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Context",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 102. Contract.term.action.contextLinkId
                        this.Element_ContextLinkId = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ContextLinkId",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 103. Contract.term.action.occurrence[x]
                        this.Element_Occurrence = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Occurrence",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.DateTime(),                                                             // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 104. Contract.term.action.requester
                        this.Element_Requester = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Requester",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 105. Contract.term.action.requesterLinkId
                        this.Element_RequesterLinkId = new MakerElementInstance                                                             // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_RequesterLinkId",                                                                               // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 106. Contract.term.action.performerType
                        this.Element_PerformerType = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_PerformerType",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 107. Contract.term.action.performerRole
                        this.Element_PerformerRole = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_PerformerRole",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 108. Contract.term.action.performer
                        this.Element_Performer = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Performer",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 109. Contract.term.action.performerLinkId
                        this.Element_PerformerLinkId = new MakerElementInstance                                                             // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_PerformerLinkId",                                                                               // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 110. Contract.term.action.reasonCode
                        this.Element_ReasonCode = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ReasonCode",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 111. Contract.term.action.reasonReference
                        this.Element_ReasonReference = new MakerElementInstance                                                             // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ReasonReference",                                                                               // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 112. Contract.term.action.reason
                        this.Element_Reason = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Reason",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 113. Contract.term.action.reasonLinkId
                        this.Element_ReasonLinkId = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ReasonLinkId",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 114. Contract.term.action.note
                        this.Element_Note = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Note",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 115. Contract.term.action.securityLabelNumber
                        this.Element_SecurityLabelNumber = new MakerElementInstance                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SecurityLabelNumber",                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 33. Contract.term.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            // 34. Contract.term.issued
            public MakerElementInstance Element_Issued;                                                                                     // MakerGen.cs:232
            // 35. Contract.term.applies
            public MakerElementInstance Element_Applies;                                                                                    // MakerGen.cs:232
            // 36. Contract.term.topic[x]
            public MakerElementInstance Element_Topic;                                                                                      // MakerGen.cs:232
            // 37. Contract.term.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 38. Contract.term.subType
            public MakerElementInstance Element_SubType;                                                                                    // MakerGen.cs:232
            // 39. Contract.term.text
            public MakerElementInstance Element_Text;                                                                                       // MakerGen.cs:232
            // 116. Contract.term.group
            public MakerElementInstance Element_Group;                                                                                      // MakerGen.cs:232
            public Type_Term()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 33. Contract.term.identifier
                    this.Element_Identifier = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 34. Contract.term.issued
                    this.Element_Issued = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Issued",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 35. Contract.term.applies
                    this.Element_Applies = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Applies",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 36. Contract.term.topic[x]
                    this.Element_Topic = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Topic",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 37. Contract.term.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 38. Contract.term.subType
                    this.Element_SubType = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SubType",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 39. Contract.term.text
                    this.Element_Text = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Text",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 116. Contract.term.group
                    this.Element_Group = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Group",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 119. Contract.signer
        public class Type_Signer : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 120. Contract.signer.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 121. Contract.signer.party
            public MakerElementInstance Element_Party;                                                                                      // MakerGen.cs:232
            // 122. Contract.signer.signature
            public MakerElementInstance Element_Signature;                                                                                  // MakerGen.cs:232
            public Type_Signer()                                                                                                            // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 120. Contract.signer.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding()                                                                      // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 121. Contract.signer.party
                    this.Element_Party = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Party",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 122. Contract.signer.signature
                    this.Element_Signature = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Signature",                                                                                         // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 123. Contract.friendly
        public class Type_Friendly : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 124. Contract.friendly.content[x]
            public MakerElementInstance Element_Content;                                                                                    // MakerGen.cs:232
            public Type_Friendly()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 124. Contract.friendly.content[x]
                    this.Element_Content = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Content",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 125. Contract.legal
        public class Type_Legal : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 126. Contract.legal.content[x]
            public MakerElementInstance Element_Content;                                                                                    // MakerGen.cs:232
            public Type_Legal()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 126. Contract.legal.content[x]
                    this.Element_Content = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Content",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 127. Contract.rule
        public class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 128. Contract.rule.content[x]
            public MakerElementInstance Element_Content;                                                                                    // MakerGen.cs:232
            public Type_Rule()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 128. Contract.rule.content[x]
                    this.Element_Content = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Content",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. Contract.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Contract.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 3. Contract.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 4. Contract.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. Contract.legalState
        public MakerElementInstance Element_LegalState;                                                                                     // MakerGen.cs:232
        // 6. Contract.instantiatesCanonical
        public MakerElementInstance Element_InstantiatesCanonical;                                                                          // MakerGen.cs:232
        // 7. Contract.instantiatesUri
        public MakerElementInstance Element_InstantiatesUri;                                                                                // MakerGen.cs:232
        // 8. Contract.contentDerivative
        public MakerElementInstance Element_ContentDerivative;                                                                              // MakerGen.cs:232
        // 9. Contract.issued
        public MakerElementInstance Element_Issued;                                                                                         // MakerGen.cs:232
        // 10. Contract.applies
        public MakerElementInstance Element_Applies;                                                                                        // MakerGen.cs:232
        // 11. Contract.expirationType
        public MakerElementInstance Element_ExpirationType;                                                                                 // MakerGen.cs:232
        // 12. Contract.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 13. Contract.authority
        public MakerElementInstance Element_Authority;                                                                                      // MakerGen.cs:232
        // 14. Contract.domain
        public MakerElementInstance Element_Domain;                                                                                         // MakerGen.cs:232
        // 15. Contract.site
        public MakerElementInstance Element_Site;                                                                                           // MakerGen.cs:232
        // 16. Contract.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 17. Contract.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 18. Contract.subtitle
        public MakerElementInstance Element_Subtitle;                                                                                       // MakerGen.cs:232
        // 19. Contract.alias
        public MakerElementInstance Element_Alias;                                                                                          // MakerGen.cs:232
        // 20. Contract.author
        public MakerElementInstance Element_Author;                                                                                         // MakerGen.cs:232
        // 21. Contract.scope
        public MakerElementInstance Element_Scope;                                                                                          // MakerGen.cs:232
        // 22. Contract.topic[x]
        public MakerElementInstance Element_Topic;                                                                                          // MakerGen.cs:232
        // 23. Contract.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 24. Contract.subType
        public MakerElementInstance Element_SubType;                                                                                        // MakerGen.cs:232
        // 117. Contract.supportingInfo
        public MakerElementInstance Element_SupportingInfo;                                                                                 // MakerGen.cs:232
        // 118. Contract.relevantHistory
        public MakerElementInstance Element_RelevantHistory;                                                                                // MakerGen.cs:232
        // 129. Contract.legallyBinding[x]
        public MakerElementInstance Element_LegallyBinding;                                                                                 // MakerGen.cs:232
        public Contract()                                                                                                                   // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Contract.identifier
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
                // 2. Contract.url
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
                // 3. Contract.version
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
                // 4. Contract.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. Contract.legalState
                this.Element_LegalState = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LegalState",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. Contract.instantiatesCanonical
                this.Element_InstantiatesCanonical = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. Contract.instantiatesUri
                this.Element_InstantiatesUri = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. Contract.contentDerivative
                this.Element_ContentDerivative = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ContentDerivative",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. Contract.issued
                this.Element_Issued = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Issued",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. Contract.applies
                this.Element_Applies = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Applies",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. Contract.expirationType
                this.Element_ExpirationType = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExpirationType",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. Contract.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. Contract.authority
                this.Element_Authority = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Authority",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. Contract.domain
                this.Element_Domain = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Domain",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. Contract.site
                this.Element_Site = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Site",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. Contract.name
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
                // 17. Contract.title
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
                // 18. Contract.subtitle
                this.Element_Subtitle = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subtitle",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. Contract.alias
                this.Element_Alias = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Alias",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. Contract.author
                this.Element_Author = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Author",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 21. Contract.scope
                this.Element_Scope = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Scope",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. Contract.topic[x]
                this.Element_Topic = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Topic",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                                // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. Contract.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 24. Contract.subType
                this.Element_SubType = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SubType",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 117. Contract.supportingInfo
                this.Element_SupportingInfo = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SupportingInfo",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 118. Contract.relevantHistory
                this.Element_RelevantHistory = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_RelevantHistory",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 129. Contract.legallyBinding[x]
                this.Element_LegallyBinding = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LegallyBinding",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
