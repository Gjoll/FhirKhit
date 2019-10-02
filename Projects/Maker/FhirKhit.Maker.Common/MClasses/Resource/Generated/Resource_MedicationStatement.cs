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
      "id": "MedicationStatement",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
      "version": "4.0.0",
      "name": "MedicationStatement",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "A record of a medication that is being consumed by a patient.   A MedicationStatement may indicate that the patient may be taking the medication now or has taken the medication in the past or will be taking the medication in the future.  The source of this information can be the patient, significant other (such as a family member or spouse), or a clinician.  A common scenario where this information is captured is during the history taking process during a patient visit or stay.   The medication information may come from sources such as the patient's memory, from a prescription bottle,  or from a list of medications the patient, clinician or other party maintains. \n\nThe primary difference between a medication statement and a medication administration is that the medication administration has complete administration information and is based on actual administration information from the person who administered the medication.  A medication statement is often, if not always, less specific.  There is no required date/time when the medication was administered, in fact we only know that a source has reported the patient is taking this medication, where details such as time, quantity, or rate or even medication product may be incomplete or missing or less precise.  As stated earlier, the medication statement information may come from the patient's memory, from a prescription bottle or from a list of medications the patient, clinician or other party maintains.  Medication administration is more formal and is not missing detailed information.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicationStatement",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicationStatement",
            "path": "MedicationStatement",
            "short": "Record of medication being taken by a patient",
            "definition": "A record of a medication that is being consumed by a patient.   A MedicationStatement may indicate that the patient may be taking the medication now or has taken the medication in the past or will be taking the medication in the future.  The source of this information can be the patient, significant other (such as a family member or spouse), or a clinician.  A common scenario where this information is captured is during the history taking process during a patient visit or stay.   The medication information may come from sources such as the patient's memory, from a prescription bottle,  or from a list of medications the patient, clinician or other party maintains. \n\nThe primary difference between a medication statement and a medication administration is that the medication administration has complete administration information and is based on actual administration information from the person who administered the medication.  A medication statement is often, if not always, less specific.  There is no required date/time when the medication was administered, in fact we only know that a source has reported the patient is taking this medication, where details such as time, quantity, or rate or even medication product may be incomplete or missing or less precise.  As stated earlier, the medication statement information may come from the patient's memory, from a prescription bottle or from a list of medications the patient, clinician or other party maintains.  Medication administration is more formal and is not missing detailed information.",
            "comment": "When interpreting a medicationStatement, the value of the status and NotTaken needed to be considered:\rMedicationStatement.status + MedicationStatement.wasNotTaken\rStatus=Active + NotTaken=T = Not currently taking\rStatus=Completed + NotTaken=T = Not taken in the past\rStatus=Intended + NotTaken=T = No intention of taking\rStatus=Active + NotTaken=F = Taking, but not as prescribed\rStatus=Active + NotTaken=F = Taking\rStatus=Intended +NotTaken= F = Will be taking (not started)\rStatus=Completed + NotTaken=F = Taken in past\rStatus=In Error + NotTaken=N/A = In Error.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicationStatement.identifier",
            "path": "MedicationStatement.identifier",
            "short": "External identifier",
            "definition": "Identifiers associated with this Medication Statement that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate. They are business identifiers assigned to this resource by the performer or other systems and remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier.",
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
            "id": "MedicationStatement.basedOn",
            "path": "MedicationStatement.basedOn",
            "short": "Fulfils plan, proposal or order",
            "definition": "A plan, proposal or order that is fulfilled in whole or in part by this event.",
            "requirements": "Allows tracing of authorization for the event and tracking whether proposals/recommendations were acted upon.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationStatement.partOf",
            "path": "MedicationStatement.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular event is a component or step.",
            "requirements": "This should not be used when indicating which resource a MedicationStatement has been derived from.  If that is the use case, then MedicationStatement.derivedFrom should be used.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                  "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
                  "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationStatement.status",
            "path": "MedicationStatement.status",
            "short": "active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken",
            "definition": "A code representing the patient or other source's judgment about the state of the medication used that this statement is about.  Generally, this will be active or completed.",
            "comment": "MedicationStatement is a statement at a point in time.  The status is only representative at the point when it was asserted.  The value set for MedicationStatement.status contains codes that assert the status of the use of the medication by the patient (for example, stopped or on hold) as well as codes that assert the status of the medication statement itself (for example, entered in error).\r\rThis element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "MedicationStatementStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept indicating the current status of a MedicationStatement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-statement-status|4.0.0"
            }
          },
          {
            "id": "MedicationStatement.statusReason",
            "path": "MedicationStatement.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the MedicationStatement.",
            "comment": "This is generally only used for \"exception\" statuses such as \"not-taken\", \"on-hold\", \"cancelled\" or \"entered-in-error\". The reason for performing the event at all is captured in reasonCode, not here.",
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
                  "valueString": "MedicationStatementStatusReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept indicating the reason for the status of the statement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reason-medication-status-codes"
            }
          },
          {
            "id": "MedicationStatement.category",
            "path": "MedicationStatement.category",
            "short": "Type of medication usage",
            "definition": "Indicates where the medication is expected to be consumed or administered.",
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
                  "valueString": "MedicationStatementCategory"
                }
              ],
              "strength": "preferred",
              "description": "A coded concept identifying where the medication included in the MedicationStatement is expected to be consumed or administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-statement-category"
            }
          },
          {
            "id": "MedicationStatement.medication[x]",
            "path": "MedicationStatement.medication[x]",
            "short": "What medication was taken",
            "definition": "Identifies the medication being administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.",
            "comment": "If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationCode"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying the substance or product being taken.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "MedicationStatement.subject",
            "path": "MedicationStatement.subject",
            "short": "Who is/was taking  the medication",
            "definition": "The person, animal or group who is/was taking the medication.",
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
            "id": "MedicationStatement.context",
            "path": "MedicationStatement.context",
            "short": "Encounter / Episode associated with MedicationStatement",
            "definition": "The encounter or episode of care that establishes the context for this MedicationStatement.",
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
            ],
            "isSummary": true
          },
          {
            "id": "MedicationStatement.effective[x]",
            "path": "MedicationStatement.effective[x]",
            "short": "The date/time or interval when the medication is/was/will be taken",
            "definition": "The interval of time during which it is being asserted that the patient is/was/will be taking the medication (or was not taking, when the MedicationStatement.taken element is No).",
            "comment": "This attribute reflects the period over which the patient consumed the medication and is expected to be populated on the majority of Medication Statements. If the medication is still being taken at the time the statement is recorded, the \"end\" date will be omitted.  The date/time attribute supports a variety of dates - year, year/month and exact date.  If something more than this is required, this should be conveyed as text.",
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
            "id": "MedicationStatement.dateAsserted",
            "path": "MedicationStatement.dateAsserted",
            "short": "When the statement was asserted?",
            "definition": "The date when the medication statement was asserted by the information source.",
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
            "id": "MedicationStatement.informationSource",
            "path": "MedicationStatement.informationSource",
            "short": "Person or organization that provided the information about the taking of this medication",
            "definition": "The person or organization that provided the information about the taking of this medication. Note: Use derivedFrom when a MedicationStatement is derived from other resources, e.g. Claim or MedicationRequest.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "MedicationStatement.derivedFrom",
            "path": "MedicationStatement.derivedFrom",
            "short": "Additional supporting information",
            "definition": "Allows linking the MedicationStatement to the underlying MedicationRequest, or to other information that supports or is used to derive the MedicationStatement.",
            "comment": "Likely references would be to MedicationRequest, MedicationDispense, Claim, Observation or QuestionnaireAnswers.  The most common use cases for deriving a MedicationStatement comes from creating a MedicationStatement from a MedicationRequest or from a lab observation or a claim.  it should be noted that the amount of information that is available varies from the type resource that you derive the MedicationStatement from.",
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
            "id": "MedicationStatement.reasonCode",
            "path": "MedicationStatement.reasonCode",
            "short": "Reason for why the medication is being/was taken",
            "definition": "A reason for why the medication is being/was taken.",
            "comment": "This could be a diagnosis code. If a full condition record exists or additional detail is needed, use reasonForUseReference.",
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
                  "valueString": "MedicationReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying why the medication is being taken.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "MedicationStatement.reasonReference",
            "path": "MedicationStatement.reasonReference",
            "short": "Condition or observation that supports why the medication is being/was taken",
            "definition": "Condition or observation that supports why the medication is being/was taken.",
            "comment": "This is a reference to a condition that is the reason why the medication is being/was taken.  If only a code exists, use reasonForUseCode.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"
                ]
              }
            ]
          },
          {
            "id": "MedicationStatement.note",
            "path": "MedicationStatement.note",
            "short": "Further information about the statement",
            "definition": "Provides extra information about the medication statement that is not conveyed by the other attributes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "MedicationStatement.dosage",
            "path": "MedicationStatement.dosage",
            "short": "Details of how medication is/was taken or should be taken",
            "definition": "Indicates how the medication is/was or should be taken by the patient.",
            "comment": "The dates included in the dosage on a Medication Statement reflect the dates for a given dose.  For example, \"from November 1, 2016 to November 3, 2016, take one tablet daily and from November 4, 2016 to November 7, 2016, take two tablets daily.\"  It is expected that this specificity may only be populated where the patient brings in their labeled container or where the Medication Statement is derived from a MedicationRequest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Dosage"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MedicationStatement'
    /// </summary>
    // 0. MedicationStatement
    public class Resource_MedicationStatement : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. MedicationStatement.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MedicationStatement.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:219
        // 3. MedicationStatement.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:219
        // 4. MedicationStatement.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 5. MedicationStatement.statusReason
        public ElementDefinitionInfo Element_StatusReason;                                                                                  // MakerGen.cs:219
        // 6. MedicationStatement.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:219
        // 7. MedicationStatement.medication[x]
        public ElementDefinitionInfo Element_Medication;                                                                                    // MakerGen.cs:219
        // 8. MedicationStatement.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:219
        // 9. MedicationStatement.context
        public ElementDefinitionInfo Element_Context;                                                                                       // MakerGen.cs:219
        // 10. MedicationStatement.effective[x]
        public ElementDefinitionInfo Element_Effective;                                                                                     // MakerGen.cs:219
        // 11. MedicationStatement.dateAsserted
        public ElementDefinitionInfo Element_DateAsserted;                                                                                  // MakerGen.cs:219
        // 12. MedicationStatement.informationSource
        public ElementDefinitionInfo Element_InformationSource;                                                                             // MakerGen.cs:219
        // 13. MedicationStatement.derivedFrom
        public ElementDefinitionInfo Element_DerivedFrom;                                                                                   // MakerGen.cs:219
        // 14. MedicationStatement.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:219
        // 15. MedicationStatement.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:219
        // 16. MedicationStatement.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:219
        // 17. MedicationStatement.dosage
        public ElementDefinitionInfo Element_Dosage;                                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MedicationStatement",                                                                                               // MakerGen.cs:395
                ElementId = "MedicationStatement"                                                                                           // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_StatusReason.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Medication.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Context.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Effective.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_DateAsserted.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_InformationSource.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_DerivedFrom.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Dosage.Write(sDef);                                                                                                     // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MedicationStatement()                                                                                               // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MedicationStatement.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MedicationStatement.identifier",                                                                                 // MakerGen.cs:239
                    Id = "MedicationStatement.identifier",                                                                                  // MakerGen.cs:240
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
                // 2. MedicationStatement.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:238
                    Path= "MedicationStatement.basedOn",                                                                                    // MakerGen.cs:239
                    Id = "MedicationStatement.basedOn",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                                // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MedicationStatement.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:238
                    Path= "MedicationStatement.partOf",                                                                                     // MakerGen.cs:239
                    Id = "MedicationStatement.partOf",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/MedicationDispense",                                               // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/MedicationStatement",                                              // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Procedure",                                                        // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Observation"                                                       // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MedicationStatement.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "MedicationStatement.status",                                                                                     // MakerGen.cs:239
                    Id = "MedicationStatement.status",                                                                                      // MakerGen.cs:240
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
                // 5. MedicationStatement.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:238
                    Path= "MedicationStatement.statusReason",                                                                               // MakerGen.cs:239
                    Id = "MedicationStatement.statusReason",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 6. MedicationStatement.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Category",                                                                                              // MakerGen.cs:238
                    Path= "MedicationStatement.category",                                                                                   // MakerGen.cs:239
                    Id = "MedicationStatement.category",                                                                                    // MakerGen.cs:240
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
                // 7. MedicationStatement.medication[x]
                this.Element_Medication = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Medication",                                                                                            // MakerGen.cs:238
                    Path= "MedicationStatement.medication[x]",                                                                              // MakerGen.cs:239
                    Id = "MedicationStatement.medication[x]",                                                                               // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        },                                                                                                                  // MakerGen.cs:322
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. MedicationStatement.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:238
                    Path= "MedicationStatement.subject",                                                                                    // MakerGen.cs:239
                    Id = "MedicationStatement.subject",                                                                                     // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. MedicationStatement.context
                this.Element_Context = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Context",                                                                                               // MakerGen.cs:238
                    Path= "MedicationStatement.context",                                                                                    // MakerGen.cs:239
                    Id = "MedicationStatement.context",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter",                                                        // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                     // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. MedicationStatement.effective[x]
                this.Element_Effective = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Effective",                                                                                             // MakerGen.cs:238
                    Path= "MedicationStatement.effective[x]",                                                                               // MakerGen.cs:239
                    Id = "MedicationStatement.effective[x]",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. MedicationStatement.dateAsserted
                this.Element_DateAsserted = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DateAsserted",                                                                                          // MakerGen.cs:238
                    Path= "MedicationStatement.dateAsserted",                                                                               // MakerGen.cs:239
                    Id = "MedicationStatement.dateAsserted",                                                                                // MakerGen.cs:240
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
                // 12. MedicationStatement.informationSource
                this.Element_InformationSource = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_InformationSource",                                                                                     // MakerGen.cs:238
                    Path= "MedicationStatement.informationSource",                                                                          // MakerGen.cs:239
                    Id = "MedicationStatement.informationSource",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. MedicationStatement.derivedFrom
                this.Element_DerivedFrom = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DerivedFrom",                                                                                           // MakerGen.cs:238
                    Path= "MedicationStatement.derivedFrom",                                                                                // MakerGen.cs:239
                    Id = "MedicationStatement.derivedFrom",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. MedicationStatement.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:238
                    Path= "MedicationStatement.reasonCode",                                                                                 // MakerGen.cs:239
                    Id = "MedicationStatement.reasonCode",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 15. MedicationStatement.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:238
                    Path= "MedicationStatement.reasonReference",                                                                            // MakerGen.cs:239
                    Id = "MedicationStatement.reasonReference",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. MedicationStatement.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:238
                    Path= "MedicationStatement.note",                                                                                       // MakerGen.cs:239
                    Id = "MedicationStatement.note",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. MedicationStatement.dosage
                this.Element_Dosage = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Dosage",                                                                                                // MakerGen.cs:238
                    Path= "MedicationStatement.dosage",                                                                                     // MakerGen.cs:239
                    Id = "MedicationStatement.dosage",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Dosage                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MedicationStatement";                                                                                              // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationStatement";                                                       // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
