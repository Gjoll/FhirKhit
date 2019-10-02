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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Immunization'
    /// </summary>
    // 0. Immunization
    public class Resource_Immunization : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 18. Immunization.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 19. Immunization.performer.function
            public ElementDefinitionInfo Element_Function;                                                                                  // MakerGen.cs:219
            // 20. Immunization.performer.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Immunization.performer",                                                                                        // MakerGen.cs:395
                    ElementId = "Immunization.performer"                                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Function.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Performer()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 19. Immunization.performer.function
                    this.Element_Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Function",                                                                                          // MakerGen.cs:238
                        Path= "Immunization.performer.function",                                                                            // MakerGen.cs:239
                        Id = "Immunization.performer.function",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. Immunization.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:238
                        Path= "Immunization.performer.actor",                                                                               // MakerGen.cs:239
                        Id = "Immunization.performer.actor",                                                                                // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 26. Immunization.education
        public class Type_Education : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 27. Immunization.education.documentType
            public ElementDefinitionInfo Element_DocumentType;                                                                              // MakerGen.cs:219
            // 28. Immunization.education.reference
            public ElementDefinitionInfo Element_Reference;                                                                                 // MakerGen.cs:219
            // 29. Immunization.education.publicationDate
            public ElementDefinitionInfo Element_PublicationDate;                                                                           // MakerGen.cs:219
            // 30. Immunization.education.presentationDate
            public ElementDefinitionInfo Element_PresentationDate;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Immunization.education",                                                                                        // MakerGen.cs:395
                    ElementId = "Immunization.education"                                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_DocumentType.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Reference.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_PublicationDate.Write(sDef);                                                                                        // MakerGen.cs:223
                Element_PresentationDate.Write(sDef);                                                                                       // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Education()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 27. Immunization.education.documentType
                    this.Element_DocumentType = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DocumentType",                                                                                      // MakerGen.cs:238
                        Path= "Immunization.education.documentType",                                                                        // MakerGen.cs:239
                        Id = "Immunization.education.documentType",                                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 28. Immunization.education.reference
                    this.Element_Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Reference",                                                                                         // MakerGen.cs:238
                        Path= "Immunization.education.reference",                                                                           // MakerGen.cs:239
                        Id = "Immunization.education.reference",                                                                            // MakerGen.cs:240
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
                    // 29. Immunization.education.publicationDate
                    this.Element_PublicationDate = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PublicationDate",                                                                                   // MakerGen.cs:238
                        Path= "Immunization.education.publicationDate",                                                                     // MakerGen.cs:239
                        Id = "Immunization.education.publicationDate",                                                                      // MakerGen.cs:240
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
                {                                                                                                                           // MakerGen.cs:234
                    // 30. Immunization.education.presentationDate
                    this.Element_PresentationDate = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PresentationDate",                                                                                  // MakerGen.cs:238
                        Path= "Immunization.education.presentationDate",                                                                    // MakerGen.cs:239
                        Id = "Immunization.education.presentationDate",                                                                     // MakerGen.cs:240
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
        // 33. Immunization.reaction
        public class Type_Reaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 34. Immunization.reaction.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:219
            // 35. Immunization.reaction.detail
            public ElementDefinitionInfo Element_Detail;                                                                                    // MakerGen.cs:219
            // 36. Immunization.reaction.reported
            public ElementDefinitionInfo Element_Reported;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Immunization.reaction",                                                                                         // MakerGen.cs:395
                    ElementId = "Immunization.reaction"                                                                                     // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Detail.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Reported.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Reaction()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 34. Immunization.reaction.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Date",                                                                                              // MakerGen.cs:238
                        Path= "Immunization.reaction.date",                                                                                 // MakerGen.cs:239
                        Id = "Immunization.reaction.date",                                                                                  // MakerGen.cs:240
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
                {                                                                                                                           // MakerGen.cs:234
                    // 35. Immunization.reaction.detail
                    this.Element_Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Detail",                                                                                            // MakerGen.cs:238
                        Path= "Immunization.reaction.detail",                                                                               // MakerGen.cs:239
                        Id = "Immunization.reaction.detail",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Observation"                                                   // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 36. Immunization.reaction.reported
                    this.Element_Reported = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Reported",                                                                                          // MakerGen.cs:238
                        Path= "Immunization.reaction.reported",                                                                             // MakerGen.cs:239
                        Id = "Immunization.reaction.reported",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 37. Immunization.protocolApplied
        public class Type_ProtocolApplied : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 38. Immunization.protocolApplied.series
            public ElementDefinitionInfo Element_Series;                                                                                    // MakerGen.cs:219
            // 39. Immunization.protocolApplied.authority
            public ElementDefinitionInfo Element_Authority;                                                                                 // MakerGen.cs:219
            // 40. Immunization.protocolApplied.targetDisease
            public ElementDefinitionInfo Element_TargetDisease;                                                                             // MakerGen.cs:219
            // 41. Immunization.protocolApplied.doseNumber[x]
            public ElementDefinitionInfo Element_DoseNumber;                                                                                // MakerGen.cs:219
            // 42. Immunization.protocolApplied.seriesDoses[x]
            public ElementDefinitionInfo Element_SeriesDoses;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Immunization.protocolApplied",                                                                                  // MakerGen.cs:395
                    ElementId = "Immunization.protocolApplied"                                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Series.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Authority.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_TargetDisease.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_DoseNumber.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_SeriesDoses.Write(sDef);                                                                                            // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_ProtocolApplied()                                                                                                   // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 38. Immunization.protocolApplied.series
                    this.Element_Series = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Series",                                                                                            // MakerGen.cs:238
                        Path= "Immunization.protocolApplied.series",                                                                        // MakerGen.cs:239
                        Id = "Immunization.protocolApplied.series",                                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 39. Immunization.protocolApplied.authority
                    this.Element_Authority = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Authority",                                                                                         // MakerGen.cs:238
                        Path= "Immunization.protocolApplied.authority",                                                                     // MakerGen.cs:239
                        Id = "Immunization.protocolApplied.authority",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 40. Immunization.protocolApplied.targetDisease
                    this.Element_TargetDisease = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_TargetDisease",                                                                                     // MakerGen.cs:238
                        Path= "Immunization.protocolApplied.targetDisease",                                                                 // MakerGen.cs:239
                        Id = "Immunization.protocolApplied.targetDisease",                                                                  // MakerGen.cs:240
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
                    // 41. Immunization.protocolApplied.doseNumber[x]
                    this.Element_DoseNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DoseNumber",                                                                                        // MakerGen.cs:238
                        Path= "Immunization.protocolApplied.doseNumber[x]",                                                                 // MakerGen.cs:239
                        Id = "Immunization.protocolApplied.doseNumber[x]",                                                                  // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 42. Immunization.protocolApplied.seriesDoses[x]
                    this.Element_SeriesDoses = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_SeriesDoses",                                                                                       // MakerGen.cs:238
                        Path= "Immunization.protocolApplied.seriesDoses[x]",                                                                // MakerGen.cs:239
                        Id = "Immunization.protocolApplied.seriesDoses[x]",                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Immunization.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Immunization.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. Immunization.statusReason
        public ElementDefinitionInfo Element_StatusReason;                                                                                  // MakerGen.cs:219
        // 4. Immunization.vaccineCode
        public ElementDefinitionInfo Element_VaccineCode;                                                                                   // MakerGen.cs:219
        // 5. Immunization.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
        // 6. Immunization.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:219
        // 7. Immunization.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;                                                                                    // MakerGen.cs:219
        // 8. Immunization.recorded
        public ElementDefinitionInfo Element_Recorded;                                                                                      // MakerGen.cs:219
        // 9. Immunization.primarySource
        public ElementDefinitionInfo Element_PrimarySource;                                                                                 // MakerGen.cs:219
        // 10. Immunization.reportOrigin
        public ElementDefinitionInfo Element_ReportOrigin;                                                                                  // MakerGen.cs:219
        // 11. Immunization.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:219
        // 12. Immunization.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:219
        // 13. Immunization.lotNumber
        public ElementDefinitionInfo Element_LotNumber;                                                                                     // MakerGen.cs:219
        // 14. Immunization.expirationDate
        public ElementDefinitionInfo Element_ExpirationDate;                                                                                // MakerGen.cs:219
        // 15. Immunization.site
        public ElementDefinitionInfo Element_Site;                                                                                          // MakerGen.cs:219
        // 16. Immunization.route
        public ElementDefinitionInfo Element_Route;                                                                                         // MakerGen.cs:219
        // 17. Immunization.doseQuantity
        public ElementDefinitionInfo Element_DoseQuantity;                                                                                  // MakerGen.cs:219
        // 18. Immunization.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:219
        // 21. Immunization.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:219
        // 22. Immunization.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:219
        // 23. Immunization.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:219
        // 24. Immunization.isSubpotent
        public ElementDefinitionInfo Element_IsSubpotent;                                                                                   // MakerGen.cs:219
        // 25. Immunization.subpotentReason
        public ElementDefinitionInfo Element_SubpotentReason;                                                                               // MakerGen.cs:219
        // 26. Immunization.education
        public ElementDefinitionInfo Element_Education;                                                                                     // MakerGen.cs:219
        // 31. Immunization.programEligibility
        public ElementDefinitionInfo Element_ProgramEligibility;                                                                            // MakerGen.cs:219
        // 32. Immunization.fundingSource
        public ElementDefinitionInfo Element_FundingSource;                                                                                 // MakerGen.cs:219
        // 33. Immunization.reaction
        public ElementDefinitionInfo Element_Reaction;                                                                                      // MakerGen.cs:219
        // 37. Immunization.protocolApplied
        public ElementDefinitionInfo Element_ProtocolApplied;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Immunization",                                                                                                      // MakerGen.cs:395
                ElementId = "Immunization"                                                                                                  // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_StatusReason.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_VaccineCode.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Occurrence.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Recorded.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_PrimarySource.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_ReportOrigin.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_LotNumber.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_ExpirationDate.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_Site.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Route.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_DoseQuantity.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_IsSubpotent.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_SubpotentReason.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_Education.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_ProgramEligibility.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_FundingSource.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Reaction.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_ProtocolApplied.Write(sDef);                                                                                            // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Immunization()                                                                                                      // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Immunization.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Immunization.identifier",                                                                                        // MakerGen.cs:239
                    Id = "Immunization.identifier",                                                                                         // MakerGen.cs:240
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
                // 2. Immunization.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "Immunization.status",                                                                                            // MakerGen.cs:239
                    Id = "Immunization.status",                                                                                             // MakerGen.cs:240
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
                // 3. Immunization.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:238
                    Path= "Immunization.statusReason",                                                                                      // MakerGen.cs:239
                    Id = "Immunization.statusReason",                                                                                       // MakerGen.cs:240
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
                // 4. Immunization.vaccineCode
                this.Element_VaccineCode = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_VaccineCode",                                                                                           // MakerGen.cs:238
                    Path= "Immunization.vaccineCode",                                                                                       // MakerGen.cs:239
                    Id = "Immunization.vaccineCode",                                                                                        // MakerGen.cs:240
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
                // 5. Immunization.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "Immunization.patient",                                                                                           // MakerGen.cs:239
                    Id = "Immunization.patient",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 6. Immunization.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:238
                    Path= "Immunization.encounter",                                                                                         // MakerGen.cs:239
                    Id = "Immunization.encounter",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Immunization.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:238
                    Path= "Immunization.occurrence[x]",                                                                                     // MakerGen.cs:239
                    Id = "Immunization.occurrence[x]",                                                                                      // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Immunization.recorded
                this.Element_Recorded = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Recorded",                                                                                              // MakerGen.cs:238
                    Path= "Immunization.recorded",                                                                                          // MakerGen.cs:239
                    Id = "Immunization.recorded",                                                                                           // MakerGen.cs:240
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
                // 9. Immunization.primarySource
                this.Element_PrimarySource = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PrimarySource",                                                                                         // MakerGen.cs:238
                    Path= "Immunization.primarySource",                                                                                     // MakerGen.cs:239
                    Id = "Immunization.primarySource",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. Immunization.reportOrigin
                this.Element_ReportOrigin = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReportOrigin",                                                                                          // MakerGen.cs:238
                    Path= "Immunization.reportOrigin",                                                                                      // MakerGen.cs:239
                    Id = "Immunization.reportOrigin",                                                                                       // MakerGen.cs:240
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
                // 11. Immunization.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Location",                                                                                              // MakerGen.cs:238
                    Path= "Immunization.location",                                                                                          // MakerGen.cs:239
                    Id = "Immunization.location",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. Immunization.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:238
                    Path= "Immunization.manufacturer",                                                                                      // MakerGen.cs:239
                    Id = "Immunization.manufacturer",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
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
                // 13. Immunization.lotNumber
                this.Element_LotNumber = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_LotNumber",                                                                                             // MakerGen.cs:238
                    Path= "Immunization.lotNumber",                                                                                         // MakerGen.cs:239
                    Id = "Immunization.lotNumber",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. Immunization.expirationDate
                this.Element_ExpirationDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ExpirationDate",                                                                                        // MakerGen.cs:238
                    Path= "Immunization.expirationDate",                                                                                    // MakerGen.cs:239
                    Id = "Immunization.expirationDate",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 15. Immunization.site
                this.Element_Site = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Site",                                                                                                  // MakerGen.cs:238
                    Path= "Immunization.site",                                                                                              // MakerGen.cs:239
                    Id = "Immunization.site",                                                                                               // MakerGen.cs:240
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
                // 16. Immunization.route
                this.Element_Route = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Route",                                                                                                 // MakerGen.cs:238
                    Path= "Immunization.route",                                                                                             // MakerGen.cs:239
                    Id = "Immunization.route",                                                                                              // MakerGen.cs:240
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
                // 17. Immunization.doseQuantity
                this.Element_DoseQuantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DoseQuantity",                                                                                          // MakerGen.cs:238
                    Path= "Immunization.doseQuantity",                                                                                      // MakerGen.cs:239
                    Id = "Immunization.doseQuantity",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. Immunization.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:238
                    Path= "Immunization.performer",                                                                                         // MakerGen.cs:239
                    Id = "Immunization.performer",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Performer                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 21. Immunization.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:238
                    Path= "Immunization.note",                                                                                              // MakerGen.cs:239
                    Id = "Immunization.note",                                                                                               // MakerGen.cs:240
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
                // 22. Immunization.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:238
                    Path= "Immunization.reasonCode",                                                                                        // MakerGen.cs:239
                    Id = "Immunization.reasonCode",                                                                                         // MakerGen.cs:240
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
                // 23. Immunization.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:238
                    Path= "Immunization.reasonReference",                                                                                   // MakerGen.cs:239
                    Id = "Immunization.reasonReference",                                                                                    // MakerGen.cs:240
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
                // 24. Immunization.isSubpotent
                this.Element_IsSubpotent = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_IsSubpotent",                                                                                           // MakerGen.cs:238
                    Path= "Immunization.isSubpotent",                                                                                       // MakerGen.cs:239
                    Id = "Immunization.isSubpotent",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. Immunization.subpotentReason
                this.Element_SubpotentReason = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SubpotentReason",                                                                                       // MakerGen.cs:238
                    Path= "Immunization.subpotentReason",                                                                                   // MakerGen.cs:239
                    Id = "Immunization.subpotentReason",                                                                                    // MakerGen.cs:240
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
                // 26. Immunization.education
                this.Element_Education = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Education",                                                                                             // MakerGen.cs:238
                    Path= "Immunization.education",                                                                                         // MakerGen.cs:239
                    Id = "Immunization.education",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Education                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 31. Immunization.programEligibility
                this.Element_ProgramEligibility = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ProgramEligibility",                                                                                    // MakerGen.cs:238
                    Path= "Immunization.programEligibility",                                                                                // MakerGen.cs:239
                    Id = "Immunization.programEligibility",                                                                                 // MakerGen.cs:240
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
                // 32. Immunization.fundingSource
                this.Element_FundingSource = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_FundingSource",                                                                                         // MakerGen.cs:238
                    Path= "Immunization.fundingSource",                                                                                     // MakerGen.cs:239
                    Id = "Immunization.fundingSource",                                                                                      // MakerGen.cs:240
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
                // 33. Immunization.reaction
                this.Element_Reaction = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Reaction",                                                                                              // MakerGen.cs:238
                    Path= "Immunization.reaction",                                                                                          // MakerGen.cs:239
                    Id = "Immunization.reaction",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Reaction                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 37. Immunization.protocolApplied
                this.Element_ProtocolApplied = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ProtocolApplied",                                                                                       // MakerGen.cs:238
                    Path= "Immunization.protocolApplied",                                                                                   // MakerGen.cs:239
                    Id = "Immunization.protocolApplied",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_ProtocolApplied                                                                                            // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Immunization";                                                                                                     // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Immunization";                                                              // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
