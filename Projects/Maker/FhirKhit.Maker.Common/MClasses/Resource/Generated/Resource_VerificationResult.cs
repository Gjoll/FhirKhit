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
      "id": "VerificationResult",
      "url": "http://hl7.org/fhir/StructureDefinition/VerificationResult",
      "version": "4.0.0",
      "name": "VerificationResult",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Describes validation requirements, source(s), status and dates for one or more elements.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "VerificationResult",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "VerificationResult",
            "path": "VerificationResult",
            "short": "Describes validation requirements, source(s), status and dates for one or more elements",
            "definition": "Describes validation requirements, source(s), status and dates for one or more elements.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "VerificationResult.target",
            "path": "VerificationResult.target",
            "short": "A resource that was validated",
            "definition": "A resource that was validated.",
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
            "id": "VerificationResult.targetLocation",
            "path": "VerificationResult.targetLocation",
            "short": "The fhirpath location(s) within the resource that was validated",
            "definition": "The fhirpath location(s) within the resource that was validated.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "VerificationResult.need",
            "path": "VerificationResult.need",
            "short": "none | initial | periodic",
            "definition": "The frequency with which the target must be validated (none; initial; periodic).",
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
                  "valueString": "need"
                }
              ],
              "strength": "preferred",
              "description": "The frequency with which the target must be validated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-need"
            }
          },
          {
            "id": "VerificationResult.status",
            "path": "VerificationResult.status",
            "short": "attested | validated | in-process | req-revalid | val-fail | reval-fail",
            "definition": "The validation status of the target (attested; validated; in process; requires revalidation; validation failed; revalidation failed).",
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
                  "valueString": "status"
                }
              ],
              "strength": "required",
              "description": "The validation status of the target.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-status|4.0.0"
            }
          },
          {
            "id": "VerificationResult.statusDate",
            "path": "VerificationResult.statusDate",
            "short": "When the validation status was updated",
            "definition": "When the validation status was updated.",
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
            "id": "VerificationResult.validationType",
            "path": "VerificationResult.validationType",
            "short": "nothing | primary | multiple",
            "definition": "What the target is validated against (nothing; primary source; multiple sources).",
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
                  "valueString": "validation-type"
                }
              ],
              "strength": "preferred",
              "description": "What the target is validated against.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-validation-type"
            }
          },
          {
            "id": "VerificationResult.validationProcess",
            "path": "VerificationResult.validationProcess",
            "short": "The primary process by which the target is validated (edit check; value set; primary source; multiple sources; standalone; in context)",
            "definition": "The primary process by which the target is validated (edit check; value set; primary source; multiple sources; standalone; in context).",
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
                  "valueString": "validation-process"
                }
              ],
              "strength": "example",
              "description": "The primary process by which the target is validated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-validation-process"
            }
          },
          {
            "id": "VerificationResult.frequency",
            "path": "VerificationResult.frequency",
            "short": "Frequency of revalidation",
            "definition": "Frequency of revalidation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "VerificationResult.lastPerformed",
            "path": "VerificationResult.lastPerformed",
            "short": "The date/time validation was last completed (including failed validations)",
            "definition": "The date/time validation was last completed (including failed validations).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "VerificationResult.nextScheduled",
            "path": "VerificationResult.nextScheduled",
            "short": "The date when target is next validated, if appropriate",
            "definition": "The date when target is next validated, if appropriate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "VerificationResult.failureAction",
            "path": "VerificationResult.failureAction",
            "short": "fatal | warn | rec-only | none",
            "definition": "The result if validation fails (fatal; warning; record only; none).",
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
                  "valueString": "failure-action"
                }
              ],
              "strength": "preferred",
              "description": "The result if validation fails.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-failure-action"
            }
          },
          {
            "id": "VerificationResult.primarySource",
            "path": "VerificationResult.primarySource",
            "short": "Information about the primary source(s) involved in validation",
            "definition": "Information about the primary source(s) involved in validation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "VerificationResult.primarySource.who",
            "path": "VerificationResult.primarySource.who",
            "short": "Reference to the primary source",
            "definition": "Reference to the primary source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "VerificationResult.primarySource.type",
            "path": "VerificationResult.primarySource.type",
            "short": "Type of primary source (License Board; Primary Education; Continuing Education; Postal Service; Relationship owner; Registration Authority; legal source; issuing source; authoritative source)",
            "definition": "Type of primary source (License Board; Primary Education; Continuing Education; Postal Service; Relationship owner; Registration Authority; legal source; issuing source; authoritative source).",
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
                  "valueString": "primary-source-type"
                }
              ],
              "strength": "example",
              "description": "Type of the validation primary source.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-primary-source-type"
            }
          },
          {
            "id": "VerificationResult.primarySource.communicationMethod",
            "path": "VerificationResult.primarySource.communicationMethod",
            "short": "Method for exchanging information with the primary source",
            "definition": "Method for communicating with the primary source (manual; API; Push).",
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
                  "valueString": "communication-method"
                }
              ],
              "strength": "example",
              "description": "Method for communicating with the data source (manual; API; Push).",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-communication-method"
            }
          },
          {
            "id": "VerificationResult.primarySource.validationStatus",
            "path": "VerificationResult.primarySource.validationStatus",
            "short": "successful | failed | unknown",
            "definition": "Status of the validation of the target against the primary source (successful; failed; unknown).",
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
                  "valueString": "validation-status"
                }
              ],
              "strength": "preferred",
              "description": "Status of the validation of the target against the primary source.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-validation-status"
            }
          },
          {
            "id": "VerificationResult.primarySource.validationDate",
            "path": "VerificationResult.primarySource.validationDate",
            "short": "When the target was validated against the primary source",
            "definition": "When the target was validated against the primary source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "VerificationResult.primarySource.canPushUpdates",
            "path": "VerificationResult.primarySource.canPushUpdates",
            "short": "yes | no | undetermined",
            "definition": "Ability of the primary source to push updates/alerts (yes; no; undetermined).",
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
                  "valueString": "can-push-updates"
                }
              ],
              "strength": "preferred",
              "description": "Ability of the primary source to push updates/alerts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-can-push-updates"
            }
          },
          {
            "id": "VerificationResult.primarySource.pushTypeAvailable",
            "path": "VerificationResult.primarySource.pushTypeAvailable",
            "short": "specific | any | source",
            "definition": "Type of alerts/updates the primary source can send (specific requested changes; any changes; as defined by source).",
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
                  "valueString": "push-type-available"
                }
              ],
              "strength": "preferred",
              "description": "Type of alerts/updates the primary source can send.",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-push-type-available"
            }
          },
          {
            "id": "VerificationResult.attestation",
            "path": "VerificationResult.attestation",
            "short": "Information about the entity attesting to information",
            "definition": "Information about the entity attesting to information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "VerificationResult.attestation.who",
            "path": "VerificationResult.attestation.who",
            "short": "The individual or organization attesting to information",
            "definition": "The individual or organization attesting to information.",
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
            ],
            "isSummary": true
          },
          {
            "id": "VerificationResult.attestation.onBehalfOf",
            "path": "VerificationResult.attestation.onBehalfOf",
            "short": "When the who is asserting on behalf of another (organization or individual)",
            "definition": "When the who is asserting on behalf of another (organization or individual).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "VerificationResult.attestation.communicationMethod",
            "path": "VerificationResult.attestation.communicationMethod",
            "short": "The method by which attested information was submitted/retrieved",
            "definition": "The method by which attested information was submitted/retrieved (manual; API; Push).",
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
                  "valueString": "communication-method"
                }
              ],
              "strength": "example",
              "description": "Method for communicating with the data source (manual; API; Push).",
              "valueSet": "http://hl7.org/fhir/ValueSet/verificationresult-communication-method"
            }
          },
          {
            "id": "VerificationResult.attestation.date",
            "path": "VerificationResult.attestation.date",
            "short": "The date the information was attested to",
            "definition": "The date the information was attested to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "VerificationResult.attestation.sourceIdentityCertificate",
            "path": "VerificationResult.attestation.sourceIdentityCertificate",
            "short": "A digital identity certificate associated with the attestation source",
            "definition": "A digital identity certificate associated with the attestation source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "VerificationResult.attestation.proxyIdentityCertificate",
            "path": "VerificationResult.attestation.proxyIdentityCertificate",
            "short": "A digital identity certificate associated with the proxy entity submitting attested information on behalf of the attestation source",
            "definition": "A digital identity certificate associated with the proxy entity submitting attested information on behalf of the attestation source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "VerificationResult.attestation.proxySignature",
            "path": "VerificationResult.attestation.proxySignature",
            "short": "Proxy signature",
            "definition": "Signed assertion by the proxy entity indicating that they have the right to submit attested information on behalf of the attestation source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Signature"
              }
            ]
          },
          {
            "id": "VerificationResult.attestation.sourceSignature",
            "path": "VerificationResult.attestation.sourceSignature",
            "short": "Attester signature",
            "definition": "Signed assertion by the attestation source that they have attested to the information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Signature"
              }
            ]
          },
          {
            "id": "VerificationResult.validator",
            "path": "VerificationResult.validator",
            "short": "Information about the entity validating information",
            "definition": "Information about the entity validating information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "VerificationResult.validator.organization",
            "path": "VerificationResult.validator.organization",
            "short": "Reference to the organization validating information",
            "definition": "Reference to the organization validating information.",
            "min": 1,
            "max": "1",
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
            "id": "VerificationResult.validator.identityCertificate",
            "path": "VerificationResult.validator.identityCertificate",
            "short": "A digital identity certificate associated with the validator",
            "definition": "A digital identity certificate associated with the validator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "VerificationResult.validator.attestationSignature",
            "path": "VerificationResult.validator.attestationSignature",
            "short": "Validator signature",
            "definition": "Signed assertion by the validator that they have validated the information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Signature"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'VerificationResult'
    /// </summary>
    // 0. VerificationResult
    public class Resource_VerificationResult : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. VerificationResult.primarySource
        public class Type_PrimarySource : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. VerificationResult.primarySource.who
            public ElementDefinitionInfo Element_Who;
            // 14. VerificationResult.primarySource.type
            public ElementDefinitionInfo Element_Type;
            // 15. VerificationResult.primarySource.communicationMethod
            public ElementDefinitionInfo Element_CommunicationMethod;
            // 16. VerificationResult.primarySource.validationStatus
            public ElementDefinitionInfo Element_ValidationStatus;
            // 17. VerificationResult.primarySource.validationDate
            public ElementDefinitionInfo Element_ValidationDate;
            // 18. VerificationResult.primarySource.canPushUpdates
            public ElementDefinitionInfo Element_CanPushUpdates;
            // 19. VerificationResult.primarySource.pushTypeAvailable
            public ElementDefinitionInfo Element_PushTypeAvailable;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "VerificationResult.primarySource",
                    ElementId = "VerificationResult.primarySource"
                });
                Element_Who.Write(sDef);
                Element_Type.Write(sDef);
                Element_CommunicationMethod.Write(sDef);
                Element_ValidationStatus.Write(sDef);
                Element_ValidationDate.Write(sDef);
                Element_CanPushUpdates.Write(sDef);
                Element_PushTypeAvailable.Write(sDef);
            }
            
            public Type_PrimarySource()
            {
                {
                    // 13. VerificationResult.primarySource.who
                    this.Element_Who = new ElementDefinitionInfo
                    {
                        Name = "Element_Who",
                        Path= "VerificationResult.primarySource.who",
                        Id = "VerificationResult.primarySource.who",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 14. VerificationResult.primarySource.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "VerificationResult.primarySource.type",
                        Id = "VerificationResult.primarySource.type",
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
                    // 15. VerificationResult.primarySource.communicationMethod
                    this.Element_CommunicationMethod = new ElementDefinitionInfo
                    {
                        Name = "Element_CommunicationMethod",
                        Path= "VerificationResult.primarySource.communicationMethod",
                        Id = "VerificationResult.primarySource.communicationMethod",
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
                    // 16. VerificationResult.primarySource.validationStatus
                    this.Element_ValidationStatus = new ElementDefinitionInfo
                    {
                        Name = "Element_ValidationStatus",
                        Path= "VerificationResult.primarySource.validationStatus",
                        Id = "VerificationResult.primarySource.validationStatus",
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
                    // 17. VerificationResult.primarySource.validationDate
                    this.Element_ValidationDate = new ElementDefinitionInfo
                    {
                        Name = "Element_ValidationDate",
                        Path= "VerificationResult.primarySource.validationDate",
                        Id = "VerificationResult.primarySource.validationDate",
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
                    // 18. VerificationResult.primarySource.canPushUpdates
                    this.Element_CanPushUpdates = new ElementDefinitionInfo
                    {
                        Name = "Element_CanPushUpdates",
                        Path= "VerificationResult.primarySource.canPushUpdates",
                        Id = "VerificationResult.primarySource.canPushUpdates",
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
                    // 19. VerificationResult.primarySource.pushTypeAvailable
                    this.Element_PushTypeAvailable = new ElementDefinitionInfo
                    {
                        Name = "Element_PushTypeAvailable",
                        Path= "VerificationResult.primarySource.pushTypeAvailable",
                        Id = "VerificationResult.primarySource.pushTypeAvailable",
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
            }
        }
        // 20. VerificationResult.attestation
        public class Type_Attestation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. VerificationResult.attestation.who
            public ElementDefinitionInfo Element_Who;
            // 22. VerificationResult.attestation.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;
            // 23. VerificationResult.attestation.communicationMethod
            public ElementDefinitionInfo Element_CommunicationMethod;
            // 24. VerificationResult.attestation.date
            public ElementDefinitionInfo Element_Date;
            // 25. VerificationResult.attestation.sourceIdentityCertificate
            public ElementDefinitionInfo Element_SourceIdentityCertificate;
            // 26. VerificationResult.attestation.proxyIdentityCertificate
            public ElementDefinitionInfo Element_ProxyIdentityCertificate;
            // 27. VerificationResult.attestation.proxySignature
            public ElementDefinitionInfo Element_ProxySignature;
            // 28. VerificationResult.attestation.sourceSignature
            public ElementDefinitionInfo Element_SourceSignature;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "VerificationResult.attestation",
                    ElementId = "VerificationResult.attestation"
                });
                Element_Who.Write(sDef);
                Element_OnBehalfOf.Write(sDef);
                Element_CommunicationMethod.Write(sDef);
                Element_Date.Write(sDef);
                Element_SourceIdentityCertificate.Write(sDef);
                Element_ProxyIdentityCertificate.Write(sDef);
                Element_ProxySignature.Write(sDef);
                Element_SourceSignature.Write(sDef);
            }
            
            public Type_Attestation()
            {
                {
                    // 21. VerificationResult.attestation.who
                    this.Element_Who = new ElementDefinitionInfo
                    {
                        Name = "Element_Who",
                        Path= "VerificationResult.attestation.who",
                        Id = "VerificationResult.attestation.who",
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
                    // 22. VerificationResult.attestation.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo
                    {
                        Name = "Element_OnBehalfOf",
                        Path= "VerificationResult.attestation.onBehalfOf",
                        Id = "VerificationResult.attestation.onBehalfOf",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 23. VerificationResult.attestation.communicationMethod
                    this.Element_CommunicationMethod = new ElementDefinitionInfo
                    {
                        Name = "Element_CommunicationMethod",
                        Path= "VerificationResult.attestation.communicationMethod",
                        Id = "VerificationResult.attestation.communicationMethod",
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
                    // 24. VerificationResult.attestation.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "VerificationResult.attestation.date",
                        Id = "VerificationResult.attestation.date",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date
                            {
                            }
                        }
                    };
                }
                {
                    // 25. VerificationResult.attestation.sourceIdentityCertificate
                    this.Element_SourceIdentityCertificate = new ElementDefinitionInfo
                    {
                        Name = "Element_SourceIdentityCertificate",
                        Path= "VerificationResult.attestation.sourceIdentityCertificate",
                        Id = "VerificationResult.attestation.sourceIdentityCertificate",
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
                    // 26. VerificationResult.attestation.proxyIdentityCertificate
                    this.Element_ProxyIdentityCertificate = new ElementDefinitionInfo
                    {
                        Name = "Element_ProxyIdentityCertificate",
                        Path= "VerificationResult.attestation.proxyIdentityCertificate",
                        Id = "VerificationResult.attestation.proxyIdentityCertificate",
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
                    // 27. VerificationResult.attestation.proxySignature
                    this.Element_ProxySignature = new ElementDefinitionInfo
                    {
                        Name = "Element_ProxySignature",
                        Path= "VerificationResult.attestation.proxySignature",
                        Id = "VerificationResult.attestation.proxySignature",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Signature
                            {
                            }
                        }
                    };
                }
                {
                    // 28. VerificationResult.attestation.sourceSignature
                    this.Element_SourceSignature = new ElementDefinitionInfo
                    {
                        Name = "Element_SourceSignature",
                        Path= "VerificationResult.attestation.sourceSignature",
                        Id = "VerificationResult.attestation.sourceSignature",
                        Min = 0,
                        Max = 1,
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
        // 29. VerificationResult.validator
        public class Type_Validator : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 30. VerificationResult.validator.organization
            public ElementDefinitionInfo Element_Organization;
            // 31. VerificationResult.validator.identityCertificate
            public ElementDefinitionInfo Element_IdentityCertificate;
            // 32. VerificationResult.validator.attestationSignature
            public ElementDefinitionInfo Element_AttestationSignature;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "VerificationResult.validator",
                    ElementId = "VerificationResult.validator"
                });
                Element_Organization.Write(sDef);
                Element_IdentityCertificate.Write(sDef);
                Element_AttestationSignature.Write(sDef);
            }
            
            public Type_Validator()
            {
                {
                    // 30. VerificationResult.validator.organization
                    this.Element_Organization = new ElementDefinitionInfo
                    {
                        Name = "Element_Organization",
                        Path= "VerificationResult.validator.organization",
                        Id = "VerificationResult.validator.organization",
                        Min = 1,
                        Max = 1,
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
                    // 31. VerificationResult.validator.identityCertificate
                    this.Element_IdentityCertificate = new ElementDefinitionInfo
                    {
                        Name = "Element_IdentityCertificate",
                        Path= "VerificationResult.validator.identityCertificate",
                        Id = "VerificationResult.validator.identityCertificate",
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
                    // 32. VerificationResult.validator.attestationSignature
                    this.Element_AttestationSignature = new ElementDefinitionInfo
                    {
                        Name = "Element_AttestationSignature",
                        Path= "VerificationResult.validator.attestationSignature",
                        Id = "VerificationResult.validator.attestationSignature",
                        Min = 0,
                        Max = 1,
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
        // 1. VerificationResult.target
        public ElementDefinitionInfo Element_Target;
        // 2. VerificationResult.targetLocation
        public ElementDefinitionInfo Element_TargetLocation;
        // 3. VerificationResult.need
        public ElementDefinitionInfo Element_Need;
        // 4. VerificationResult.status
        public ElementDefinitionInfo Element_Status;
        // 5. VerificationResult.statusDate
        public ElementDefinitionInfo Element_StatusDate;
        // 6. VerificationResult.validationType
        public ElementDefinitionInfo Element_ValidationType;
        // 7. VerificationResult.validationProcess
        public ElementDefinitionInfo Element_ValidationProcess;
        // 8. VerificationResult.frequency
        public ElementDefinitionInfo Element_Frequency;
        // 9. VerificationResult.lastPerformed
        public ElementDefinitionInfo Element_LastPerformed;
        // 10. VerificationResult.nextScheduled
        public ElementDefinitionInfo Element_NextScheduled;
        // 11. VerificationResult.failureAction
        public ElementDefinitionInfo Element_FailureAction;
        // 12. VerificationResult.primarySource
        public ElementDefinitionInfo Element_PrimarySource;
        // 20. VerificationResult.attestation
        public ElementDefinitionInfo Element_Attestation;
        // 29. VerificationResult.validator
        public ElementDefinitionInfo Element_Validator;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "VerificationResult",
                ElementId = "VerificationResult"
            });
            Element_Target.Write(sDef);
            Element_TargetLocation.Write(sDef);
            Element_Need.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusDate.Write(sDef);
            Element_ValidationType.Write(sDef);
            Element_ValidationProcess.Write(sDef);
            Element_Frequency.Write(sDef);
            Element_LastPerformed.Write(sDef);
            Element_NextScheduled.Write(sDef);
            Element_FailureAction.Write(sDef);
            Element_PrimarySource.Write(sDef);
            Element_Attestation.Write(sDef);
            Element_Validator.Write(sDef);
        }
        
        public Resource_VerificationResult()
        {
            {
                // 1. VerificationResult.target
                this.Element_Target = new ElementDefinitionInfo
                {
                    Name = "Element_Target",
                    Path= "VerificationResult.target",
                    Id = "VerificationResult.target",
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
                // 2. VerificationResult.targetLocation
                this.Element_TargetLocation = new ElementDefinitionInfo
                {
                    Name = "Element_TargetLocation",
                    Path= "VerificationResult.targetLocation",
                    Id = "VerificationResult.targetLocation",
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
                // 3. VerificationResult.need
                this.Element_Need = new ElementDefinitionInfo
                {
                    Name = "Element_Need",
                    Path= "VerificationResult.need",
                    Id = "VerificationResult.need",
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
                // 4. VerificationResult.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "VerificationResult.status",
                    Id = "VerificationResult.status",
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
                // 5. VerificationResult.statusDate
                this.Element_StatusDate = new ElementDefinitionInfo
                {
                    Name = "Element_StatusDate",
                    Path= "VerificationResult.statusDate",
                    Id = "VerificationResult.statusDate",
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
                // 6. VerificationResult.validationType
                this.Element_ValidationType = new ElementDefinitionInfo
                {
                    Name = "Element_ValidationType",
                    Path= "VerificationResult.validationType",
                    Id = "VerificationResult.validationType",
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
                // 7. VerificationResult.validationProcess
                this.Element_ValidationProcess = new ElementDefinitionInfo
                {
                    Name = "Element_ValidationProcess",
                    Path= "VerificationResult.validationProcess",
                    Id = "VerificationResult.validationProcess",
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
                // 8. VerificationResult.frequency
                this.Element_Frequency = new ElementDefinitionInfo
                {
                    Name = "Element_Frequency",
                    Path= "VerificationResult.frequency",
                    Id = "VerificationResult.frequency",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        }
                    }
                };
            }
            {
                // 9. VerificationResult.lastPerformed
                this.Element_LastPerformed = new ElementDefinitionInfo
                {
                    Name = "Element_LastPerformed",
                    Path= "VerificationResult.lastPerformed",
                    Id = "VerificationResult.lastPerformed",
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
                // 10. VerificationResult.nextScheduled
                this.Element_NextScheduled = new ElementDefinitionInfo
                {
                    Name = "Element_NextScheduled",
                    Path= "VerificationResult.nextScheduled",
                    Id = "VerificationResult.nextScheduled",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        }
                    }
                };
            }
            {
                // 11. VerificationResult.failureAction
                this.Element_FailureAction = new ElementDefinitionInfo
                {
                    Name = "Element_FailureAction",
                    Path= "VerificationResult.failureAction",
                    Id = "VerificationResult.failureAction",
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
                // 12. VerificationResult.primarySource
                this.Element_PrimarySource = new ElementDefinitionInfo
                {
                    Name = "Element_PrimarySource",
                    Path= "VerificationResult.primarySource",
                    Id = "VerificationResult.primarySource",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_PrimarySource
                        {
                        }
                    }
                };
            }
            {
                // 20. VerificationResult.attestation
                this.Element_Attestation = new ElementDefinitionInfo
                {
                    Name = "Element_Attestation",
                    Path= "VerificationResult.attestation",
                    Id = "VerificationResult.attestation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Attestation
                        {
                        }
                    }
                };
            }
            {
                // 29. VerificationResult.validator
                this.Element_Validator = new ElementDefinitionInfo
                {
                    Name = "Element_Validator",
                    Path= "VerificationResult.validator",
                    Id = "VerificationResult.validator",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Validator
                        {
                        }
                    }
                };
            }
            this.Name = "VerificationResult";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VerificationResult";
        }
    }
}
