using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
    {
      "resourceType": "StructureDefinition",
      "id": "Consent",
      "url": "http://hl7.org/fhir/StructureDefinition/Consent",
      "version": "4.0.0",
      "name": "Consent",
      "status": "draft",
      "publisher": "Health Level Seven International (Community Based Collaborative Care)",
      "description": "A record of a healthcare consumer’s  choices, which permits or denies identified recipient(s) or recipient role(s) to perform one or more actions within a given policy context, for specific purposes and periods of time.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Consent",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Consent",
            "path": "Consent",
            "short": "A healthcare consumer's  choices to permit or deny recipients or roles to perform actions for specific purposes and periods of time",
            "definition": "A record of a healthcare consumer’s  choices, which permits or denies identified recipient(s) or recipient role(s) to perform one or more actions within a given policy context, for specific purposes and periods of time.",
            "comment": "Broadly, there are 3 key areas of consent for patients: Consent around sharing information (aka Privacy Consent Directive - Authorization to Collect, Use, or Disclose information), consent for specific treatment, or kinds of treatment, and general advance care directives.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Consent.identifier",
            "path": "Consent.identifier",
            "short": "Identifier for this record (external references)",
            "definition": "Unique identifier for this copy of the Consent Statement.",
            "comment": "This identifier identifies this copy of the consent. Where this identifier is also used elsewhere as the identifier for a consent record (e.g. a CDA consent document) then the consent details are expected to be the same.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueIdentifier": {
                  "system": "urn:ietf:rfc:3986",
                  "value": "Local eCMS identifier"
                }
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.status",
            "path": "Consent.status",
            "short": "draft | proposed | active | rejected | inactive | entered-in-error",
            "definition": "Indicates the current state of this consent.",
            "comment": "This element is labeled as a modifier because the status contains the codes rejected and entered-in-error that mark the Consent as not currently valid.",
            "requirements": "The Consent Directive that is pointed to might be in various lifecycle states, e.g., a revoked Consent Directive.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConsentState"
                }
              ],
              "strength": "required",
              "description": "Indicates the state of the consent.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-state-codes|4.0.0"
            }
          },
          {
            "id": "Consent.scope",
            "path": "Consent.scope",
            "short": "Which of the four areas this resource covers (extensible)",
            "definition": "A selector of the type of consent being presented: ADR, Privacy, Treatment, Research.  This list is now extensible.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isModifier": true,
            "isModifierReason": "Allows changes to codes based on scope selection",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConsentScope"
                }
              ],
              "strength": "extensible",
              "description": "The four anticipated uses for the Consent Resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-scope"
            }
          },
          {
            "id": "Consent.category",
            "path": "Consent.category",
            "short": "Classification of the consent statement - for indexing/retrieval",
            "definition": "A classification of the type of consents found in the statement. This element supports indexing and retrieval of consent statements.",
            "min": 1,
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
                  "valueString": "ConsentCategory"
                }
              ],
              "strength": "extensible",
              "description": "A classification of the type of consents found in a consent statement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-category"
            }
          },
          {
            "id": "Consent.patient",
            "path": "Consent.patient",
            "short": "Who the consent applies to",
            "definition": "The patient/healthcare consumer to whom this consent applies.",
            "comment": "Commonly, the patient the consent pertains to is the author, but for young and old people, it may be some other person.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.dateTime",
            "path": "Consent.dateTime",
            "short": "When this Consent was created or indexed",
            "definition": "When this  Consent was issued / created / indexed.",
            "comment": "This is not the time of the original consent, but the time that this statement was made or derived.",
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
            "id": "Consent.performer",
            "path": "Consent.performer",
            "short": "Who is agreeing to the policy and rules",
            "definition": "Either the Grantor, which is the entity responsible for granting the rights listed in a Consent Directive or the Grantee, which is the entity responsible for complying with the Consent Directive, including any obligations or limitations on authorizations and enforcement of prohibitions.",
            "comment": "Commonly, the patient the consent pertains to is the consentor, but particularly for young and old people, it may be some other person - e.g. a legal guardian.",
            "alias": [
              "consentor"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.organization",
            "path": "Consent.organization",
            "short": "Custodian of the consent",
            "definition": "The organization that manages the consent, and the framework within which it is executed.",
            "alias": [
              "custodian"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.source[x]",
            "path": "Consent.source[x]",
            "short": "Source from which this consent is taken",
            "definition": "The source on which this consent statement is based. The source might be a scanned original paper form, or a reference to a consent that links back to such a source, a reference to a document repository (e.g. XDS) that stores the original consent document.",
            "comment": "The source can be contained inline (Attachment), referenced directly (Consent), referenced in a consent repository (DocumentReference), or simply by an identifier (Identifier), e.g. a CDA document id.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Consent",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/Contract",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.policy",
            "path": "Consent.policy",
            "short": "Policies covered by this consent",
            "definition": "The references to the policies that are included in this consent scope. Policies may be organizational, but are often defined jurisdictionally, or in law.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Consent.policy.authority",
            "path": "Consent.policy.authority",
            "short": "Enforcement source for policy",
            "definition": "Entity or Organization having regulatory jurisdiction or accountability for  enforcing policies pertaining to Consent Directives.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "ppc-1"
            ]
          },
          {
            "id": "Consent.policy.uri",
            "path": "Consent.policy.uri",
            "short": "Specific policy covered by this consent",
            "definition": "The references to the policies that are included in this consent scope. Policies may be organizational, but are often defined jurisdictionally, or in law.",
            "comment": "This element is for discoverability / documentation and does not modify or qualify the policy rules.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "ppc-1"
            ]
          },
          {
            "id": "Consent.policyRule",
            "path": "Consent.policyRule",
            "short": "Regulation that this consents to",
            "definition": "A reference to the specific base computable regulation or policy.",
            "comment": "If the policyRule is absent, computable consent would need to be constructed from the elements of the Consent resource.",
            "requirements": "Might be a unique identifier of a policy set in XACML, or other rules engine.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "ppc-1"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConsentPolicyRule"
                }
              ],
              "strength": "extensible",
              "description": "Regulatory policy examples.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-policy"
            }
          },
          {
            "id": "Consent.verification",
            "path": "Consent.verification",
            "short": "Consent Verified by patient or family",
            "definition": "Whether a treatment instruction (e.g. artificial respiration yes or no) was verified with the patient, his/her family or another authorized person.",
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
            "id": "Consent.verification.verified",
            "path": "Consent.verification.verified",
            "short": "Has been verified",
            "definition": "Has the instruction been verified.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.verification.verifiedWith",
            "path": "Consent.verification.verifiedWith",
            "short": "Person who verified",
            "definition": "Who verified the instruction (Patient, Relative or other Authorized Person).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "Consent.verification.verificationDate",
            "path": "Consent.verification.verificationDate",
            "short": "When consent verified",
            "definition": "Date verification was collected.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Consent.provision",
            "path": "Consent.provision",
            "short": "Constraints to the base Consent.policyRule",
            "definition": "An exception to the base policy of this consent. An exception can be an addition or removal of access permissions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Consent.provision.type",
            "path": "Consent.provision.type",
            "short": "deny | permit",
            "definition": "Action  to take - permit or deny - when the rule conditions are met.  Not permitted in root rule, required in all nested rules.",
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
                  "valueString": "ConsentProvisionType"
                }
              ],
              "strength": "required",
              "description": "How a rule statement is applied, such as adding additional consent or removing consent.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-provision-type|4.0.0"
            }
          },
          {
            "id": "Consent.provision.period",
            "path": "Consent.provision.period",
            "short": "Timeframe for this rule",
            "definition": "The timeframe in this rule is valid.",
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
            "id": "Consent.provision.actor",
            "path": "Consent.provision.actor",
            "short": "Who|what controlled by this rule (or group, by role)",
            "definition": "Who or what is controlled by this rule. Use group to identify a set of actors by some property they share (e.g. 'admitting officers').",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "meaningWhenMissing": "There is no specific actor associated with the exception"
          },
          {
            "id": "Consent.provision.actor.role",
            "path": "Consent.provision.actor.role",
            "short": "How the actor is involved",
            "definition": "How the individual is involved in the resources content that is described in the exception.",
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
                  "valueString": "ConsentActorRole"
                }
              ],
              "strength": "extensible",
              "description": "How an actor is involved in the consent considerations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-role-type"
            }
          },
          {
            "id": "Consent.provision.actor.reference",
            "path": "Consent.provision.actor.reference",
            "short": "Resource for the actor (or group, by role)",
            "definition": "The resource that identifies the actor. To identify actors by type, use group to identify a set of actors by some property they share (e.g. 'admitting officers').",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "Consent.provision.action",
            "path": "Consent.provision.action",
            "short": "Actions controlled by this rule",
            "definition": "Actions controlled by this Rule.",
            "comment": "Note that this is the direct action (not the grounds for the action covered in the purpose element). At present, the only action in the understood and tested scope of this resource is 'read'.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "meaningWhenMissing": "all actions",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConsentAction"
                }
              ],
              "strength": "example",
              "description": "Detailed codes for the consent action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-action"
            }
          },
          {
            "id": "Consent.provision.securityLabel",
            "path": "Consent.provision.securityLabel",
            "short": "Security Labels that define affected resources",
            "definition": "A security label, comprised of 0..* security label fields (Privacy tags), which define which resources are controlled by this exception.",
            "comment": "If the consent specifies a security label of \"R\" then it applies to all resources that are labeled \"R\" or lower. E.g. for Confidentiality, it's a high water mark. For other kinds of security labels, subsumption logic applies. When the purpose of use tag is on the data, access request purpose of use shall not conflict.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SecurityLabels"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Security Labels from the Healthcare Privacy and Security Classification System.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-labels"
            }
          },
          {
            "id": "Consent.provision.purpose",
            "path": "Consent.provision.purpose",
            "short": "Context of activities covered by this rule",
            "definition": "The context of the activities a user is taking - why the user is accessing the data - that are controlled by this rule.",
            "comment": "When the purpose of use tag is on the data, access request purpose of use shall not conflict.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PurposeOfUse"
                }
              ],
              "strength": "extensible",
              "description": "What purposes of use are controlled by this exception. If more than one label is specified, operations must have all the specified labels.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "Consent.provision.class",
            "path": "Consent.provision.class",
            "short": "e.g. Resource Type, Profile, CDA, etc.",
            "definition": "The class of information covered by this rule. The type can be a FHIR resource type, a profile on a type, or a CDA document, or some other type that indicates what sort of information the consent relates to.",
            "comment": "Multiple types are or'ed together. The intention of the contentType element is that the codes refer to profiles or document types defined in a standard or an implementation guide somewhere.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
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
            "id": "Consent.provision.code",
            "path": "Consent.provision.code",
            "short": "e.g. LOINC or SNOMED CT code, etc. in the content",
            "definition": "If this code is found in an instance, then the rule applies.",
            "comment": "Typical use of this is a Document code with class = CDA.",
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
                  "valueString": "ConsentContentCode"
                }
              ],
              "strength": "example",
              "description": "If this code is found in an instance, then the exception applies.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-content-code"
            }
          },
          {
            "id": "Consent.provision.dataPeriod",
            "path": "Consent.provision.dataPeriod",
            "short": "Timeframe for data controlled by this rule",
            "definition": "Clinical or Operational Relevant period of time that bounds the data controlled by this rule.",
            "comment": "This has a different sense to the Consent.period - that is when the consent agreement holds. This is the time period of the data that is controlled by the agreement.",
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
            "id": "Consent.provision.data",
            "path": "Consent.provision.data",
            "short": "Data controlled by this rule",
            "definition": "The resources controlled by this rule if specific resources are referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "meaningWhenMissing": "all data",
            "isSummary": true
          },
          {
            "id": "Consent.provision.data.meaning",
            "path": "Consent.provision.data.meaning",
            "short": "instance | related | dependents | authoredby",
            "definition": "How the resource reference is interpreted when testing consent restrictions.",
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
                  "valueString": "ConsentDataMeaning"
                }
              ],
              "strength": "required",
              "description": "How a resource reference is interpreted when testing consent restrictions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/consent-data-meaning|4.0.0"
            }
          },
          {
            "id": "Consent.provision.data.reference",
            "path": "Consent.provision.data.reference",
            "short": "The actual data reference",
            "definition": "A reference to a specific resource that defines which resources are covered by this consent.",
            "min": 1,
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
            "id": "Consent.provision.provision",
            "path": "Consent.provision.provision",
            "short": "Nested Exception Rules",
            "definition": "Rules which provide exceptions to the base rule or subrules.",
            "min": 0,
            "max": "*",
            "contentReference": "#Consent.provision"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Consent'
    /// </summary>
    // 0. Consent
    public class Consent : FhirKhit.Maker.Common.Resource.ResourceBase                                                                      // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Consent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                         // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 10. Consent.policy
            public class Type_Policy : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Policy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 11. Consent.policy.authority
                    public ElementDefinitionInfo Authority;                                                                                 // MakerGen.cs:236
                    // 12. Consent.policy.uri
                    public ElementDefinitionInfo Uri;                                                                                       // MakerGen.cs:236
                    public Type_Policy_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. Consent.policy.authority
                            this.Authority = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Authority",                                                                                         // MakerGen.cs:255
                                Path= "Consent.policy.authority",                                                                           // MakerGen.cs:256
                                Id = "Consent.policy.authority",                                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. Consent.policy.uri
                            this.Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Uri",                                                                                               // MakerGen.cs:255
                                Path= "Consent.policy.uri",                                                                                 // MakerGen.cs:256
                                Id = "Consent.policy.uri",                                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Authority.Write(sDef);                                                                                              // MakerGen.cs:240
                        Uri.Write(sDef);                                                                                                    // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Policy_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Policy()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Policy_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 14. Consent.verification
            public class Type_Verification : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Verification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 15. Consent.verification.verified
                    public ElementDefinitionInfo Verified;                                                                                  // MakerGen.cs:236
                    // 16. Consent.verification.verifiedWith
                    public ElementDefinitionInfo VerifiedWith;                                                                              // MakerGen.cs:236
                    // 17. Consent.verification.verificationDate
                    public ElementDefinitionInfo VerificationDate;                                                                          // MakerGen.cs:236
                    public Type_Verification_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. Consent.verification.verified
                            this.Verified = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Verified",                                                                                          // MakerGen.cs:255
                                Path= "Consent.verification.verified",                                                                      // MakerGen.cs:256
                                Id = "Consent.verification.verified",                                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. Consent.verification.verifiedWith
                            this.VerifiedWith = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "VerifiedWith",                                                                                      // MakerGen.cs:255
                                Path= "Consent.verification.verifiedWith",                                                                  // MakerGen.cs:256
                                Id = "Consent.verification.verifiedWith",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. Consent.verification.verificationDate
                            this.VerificationDate = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "VerificationDate",                                                                                  // MakerGen.cs:255
                                Path= "Consent.verification.verificationDate",                                                              // MakerGen.cs:256
                                Id = "Consent.verification.verificationDate",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Verified.Write(sDef);                                                                                               // MakerGen.cs:240
                        VerifiedWith.Write(sDef);                                                                                           // MakerGen.cs:240
                        VerificationDate.Write(sDef);                                                                                       // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Verification_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Verification()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Verification_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 18. Consent.provision
            public class Type_Provision : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Provision_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 21. Consent.provision.actor
                    public class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Actor_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 22. Consent.provision.actor.role
                            public ElementDefinitionInfo Role;                                                                              // MakerGen.cs:236
                            // 23. Consent.provision.actor.reference
                            public ElementDefinitionInfo Reference;                                                                         // MakerGen.cs:236
                            public Type_Actor_Elements()                                                                                    // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 22. Consent.provision.actor.role
                                    this.Role = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Role",                                                                                      // MakerGen.cs:255
                                        Path= "Consent.provision.actor.role",                                                               // MakerGen.cs:256
                                        Id = "Consent.provision.actor.role",                                                                // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 23. Consent.provision.actor.reference
                                    this.Reference = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Reference",                                                                                 // MakerGen.cs:255
                                        Path= "Consent.provision.actor.reference",                                                          // MakerGen.cs:256
                                        Id = "Consent.provision.actor.reference",                                                           // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:345
                                            {                                                                                               // MakerGen.cs:346
                                                TargetProfile = new String[]                                                                // MakerGen.cs:348
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Device",                                       // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/Group",                                        // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                     // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                 // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                      // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                              // MakerGen.cs:348
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:349
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Role.Write(sDef);                                                                                           // MakerGen.cs:240
                                Reference.Write(sDef);                                                                                      // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Actor_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Actor()                                                                                                 // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Actor_Elements();                                                                      // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 30. Consent.provision.data
                    public class Type_Data : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Data_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 31. Consent.provision.data.meaning
                            public ElementDefinitionInfo Meaning;                                                                           // MakerGen.cs:236
                            // 32. Consent.provision.data.reference
                            public ElementDefinitionInfo Reference;                                                                         // MakerGen.cs:236
                            public Type_Data_Elements()                                                                                     // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 31. Consent.provision.data.meaning
                                    this.Meaning = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Meaning",                                                                                   // MakerGen.cs:255
                                        Path= "Consent.provision.data.meaning",                                                             // MakerGen.cs:256
                                        Id = "Consent.provision.data.meaning",                                                              // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 32. Consent.provision.data.reference
                                    this.Reference = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Reference",                                                                                 // MakerGen.cs:255
                                        Path= "Consent.provision.data.reference",                                                           // MakerGen.cs:256
                                        Id = "Consent.provision.data.reference",                                                            // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:345
                                            {                                                                                               // MakerGen.cs:346
                                                TargetProfile = new String[]                                                                // MakerGen.cs:348
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:348
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:349
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Meaning.Write(sDef);                                                                                        // MakerGen.cs:240
                                Reference.Write(sDef);                                                                                      // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Data_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Data()                                                                                                  // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Data_Elements();                                                                       // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 19. Consent.provision.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 20. Consent.provision.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    // 24. Consent.provision.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:236
                    // 25. Consent.provision.securityLabel
                    public ElementDefinitionInfo SecurityLabel;                                                                             // MakerGen.cs:236
                    // 26. Consent.provision.purpose
                    public ElementDefinitionInfo Purpose;                                                                                   // MakerGen.cs:236
                    // 27. Consent.provision.class
                    public ElementDefinitionInfo Class;                                                                                     // MakerGen.cs:236
                    // 28. Consent.provision.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    // 29. Consent.provision.dataPeriod
                    public ElementDefinitionInfo DataPeriod;                                                                                // MakerGen.cs:236
                    // 33. Consent.provision.provision
                    public ElementDefinitionInfo Provision;                                                                                 // MakerGen.cs:236
                    public Type_Provision_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. Consent.provision.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "Consent.provision.type",                                                                             // MakerGen.cs:256
                                Id = "Consent.provision.type",                                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. Consent.provision.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Consent.provision.period",                                                                           // MakerGen.cs:256
                                Id = "Consent.provision.period",                                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 24. Consent.provision.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Action",                                                                                            // MakerGen.cs:255
                                Path= "Consent.provision.action",                                                                           // MakerGen.cs:256
                                Id = "Consent.provision.action",                                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 25. Consent.provision.securityLabel
                            this.SecurityLabel = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SecurityLabel",                                                                                     // MakerGen.cs:255
                                Path= "Consent.provision.securityLabel",                                                                    // MakerGen.cs:256
                                Id = "Consent.provision.securityLabel",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 26. Consent.provision.purpose
                            this.Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Purpose",                                                                                           // MakerGen.cs:255
                                Path= "Consent.provision.purpose",                                                                          // MakerGen.cs:256
                                Id = "Consent.provision.purpose",                                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 27. Consent.provision.class
                            this.Class = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Class",                                                                                             // MakerGen.cs:255
                                Path= "Consent.provision.class",                                                                            // MakerGen.cs:256
                                Id = "Consent.provision.class",                                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 28. Consent.provision.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "Consent.provision.code",                                                                             // MakerGen.cs:256
                                Id = "Consent.provision.code",                                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 29. Consent.provision.dataPeriod
                            this.DataPeriod = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DataPeriod",                                                                                        // MakerGen.cs:255
                                Path= "Consent.provision.dataPeriod",                                                                       // MakerGen.cs:256
                                Id = "Consent.provision.dataPeriod",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 33. Consent.provision.provision
                            this.Provision = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Provision",                                                                                         // MakerGen.cs:255
                                Path= "Consent.provision.provision",                                                                        // MakerGen.cs:256
                                Id = "Consent.provision.provision",                                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:240
                        SecurityLabel.Write(sDef);                                                                                          // MakerGen.cs:240
                        Purpose.Write(sDef);                                                                                                // MakerGen.cs:240
                        Class.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                        DataPeriod.Write(sDef);                                                                                             // MakerGen.cs:240
                        Provision.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Provision_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Provision()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Provision_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Consent.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Consent.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. Consent.scope
            public ElementDefinitionInfo Scope;                                                                                             // MakerGen.cs:236
            // 4. Consent.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 5. Consent.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 6. Consent.dateTime
            public ElementDefinitionInfo DateTime;                                                                                          // MakerGen.cs:236
            // 7. Consent.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:236
            // 8. Consent.organization
            public ElementDefinitionInfo Organization;                                                                                      // MakerGen.cs:236
            // 9. Consent.source[x]
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:236
            // 13. Consent.policyRule
            public ElementDefinitionInfo PolicyRule;                                                                                        // MakerGen.cs:236
            public Consent_Elements()                                                                                                       // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Consent.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Consent.identifier",                                                                                         // MakerGen.cs:256
                        Id = "Consent.identifier",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Consent.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Consent.status",                                                                                             // MakerGen.cs:256
                        Id = "Consent.status",                                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Consent.scope
                    this.Scope = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Scope",                                                                                                     // MakerGen.cs:255
                        Path= "Consent.scope",                                                                                              // MakerGen.cs:256
                        Id = "Consent.scope",                                                                                               // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Consent.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "Consent.category",                                                                                           // MakerGen.cs:256
                        Id = "Consent.category",                                                                                            // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. Consent.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "Consent.patient",                                                                                            // MakerGen.cs:256
                        Id = "Consent.patient",                                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Consent.dateTime
                    this.DateTime = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DateTime",                                                                                                  // MakerGen.cs:255
                        Path= "Consent.dateTime",                                                                                           // MakerGen.cs:256
                        Id = "Consent.dateTime",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Consent.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Performer",                                                                                                 // MakerGen.cs:255
                        Path= "Consent.performer",                                                                                          // MakerGen.cs:256
                        Id = "Consent.performer",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. Consent.organization
                    this.Organization = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Organization",                                                                                              // MakerGen.cs:255
                        Path= "Consent.organization",                                                                                       // MakerGen.cs:256
                        Id = "Consent.organization",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. Consent.source[x]
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Source",                                                                                                    // MakerGen.cs:255
                        Path= "Consent.source[x]",                                                                                          // MakerGen.cs:256
                        Id = "Consent.source[x]",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            },                                                                                                              // MakerGen.cs:359
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Consent",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Contract",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"                                         // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. Consent.policyRule
                    this.PolicyRule = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PolicyRule",                                                                                                // MakerGen.cs:255
                        Path= "Consent.policyRule",                                                                                         // MakerGen.cs:256
                        Id = "Consent.policyRule",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Scope.Write(sDef);                                                                                                          // MakerGen.cs:240
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                DateTime.Write(sDef);                                                                                                       // MakerGen.cs:240
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:240
                Organization.Write(sDef);                                                                                                   // MakerGen.cs:240
                Source.Write(sDef);                                                                                                         // MakerGen.cs:240
                PolicyRule.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Consent_Elements Elements { get; }                                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Consent()                                                                                                                    // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Consent_Elements();                                                                                         // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
