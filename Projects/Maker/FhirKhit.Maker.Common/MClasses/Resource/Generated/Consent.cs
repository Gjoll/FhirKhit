using System;                                                                                                                               // MakerGen.cs:399
using System.Diagnostics;                                                                                                                   // MakerGen.cs:400
using System.IO;                                                                                                                            // MakerGen.cs:401
using System.Linq;                                                                                                                          // MakerGen.cs:402
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:403
                                                                                                                                            // MakerGen.cs:404
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:405
{                                                                                                                                           // MakerGen.cs:406
    #region Json                                                                                                                            // MakerGen.cs:407
    #if NEVER                                                                                                                               // MakerGen.cs:408
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
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'Consent'
    /// </summary>
    // 0. Consent
    public class Consent : FhirKhit.Maker.Common.Resource.ResourceBase                                                                      // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 10. Consent.policy
        public class Type_Policy : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 11. Consent.policy.authority
            public MakerElementInstance Element_Authority;                                                                                  // MakerGen.cs:232
            // 12. Consent.policy.uri
            public MakerElementInstance Element_Uri;                                                                                        // MakerGen.cs:232
            public Type_Policy()                                                                                                            // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 11. Consent.policy.authority
                    this.Element_Authority = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Authority",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 12. Consent.policy.uri
                    this.Element_Uri = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 14. Consent.verification
        public class Type_Verification : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 15. Consent.verification.verified
            public MakerElementInstance Element_Verified;                                                                                   // MakerGen.cs:232
            // 16. Consent.verification.verifiedWith
            public MakerElementInstance Element_VerifiedWith;                                                                               // MakerGen.cs:232
            // 17. Consent.verification.verificationDate
            public MakerElementInstance Element_VerificationDate;                                                                           // MakerGen.cs:232
            public Type_Verification()                                                                                                      // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 15. Consent.verification.verified
                    this.Element_Verified = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Verified",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 16. Consent.verification.verifiedWith
                    this.Element_VerifiedWith = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VerifiedWith",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 17. Consent.verification.verificationDate
                    this.Element_VerificationDate = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VerificationDate",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 18. Consent.provision
        public class Type_Provision : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 21. Consent.provision.actor
            public class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 22. Consent.provision.actor.role
                public MakerElementInstance Element_Role;                                                                                   // MakerGen.cs:232
                // 23. Consent.provision.actor.reference
                public MakerElementInstance Element_Reference;                                                                              // MakerGen.cs:232
                public Type_Actor()                                                                                                         // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 22. Consent.provision.actor.role
                        this.Element_Role = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Role",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 23. Consent.provision.actor.reference
                        this.Element_Reference = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Reference",                                                                                     // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 30. Consent.provision.data
            public class Type_Data : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 31. Consent.provision.data.meaning
                public MakerElementInstance Element_Meaning;                                                                                // MakerGen.cs:232
                // 32. Consent.provision.data.reference
                public MakerElementInstance Element_Reference;                                                                              // MakerGen.cs:232
                public Type_Data()                                                                                                          // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 31. Consent.provision.data.meaning
                        this.Element_Meaning = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Meaning",                                                                                       // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code                                                                    // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 32. Consent.provision.data.reference
                        this.Element_Reference = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Reference",                                                                                     // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 19. Consent.provision.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 20. Consent.provision.period
            public MakerElementInstance Element_Period;                                                                                     // MakerGen.cs:232
            // 24. Consent.provision.action
            public MakerElementInstance Element_Action;                                                                                     // MakerGen.cs:232
            // 25. Consent.provision.securityLabel
            public MakerElementInstance Element_SecurityLabel;                                                                              // MakerGen.cs:232
            // 26. Consent.provision.purpose
            public MakerElementInstance Element_Purpose;                                                                                    // MakerGen.cs:232
            // 27. Consent.provision.class
            public MakerElementInstance Element_Class;                                                                                      // MakerGen.cs:232
            // 28. Consent.provision.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 29. Consent.provision.dataPeriod
            public MakerElementInstance Element_DataPeriod;                                                                                 // MakerGen.cs:232
            // 33. Consent.provision.provision
            public MakerElementInstance Element_Provision;                                                                                  // MakerGen.cs:232
            public Type_Provision()                                                                                                         // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 19. Consent.provision.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 20. Consent.provision.period
                    this.Element_Period = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Period",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 24. Consent.provision.action
                    this.Element_Action = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Action",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 25. Consent.provision.securityLabel
                    this.Element_SecurityLabel = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SecurityLabel",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 26. Consent.provision.purpose
                    this.Element_Purpose = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Purpose",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 27. Consent.provision.class
                    this.Element_Class = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Class",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 28. Consent.provision.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 29. Consent.provision.dataPeriod
                    this.Element_DataPeriod = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DataPeriod",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 33. Consent.provision.provision
                    this.Element_Provision = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Provision",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. Consent.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Consent.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. Consent.scope
        public MakerElementInstance Element_Scope;                                                                                          // MakerGen.cs:232
        // 4. Consent.category
        public MakerElementInstance Element_Category;                                                                                       // MakerGen.cs:232
        // 5. Consent.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 6. Consent.dateTime
        public MakerElementInstance Element_DateTime;                                                                                       // MakerGen.cs:232
        // 7. Consent.performer
        public MakerElementInstance Element_Performer;                                                                                      // MakerGen.cs:232
        // 8. Consent.organization
        public MakerElementInstance Element_Organization;                                                                                   // MakerGen.cs:232
        // 9. Consent.source[x]
        public MakerElementInstance Element_Source;                                                                                         // MakerGen.cs:232
        // 13. Consent.policyRule
        public MakerElementInstance Element_PolicyRule;                                                                                     // MakerGen.cs:232
        public Consent()                                                                                                                    // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. Consent.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 2. Consent.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. Consent.scope
                this.Element_Scope = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Scope",                                                                                                 // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 4. Consent.category
                this.Element_Category = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Category",                                                                                              // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 5. Consent.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 6. Consent.dateTime
                this.Element_DateTime = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DateTime",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 7. Consent.performer
                this.Element_Performer = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 8. Consent.organization
                this.Element_Organization = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Organization",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 9. Consent.source[x]
                this.Element_Source = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Source",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 13. Consent.policyRule
                this.Element_PolicyRule = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PolicyRule",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
