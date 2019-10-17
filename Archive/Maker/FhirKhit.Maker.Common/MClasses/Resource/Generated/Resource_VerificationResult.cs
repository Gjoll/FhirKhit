using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'VerificationResult'
    /// </summary>
    // 0. VerificationResult
    public partial class Resource_VerificationResult : FhirKhit.Maker.Common.Resource.Resource_DomainResource                               // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 12. VerificationResult.primarySource
        public partial class Type_PrimarySource : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 13. VerificationResult.primarySource.who
            public ElementDefinitionInfo Element_Who;                                                                                       // MakerGen.cs:217
            // 14. VerificationResult.primarySource.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 15. VerificationResult.primarySource.communicationMethod
            public ElementDefinitionInfo Element_CommunicationMethod;                                                                       // MakerGen.cs:217
            // 16. VerificationResult.primarySource.validationStatus
            public ElementDefinitionInfo Element_ValidationStatus;                                                                          // MakerGen.cs:217
            // 17. VerificationResult.primarySource.validationDate
            public ElementDefinitionInfo Element_ValidationDate;                                                                            // MakerGen.cs:217
            // 18. VerificationResult.primarySource.canPushUpdates
            public ElementDefinitionInfo Element_CanPushUpdates;                                                                            // MakerGen.cs:217
            // 19. VerificationResult.primarySource.pushTypeAvailable
            public ElementDefinitionInfo Element_PushTypeAvailable;                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "VerificationResult.primarySource",                                                                              // MakerGen.cs:393
                    ElementId = "VerificationResult.primarySource"                                                                          // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Who.Write(sDef);                                                                                                    // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_CommunicationMethod.Write(sDef);                                                                                    // MakerGen.cs:221
                Element_ValidationStatus.Write(sDef);                                                                                       // MakerGen.cs:221
                Element_ValidationDate.Write(sDef);                                                                                         // MakerGen.cs:221
                Element_CanPushUpdates.Write(sDef);                                                                                         // MakerGen.cs:221
                Element_PushTypeAvailable.Write(sDef);                                                                                      // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_PrimarySource()                                                                                                     // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 13. VerificationResult.primarySource.who
                    this.Element_Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Who",                                                                                               // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.who",                                                                       // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.who",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 14. VerificationResult.primarySource.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.type",                                                                      // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.type",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. VerificationResult.primarySource.communicationMethod
                    this.Element_CommunicationMethod = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CommunicationMethod",                                                                               // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.communicationMethod",                                                       // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.communicationMethod",                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. VerificationResult.primarySource.validationStatus
                    this.Element_ValidationStatus = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ValidationStatus",                                                                                  // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.validationStatus",                                                          // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.validationStatus",                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. VerificationResult.primarySource.validationDate
                    this.Element_ValidationDate = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ValidationDate",                                                                                    // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.validationDate",                                                            // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.validationDate",                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 18. VerificationResult.primarySource.canPushUpdates
                    this.Element_CanPushUpdates = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CanPushUpdates",                                                                                    // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.canPushUpdates",                                                            // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.canPushUpdates",                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 19. VerificationResult.primarySource.pushTypeAvailable
                    this.Element_PushTypeAvailable = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_PushTypeAvailable",                                                                                 // MakerGen.cs:236
                        Path= "VerificationResult.primarySource.pushTypeAvailable",                                                         // MakerGen.cs:237
                        Id = "VerificationResult.primarySource.pushTypeAvailable",                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 20. VerificationResult.attestation
        public partial class Type_Attestation : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 21. VerificationResult.attestation.who
            public ElementDefinitionInfo Element_Who;                                                                                       // MakerGen.cs:217
            // 22. VerificationResult.attestation.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;                                                                                // MakerGen.cs:217
            // 23. VerificationResult.attestation.communicationMethod
            public ElementDefinitionInfo Element_CommunicationMethod;                                                                       // MakerGen.cs:217
            // 24. VerificationResult.attestation.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:217
            // 25. VerificationResult.attestation.sourceIdentityCertificate
            public ElementDefinitionInfo Element_SourceIdentityCertificate;                                                                 // MakerGen.cs:217
            // 26. VerificationResult.attestation.proxyIdentityCertificate
            public ElementDefinitionInfo Element_ProxyIdentityCertificate;                                                                  // MakerGen.cs:217
            // 27. VerificationResult.attestation.proxySignature
            public ElementDefinitionInfo Element_ProxySignature;                                                                            // MakerGen.cs:217
            // 28. VerificationResult.attestation.sourceSignature
            public ElementDefinitionInfo Element_SourceSignature;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "VerificationResult.attestation",                                                                                // MakerGen.cs:393
                    ElementId = "VerificationResult.attestation"                                                                            // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Who.Write(sDef);                                                                                                    // MakerGen.cs:221
                Element_OnBehalfOf.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_CommunicationMethod.Write(sDef);                                                                                    // MakerGen.cs:221
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_SourceIdentityCertificate.Write(sDef);                                                                              // MakerGen.cs:221
                Element_ProxyIdentityCertificate.Write(sDef);                                                                               // MakerGen.cs:221
                Element_ProxySignature.Write(sDef);                                                                                         // MakerGen.cs:221
                Element_SourceSignature.Write(sDef);                                                                                        // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Attestation()                                                                                                       // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 21. VerificationResult.attestation.who
                    this.Element_Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Who",                                                                                               // MakerGen.cs:236
                        Path= "VerificationResult.attestation.who",                                                                         // MakerGen.cs:237
                        Id = "VerificationResult.attestation.who",                                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. VerificationResult.attestation.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_OnBehalfOf",                                                                                        // MakerGen.cs:236
                        Path= "VerificationResult.attestation.onBehalfOf",                                                                  // MakerGen.cs:237
                        Id = "VerificationResult.attestation.onBehalfOf",                                                                   // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 23. VerificationResult.attestation.communicationMethod
                    this.Element_CommunicationMethod = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CommunicationMethod",                                                                               // MakerGen.cs:236
                        Path= "VerificationResult.attestation.communicationMethod",                                                         // MakerGen.cs:237
                        Id = "VerificationResult.attestation.communicationMethod",                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 24. VerificationResult.attestation.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Date",                                                                                              // MakerGen.cs:236
                        Path= "VerificationResult.attestation.date",                                                                        // MakerGen.cs:237
                        Id = "VerificationResult.attestation.date",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 25. VerificationResult.attestation.sourceIdentityCertificate
                    this.Element_SourceIdentityCertificate = new ElementDefinitionInfo                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SourceIdentityCertificate",                                                                         // MakerGen.cs:236
                        Path= "VerificationResult.attestation.sourceIdentityCertificate",                                                   // MakerGen.cs:237
                        Id = "VerificationResult.attestation.sourceIdentityCertificate",                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 26. VerificationResult.attestation.proxyIdentityCertificate
                    this.Element_ProxyIdentityCertificate = new ElementDefinitionInfo                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ProxyIdentityCertificate",                                                                          // MakerGen.cs:236
                        Path= "VerificationResult.attestation.proxyIdentityCertificate",                                                    // MakerGen.cs:237
                        Id = "VerificationResult.attestation.proxyIdentityCertificate",                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 27. VerificationResult.attestation.proxySignature
                    this.Element_ProxySignature = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ProxySignature",                                                                                    // MakerGen.cs:236
                        Path= "VerificationResult.attestation.proxySignature",                                                              // MakerGen.cs:237
                        Id = "VerificationResult.attestation.proxySignature",                                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Signature                                                                // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 28. VerificationResult.attestation.sourceSignature
                    this.Element_SourceSignature = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SourceSignature",                                                                                   // MakerGen.cs:236
                        Path= "VerificationResult.attestation.sourceSignature",                                                             // MakerGen.cs:237
                        Id = "VerificationResult.attestation.sourceSignature",                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Signature                                                                // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 29. VerificationResult.validator
        public partial class Type_Validator : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 30. VerificationResult.validator.organization
            public ElementDefinitionInfo Element_Organization;                                                                              // MakerGen.cs:217
            // 31. VerificationResult.validator.identityCertificate
            public ElementDefinitionInfo Element_IdentityCertificate;                                                                       // MakerGen.cs:217
            // 32. VerificationResult.validator.attestationSignature
            public ElementDefinitionInfo Element_AttestationSignature;                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "VerificationResult.validator",                                                                                  // MakerGen.cs:393
                    ElementId = "VerificationResult.validator"                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Organization.Write(sDef);                                                                                           // MakerGen.cs:221
                Element_IdentityCertificate.Write(sDef);                                                                                    // MakerGen.cs:221
                Element_AttestationSignature.Write(sDef);                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Validator()                                                                                                         // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 30. VerificationResult.validator.organization
                    this.Element_Organization = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Organization",                                                                                      // MakerGen.cs:236
                        Path= "VerificationResult.validator.organization",                                                                  // MakerGen.cs:237
                        Id = "VerificationResult.validator.organization",                                                                   // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 31. VerificationResult.validator.identityCertificate
                    this.Element_IdentityCertificate = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_IdentityCertificate",                                                                               // MakerGen.cs:236
                        Path= "VerificationResult.validator.identityCertificate",                                                           // MakerGen.cs:237
                        Id = "VerificationResult.validator.identityCertificate",                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 32. VerificationResult.validator.attestationSignature
                    this.Element_AttestationSignature = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AttestationSignature",                                                                              // MakerGen.cs:236
                        Path= "VerificationResult.validator.attestationSignature",                                                          // MakerGen.cs:237
                        Id = "VerificationResult.validator.attestationSignature",                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Signature                                                                // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. VerificationResult.target
        public ElementDefinitionInfo Element_Target;                                                                                        // MakerGen.cs:217
        // 2. VerificationResult.targetLocation
        public ElementDefinitionInfo Element_TargetLocation;                                                                                // MakerGen.cs:217
        // 3. VerificationResult.need
        public ElementDefinitionInfo Element_Need;                                                                                          // MakerGen.cs:217
        // 4. VerificationResult.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 5. VerificationResult.statusDate
        public ElementDefinitionInfo Element_StatusDate;                                                                                    // MakerGen.cs:217
        // 6. VerificationResult.validationType
        public ElementDefinitionInfo Element_ValidationType;                                                                                // MakerGen.cs:217
        // 7. VerificationResult.validationProcess
        public ElementDefinitionInfo Element_ValidationProcess;                                                                             // MakerGen.cs:217
        // 8. VerificationResult.frequency
        public ElementDefinitionInfo Element_Frequency;                                                                                     // MakerGen.cs:217
        // 9. VerificationResult.lastPerformed
        public ElementDefinitionInfo Element_LastPerformed;                                                                                 // MakerGen.cs:217
        // 10. VerificationResult.nextScheduled
        public ElementDefinitionInfo Element_NextScheduled;                                                                                 // MakerGen.cs:217
        // 11. VerificationResult.failureAction
        public ElementDefinitionInfo Element_FailureAction;                                                                                 // MakerGen.cs:217
        // 12. VerificationResult.primarySource
        public ElementDefinitionInfo Element_PrimarySource;                                                                                 // MakerGen.cs:217
        // 20. VerificationResult.attestation
        public ElementDefinitionInfo Element_Attestation;                                                                                   // MakerGen.cs:217
        // 29. VerificationResult.validator
        public ElementDefinitionInfo Element_Validator;                                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "VerificationResult",                                                                                                // MakerGen.cs:393
                ElementId = "VerificationResult"                                                                                            // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Target.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_TargetLocation.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Need.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_StatusDate.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_ValidationType.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_ValidationProcess.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_Frequency.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_LastPerformed.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_NextScheduled.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_FailureAction.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_PrimarySource.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_Attestation.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Validator.Write(sDef);                                                                                                  // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_VerificationResult()                                                                                                // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. VerificationResult.target
                this.Element_Target = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Target",                                                                                                // MakerGen.cs:236
                    Path= "VerificationResult.target",                                                                                      // MakerGen.cs:237
                    Id = "VerificationResult.target",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. VerificationResult.targetLocation
                this.Element_TargetLocation = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_TargetLocation",                                                                                        // MakerGen.cs:236
                    Path= "VerificationResult.targetLocation",                                                                              // MakerGen.cs:237
                    Id = "VerificationResult.targetLocation",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. VerificationResult.need
                this.Element_Need = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Need",                                                                                                  // MakerGen.cs:236
                    Path= "VerificationResult.need",                                                                                        // MakerGen.cs:237
                    Id = "VerificationResult.need",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. VerificationResult.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "VerificationResult.status",                                                                                      // MakerGen.cs:237
                    Id = "VerificationResult.status",                                                                                       // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. VerificationResult.statusDate
                this.Element_StatusDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_StatusDate",                                                                                            // MakerGen.cs:236
                    Path= "VerificationResult.statusDate",                                                                                  // MakerGen.cs:237
                    Id = "VerificationResult.statusDate",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. VerificationResult.validationType
                this.Element_ValidationType = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ValidationType",                                                                                        // MakerGen.cs:236
                    Path= "VerificationResult.validationType",                                                                              // MakerGen.cs:237
                    Id = "VerificationResult.validationType",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. VerificationResult.validationProcess
                this.Element_ValidationProcess = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ValidationProcess",                                                                                     // MakerGen.cs:236
                    Path= "VerificationResult.validationProcess",                                                                           // MakerGen.cs:237
                    Id = "VerificationResult.validationProcess",                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. VerificationResult.frequency
                this.Element_Frequency = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Frequency",                                                                                             // MakerGen.cs:236
                    Path= "VerificationResult.frequency",                                                                                   // MakerGen.cs:237
                    Id = "VerificationResult.frequency",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. VerificationResult.lastPerformed
                this.Element_LastPerformed = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_LastPerformed",                                                                                         // MakerGen.cs:236
                    Path= "VerificationResult.lastPerformed",                                                                               // MakerGen.cs:237
                    Id = "VerificationResult.lastPerformed",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. VerificationResult.nextScheduled
                this.Element_NextScheduled = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_NextScheduled",                                                                                         // MakerGen.cs:236
                    Path= "VerificationResult.nextScheduled",                                                                               // MakerGen.cs:237
                    Id = "VerificationResult.nextScheduled",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. VerificationResult.failureAction
                this.Element_FailureAction = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_FailureAction",                                                                                         // MakerGen.cs:236
                    Path= "VerificationResult.failureAction",                                                                               // MakerGen.cs:237
                    Id = "VerificationResult.failureAction",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. VerificationResult.primarySource
                this.Element_PrimarySource = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PrimarySource",                                                                                         // MakerGen.cs:236
                    Path= "VerificationResult.primarySource",                                                                               // MakerGen.cs:237
                    Id = "VerificationResult.primarySource",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_PrimarySource                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 20. VerificationResult.attestation
                this.Element_Attestation = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Attestation",                                                                                           // MakerGen.cs:236
                    Path= "VerificationResult.attestation",                                                                                 // MakerGen.cs:237
                    Id = "VerificationResult.attestation",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Attestation                                                                                                // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 29. VerificationResult.validator
                this.Element_Validator = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Validator",                                                                                             // MakerGen.cs:236
                    Path= "VerificationResult.validator",                                                                                   // MakerGen.cs:237
                    Id = "VerificationResult.validator",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Validator                                                                                                  // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "VerificationResult";                                                                                               // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VerificationResult";                                                        // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
