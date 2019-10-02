using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Consent'
    /// </summary>
    // 0. Consent
    public class Resource_Consent : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                  // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 10. Consent.policy
        public class Type_Policy : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 11. Consent.policy.authority
            public ElementDefinitionInfo Element_Authority;                                                                                 // MakerGen.cs:219
            // 12. Consent.policy.uri
            public ElementDefinitionInfo Element_Uri;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Consent.policy",                                                                                                // MakerGen.cs:395
                    ElementId = "Consent.policy"                                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Authority.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Uri.Write(sDef);                                                                                                    // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Policy()                                                                                                            // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 11. Consent.policy.authority
                    this.Element_Authority = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Authority",                                                                                         // MakerGen.cs:238
                        Path= "Consent.policy.authority",                                                                                   // MakerGen.cs:239
                        Id = "Consent.policy.authority",                                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. Consent.policy.uri
                    this.Element_Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:238
                        Path= "Consent.policy.uri",                                                                                         // MakerGen.cs:239
                        Id = "Consent.policy.uri",                                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 14. Consent.verification
        public class Type_Verification : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 15. Consent.verification.verified
            public ElementDefinitionInfo Element_Verified;                                                                                  // MakerGen.cs:219
            // 16. Consent.verification.verifiedWith
            public ElementDefinitionInfo Element_VerifiedWith;                                                                              // MakerGen.cs:219
            // 17. Consent.verification.verificationDate
            public ElementDefinitionInfo Element_VerificationDate;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Consent.verification",                                                                                          // MakerGen.cs:395
                    ElementId = "Consent.verification"                                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Verified.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_VerifiedWith.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_VerificationDate.Write(sDef);                                                                                       // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Verification()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 15. Consent.verification.verified
                    this.Element_Verified = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Verified",                                                                                          // MakerGen.cs:238
                        Path= "Consent.verification.verified",                                                                              // MakerGen.cs:239
                        Id = "Consent.verification.verified",                                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. Consent.verification.verifiedWith
                    this.Element_VerifiedWith = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_VerifiedWith",                                                                                      // MakerGen.cs:238
                        Path= "Consent.verification.verifiedWith",                                                                          // MakerGen.cs:239
                        Id = "Consent.verification.verifiedWith",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. Consent.verification.verificationDate
                    this.Element_VerificationDate = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_VerificationDate",                                                                                  // MakerGen.cs:238
                        Path= "Consent.verification.verificationDate",                                                                      // MakerGen.cs:239
                        Id = "Consent.verification.verificationDate",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 18. Consent.provision
        public class Type_Provision : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 21. Consent.provision.actor
            public class Type_Actor : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 22. Consent.provision.actor.role
                public ElementDefinitionInfo Element_Role;                                                                                  // MakerGen.cs:219
                // 23. Consent.provision.actor.reference
                public ElementDefinitionInfo Element_Reference;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "Consent.provision.actor",                                                                                   // MakerGen.cs:395
                        ElementId = "Consent.provision.actor"                                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Role.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Reference.Write(sDef);                                                                                          // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Actor()                                                                                                         // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 22. Consent.provision.actor.role
                        this.Element_Role = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Role",                                                                                          // MakerGen.cs:238
                            Path= "Consent.provision.actor.role",                                                                           // MakerGen.cs:239
                            Id = "Consent.provision.actor.role",                                                                            // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 23. Consent.provision.actor.reference
                        this.Element_Reference = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Reference",                                                                                     // MakerGen.cs:238
                            Path= "Consent.provision.actor.reference",                                                                      // MakerGen.cs:239
                            Id = "Consent.provision.actor.reference",                                                                       // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:346
                                {                                                                                                           // MakerGen.cs:347
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:349
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/Device",                                                   // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/Group",                                                    // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                 // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/Organization",                                             // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/Patient",                                                  // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",                                             // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                            // MakerGen.cs:349
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                          // MakerGen.cs:349
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:350
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 30. Consent.provision.data
            public class Type_Data : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 31. Consent.provision.data.meaning
                public ElementDefinitionInfo Element_Meaning;                                                                               // MakerGen.cs:219
                // 32. Consent.provision.data.reference
                public ElementDefinitionInfo Element_Reference;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "Consent.provision.data",                                                                                    // MakerGen.cs:395
                        ElementId = "Consent.provision.data"                                                                                // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Meaning.Write(sDef);                                                                                            // MakerGen.cs:223
                    Element_Reference.Write(sDef);                                                                                          // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Data()                                                                                                          // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 31. Consent.provision.data.meaning
                        this.Element_Meaning = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Meaning",                                                                                       // MakerGen.cs:238
                            Path= "Consent.provision.data.meaning",                                                                         // MakerGen.cs:239
                            Id = "Consent.provision.data.meaning",                                                                          // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 32. Consent.provision.data.reference
                        this.Element_Reference = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Reference",                                                                                     // MakerGen.cs:238
                            Path= "Consent.provision.data.reference",                                                                       // MakerGen.cs:239
                            Id = "Consent.provision.data.reference",                                                                        // MakerGen.cs:240
                            Min = 1,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:346
                                {                                                                                                           // MakerGen.cs:347
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:349
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/Resource"                                                  // MakerGen.cs:349
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:350
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 19. Consent.provision.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 20. Consent.provision.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:219
            // 21. Consent.provision.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:219
            // 24. Consent.provision.action
            public ElementDefinitionInfo Element_Action;                                                                                    // MakerGen.cs:219
            // 25. Consent.provision.securityLabel
            public ElementDefinitionInfo Element_SecurityLabel;                                                                             // MakerGen.cs:219
            // 26. Consent.provision.purpose
            public ElementDefinitionInfo Element_Purpose;                                                                                   // MakerGen.cs:219
            // 27. Consent.provision.class
            public ElementDefinitionInfo Element_Class;                                                                                     // MakerGen.cs:219
            // 28. Consent.provision.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 29. Consent.provision.dataPeriod
            public ElementDefinitionInfo Element_DataPeriod;                                                                                // MakerGen.cs:219
            // 30. Consent.provision.data
            public ElementDefinitionInfo Element_Data;                                                                                      // MakerGen.cs:219
            // 33. Consent.provision.provision
            public ElementDefinitionInfo Element_Provision;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Consent.provision",                                                                                             // MakerGen.cs:395
                    ElementId = "Consent.provision"                                                                                         // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Action.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_SecurityLabel.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_Purpose.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Class.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_DataPeriod.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_Data.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Provision.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Provision()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 19. Consent.provision.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "Consent.provision.type",                                                                                     // MakerGen.cs:239
                        Id = "Consent.provision.type",                                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. Consent.provision.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Period",                                                                                            // MakerGen.cs:238
                        Path= "Consent.provision.period",                                                                                   // MakerGen.cs:239
                        Id = "Consent.provision.period",                                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. Consent.provision.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:238
                        Path= "Consent.provision.actor",                                                                                    // MakerGen.cs:239
                        Id = "Consent.provision.actor",                                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Actor                                                                                                  // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 24. Consent.provision.action
                    this.Element_Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Action",                                                                                            // MakerGen.cs:238
                        Path= "Consent.provision.action",                                                                                   // MakerGen.cs:239
                        Id = "Consent.provision.action",                                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 25. Consent.provision.securityLabel
                    this.Element_SecurityLabel = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_SecurityLabel",                                                                                     // MakerGen.cs:238
                        Path= "Consent.provision.securityLabel",                                                                            // MakerGen.cs:239
                        Id = "Consent.provision.securityLabel",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 26. Consent.provision.purpose
                    this.Element_Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Purpose",                                                                                           // MakerGen.cs:238
                        Path= "Consent.provision.purpose",                                                                                  // MakerGen.cs:239
                        Id = "Consent.provision.purpose",                                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 27. Consent.provision.class
                    this.Element_Class = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Class",                                                                                             // MakerGen.cs:238
                        Path= "Consent.provision.class",                                                                                    // MakerGen.cs:239
                        Id = "Consent.provision.class",                                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 28. Consent.provision.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "Consent.provision.code",                                                                                     // MakerGen.cs:239
                        Id = "Consent.provision.code",                                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 29. Consent.provision.dataPeriod
                    this.Element_DataPeriod = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DataPeriod",                                                                                        // MakerGen.cs:238
                        Path= "Consent.provision.dataPeriod",                                                                               // MakerGen.cs:239
                        Id = "Consent.provision.dataPeriod",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 30. Consent.provision.data
                    this.Element_Data = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Data",                                                                                              // MakerGen.cs:238
                        Path= "Consent.provision.data",                                                                                     // MakerGen.cs:239
                        Id = "Consent.provision.data",                                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Data                                                                                                   // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 33. Consent.provision.provision
                    this.Element_Provision = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Provision",                                                                                         // MakerGen.cs:238
                        Path= "Consent.provision.provision",                                                                                // MakerGen.cs:239
                        Id = "Consent.provision.provision",                                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Consent.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Consent.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. Consent.scope
        public ElementDefinitionInfo Element_Scope;                                                                                         // MakerGen.cs:219
        // 4. Consent.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:219
        // 5. Consent.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
        // 6. Consent.dateTime
        public ElementDefinitionInfo Element_DateTime;                                                                                      // MakerGen.cs:219
        // 7. Consent.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:219
        // 8. Consent.organization
        public ElementDefinitionInfo Element_Organization;                                                                                  // MakerGen.cs:219
        // 9. Consent.source[x]
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:219
        // 10. Consent.policy
        public ElementDefinitionInfo Element_Policy;                                                                                        // MakerGen.cs:219
        // 13. Consent.policyRule
        public ElementDefinitionInfo Element_PolicyRule;                                                                                    // MakerGen.cs:219
        // 14. Consent.verification
        public ElementDefinitionInfo Element_Verification;                                                                                  // MakerGen.cs:219
        // 18. Consent.provision
        public ElementDefinitionInfo Element_Provision;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Consent",                                                                                                           // MakerGen.cs:395
                ElementId = "Consent"                                                                                                       // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Scope.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_DateTime.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Organization.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Policy.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_PolicyRule.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Verification.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Provision.Write(sDef);                                                                                                  // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Consent()                                                                                                           // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Consent.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Consent.identifier",                                                                                             // MakerGen.cs:239
                    Id = "Consent.identifier",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Consent.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "Consent.status",                                                                                                 // MakerGen.cs:239
                    Id = "Consent.status",                                                                                                  // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Consent.scope
                this.Element_Scope = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Scope",                                                                                                 // MakerGen.cs:238
                    Path= "Consent.scope",                                                                                                  // MakerGen.cs:239
                    Id = "Consent.scope",                                                                                                   // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Consent.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Category",                                                                                              // MakerGen.cs:238
                    Path= "Consent.category",                                                                                               // MakerGen.cs:239
                    Id = "Consent.category",                                                                                                // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Consent.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "Consent.patient",                                                                                                // MakerGen.cs:239
                    Id = "Consent.patient",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Consent.dateTime
                this.Element_DateTime = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DateTime",                                                                                              // MakerGen.cs:238
                    Path= "Consent.dateTime",                                                                                               // MakerGen.cs:239
                    Id = "Consent.dateTime",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Consent.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:238
                    Path= "Consent.performer",                                                                                              // MakerGen.cs:239
                    Id = "Consent.performer",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Consent.organization
                this.Element_Organization = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Organization",                                                                                          // MakerGen.cs:238
                    Path= "Consent.organization",                                                                                           // MakerGen.cs:239
                    Id = "Consent.organization",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. Consent.source[x]
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Source",                                                                                                // MakerGen.cs:238
                    Path= "Consent.source[x]",                                                                                              // MakerGen.cs:239
                    Id = "Consent.source[x]",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        },                                                                                                                  // MakerGen.cs:360
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Consent",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                                // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Contract",                                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse"                                             // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. Consent.policy
                this.Element_Policy = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Policy",                                                                                                // MakerGen.cs:238
                    Path= "Consent.policy",                                                                                                 // MakerGen.cs:239
                    Id = "Consent.policy",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Policy                                                                                                     // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. Consent.policyRule
                this.Element_PolicyRule = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PolicyRule",                                                                                            // MakerGen.cs:238
                    Path= "Consent.policyRule",                                                                                             // MakerGen.cs:239
                    Id = "Consent.policyRule",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. Consent.verification
                this.Element_Verification = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Verification",                                                                                          // MakerGen.cs:238
                    Path= "Consent.verification",                                                                                           // MakerGen.cs:239
                    Id = "Consent.verification",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Verification                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. Consent.provision
                this.Element_Provision = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Provision",                                                                                             // MakerGen.cs:238
                    Path= "Consent.provision",                                                                                              // MakerGen.cs:239
                    Id = "Consent.provision",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Provision                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Consent";                                                                                                          // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Consent";                                                                   // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
