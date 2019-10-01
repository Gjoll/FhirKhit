using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "Immunization",
      "url": "http://hl7.org/fhir/StructureDefinition/Immunization",
      "version": "4.0.0",
      "name": "Immunization",
      "status": "draft",
      "publisher": "Health Level Seven International (Public Health and Emergency Response)",
      "description": "Describes the event of a patient being administered a vaccine or a record of an immunization as reported by a patient, a clinician or another party.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Immunization",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Immunization",
            "path": "Immunization",
            "short": "Immunization event information",
            "definition": "Describes the event of a patient being administered a vaccine or a record of an immunization as reported by a patient, a clinician or another party.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Immunization.identifier",
            "path": "Immunization.identifier",
            "short": "Business identifier",
            "definition": "A unique identifier assigned to this immunization record.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Immunization.status",
            "path": "Immunization.status",
            "short": "completed | entered-in-error | not-done",
            "definition": "Indicates the current status of the immunization event.",
            "comment": "Will generally be set to show that the immunization has been completed or not done.  This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains statuses entered-in-error and not-done which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ImmunizationStatus"
                }
              ],
              "strength": "required",
              "description": "A set of codes indicating the current status of an Immunization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-status|4.0.0"
            }
          },
          {
            "id": "Immunization.statusReason",
            "path": "Immunization.statusReason",
            "short": "Reason not done",
            "definition": "Indicates the reason the immunization event was not performed.",
            "comment": "This is generally only used for the status of \"not-done\". The reason for performing the immunization event is captured in reasonCode, not here.",
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
                  "valueString": "ImmunizationStatusReason"
                }
              ],
              "strength": "example",
              "description": "The reason why a vaccine was not administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-status-reason"
            }
          },
          {
            "id": "Immunization.vaccineCode",
            "path": "Immunization.vaccineCode",
            "short": "Vaccine product administered",
            "definition": "Vaccine that was administered or was to be administered.",
            "min": 1,
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
                  "valueString": "VaccineCode"
                }
              ],
              "strength": "example",
              "description": "The code for vaccine product administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vaccine-code"
            }
          },
          {
            "id": "Immunization.patient",
            "path": "Immunization.patient",
            "short": "Who was immunized",
            "definition": "The patient who either received or did not receive the immunization.",
            "min": 1,
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
            "id": "Immunization.encounter",
            "path": "Immunization.encounter",
            "short": "Encounter immunization was part of",
            "definition": "The visit or admission or other contact between patient and health care provider the immunization was performed as part of.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "Immunization.occurrence[x]",
            "path": "Immunization.occurrence[x]",
            "short": "Vaccine administration date",
            "definition": "Date vaccine administered or was to be administered.",
            "comment": "When immunizations are given a specific date and time should always be known.   When immunizations are patient reported, a specific date might not be known.  Although partial dates are allowed, an adult patient might not be able to recall the year a childhood immunization was given. An exact date is always preferable, but the use of the String data type is acceptable when an exact date is not known. A small number of vaccines (e.g. live oral typhoid vaccine) are given as a series of patient self-administered dose over a span of time. In cases like this, often, only the first dose (typically a provider supervised dose) is recorded with the occurrence indicating the date/time of the first dose.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Immunization.recorded",
            "path": "Immunization.recorded",
            "short": "When the immunization was first captured in the subject's record",
            "definition": "The date the occurrence of the immunization was first captured in the record - potentially significantly after the occurrence of the event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": false
          },
          {
            "id": "Immunization.primarySource",
            "path": "Immunization.primarySource",
            "short": "Indicates context the data was recorded in",
            "definition": "An indication that the content of the record is based on information from the person who administered the vaccine. This reflects the context under which the data was originally recorded.",
            "comment": "Reflects the “reliability” of the content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Immunization.reportOrigin",
            "path": "Immunization.reportOrigin",
            "short": "Indicates the source of a secondarily reported record",
            "definition": "The source of the data when the report of the immunization event is not based on information from the person who administered the vaccine.",
            "comment": "Should not be populated if primarySource = True, not required even if primarySource = False.",
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
                  "valueString": "ImmunizationReportOrigin"
                }
              ],
              "strength": "example",
              "description": "The source of the data for a record which is not from a primary source.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-origin"
            }
          },
          {
            "id": "Immunization.location",
            "path": "Immunization.location",
            "short": "Where immunization occurred",
            "definition": "The service delivery location where the vaccine administration occurred.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Immunization.manufacturer",
            "path": "Immunization.manufacturer",
            "short": "Vaccine manufacturer",
            "definition": "Name of vaccine manufacturer.",
            "min": 0,
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
            "id": "Immunization.lotNumber",
            "path": "Immunization.lotNumber",
            "short": "Vaccine lot number",
            "definition": "Lot number of the  vaccine product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Immunization.expirationDate",
            "path": "Immunization.expirationDate",
            "short": "Vaccine expiration date",
            "definition": "Date vaccine batch expires.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "Immunization.site",
            "path": "Immunization.site",
            "short": "Body site vaccine  was administered",
            "definition": "Body site where vaccine was administered.",
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
                  "valueString": "ImmunizationSite"
                }
              ],
              "strength": "example",
              "description": "The site at which the vaccine was administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-site"
            }
          },
          {
            "id": "Immunization.route",
            "path": "Immunization.route",
            "short": "How vaccine entered body",
            "definition": "The path by which the vaccine product is taken into the body.",
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
                  "valueString": "ImmunizationRoute"
                }
              ],
              "strength": "example",
              "description": "The route by which the vaccine was administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-route"
            }
          },
          {
            "id": "Immunization.doseQuantity",
            "path": "Immunization.doseQuantity",
            "short": "Amount of vaccine administered",
            "definition": "The quantity of vaccine product that was administered.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "Immunization.performer",
            "path": "Immunization.performer",
            "short": "Who performed event",
            "definition": "Indicates who performed the immunization event.",
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
            "id": "Immunization.performer.function",
            "path": "Immunization.performer.function",
            "short": "What type of performance was done",
            "definition": "Describes the type of performance (e.g. ordering provider, administering provider, etc.).",
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
                  "valueString": "ImmunizationFunction"
                }
              ],
              "strength": "extensible",
              "description": "The role a practitioner or organization plays in the immunization event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-function"
            }
          },
          {
            "id": "Immunization.performer.actor",
            "path": "Immunization.performer.actor",
            "short": "Individual or organization who was performing",
            "definition": "The practitioner or organization who performed the action.",
            "comment": "When the individual practitioner who performed the action is known, it is best to send.",
            "min": 1,
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
            "id": "Immunization.note",
            "path": "Immunization.note",
            "short": "Additional immunization notes",
            "definition": "Extra information about the immunization that is not conveyed by the other attributes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Immunization.reasonCode",
            "path": "Immunization.reasonCode",
            "short": "Why immunization occurred",
            "definition": "Reasons why the vaccine was administered.",
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
                  "valueString": "ImmunizationReason"
                }
              ],
              "strength": "example",
              "description": "The reason why a vaccine was administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-reason"
            }
          },
          {
            "id": "Immunization.reasonReference",
            "path": "Immunization.reasonReference",
            "short": "Why immunization occurred",
            "definition": "Condition, Observation or DiagnosticReport that supports why the immunization was administered.",
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
            "id": "Immunization.isSubpotent",
            "path": "Immunization.isSubpotent",
            "short": "Dose potency",
            "definition": "Indication if a dose is considered to be subpotent. By default, a dose should be considered to be potent.",
            "comment": "Typically, the recognition of the dose being sub-potent is retrospective, after the administration (ex. notification of a manufacturer recall after administration). However, in the case of a partial administration (the patient moves unexpectedly and only some of the dose is actually administered), subpotency may be recognized immediately, but it is still important to record the event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "By default, a dose should be considered to be potent.",
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because an immunization event with a subpotent vaccine doesn't protect the patient the same way as a potent dose.",
            "isSummary": true
          },
          {
            "id": "Immunization.subpotentReason",
            "path": "Immunization.subpotentReason",
            "short": "Reason for being subpotent",
            "definition": "Reason why a dose is considered to be subpotent.",
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
                  "valueString": "SubpotentReason"
                }
              ],
              "strength": "example",
              "description": "The reason why a dose is considered to be subpotent.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-subpotent-reason"
            }
          },
          {
            "id": "Immunization.education",
            "path": "Immunization.education",
            "short": "Educational material presented to patient",
            "definition": "Educational material presented to the patient (or guardian) at the time of vaccine administration.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Immunization.education.documentType",
            "path": "Immunization.education.documentType",
            "short": "Educational material document identifier",
            "definition": "Identifier of the material presented to the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Immunization.education.reference",
            "path": "Immunization.education.reference",
            "short": "Educational material reference pointer",
            "definition": "Reference pointer to the educational material given to the patient if the information was on line.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Immunization.education.publicationDate",
            "path": "Immunization.education.publicationDate",
            "short": "Educational material publication date",
            "definition": "Date the educational material was published.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Immunization.education.presentationDate",
            "path": "Immunization.education.presentationDate",
            "short": "Educational material presentation date",
            "definition": "Date the educational material was given to the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Immunization.programEligibility",
            "path": "Immunization.programEligibility",
            "short": "Patient eligibility for a vaccination program",
            "definition": "Indicates a patient's eligibility for a funding program.",
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
                  "valueString": "ProgramEligibility"
                }
              ],
              "strength": "example",
              "description": "The patient's eligibility for a vaccation program.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-program-eligibility"
            }
          },
          {
            "id": "Immunization.fundingSource",
            "path": "Immunization.fundingSource",
            "short": "Funding source for the vaccine",
            "definition": "Indicates the source of the vaccine actually administered. This may be different than the patient eligibility (e.g. the patient may be eligible for a publically purchased vaccine but due to inventory issues, vaccine purchased with private funds was actually administered).",
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
                  "valueString": "FundingSource"
                }
              ],
              "strength": "example",
              "description": "The source of funding used to purchase the vaccine administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-funding-source"
            }
          },
          {
            "id": "Immunization.reaction",
            "path": "Immunization.reaction",
            "short": "Details of a reaction that follows immunization",
            "definition": "Categorical data indicating that an adverse event is associated in time to an immunization.",
            "comment": "A reaction may be an indication of an allergy or intolerance and, if this is determined to be the case, it should be recorded as a new AllergyIntolerance resource instance as most systems will not query against past Immunization.reaction elements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Immunization.reaction.date",
            "path": "Immunization.reaction.date",
            "short": "When reaction started",
            "definition": "Date of reaction to the immunization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Immunization.reaction.detail",
            "path": "Immunization.reaction.detail",
            "short": "Additional information on reaction",
            "definition": "Details of the reaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ]
          },
          {
            "id": "Immunization.reaction.reported",
            "path": "Immunization.reaction.reported",
            "short": "Indicates self-reported reaction",
            "definition": "Self-reported indicator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Immunization.protocolApplied",
            "path": "Immunization.protocolApplied",
            "short": "Protocol followed by the provider",
            "definition": "The protocol (set of recommendations) being followed by the provider who administered the dose.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Immunization.protocolApplied.series",
            "path": "Immunization.protocolApplied.series",
            "short": "Name of vaccine series",
            "definition": "One possible path to achieve presumed immunity against a disease - within the context of an authority.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Immunization.protocolApplied.authority",
            "path": "Immunization.protocolApplied.authority",
            "short": "Who is responsible for publishing the recommendations",
            "definition": "Indicates the authority who published the protocol (e.g. ACIP) that is being followed.",
            "min": 0,
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
            "id": "Immunization.protocolApplied.targetDisease",
            "path": "Immunization.protocolApplied.targetDisease",
            "short": "Vaccine preventatable disease being targetted",
            "definition": "The vaccine preventable disease the dose is being administered against.",
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
                  "valueString": "TargetDisease"
                }
              ],
              "strength": "example",
              "description": "The vaccine preventable disease the dose is being administered for.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-target-disease"
            }
          },
          {
            "id": "Immunization.protocolApplied.doseNumber[x]",
            "path": "Immunization.protocolApplied.doseNumber[x]",
            "short": "Dose number within series",
            "definition": "Nominal position in a series.",
            "comment": "The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Immunization.protocolApplied.seriesDoses[x]",
            "path": "Immunization.protocolApplied.seriesDoses[x]",
            "short": "Recommended number of doses for immunity",
            "definition": "The recommended number of doses to achieve immunity.",
            "comment": "The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Immunization'
    /// </summary>
    // 0. Immunization
    public class Immunization : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Immunization_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 18. Immunization.performer
            public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Performer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 19. Immunization.performer.function
                    public ElementDefinitionInfo Function;                                                                                  // MakerGen.cs:211
                    // 20. Immunization.performer.actor
                    public ElementDefinitionInfo Actor;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Performer_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. Immunization.performer.function
                            this.Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Function",                                                                                          // MakerGen.cs:230
                                Path= "Immunization.performer.function",                                                                    // MakerGen.cs:231
                                Id = "Immunization.performer.function",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. Immunization.performer.actor
                            this.Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Actor",                                                                                             // MakerGen.cs:230
                                Path= "Immunization.performer.actor",                                                                       // MakerGen.cs:231
                                Id = "Immunization.performer.actor",                                                                        // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Function.Write(sDef);                                                                                               // MakerGen.cs:215
                        Actor.Write(sDef);                                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Performer_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Performer_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Performer_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Performer()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Immunization.performer",                                                                                    // MakerGen.cs:423
                        ElementId = "Immunization.performer"                                                                                // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 26. Immunization.education
            public class Type_Education : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Education_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 27. Immunization.education.documentType
                    public ElementDefinitionInfo DocumentType;                                                                              // MakerGen.cs:211
                    // 28. Immunization.education.reference
                    public ElementDefinitionInfo Reference;                                                                                 // MakerGen.cs:211
                    // 29. Immunization.education.publicationDate
                    public ElementDefinitionInfo PublicationDate;                                                                           // MakerGen.cs:211
                    // 30. Immunization.education.presentationDate
                    public ElementDefinitionInfo PresentationDate;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Education_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. Immunization.education.documentType
                            this.DocumentType = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DocumentType",                                                                                      // MakerGen.cs:230
                                Path= "Immunization.education.documentType",                                                                // MakerGen.cs:231
                                Id = "Immunization.education.documentType",                                                                 // MakerGen.cs:232
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
                            // 28. Immunization.education.reference
                            this.Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Reference",                                                                                         // MakerGen.cs:230
                                Path= "Immunization.education.reference",                                                                   // MakerGen.cs:231
                                Id = "Immunization.education.reference",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. Immunization.education.publicationDate
                            this.PublicationDate = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "PublicationDate",                                                                                   // MakerGen.cs:230
                                Path= "Immunization.education.publicationDate",                                                             // MakerGen.cs:231
                                Id = "Immunization.education.publicationDate",                                                              // MakerGen.cs:232
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
                            // 30. Immunization.education.presentationDate
                            this.PresentationDate = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "PresentationDate",                                                                                  // MakerGen.cs:230
                                Path= "Immunization.education.presentationDate",                                                            // MakerGen.cs:231
                                Id = "Immunization.education.presentationDate",                                                             // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        DocumentType.Write(sDef);                                                                                           // MakerGen.cs:215
                        Reference.Write(sDef);                                                                                              // MakerGen.cs:215
                        PublicationDate.Write(sDef);                                                                                        // MakerGen.cs:215
                        PresentationDate.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Education_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Education_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Education_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Education()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Immunization.education",                                                                                    // MakerGen.cs:423
                        ElementId = "Immunization.education"                                                                                // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 33. Immunization.reaction
            public class Type_Reaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Reaction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 34. Immunization.reaction.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:211
                    // 35. Immunization.reaction.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:211
                    // 36. Immunization.reaction.reported
                    public ElementDefinitionInfo Reported;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Reaction_Elements()                                                                                         // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 34. Immunization.reaction.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Date",                                                                                              // MakerGen.cs:230
                                Path= "Immunization.reaction.date",                                                                         // MakerGen.cs:231
                                Id = "Immunization.reaction.date",                                                                          // MakerGen.cs:232
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
                            // 35. Immunization.reaction.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Detail",                                                                                            // MakerGen.cs:230
                                Path= "Immunization.reaction.detail",                                                                       // MakerGen.cs:231
                                Id = "Immunization.reaction.detail",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Observation"                                           // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 36. Immunization.reaction.reported
                            this.Reported = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Reported",                                                                                          // MakerGen.cs:230
                                Path= "Immunization.reaction.reported",                                                                     // MakerGen.cs:231
                                Id = "Immunization.reaction.reported",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Reported.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Reaction_Elements Elements                                                                                      // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Reaction_Elements();                                                                   // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Reaction_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Reaction()                                                                                                      // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Immunization.reaction",                                                                                     // MakerGen.cs:423
                        ElementId = "Immunization.reaction"                                                                                 // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 37. Immunization.protocolApplied
            public class Type_ProtocolApplied : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_ProtocolApplied_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 38. Immunization.protocolApplied.series
                    public ElementDefinitionInfo Series;                                                                                    // MakerGen.cs:211
                    // 39. Immunization.protocolApplied.authority
                    public ElementDefinitionInfo Authority;                                                                                 // MakerGen.cs:211
                    // 40. Immunization.protocolApplied.targetDisease
                    public ElementDefinitionInfo TargetDisease;                                                                             // MakerGen.cs:211
                    // 41. Immunization.protocolApplied.doseNumber[x]
                    public ElementDefinitionInfo DoseNumber;                                                                                // MakerGen.cs:211
                    // 42. Immunization.protocolApplied.seriesDoses[x]
                    public ElementDefinitionInfo SeriesDoses;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_ProtocolApplied_Elements()                                                                                  // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 38. Immunization.protocolApplied.series
                            this.Series = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Series",                                                                                            // MakerGen.cs:230
                                Path= "Immunization.protocolApplied.series",                                                                // MakerGen.cs:231
                                Id = "Immunization.protocolApplied.series",                                                                 // MakerGen.cs:232
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
                            // 39. Immunization.protocolApplied.authority
                            this.Authority = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Authority",                                                                                         // MakerGen.cs:230
                                Path= "Immunization.protocolApplied.authority",                                                             // MakerGen.cs:231
                                Id = "Immunization.protocolApplied.authority",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 40. Immunization.protocolApplied.targetDisease
                            this.TargetDisease = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "TargetDisease",                                                                                     // MakerGen.cs:230
                                Path= "Immunization.protocolApplied.targetDisease",                                                         // MakerGen.cs:231
                                Id = "Immunization.protocolApplied.targetDisease",                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 41. Immunization.protocolApplied.doseNumber[x]
                            this.DoseNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DoseNumber",                                                                                        // MakerGen.cs:230
                                Path= "Immunization.protocolApplied.doseNumber[x]",                                                         // MakerGen.cs:231
                                Id = "Immunization.protocolApplied.doseNumber[x]",                                                          // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 42. Immunization.protocolApplied.seriesDoses[x]
                            this.SeriesDoses = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "SeriesDoses",                                                                                       // MakerGen.cs:230
                                Path= "Immunization.protocolApplied.seriesDoses[x]",                                                        // MakerGen.cs:231
                                Id = "Immunization.protocolApplied.seriesDoses[x]",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Series.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Authority.Write(sDef);                                                                                              // MakerGen.cs:215
                        TargetDisease.Write(sDef);                                                                                          // MakerGen.cs:215
                        DoseNumber.Write(sDef);                                                                                             // MakerGen.cs:215
                        SeriesDoses.Write(sDef);                                                                                            // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_ProtocolApplied_Elements Elements                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_ProtocolApplied_Elements();                                                            // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_ProtocolApplied_Elements elements;                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_ProtocolApplied()                                                                                               // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Immunization.protocolApplied",                                                                              // MakerGen.cs:423
                        ElementId = "Immunization.protocolApplied"                                                                          // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. Immunization.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. Immunization.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 3. Immunization.statusReason
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:211
            // 4. Immunization.vaccineCode
            public ElementDefinitionInfo VaccineCode;                                                                                       // MakerGen.cs:211
            // 5. Immunization.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:211
            // 6. Immunization.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:211
            // 7. Immunization.occurrence[x]
            public ElementDefinitionInfo Occurrence;                                                                                        // MakerGen.cs:211
            // 8. Immunization.recorded
            public ElementDefinitionInfo Recorded;                                                                                          // MakerGen.cs:211
            // 9. Immunization.primarySource
            public ElementDefinitionInfo PrimarySource;                                                                                     // MakerGen.cs:211
            // 10. Immunization.reportOrigin
            public ElementDefinitionInfo ReportOrigin;                                                                                      // MakerGen.cs:211
            // 11. Immunization.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:211
            // 12. Immunization.manufacturer
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:211
            // 13. Immunization.lotNumber
            public ElementDefinitionInfo LotNumber;                                                                                         // MakerGen.cs:211
            // 14. Immunization.expirationDate
            public ElementDefinitionInfo ExpirationDate;                                                                                    // MakerGen.cs:211
            // 15. Immunization.site
            public ElementDefinitionInfo Site;                                                                                              // MakerGen.cs:211
            // 16. Immunization.route
            public ElementDefinitionInfo Route;                                                                                             // MakerGen.cs:211
            // 17. Immunization.doseQuantity
            public ElementDefinitionInfo DoseQuantity;                                                                                      // MakerGen.cs:211
            // 18. Immunization.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:211
            // 21. Immunization.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:211
            // 22. Immunization.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:211
            // 23. Immunization.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:211
            // 24. Immunization.isSubpotent
            public ElementDefinitionInfo IsSubpotent;                                                                                       // MakerGen.cs:211
            // 25. Immunization.subpotentReason
            public ElementDefinitionInfo SubpotentReason;                                                                                   // MakerGen.cs:211
            // 26. Immunization.education
            public ElementDefinitionInfo Education;                                                                                         // MakerGen.cs:211
            // 31. Immunization.programEligibility
            public ElementDefinitionInfo ProgramEligibility;                                                                                // MakerGen.cs:211
            // 32. Immunization.fundingSource
            public ElementDefinitionInfo FundingSource;                                                                                     // MakerGen.cs:211
            // 33. Immunization.reaction
            public ElementDefinitionInfo Reaction;                                                                                          // MakerGen.cs:211
            // 37. Immunization.protocolApplied
            public ElementDefinitionInfo ProtocolApplied;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Immunization_Elements()                                                                                                  // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Immunization.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Immunization.identifier",                                                                                    // MakerGen.cs:231
                        Id = "Immunization.identifier",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Immunization.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Immunization.status",                                                                                        // MakerGen.cs:231
                        Id = "Immunization.status",                                                                                         // MakerGen.cs:232
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
                    // 3. Immunization.statusReason
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "StatusReason",                                                                                              // MakerGen.cs:230
                        Path= "Immunization.statusReason",                                                                                  // MakerGen.cs:231
                        Id = "Immunization.statusReason",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Immunization.vaccineCode
                    this.VaccineCode = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "VaccineCode",                                                                                               // MakerGen.cs:230
                        Path= "Immunization.vaccineCode",                                                                                   // MakerGen.cs:231
                        Id = "Immunization.vaccineCode",                                                                                    // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Immunization.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Patient",                                                                                                   // MakerGen.cs:230
                        Path= "Immunization.patient",                                                                                       // MakerGen.cs:231
                        Id = "Immunization.patient",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Immunization.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Encounter",                                                                                                 // MakerGen.cs:230
                        Path= "Immunization.encounter",                                                                                     // MakerGen.cs:231
                        Id = "Immunization.encounter",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Immunization.occurrence[x]
                    this.Occurrence = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Occurrence",                                                                                                // MakerGen.cs:230
                        Path= "Immunization.occurrence[x]",                                                                                 // MakerGen.cs:231
                        Id = "Immunization.occurrence[x]",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Immunization.recorded
                    this.Recorded = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Recorded",                                                                                                  // MakerGen.cs:230
                        Path= "Immunization.recorded",                                                                                      // MakerGen.cs:231
                        Id = "Immunization.recorded",                                                                                       // MakerGen.cs:232
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
                    // 9. Immunization.primarySource
                    this.PrimarySource = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PrimarySource",                                                                                             // MakerGen.cs:230
                        Path= "Immunization.primarySource",                                                                                 // MakerGen.cs:231
                        Id = "Immunization.primarySource",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Immunization.reportOrigin
                    this.ReportOrigin = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReportOrigin",                                                                                              // MakerGen.cs:230
                        Path= "Immunization.reportOrigin",                                                                                  // MakerGen.cs:231
                        Id = "Immunization.reportOrigin",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Immunization.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Location",                                                                                                  // MakerGen.cs:230
                        Path= "Immunization.location",                                                                                      // MakerGen.cs:231
                        Id = "Immunization.location",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. Immunization.manufacturer
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:230
                        Path= "Immunization.manufacturer",                                                                                  // MakerGen.cs:231
                        Id = "Immunization.manufacturer",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. Immunization.lotNumber
                    this.LotNumber = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LotNumber",                                                                                                 // MakerGen.cs:230
                        Path= "Immunization.lotNumber",                                                                                     // MakerGen.cs:231
                        Id = "Immunization.lotNumber",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Immunization.expirationDate
                    this.ExpirationDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ExpirationDate",                                                                                            // MakerGen.cs:230
                        Path= "Immunization.expirationDate",                                                                                // MakerGen.cs:231
                        Id = "Immunization.expirationDate",                                                                                 // MakerGen.cs:232
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
                    // 15. Immunization.site
                    this.Site = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Site",                                                                                                      // MakerGen.cs:230
                        Path= "Immunization.site",                                                                                          // MakerGen.cs:231
                        Id = "Immunization.site",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. Immunization.route
                    this.Route = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Route",                                                                                                     // MakerGen.cs:230
                        Path= "Immunization.route",                                                                                         // MakerGen.cs:231
                        Id = "Immunization.route",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. Immunization.doseQuantity
                    this.DoseQuantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "DoseQuantity",                                                                                              // MakerGen.cs:230
                        Path= "Immunization.doseQuantity",                                                                                  // MakerGen.cs:231
                        Id = "Immunization.doseQuantity",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. Immunization.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Performer",                                                                                                 // MakerGen.cs:230
                        Path= "Immunization.performer",                                                                                     // MakerGen.cs:231
                        Id = "Immunization.performer",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Performer                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. Immunization.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Note",                                                                                                      // MakerGen.cs:230
                        Path= "Immunization.note",                                                                                          // MakerGen.cs:231
                        Id = "Immunization.note",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. Immunization.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:230
                        Path= "Immunization.reasonCode",                                                                                    // MakerGen.cs:231
                        Id = "Immunization.reasonCode",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. Immunization.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:230
                        Path= "Immunization.reasonReference",                                                                               // MakerGen.cs:231
                        Id = "Immunization.reasonReference",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. Immunization.isSubpotent
                    this.IsSubpotent = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "IsSubpotent",                                                                                               // MakerGen.cs:230
                        Path= "Immunization.isSubpotent",                                                                                   // MakerGen.cs:231
                        Id = "Immunization.isSubpotent",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. Immunization.subpotentReason
                    this.SubpotentReason = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SubpotentReason",                                                                                           // MakerGen.cs:230
                        Path= "Immunization.subpotentReason",                                                                               // MakerGen.cs:231
                        Id = "Immunization.subpotentReason",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. Immunization.education
                    this.Education = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Education",                                                                                                 // MakerGen.cs:230
                        Path= "Immunization.education",                                                                                     // MakerGen.cs:231
                        Id = "Immunization.education",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Education                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 31. Immunization.programEligibility
                    this.ProgramEligibility = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ProgramEligibility",                                                                                        // MakerGen.cs:230
                        Path= "Immunization.programEligibility",                                                                            // MakerGen.cs:231
                        Id = "Immunization.programEligibility",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 32. Immunization.fundingSource
                    this.FundingSource = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "FundingSource",                                                                                             // MakerGen.cs:230
                        Path= "Immunization.fundingSource",                                                                                 // MakerGen.cs:231
                        Id = "Immunization.fundingSource",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 33. Immunization.reaction
                    this.Reaction = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Reaction",                                                                                                  // MakerGen.cs:230
                        Path= "Immunization.reaction",                                                                                      // MakerGen.cs:231
                        Id = "Immunization.reaction",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Reaction                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 37. Immunization.protocolApplied
                    this.ProtocolApplied = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ProtocolApplied",                                                                                           // MakerGen.cs:230
                        Path= "Immunization.protocolApplied",                                                                               // MakerGen.cs:231
                        Id = "Immunization.protocolApplied",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_ProtocolApplied                                                                                        // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:215
                VaccineCode.Write(sDef);                                                                                                    // MakerGen.cs:215
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:215
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:215
                Occurrence.Write(sDef);                                                                                                     // MakerGen.cs:215
                Recorded.Write(sDef);                                                                                                       // MakerGen.cs:215
                PrimarySource.Write(sDef);                                                                                                  // MakerGen.cs:215
                ReportOrigin.Write(sDef);                                                                                                   // MakerGen.cs:215
                Location.Write(sDef);                                                                                                       // MakerGen.cs:215
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:215
                LotNumber.Write(sDef);                                                                                                      // MakerGen.cs:215
                ExpirationDate.Write(sDef);                                                                                                 // MakerGen.cs:215
                Site.Write(sDef);                                                                                                           // MakerGen.cs:215
                Route.Write(sDef);                                                                                                          // MakerGen.cs:215
                DoseQuantity.Write(sDef);                                                                                                   // MakerGen.cs:215
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:215
                Note.Write(sDef);                                                                                                           // MakerGen.cs:215
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:215
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:215
                IsSubpotent.Write(sDef);                                                                                                    // MakerGen.cs:215
                SubpotentReason.Write(sDef);                                                                                                // MakerGen.cs:215
                Education.Write(sDef);                                                                                                      // MakerGen.cs:215
                ProgramEligibility.Write(sDef);                                                                                             // MakerGen.cs:215
                FundingSource.Write(sDef);                                                                                                  // MakerGen.cs:215
                Reaction.Write(sDef);                                                                                                       // MakerGen.cs:215
                ProtocolApplied.Write(sDef);                                                                                                // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Immunization_Elements Elements                                                                                               // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Immunization_Elements();                                                                            // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Immunization_Elements elements;                                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Immunization()                                                                                                               // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Immunization";                                                                                                     // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Immunization";                                                              // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Immunization",                                                                                                      // MakerGen.cs:423
                ElementId = "Immunization"                                                                                                  // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
