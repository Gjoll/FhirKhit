using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'VerificationResult'
    /// </summary>
    // 0. VerificationResult
    public class Resource_VerificationResult : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_VerificationResult_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 12. VerificationResult.primarySource
            public class Type_PrimarySource : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_PrimarySource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 13. VerificationResult.primarySource.who
                    public ElementDefinitionInfo Element_Who;                                                                               // MakerGen.cs:211
                    // 14. VerificationResult.primarySource.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 15. VerificationResult.primarySource.communicationMethod
                    public ElementDefinitionInfo Element_CommunicationMethod;                                                               // MakerGen.cs:211
                    // 16. VerificationResult.primarySource.validationStatus
                    public ElementDefinitionInfo Element_ValidationStatus;                                                                  // MakerGen.cs:211
                    // 17. VerificationResult.primarySource.validationDate
                    public ElementDefinitionInfo Element_ValidationDate;                                                                    // MakerGen.cs:211
                    // 18. VerificationResult.primarySource.canPushUpdates
                    public ElementDefinitionInfo Element_CanPushUpdates;                                                                    // MakerGen.cs:211
                    // 19. VerificationResult.primarySource.pushTypeAvailable
                    public ElementDefinitionInfo Element_PushTypeAvailable;                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_PrimarySource_Elements()                                                                                    // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. VerificationResult.primarySource.who
                            this.Element_Who = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Who",                                                                                       // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.who",                                                               // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.who",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. VerificationResult.primarySource.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.type",                                                              // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.type",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. VerificationResult.primarySource.communicationMethod
                            this.Element_CommunicationMethod = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_CommunicationMethod",                                                                       // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.communicationMethod",                                               // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.communicationMethod",                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. VerificationResult.primarySource.validationStatus
                            this.Element_ValidationStatus = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ValidationStatus",                                                                          // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.validationStatus",                                                  // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.validationStatus",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. VerificationResult.primarySource.validationDate
                            this.Element_ValidationDate = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ValidationDate",                                                                            // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.validationDate",                                                    // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.validationDate",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. VerificationResult.primarySource.canPushUpdates
                            this.Element_CanPushUpdates = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_CanPushUpdates",                                                                            // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.canPushUpdates",                                                    // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.canPushUpdates",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. VerificationResult.primarySource.pushTypeAvailable
                            this.Element_PushTypeAvailable = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_PushTypeAvailable",                                                                         // MakerGen.cs:230
                                Path= "VerificationResult.primarySource.pushTypeAvailable",                                                 // MakerGen.cs:231
                                Id = "VerificationResult.primarySource.pushTypeAvailable",                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Who.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_CommunicationMethod.Write(sDef);                                                                            // MakerGen.cs:215
                        Element_ValidationStatus.Write(sDef);                                                                               // MakerGen.cs:215
                        Element_ValidationDate.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_CanPushUpdates.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_PushTypeAvailable.Write(sDef);                                                                              // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_PrimarySource_Elements Elements                                                                                 // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_PrimarySource_Elements();                                                              // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_PrimarySource_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_PrimarySource()                                                                                                 // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "VerificationResult.primarySource",                                                                          // MakerGen.cs:420
                        ElementId = "VerificationResult.primarySource"                                                                      // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 20. VerificationResult.attestation
            public class Type_Attestation : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Attestation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 21. VerificationResult.attestation.who
                    public ElementDefinitionInfo Element_Who;                                                                               // MakerGen.cs:211
                    // 22. VerificationResult.attestation.onBehalfOf
                    public ElementDefinitionInfo Element_OnBehalfOf;                                                                        // MakerGen.cs:211
                    // 23. VerificationResult.attestation.communicationMethod
                    public ElementDefinitionInfo Element_CommunicationMethod;                                                               // MakerGen.cs:211
                    // 24. VerificationResult.attestation.date
                    public ElementDefinitionInfo Element_Date;                                                                              // MakerGen.cs:211
                    // 25. VerificationResult.attestation.sourceIdentityCertificate
                    public ElementDefinitionInfo Element_SourceIdentityCertificate;                                                         // MakerGen.cs:211
                    // 26. VerificationResult.attestation.proxyIdentityCertificate
                    public ElementDefinitionInfo Element_ProxyIdentityCertificate;                                                          // MakerGen.cs:211
                    // 27. VerificationResult.attestation.proxySignature
                    public ElementDefinitionInfo Element_ProxySignature;                                                                    // MakerGen.cs:211
                    // 28. VerificationResult.attestation.sourceSignature
                    public ElementDefinitionInfo Element_SourceSignature;                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Attestation_Elements()                                                                                      // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. VerificationResult.attestation.who
                            this.Element_Who = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Who",                                                                                       // MakerGen.cs:230
                                Path= "VerificationResult.attestation.who",                                                                 // MakerGen.cs:231
                                Id = "VerificationResult.attestation.who",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. VerificationResult.attestation.onBehalfOf
                            this.Element_OnBehalfOf = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_OnBehalfOf",                                                                                // MakerGen.cs:230
                                Path= "VerificationResult.attestation.onBehalfOf",                                                          // MakerGen.cs:231
                                Id = "VerificationResult.attestation.onBehalfOf",                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                      // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. VerificationResult.attestation.communicationMethod
                            this.Element_CommunicationMethod = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_CommunicationMethod",                                                                       // MakerGen.cs:230
                                Path= "VerificationResult.attestation.communicationMethod",                                                 // MakerGen.cs:231
                                Id = "VerificationResult.attestation.communicationMethod",                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. VerificationResult.attestation.date
                            this.Element_Date = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Date",                                                                                      // MakerGen.cs:230
                                Path= "VerificationResult.attestation.date",                                                                // MakerGen.cs:231
                                Id = "VerificationResult.attestation.date",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. VerificationResult.attestation.sourceIdentityCertificate
                            this.Element_SourceIdentityCertificate = new ElementDefinitionInfo                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SourceIdentityCertificate",                                                                 // MakerGen.cs:230
                                Path= "VerificationResult.attestation.sourceIdentityCertificate",                                           // MakerGen.cs:231
                                Id = "VerificationResult.attestation.sourceIdentityCertificate",                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. VerificationResult.attestation.proxyIdentityCertificate
                            this.Element_ProxyIdentityCertificate = new ElementDefinitionInfo                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ProxyIdentityCertificate",                                                                  // MakerGen.cs:230
                                Path= "VerificationResult.attestation.proxyIdentityCertificate",                                            // MakerGen.cs:231
                                Id = "VerificationResult.attestation.proxyIdentityCertificate",                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. VerificationResult.attestation.proxySignature
                            this.Element_ProxySignature = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ProxySignature",                                                                            // MakerGen.cs:230
                                Path= "VerificationResult.attestation.proxySignature",                                                      // MakerGen.cs:231
                                Id = "VerificationResult.attestation.proxySignature",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Signature                                                        // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. VerificationResult.attestation.sourceSignature
                            this.Element_SourceSignature = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SourceSignature",                                                                           // MakerGen.cs:230
                                Path= "VerificationResult.attestation.sourceSignature",                                                     // MakerGen.cs:231
                                Id = "VerificationResult.attestation.sourceSignature",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Signature                                                        // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Who.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_OnBehalfOf.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_CommunicationMethod.Write(sDef);                                                                            // MakerGen.cs:215
                        Element_Date.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_SourceIdentityCertificate.Write(sDef);                                                                      // MakerGen.cs:215
                        Element_ProxyIdentityCertificate.Write(sDef);                                                                       // MakerGen.cs:215
                        Element_ProxySignature.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_SourceSignature.Write(sDef);                                                                                // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Attestation_Elements Elements                                                                                   // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Attestation_Elements();                                                                // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Attestation_Elements elements;                                                                                         // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Attestation()                                                                                                   // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "VerificationResult.attestation",                                                                            // MakerGen.cs:420
                        ElementId = "VerificationResult.attestation"                                                                        // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 29. VerificationResult.validator
            public class Type_Validator : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Validator_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 30. VerificationResult.validator.organization
                    public ElementDefinitionInfo Element_Organization;                                                                      // MakerGen.cs:211
                    // 31. VerificationResult.validator.identityCertificate
                    public ElementDefinitionInfo Element_IdentityCertificate;                                                               // MakerGen.cs:211
                    // 32. VerificationResult.validator.attestationSignature
                    public ElementDefinitionInfo Element_AttestationSignature;                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Validator_Elements()                                                                                        // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 30. VerificationResult.validator.organization
                            this.Element_Organization = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Organization",                                                                              // MakerGen.cs:230
                                Path= "VerificationResult.validator.organization",                                                          // MakerGen.cs:231
                                Id = "VerificationResult.validator.organization",                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 31. VerificationResult.validator.identityCertificate
                            this.Element_IdentityCertificate = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_IdentityCertificate",                                                                       // MakerGen.cs:230
                                Path= "VerificationResult.validator.identityCertificate",                                                   // MakerGen.cs:231
                                Id = "VerificationResult.validator.identityCertificate",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 32. VerificationResult.validator.attestationSignature
                            this.Element_AttestationSignature = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_AttestationSignature",                                                                      // MakerGen.cs:230
                                Path= "VerificationResult.validator.attestationSignature",                                                  // MakerGen.cs:231
                                Id = "VerificationResult.validator.attestationSignature",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Signature                                                        // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Organization.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_IdentityCertificate.Write(sDef);                                                                            // MakerGen.cs:215
                        Element_AttestationSignature.Write(sDef);                                                                           // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Validator_Elements Elements                                                                                     // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Validator_Elements();                                                                  // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Validator_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Validator()                                                                                                     // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "VerificationResult.validator",                                                                              // MakerGen.cs:420
                        ElementId = "VerificationResult.validator"                                                                          // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. VerificationResult.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:211
            // 2. VerificationResult.targetLocation
            public ElementDefinitionInfo Element_TargetLocation;                                                                            // MakerGen.cs:211
            // 3. VerificationResult.need
            public ElementDefinitionInfo Element_Need;                                                                                      // MakerGen.cs:211
            // 4. VerificationResult.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 5. VerificationResult.statusDate
            public ElementDefinitionInfo Element_StatusDate;                                                                                // MakerGen.cs:211
            // 6. VerificationResult.validationType
            public ElementDefinitionInfo Element_ValidationType;                                                                            // MakerGen.cs:211
            // 7. VerificationResult.validationProcess
            public ElementDefinitionInfo Element_ValidationProcess;                                                                         // MakerGen.cs:211
            // 8. VerificationResult.frequency
            public ElementDefinitionInfo Element_Frequency;                                                                                 // MakerGen.cs:211
            // 9. VerificationResult.lastPerformed
            public ElementDefinitionInfo Element_LastPerformed;                                                                             // MakerGen.cs:211
            // 10. VerificationResult.nextScheduled
            public ElementDefinitionInfo Element_NextScheduled;                                                                             // MakerGen.cs:211
            // 11. VerificationResult.failureAction
            public ElementDefinitionInfo Element_FailureAction;                                                                             // MakerGen.cs:211
            // 12. VerificationResult.primarySource
            public ElementDefinitionInfo Element_PrimarySource;                                                                             // MakerGen.cs:211
            // 20. VerificationResult.attestation
            public ElementDefinitionInfo Element_Attestation;                                                                               // MakerGen.cs:211
            // 29. VerificationResult.validator
            public ElementDefinitionInfo Element_Validator;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_VerificationResult_Elements()                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. VerificationResult.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Target",                                                                                            // MakerGen.cs:230
                        Path= "VerificationResult.target",                                                                                  // MakerGen.cs:231
                        Id = "VerificationResult.target",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. VerificationResult.targetLocation
                    this.Element_TargetLocation = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_TargetLocation",                                                                                    // MakerGen.cs:230
                        Path= "VerificationResult.targetLocation",                                                                          // MakerGen.cs:231
                        Id = "VerificationResult.targetLocation",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. VerificationResult.need
                    this.Element_Need = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Need",                                                                                              // MakerGen.cs:230
                        Path= "VerificationResult.need",                                                                                    // MakerGen.cs:231
                        Id = "VerificationResult.need",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. VerificationResult.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "VerificationResult.status",                                                                                  // MakerGen.cs:231
                        Id = "VerificationResult.status",                                                                                   // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. VerificationResult.statusDate
                    this.Element_StatusDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_StatusDate",                                                                                        // MakerGen.cs:230
                        Path= "VerificationResult.statusDate",                                                                              // MakerGen.cs:231
                        Id = "VerificationResult.statusDate",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. VerificationResult.validationType
                    this.Element_ValidationType = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ValidationType",                                                                                    // MakerGen.cs:230
                        Path= "VerificationResult.validationType",                                                                          // MakerGen.cs:231
                        Id = "VerificationResult.validationType",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. VerificationResult.validationProcess
                    this.Element_ValidationProcess = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ValidationProcess",                                                                                 // MakerGen.cs:230
                        Path= "VerificationResult.validationProcess",                                                                       // MakerGen.cs:231
                        Id = "VerificationResult.validationProcess",                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. VerificationResult.frequency
                    this.Element_Frequency = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Frequency",                                                                                         // MakerGen.cs:230
                        Path= "VerificationResult.frequency",                                                                               // MakerGen.cs:231
                        Id = "VerificationResult.frequency",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Timing                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. VerificationResult.lastPerformed
                    this.Element_LastPerformed = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_LastPerformed",                                                                                     // MakerGen.cs:230
                        Path= "VerificationResult.lastPerformed",                                                                           // MakerGen.cs:231
                        Id = "VerificationResult.lastPerformed",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. VerificationResult.nextScheduled
                    this.Element_NextScheduled = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_NextScheduled",                                                                                     // MakerGen.cs:230
                        Path= "VerificationResult.nextScheduled",                                                                           // MakerGen.cs:231
                        Id = "VerificationResult.nextScheduled",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. VerificationResult.failureAction
                    this.Element_FailureAction = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_FailureAction",                                                                                     // MakerGen.cs:230
                        Path= "VerificationResult.failureAction",                                                                           // MakerGen.cs:231
                        Id = "VerificationResult.failureAction",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. VerificationResult.primarySource
                    this.Element_PrimarySource = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PrimarySource",                                                                                     // MakerGen.cs:230
                        Path= "VerificationResult.primarySource",                                                                           // MakerGen.cs:231
                        Id = "VerificationResult.primarySource",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_PrimarySource                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. VerificationResult.attestation
                    this.Element_Attestation = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Attestation",                                                                                       // MakerGen.cs:230
                        Path= "VerificationResult.attestation",                                                                             // MakerGen.cs:231
                        Id = "VerificationResult.attestation",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Attestation                                                                                            // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. VerificationResult.validator
                    this.Element_Validator = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Validator",                                                                                         // MakerGen.cs:230
                        Path= "VerificationResult.validator",                                                                               // MakerGen.cs:231
                        Id = "VerificationResult.validator",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Validator                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_TargetLocation.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_Need.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_StatusDate.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_ValidationType.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_ValidationProcess.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_Frequency.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_LastPerformed.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_NextScheduled.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_FailureAction.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_PrimarySource.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_Attestation.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Validator.Write(sDef);                                                                                              // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_VerificationResult_Elements Elements                                                                                // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_VerificationResult_Elements();                                                             // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_VerificationResult_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_VerificationResult()                                                                                                // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "VerificationResult";                                                                                               // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VerificationResult";                                                        // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "VerificationResult",                                                                                                // MakerGen.cs:420
                ElementId = "VerificationResult"                                                                                            // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
