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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'VerificationResult'
    /// </summary>
    // 0. VerificationResult
    public class VerificationResult : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class VerificationResult_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 12. VerificationResult.primarySource
            public class Type_PrimarySource : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_PrimarySource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 13. VerificationResult.primarySource.who
                    public ElementDefinitionInfo Who;                                                                                       // MakerGen.cs:216
                    // 14. VerificationResult.primarySource.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 15. VerificationResult.primarySource.communicationMethod
                    public ElementDefinitionInfo CommunicationMethod;                                                                       // MakerGen.cs:216
                    // 16. VerificationResult.primarySource.validationStatus
                    public ElementDefinitionInfo ValidationStatus;                                                                          // MakerGen.cs:216
                    // 17. VerificationResult.primarySource.validationDate
                    public ElementDefinitionInfo ValidationDate;                                                                            // MakerGen.cs:216
                    // 18. VerificationResult.primarySource.canPushUpdates
                    public ElementDefinitionInfo CanPushUpdates;                                                                            // MakerGen.cs:216
                    // 19. VerificationResult.primarySource.pushTypeAvailable
                    public ElementDefinitionInfo PushTypeAvailable;                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_PrimarySource_Elements()                                                                                    // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. VerificationResult.primarySource.who
                            this.Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Who",                                                                                               // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.who",                                                               // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.who",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. VerificationResult.primarySource.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.type",                                                              // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.type",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. VerificationResult.primarySource.communicationMethod
                            this.CommunicationMethod = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CommunicationMethod",                                                                               // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.communicationMethod",                                               // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.communicationMethod",                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. VerificationResult.primarySource.validationStatus
                            this.ValidationStatus = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ValidationStatus",                                                                                  // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.validationStatus",                                                  // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.validationStatus",                                                   // MakerGen.cs:237
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
                            // 17. VerificationResult.primarySource.validationDate
                            this.ValidationDate = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ValidationDate",                                                                                    // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.validationDate",                                                    // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.validationDate",                                                     // MakerGen.cs:237
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
                            // 18. VerificationResult.primarySource.canPushUpdates
                            this.CanPushUpdates = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CanPushUpdates",                                                                                    // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.canPushUpdates",                                                    // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.canPushUpdates",                                                     // MakerGen.cs:237
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
                            // 19. VerificationResult.primarySource.pushTypeAvailable
                            this.PushTypeAvailable = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PushTypeAvailable",                                                                                 // MakerGen.cs:235
                                Path= "VerificationResult.primarySource.pushTypeAvailable",                                                 // MakerGen.cs:236
                                Id = "VerificationResult.primarySource.pushTypeAvailable",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Who.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        CommunicationMethod.Write(sDef);                                                                                    // MakerGen.cs:220
                        ValidationStatus.Write(sDef);                                                                                       // MakerGen.cs:220
                        ValidationDate.Write(sDef);                                                                                         // MakerGen.cs:220
                        CanPushUpdates.Write(sDef);                                                                                         // MakerGen.cs:220
                        PushTypeAvailable.Write(sDef);                                                                                      // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_PrimarySource_Elements Elements                                                                                 // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_PrimarySource_Elements();                                                              // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_PrimarySource_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_PrimarySource()                                                                                                 // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "VerificationResult.primarySource",                                                                          // MakerGen.cs:428
                        ElementId = "VerificationResult.primarySource"                                                                      // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 20. VerificationResult.attestation
            public class Type_Attestation : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Attestation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 21. VerificationResult.attestation.who
                    public ElementDefinitionInfo Who;                                                                                       // MakerGen.cs:216
                    // 22. VerificationResult.attestation.onBehalfOf
                    public ElementDefinitionInfo OnBehalfOf;                                                                                // MakerGen.cs:216
                    // 23. VerificationResult.attestation.communicationMethod
                    public ElementDefinitionInfo CommunicationMethod;                                                                       // MakerGen.cs:216
                    // 24. VerificationResult.attestation.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:216
                    // 25. VerificationResult.attestation.sourceIdentityCertificate
                    public ElementDefinitionInfo SourceIdentityCertificate;                                                                 // MakerGen.cs:216
                    // 26. VerificationResult.attestation.proxyIdentityCertificate
                    public ElementDefinitionInfo ProxyIdentityCertificate;                                                                  // MakerGen.cs:216
                    // 27. VerificationResult.attestation.proxySignature
                    public ElementDefinitionInfo ProxySignature;                                                                            // MakerGen.cs:216
                    // 28. VerificationResult.attestation.sourceSignature
                    public ElementDefinitionInfo SourceSignature;                                                                           // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Attestation_Elements()                                                                                      // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. VerificationResult.attestation.who
                            this.Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Who",                                                                                               // MakerGen.cs:235
                                Path= "VerificationResult.attestation.who",                                                                 // MakerGen.cs:236
                                Id = "VerificationResult.attestation.who",                                                                  // MakerGen.cs:237
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
                            // 22. VerificationResult.attestation.onBehalfOf
                            this.OnBehalfOf = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OnBehalfOf",                                                                                        // MakerGen.cs:235
                                Path= "VerificationResult.attestation.onBehalfOf",                                                          // MakerGen.cs:236
                                Id = "VerificationResult.attestation.onBehalfOf",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. VerificationResult.attestation.communicationMethod
                            this.CommunicationMethod = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CommunicationMethod",                                                                               // MakerGen.cs:235
                                Path= "VerificationResult.attestation.communicationMethod",                                                 // MakerGen.cs:236
                                Id = "VerificationResult.attestation.communicationMethod",                                                  // MakerGen.cs:237
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
                            // 24. VerificationResult.attestation.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Date",                                                                                              // MakerGen.cs:235
                                Path= "VerificationResult.attestation.date",                                                                // MakerGen.cs:236
                                Id = "VerificationResult.attestation.date",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. VerificationResult.attestation.sourceIdentityCertificate
                            this.SourceIdentityCertificate = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SourceIdentityCertificate",                                                                         // MakerGen.cs:235
                                Path= "VerificationResult.attestation.sourceIdentityCertificate",                                           // MakerGen.cs:236
                                Id = "VerificationResult.attestation.sourceIdentityCertificate",                                            // MakerGen.cs:237
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
                            // 26. VerificationResult.attestation.proxyIdentityCertificate
                            this.ProxyIdentityCertificate = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ProxyIdentityCertificate",                                                                          // MakerGen.cs:235
                                Path= "VerificationResult.attestation.proxyIdentityCertificate",                                            // MakerGen.cs:236
                                Id = "VerificationResult.attestation.proxyIdentityCertificate",                                             // MakerGen.cs:237
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
                            // 27. VerificationResult.attestation.proxySignature
                            this.ProxySignature = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ProxySignature",                                                                                    // MakerGen.cs:235
                                Path= "VerificationResult.attestation.proxySignature",                                                      // MakerGen.cs:236
                                Id = "VerificationResult.attestation.proxySignature",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. VerificationResult.attestation.sourceSignature
                            this.SourceSignature = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SourceSignature",                                                                                   // MakerGen.cs:235
                                Path= "VerificationResult.attestation.sourceSignature",                                                     // MakerGen.cs:236
                                Id = "VerificationResult.attestation.sourceSignature",                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Who.Write(sDef);                                                                                                    // MakerGen.cs:220
                        OnBehalfOf.Write(sDef);                                                                                             // MakerGen.cs:220
                        CommunicationMethod.Write(sDef);                                                                                    // MakerGen.cs:220
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:220
                        SourceIdentityCertificate.Write(sDef);                                                                              // MakerGen.cs:220
                        ProxyIdentityCertificate.Write(sDef);                                                                               // MakerGen.cs:220
                        ProxySignature.Write(sDef);                                                                                         // MakerGen.cs:220
                        SourceSignature.Write(sDef);                                                                                        // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Attestation_Elements Elements                                                                                   // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Attestation_Elements();                                                                // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Attestation_Elements elements;                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Attestation()                                                                                                   // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "VerificationResult.attestation",                                                                            // MakerGen.cs:428
                        ElementId = "VerificationResult.attestation"                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 29. VerificationResult.validator
            public class Type_Validator : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Validator_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 30. VerificationResult.validator.organization
                    public ElementDefinitionInfo Organization;                                                                              // MakerGen.cs:216
                    // 31. VerificationResult.validator.identityCertificate
                    public ElementDefinitionInfo IdentityCertificate;                                                                       // MakerGen.cs:216
                    // 32. VerificationResult.validator.attestationSignature
                    public ElementDefinitionInfo AttestationSignature;                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Validator_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. VerificationResult.validator.organization
                            this.Organization = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Organization",                                                                                      // MakerGen.cs:235
                                Path= "VerificationResult.validator.organization",                                                          // MakerGen.cs:236
                                Id = "VerificationResult.validator.organization",                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. VerificationResult.validator.identityCertificate
                            this.IdentityCertificate = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "IdentityCertificate",                                                                               // MakerGen.cs:235
                                Path= "VerificationResult.validator.identityCertificate",                                                   // MakerGen.cs:236
                                Id = "VerificationResult.validator.identityCertificate",                                                    // MakerGen.cs:237
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
                            // 32. VerificationResult.validator.attestationSignature
                            this.AttestationSignature = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AttestationSignature",                                                                              // MakerGen.cs:235
                                Path= "VerificationResult.validator.attestationSignature",                                                  // MakerGen.cs:236
                                Id = "VerificationResult.validator.attestationSignature",                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Organization.Write(sDef);                                                                                           // MakerGen.cs:220
                        IdentityCertificate.Write(sDef);                                                                                    // MakerGen.cs:220
                        AttestationSignature.Write(sDef);                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Validator_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Validator_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Validator_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Validator()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "VerificationResult.validator",                                                                              // MakerGen.cs:428
                        ElementId = "VerificationResult.validator"                                                                          // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. VerificationResult.target
            public ElementDefinitionInfo Target;                                                                                            // MakerGen.cs:216
            // 2. VerificationResult.targetLocation
            public ElementDefinitionInfo TargetLocation;                                                                                    // MakerGen.cs:216
            // 3. VerificationResult.need
            public ElementDefinitionInfo Need;                                                                                              // MakerGen.cs:216
            // 4. VerificationResult.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 5. VerificationResult.statusDate
            public ElementDefinitionInfo StatusDate;                                                                                        // MakerGen.cs:216
            // 6. VerificationResult.validationType
            public ElementDefinitionInfo ValidationType;                                                                                    // MakerGen.cs:216
            // 7. VerificationResult.validationProcess
            public ElementDefinitionInfo ValidationProcess;                                                                                 // MakerGen.cs:216
            // 8. VerificationResult.frequency
            public ElementDefinitionInfo Frequency;                                                                                         // MakerGen.cs:216
            // 9. VerificationResult.lastPerformed
            public ElementDefinitionInfo LastPerformed;                                                                                     // MakerGen.cs:216
            // 10. VerificationResult.nextScheduled
            public ElementDefinitionInfo NextScheduled;                                                                                     // MakerGen.cs:216
            // 11. VerificationResult.failureAction
            public ElementDefinitionInfo FailureAction;                                                                                     // MakerGen.cs:216
            // 12. VerificationResult.primarySource
            public ElementDefinitionInfo PrimarySource;                                                                                     // MakerGen.cs:216
            // 20. VerificationResult.attestation
            public ElementDefinitionInfo Attestation;                                                                                       // MakerGen.cs:216
            // 29. VerificationResult.validator
            public ElementDefinitionInfo Validator;                                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public VerificationResult_Elements()                                                                                            // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. VerificationResult.target
                    this.Target = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Target",                                                                                                    // MakerGen.cs:235
                        Path= "VerificationResult.target",                                                                                  // MakerGen.cs:236
                        Id = "VerificationResult.target",                                                                                   // MakerGen.cs:237
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
                    // 2. VerificationResult.targetLocation
                    this.TargetLocation = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "TargetLocation",                                                                                            // MakerGen.cs:235
                        Path= "VerificationResult.targetLocation",                                                                          // MakerGen.cs:236
                        Id = "VerificationResult.targetLocation",                                                                           // MakerGen.cs:237
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
                    // 3. VerificationResult.need
                    this.Need = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Need",                                                                                                      // MakerGen.cs:235
                        Path= "VerificationResult.need",                                                                                    // MakerGen.cs:236
                        Id = "VerificationResult.need",                                                                                     // MakerGen.cs:237
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
                    // 4. VerificationResult.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "VerificationResult.status",                                                                                  // MakerGen.cs:236
                        Id = "VerificationResult.status",                                                                                   // MakerGen.cs:237
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
                    // 5. VerificationResult.statusDate
                    this.StatusDate = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusDate",                                                                                                // MakerGen.cs:235
                        Path= "VerificationResult.statusDate",                                                                              // MakerGen.cs:236
                        Id = "VerificationResult.statusDate",                                                                               // MakerGen.cs:237
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
                    // 6. VerificationResult.validationType
                    this.ValidationType = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ValidationType",                                                                                            // MakerGen.cs:235
                        Path= "VerificationResult.validationType",                                                                          // MakerGen.cs:236
                        Id = "VerificationResult.validationType",                                                                           // MakerGen.cs:237
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
                    // 7. VerificationResult.validationProcess
                    this.ValidationProcess = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ValidationProcess",                                                                                         // MakerGen.cs:235
                        Path= "VerificationResult.validationProcess",                                                                       // MakerGen.cs:236
                        Id = "VerificationResult.validationProcess",                                                                        // MakerGen.cs:237
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
                    // 8. VerificationResult.frequency
                    this.Frequency = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Frequency",                                                                                                 // MakerGen.cs:235
                        Path= "VerificationResult.frequency",                                                                               // MakerGen.cs:236
                        Id = "VerificationResult.frequency",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. VerificationResult.lastPerformed
                    this.LastPerformed = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LastPerformed",                                                                                             // MakerGen.cs:235
                        Path= "VerificationResult.lastPerformed",                                                                           // MakerGen.cs:236
                        Id = "VerificationResult.lastPerformed",                                                                            // MakerGen.cs:237
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
                    // 10. VerificationResult.nextScheduled
                    this.NextScheduled = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "NextScheduled",                                                                                             // MakerGen.cs:235
                        Path= "VerificationResult.nextScheduled",                                                                           // MakerGen.cs:236
                        Id = "VerificationResult.nextScheduled",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. VerificationResult.failureAction
                    this.FailureAction = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "FailureAction",                                                                                             // MakerGen.cs:235
                        Path= "VerificationResult.failureAction",                                                                           // MakerGen.cs:236
                        Id = "VerificationResult.failureAction",                                                                            // MakerGen.cs:237
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
                    // 12. VerificationResult.primarySource
                    this.PrimarySource = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PrimarySource",                                                                                             // MakerGen.cs:235
                        Path= "VerificationResult.primarySource",                                                                           // MakerGen.cs:236
                        Id = "VerificationResult.primarySource",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_PrimarySource                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. VerificationResult.attestation
                    this.Attestation = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Attestation",                                                                                               // MakerGen.cs:235
                        Path= "VerificationResult.attestation",                                                                             // MakerGen.cs:236
                        Id = "VerificationResult.attestation",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Attestation                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. VerificationResult.validator
                    this.Validator = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Validator",                                                                                                 // MakerGen.cs:235
                        Path= "VerificationResult.validator",                                                                               // MakerGen.cs:236
                        Id = "VerificationResult.validator",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Validator                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Target.Write(sDef);                                                                                                         // MakerGen.cs:220
                TargetLocation.Write(sDef);                                                                                                 // MakerGen.cs:220
                Need.Write(sDef);                                                                                                           // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                StatusDate.Write(sDef);                                                                                                     // MakerGen.cs:220
                ValidationType.Write(sDef);                                                                                                 // MakerGen.cs:220
                ValidationProcess.Write(sDef);                                                                                              // MakerGen.cs:220
                Frequency.Write(sDef);                                                                                                      // MakerGen.cs:220
                LastPerformed.Write(sDef);                                                                                                  // MakerGen.cs:220
                NextScheduled.Write(sDef);                                                                                                  // MakerGen.cs:220
                FailureAction.Write(sDef);                                                                                                  // MakerGen.cs:220
                PrimarySource.Write(sDef);                                                                                                  // MakerGen.cs:220
                Attestation.Write(sDef);                                                                                                    // MakerGen.cs:220
                Validator.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public VerificationResult_Elements Elements                                                                                         // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new VerificationResult_Elements();                                                                      // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        VerificationResult_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public VerificationResult()                                                                                                         // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "VerificationResult";                                                                                               // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VerificationResult";                                                        // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "VerificationResult",                                                                                                // MakerGen.cs:428
                ElementId = "VerificationResult"                                                                                            // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
