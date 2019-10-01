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
      "id": "ClinicalImpression",
      "url": "http://hl7.org/fhir/StructureDefinition/ClinicalImpression",
      "version": "4.0.0",
      "name": "ClinicalImpression",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called \"ClinicalImpression\" rather than \"ClinicalAssessment\" to avoid confusion with the recording of assessment tools such as Apgar score.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ClinicalImpression",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ClinicalImpression",
            "path": "ClinicalImpression",
            "short": "A clinical assessment performed when planning treatments and management strategies for a patient",
            "definition": "A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called \"ClinicalImpression\" rather than \"ClinicalAssessment\" to avoid confusion with the recording of assessment tools such as Apgar score.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ClinicalImpression.identifier",
            "path": "ClinicalImpression.identifier",
            "short": "Business identifier",
            "definition": "Business identifiers assigned to this clinical impression by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the clinical impression as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "ClinicalImpression.status",
            "path": "ClinicalImpression.status",
            "short": "draft | completed | entered-in-error",
            "definition": "Identifies the workflow status of the assessment.",
            "comment": "This element is labeled as a modifier because the status contains the code entered-in-error that marks the clinical impression as not currently valid.",
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
                  "valueString": "ClinicalImpressionStatus"
                }
              ],
              "strength": "required",
              "description": "The workflow state of a clinical impression.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinicalimpression-status|4.0.0"
            }
          },
          {
            "id": "ClinicalImpression.statusReason",
            "path": "ClinicalImpression.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the ClinicalImpression.",
            "comment": "This is generally only used for \"exception\" statuses such as \"not-done\", \"suspended\" or \"cancelled\".\n\n[distinct reason codes for different statuses can be enforced using invariants if they are universal bindings].",
            "alias": [
              "Suspended Reason",
              "Cancelled Reason"
            ],
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
                  "valueString": "ClinicalImpressionStatusReason"
                }
              ],
              "strength": "example",
              "description": "Codes identifying the reason for the current state of a clinical impression."
            }
          },
          {
            "id": "ClinicalImpression.code",
            "path": "ClinicalImpression.code",
            "short": "Kind of assessment performed",
            "definition": "Categorizes the type of clinical assessment performed.",
            "comment": "This is present as a place-holder only and may be removed based on feedback/work group opinion.",
            "alias": [
              "type"
            ],
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
                  "valueString": "ClinicalImpressionCode"
                }
              ],
              "strength": "example",
              "description": "Identifies categories of clinical impressions.  This is a place-holder only.  It may be removed."
            }
          },
          {
            "id": "ClinicalImpression.description",
            "path": "ClinicalImpression.description",
            "short": "Why/how the assessment was performed",
            "definition": "A summary of the context and/or cause of the assessment - why / where it was performed, and what patient events/status prompted it.",
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
            "id": "ClinicalImpression.subject",
            "path": "ClinicalImpression.subject",
            "short": "Patient or group assessed",
            "definition": "The patient or group of individuals assessed as part of this record.",
            "requirements": "Group is typically for veterinary and/or public health purposes.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.encounter",
            "path": "ClinicalImpression.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this ClinicalImpression was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.effective[x]",
            "path": "ClinicalImpression.effective[x]",
            "short": "Time of assessment",
            "definition": "The point in time or period over which the subject was assessed.",
            "comment": "This SHOULD be accurate to at least the minute, though some assessments only have a known date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.date",
            "path": "ClinicalImpression.date",
            "short": "When the assessment was documented",
            "definition": "Indicates when the documentation of the assessment was complete.",
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
            "id": "ClinicalImpression.assessor",
            "path": "ClinicalImpression.assessor",
            "short": "The clinician performing the assessment",
            "definition": "The clinician performing the assessment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.previous",
            "path": "ClinicalImpression.previous",
            "short": "Reference to last assessment",
            "definition": "A reference to the last assessment that was conducted on this patient. Assessments are often/usually ongoing in nature; a care provider (practitioner or team) will make new assessments on an ongoing basis as new data arises or the patient's conditions changes.",
            "comment": "It is always likely that multiple previous assessments exist for a patient. The point of quoting a previous assessment is that this assessment is relative to it (see resolved).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ClinicalImpression"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.problem",
            "path": "ClinicalImpression.problem",
            "short": "Relevant impressions of patient state",
            "definition": "A list of the relevant problems/conditions for a patient.",
            "comment": "e.g. The patient is a pregnant, has congestive heart failure, has an ‎Adenocarcinoma, and is allergic to penicillin.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClinicalImpression.investigation",
            "path": "ClinicalImpression.investigation",
            "short": "One or more sets of investigations (signs, symptoms, etc.)",
            "definition": "One or more sets of investigations (signs, symptoms, etc.). The actual grouping of investigations varies greatly depending on the type and context of the assessment. These investigations may include data generated during the assessment process, or data previously generated and recorded that is pertinent to the outcomes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClinicalImpression.investigation.code",
            "path": "ClinicalImpression.investigation.code",
            "short": "A name/code for the set",
            "definition": "A name/code for the group (\"set\") of investigations. Typically, this will be something like \"signs\", \"symptoms\", \"clinical\", \"diagnostic\", but the list is not constrained, and others such groups such as (exposure|family|travel|nutritional) history may be used.",
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
                  "valueString": "InvestigationGroupType"
                }
              ],
              "strength": "example",
              "description": "A name/code for a set of investigations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/investigation-sets"
            }
          },
          {
            "id": "ClinicalImpression.investigation.item",
            "path": "ClinicalImpression.investigation.item",
            "short": "Record of a specific investigation",
            "definition": "A record of a specific investigation that was undertaken.",
            "comment": "Most investigations are observations of one kind or another but some other specific types of data collection resources can also be used.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/RiskAssessment",
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.protocol",
            "path": "ClinicalImpression.protocol",
            "short": "Clinical Protocol followed",
            "definition": "Reference to a specific published clinical protocol that was followed during this assessment, and/or that provides evidence in support of the diagnosis.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ClinicalImpression.summary",
            "path": "ClinicalImpression.summary",
            "short": "Summary of the assessment",
            "definition": "A text summary of the investigations and the diagnosis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding",
            "path": "ClinicalImpression.finding",
            "short": "Possible or likely findings and diagnoses",
            "definition": "Specific findings or diagnoses that were considered likely or relevant to ongoing treatment.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding.itemCodeableConcept",
            "path": "ClinicalImpression.finding.itemCodeableConcept",
            "short": "What was found",
            "definition": "Specific text or code for finding or diagnosis, which may include ruled-out or resolved conditions.",
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
                  "valueString": "ConditionKind"
                }
              ],
              "strength": "example",
              "description": "Identification of the Condition or diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "ClinicalImpression.finding.itemReference",
            "path": "ClinicalImpression.finding.itemReference",
            "short": "What was found",
            "definition": "Specific reference for finding or diagnosis, which may include ruled-out or resolved conditions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.finding.basis",
            "path": "ClinicalImpression.finding.basis",
            "short": "Which investigations support finding",
            "definition": "Which investigations support finding or diagnosis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClinicalImpression.prognosisCodeableConcept",
            "path": "ClinicalImpression.prognosisCodeableConcept",
            "short": "Estimate of likely outcome",
            "definition": "Estimate of likely outcome.",
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
                  "valueString": "ClinicalImpressionPrognosis"
                }
              ],
              "strength": "example",
              "description": "Prognosis or outlook findings.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinicalimpression-prognosis"
            }
          },
          {
            "id": "ClinicalImpression.prognosisReference",
            "path": "ClinicalImpression.prognosisReference",
            "short": "RiskAssessment expressing likely outcome",
            "definition": "RiskAssessment expressing likely outcome.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/RiskAssessment"
                ]
              }
            ]
          },
          {
            "id": "ClinicalImpression.supportingInfo",
            "path": "ClinicalImpression.supportingInfo",
            "short": "Information supporting the clinical impression",
            "definition": "Information supporting the clinical impression.",
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
            "id": "ClinicalImpression.note",
            "path": "ClinicalImpression.note",
            "short": "Comments made about the ClinicalImpression",
            "definition": "Commentary about the impression, typically recorded after the impression itself was made, though supplemental notes by the original author could also appear.",
            "comment": "Don't use this element for content that should more properly appear as one of the specific elements of the impression.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ClinicalImpression'
    /// </summary>
    // 0. ClinicalImpression
    public class ClinicalImpression : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ClinicalImpression_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 13. ClinicalImpression.investigation
            public class Type_Investigation : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Investigation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 14. ClinicalImpression.investigation.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 15. ClinicalImpression.investigation.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Investigation_Elements()                                                                                    // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. ClinicalImpression.investigation.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "ClinicalImpression.investigation.code",                                                              // MakerGen.cs:236
                                Id = "ClinicalImpression.investigation.code",                                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
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
                            // 15. ClinicalImpression.investigation.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Item",                                                                                              // MakerGen.cs:235
                                Path= "ClinicalImpression.investigation.item",                                                              // MakerGen.cs:236
                                Id = "ClinicalImpression.investigation.item",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Observation",                                          // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",                                // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",                                  // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RiskAssessment",                                       // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/ImagingStudy",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Media"                                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Investigation_Elements Elements                                                                                 // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Investigation_Elements();                                                              // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Investigation_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Investigation()                                                                                                 // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ClinicalImpression.investigation",                                                                          // MakerGen.cs:428
                        ElementId = "ClinicalImpression.investigation"                                                                      // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 18. ClinicalImpression.finding
            public class Type_Finding : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Finding_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 19. ClinicalImpression.finding.itemCodeableConcept
                    public ElementDefinitionInfo ItemCodeableConcept;                                                                       // MakerGen.cs:216
                    // 20. ClinicalImpression.finding.itemReference
                    public ElementDefinitionInfo ItemReference;                                                                             // MakerGen.cs:216
                    // 21. ClinicalImpression.finding.basis
                    public ElementDefinitionInfo Basis;                                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Finding_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. ClinicalImpression.finding.itemCodeableConcept
                            this.ItemCodeableConcept = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ItemCodeableConcept",                                                                               // MakerGen.cs:235
                                Path= "ClinicalImpression.finding.itemCodeableConcept",                                                     // MakerGen.cs:236
                                Id = "ClinicalImpression.finding.itemCodeableConcept",                                                      // MakerGen.cs:237
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
                            // 20. ClinicalImpression.finding.itemReference
                            this.ItemReference = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ItemReference",                                                                                     // MakerGen.cs:235
                                Path= "ClinicalImpression.finding.itemReference",                                                           // MakerGen.cs:236
                                Id = "ClinicalImpression.finding.itemReference",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Observation",                                          // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Media"                                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. ClinicalImpression.finding.basis
                            this.Basis = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Basis",                                                                                             // MakerGen.cs:235
                                Path= "ClinicalImpression.finding.basis",                                                                   // MakerGen.cs:236
                                Id = "ClinicalImpression.finding.basis",                                                                    // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        ItemCodeableConcept.Write(sDef);                                                                                    // MakerGen.cs:220
                        ItemReference.Write(sDef);                                                                                          // MakerGen.cs:220
                        Basis.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Finding_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Finding_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Finding_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Finding()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ClinicalImpression.finding",                                                                                // MakerGen.cs:428
                        ElementId = "ClinicalImpression.finding"                                                                            // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. ClinicalImpression.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. ClinicalImpression.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. ClinicalImpression.statusReason
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:216
            // 4. ClinicalImpression.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:216
            // 5. ClinicalImpression.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 6. ClinicalImpression.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 7. ClinicalImpression.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 8. ClinicalImpression.effective[x]
            public ElementDefinitionInfo Effective;                                                                                         // MakerGen.cs:216
            // 9. ClinicalImpression.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 10. ClinicalImpression.assessor
            public ElementDefinitionInfo Assessor;                                                                                          // MakerGen.cs:216
            // 11. ClinicalImpression.previous
            public ElementDefinitionInfo Previous;                                                                                          // MakerGen.cs:216
            // 12. ClinicalImpression.problem
            public ElementDefinitionInfo Problem;                                                                                           // MakerGen.cs:216
            // 13. ClinicalImpression.investigation
            public ElementDefinitionInfo Investigation;                                                                                     // MakerGen.cs:216
            // 16. ClinicalImpression.protocol
            public ElementDefinitionInfo Protocol;                                                                                          // MakerGen.cs:216
            // 17. ClinicalImpression.summary
            public ElementDefinitionInfo Summary;                                                                                           // MakerGen.cs:216
            // 18. ClinicalImpression.finding
            public ElementDefinitionInfo Finding;                                                                                           // MakerGen.cs:216
            // 22. ClinicalImpression.prognosisCodeableConcept
            public ElementDefinitionInfo PrognosisCodeableConcept;                                                                          // MakerGen.cs:216
            // 23. ClinicalImpression.prognosisReference
            public ElementDefinitionInfo PrognosisReference;                                                                                // MakerGen.cs:216
            // 24. ClinicalImpression.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:216
            // 25. ClinicalImpression.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ClinicalImpression_Elements()                                                                                            // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ClinicalImpression.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ClinicalImpression.identifier",                                                                              // MakerGen.cs:236
                        Id = "ClinicalImpression.identifier",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. ClinicalImpression.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ClinicalImpression.status",                                                                                  // MakerGen.cs:236
                        Id = "ClinicalImpression.status",                                                                                   // MakerGen.cs:237
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
                    // 3. ClinicalImpression.statusReason
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusReason",                                                                                              // MakerGen.cs:235
                        Path= "ClinicalImpression.statusReason",                                                                            // MakerGen.cs:236
                        Id = "ClinicalImpression.statusReason",                                                                             // MakerGen.cs:237
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
                    // 4. ClinicalImpression.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Code",                                                                                                      // MakerGen.cs:235
                        Path= "ClinicalImpression.code",                                                                                    // MakerGen.cs:236
                        Id = "ClinicalImpression.code",                                                                                     // MakerGen.cs:237
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
                    // 5. ClinicalImpression.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "ClinicalImpression.description",                                                                             // MakerGen.cs:236
                        Id = "ClinicalImpression.description",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ClinicalImpression.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "ClinicalImpression.subject",                                                                                 // MakerGen.cs:236
                        Id = "ClinicalImpression.subject",                                                                                  // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. ClinicalImpression.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "ClinicalImpression.encounter",                                                                               // MakerGen.cs:236
                        Id = "ClinicalImpression.encounter",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. ClinicalImpression.effective[x]
                    this.Effective = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Effective",                                                                                                 // MakerGen.cs:235
                        Path= "ClinicalImpression.effective[x]",                                                                            // MakerGen.cs:236
                        Id = "ClinicalImpression.effective[x]",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. ClinicalImpression.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "ClinicalImpression.date",                                                                                    // MakerGen.cs:236
                        Id = "ClinicalImpression.date",                                                                                     // MakerGen.cs:237
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
                    // 10. ClinicalImpression.assessor
                    this.Assessor = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Assessor",                                                                                                  // MakerGen.cs:235
                        Path= "ClinicalImpression.assessor",                                                                                // MakerGen.cs:236
                        Id = "ClinicalImpression.assessor",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. ClinicalImpression.previous
                    this.Previous = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Previous",                                                                                                  // MakerGen.cs:235
                        Path= "ClinicalImpression.previous",                                                                                // MakerGen.cs:236
                        Id = "ClinicalImpression.previous",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ClinicalImpression"                                            // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. ClinicalImpression.problem
                    this.Problem = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Problem",                                                                                                   // MakerGen.cs:235
                        Path= "ClinicalImpression.problem",                                                                                 // MakerGen.cs:236
                        Id = "ClinicalImpression.problem",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"                                            // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. ClinicalImpression.investigation
                    this.Investigation = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Investigation",                                                                                             // MakerGen.cs:235
                        Path= "ClinicalImpression.investigation",                                                                           // MakerGen.cs:236
                        Id = "ClinicalImpression.investigation",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Investigation                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. ClinicalImpression.protocol
                    this.Protocol = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Protocol",                                                                                                  // MakerGen.cs:235
                        Path= "ClinicalImpression.protocol",                                                                                // MakerGen.cs:236
                        Id = "ClinicalImpression.protocol",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. ClinicalImpression.summary
                    this.Summary = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Summary",                                                                                                   // MakerGen.cs:235
                        Path= "ClinicalImpression.summary",                                                                                 // MakerGen.cs:236
                        Id = "ClinicalImpression.summary",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. ClinicalImpression.finding
                    this.Finding = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Finding",                                                                                                   // MakerGen.cs:235
                        Path= "ClinicalImpression.finding",                                                                                 // MakerGen.cs:236
                        Id = "ClinicalImpression.finding",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Finding                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. ClinicalImpression.prognosisCodeableConcept
                    this.PrognosisCodeableConcept = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PrognosisCodeableConcept",                                                                                  // MakerGen.cs:235
                        Path= "ClinicalImpression.prognosisCodeableConcept",                                                                // MakerGen.cs:236
                        Id = "ClinicalImpression.prognosisCodeableConcept",                                                                 // MakerGen.cs:237
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
                    // 23. ClinicalImpression.prognosisReference
                    this.PrognosisReference = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PrognosisReference",                                                                                        // MakerGen.cs:235
                        Path= "ClinicalImpression.prognosisReference",                                                                      // MakerGen.cs:236
                        Id = "ClinicalImpression.prognosisReference",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/RiskAssessment"                                                // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. ClinicalImpression.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:235
                        Path= "ClinicalImpression.supportingInfo",                                                                          // MakerGen.cs:236
                        Id = "ClinicalImpression.supportingInfo",                                                                           // MakerGen.cs:237
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
                    // 25. ClinicalImpression.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "ClinicalImpression.note",                                                                                    // MakerGen.cs:236
                        Id = "ClinicalImpression.note",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:220
                Code.Write(sDef);                                                                                                           // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Effective.Write(sDef);                                                                                                      // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Assessor.Write(sDef);                                                                                                       // MakerGen.cs:220
                Previous.Write(sDef);                                                                                                       // MakerGen.cs:220
                Problem.Write(sDef);                                                                                                        // MakerGen.cs:220
                Investigation.Write(sDef);                                                                                                  // MakerGen.cs:220
                Protocol.Write(sDef);                                                                                                       // MakerGen.cs:220
                Summary.Write(sDef);                                                                                                        // MakerGen.cs:220
                Finding.Write(sDef);                                                                                                        // MakerGen.cs:220
                PrognosisCodeableConcept.Write(sDef);                                                                                       // MakerGen.cs:220
                PrognosisReference.Write(sDef);                                                                                             // MakerGen.cs:220
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ClinicalImpression_Elements Elements                                                                                         // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ClinicalImpression_Elements();                                                                      // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ClinicalImpression_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ClinicalImpression()                                                                                                         // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ClinicalImpression";                                                                                               // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ClinicalImpression";                                                        // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ClinicalImpression",                                                                                                // MakerGen.cs:428
                ElementId = "ClinicalImpression"                                                                                            // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
