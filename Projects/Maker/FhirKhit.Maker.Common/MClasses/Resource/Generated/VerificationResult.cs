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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'VerificationResult'
    /// </summary>
    // 0. VerificationResult
    public class VerificationResult : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 12. VerificationResult.primarySource
        public class Type_PrimarySource : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 13. VerificationResult.primarySource.who
            public MakerElementInstance Element_Who;                                                                                        // MakerGen.cs:232
            // 14. VerificationResult.primarySource.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 15. VerificationResult.primarySource.communicationMethod
            public MakerElementInstance Element_CommunicationMethod;                                                                        // MakerGen.cs:232
            // 16. VerificationResult.primarySource.validationStatus
            public MakerElementInstance Element_ValidationStatus;                                                                           // MakerGen.cs:232
            // 17. VerificationResult.primarySource.validationDate
            public MakerElementInstance Element_ValidationDate;                                                                             // MakerGen.cs:232
            // 18. VerificationResult.primarySource.canPushUpdates
            public MakerElementInstance Element_CanPushUpdates;                                                                             // MakerGen.cs:232
            // 19. VerificationResult.primarySource.pushTypeAvailable
            public MakerElementInstance Element_PushTypeAvailable;                                                                          // MakerGen.cs:232
            public Type_PrimarySource()                                                                                                     // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 13. VerificationResult.primarySource.who
                    this.Element_Who = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Who",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 14. VerificationResult.primarySource.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 15. VerificationResult.primarySource.communicationMethod
                    this.Element_CommunicationMethod = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CommunicationMethod",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 16. VerificationResult.primarySource.validationStatus
                    this.Element_ValidationStatus = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ValidationStatus",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. VerificationResult.primarySource.validationDate
                    this.Element_ValidationDate = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ValidationDate",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. VerificationResult.primarySource.canPushUpdates
                    this.Element_CanPushUpdates = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CanPushUpdates",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 19. VerificationResult.primarySource.pushTypeAvailable
                    this.Element_PushTypeAvailable = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PushTypeAvailable",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 20. VerificationResult.attestation
        public class Type_Attestation : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 21. VerificationResult.attestation.who
            public MakerElementInstance Element_Who;                                                                                        // MakerGen.cs:232
            // 22. VerificationResult.attestation.onBehalfOf
            public MakerElementInstance Element_OnBehalfOf;                                                                                 // MakerGen.cs:232
            // 23. VerificationResult.attestation.communicationMethod
            public MakerElementInstance Element_CommunicationMethod;                                                                        // MakerGen.cs:232
            // 24. VerificationResult.attestation.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 25. VerificationResult.attestation.sourceIdentityCertificate
            public MakerElementInstance Element_SourceIdentityCertificate;                                                                  // MakerGen.cs:232
            // 26. VerificationResult.attestation.proxyIdentityCertificate
            public MakerElementInstance Element_ProxyIdentityCertificate;                                                                   // MakerGen.cs:232
            // 27. VerificationResult.attestation.proxySignature
            public MakerElementInstance Element_ProxySignature;                                                                             // MakerGen.cs:232
            // 28. VerificationResult.attestation.sourceSignature
            public MakerElementInstance Element_SourceSignature;                                                                            // MakerGen.cs:232
            public Type_Attestation()                                                                                                       // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 21. VerificationResult.attestation.who
                    this.Element_Who = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Who",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 22. VerificationResult.attestation.onBehalfOf
                    this.Element_OnBehalfOf = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OnBehalfOf",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 23. VerificationResult.attestation.communicationMethod
                    this.Element_CommunicationMethod = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CommunicationMethod",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 24. VerificationResult.attestation.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. VerificationResult.attestation.sourceIdentityCertificate
                    this.Element_SourceIdentityCertificate = new MakerElementInstance                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SourceIdentityCertificate",                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 26. VerificationResult.attestation.proxyIdentityCertificate
                    this.Element_ProxyIdentityCertificate = new MakerElementInstance                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProxyIdentityCertificate",                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 27. VerificationResult.attestation.proxySignature
                    this.Element_ProxySignature = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProxySignature",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 28. VerificationResult.attestation.sourceSignature
                    this.Element_SourceSignature = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SourceSignature",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 29. VerificationResult.validator
        public class Type_Validator : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 30. VerificationResult.validator.organization
            public MakerElementInstance Element_Organization;                                                                               // MakerGen.cs:232
            // 31. VerificationResult.validator.identityCertificate
            public MakerElementInstance Element_IdentityCertificate;                                                                        // MakerGen.cs:232
            // 32. VerificationResult.validator.attestationSignature
            public MakerElementInstance Element_AttestationSignature;                                                                       // MakerGen.cs:232
            public Type_Validator()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 30. VerificationResult.validator.organization
                    this.Element_Organization = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Organization",                                                                                      // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 31. VerificationResult.validator.identityCertificate
                    this.Element_IdentityCertificate = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_IdentityCertificate",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 32. VerificationResult.validator.attestationSignature
                    this.Element_AttestationSignature = new MakerElementInstance                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AttestationSignature",                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. VerificationResult.target
        public MakerElementInstance Element_Target;                                                                                         // MakerGen.cs:232
        // 2. VerificationResult.targetLocation
        public MakerElementInstance Element_TargetLocation;                                                                                 // MakerGen.cs:232
        // 3. VerificationResult.need
        public MakerElementInstance Element_Need;                                                                                           // MakerGen.cs:232
        // 4. VerificationResult.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. VerificationResult.statusDate
        public MakerElementInstance Element_StatusDate;                                                                                     // MakerGen.cs:232
        // 6. VerificationResult.validationType
        public MakerElementInstance Element_ValidationType;                                                                                 // MakerGen.cs:232
        // 7. VerificationResult.validationProcess
        public MakerElementInstance Element_ValidationProcess;                                                                              // MakerGen.cs:232
        // 8. VerificationResult.frequency
        public MakerElementInstance Element_Frequency;                                                                                      // MakerGen.cs:232
        // 9. VerificationResult.lastPerformed
        public MakerElementInstance Element_LastPerformed;                                                                                  // MakerGen.cs:232
        // 10. VerificationResult.nextScheduled
        public MakerElementInstance Element_NextScheduled;                                                                                  // MakerGen.cs:232
        // 11. VerificationResult.failureAction
        public MakerElementInstance Element_FailureAction;                                                                                  // MakerGen.cs:232
        public VerificationResult()                                                                                                         // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. VerificationResult.target
                this.Element_Target = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Target",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. VerificationResult.targetLocation
                this.Element_TargetLocation = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_TargetLocation",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. VerificationResult.need
                this.Element_Need = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Need",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. VerificationResult.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. VerificationResult.statusDate
                this.Element_StatusDate = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusDate",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. VerificationResult.validationType
                this.Element_ValidationType = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ValidationType",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. VerificationResult.validationProcess
                this.Element_ValidationProcess = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ValidationProcess",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. VerificationResult.frequency
                this.Element_Frequency = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Frequency",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. VerificationResult.lastPerformed
                this.Element_LastPerformed = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LastPerformed",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. VerificationResult.nextScheduled
                this.Element_NextScheduled = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_NextScheduled",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. VerificationResult.failureAction
                this.Element_FailureAction = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FailureAction",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
