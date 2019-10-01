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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'Immunization'
    /// </summary>
    // 0. Immunization
    public class Immunization : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 18. Immunization.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 19. Immunization.performer.function
            public MakerElementInstance Element_Function;                                                                                   // MakerGen.cs:232
            // 20. Immunization.performer.actor
            public MakerElementInstance Element_Actor;                                                                                      // MakerGen.cs:232
            public Type_Performer()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 19. Immunization.performer.function
                    this.Element_Function = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Function",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 20. Immunization.performer.actor
                    this.Element_Actor = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 26. Immunization.education
        public class Type_Education : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 27. Immunization.education.documentType
            public MakerElementInstance Element_DocumentType;                                                                               // MakerGen.cs:232
            // 28. Immunization.education.reference
            public MakerElementInstance Element_Reference;                                                                                  // MakerGen.cs:232
            // 29. Immunization.education.publicationDate
            public MakerElementInstance Element_PublicationDate;                                                                            // MakerGen.cs:232
            // 30. Immunization.education.presentationDate
            public MakerElementInstance Element_PresentationDate;                                                                           // MakerGen.cs:232
            public Type_Education()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 27. Immunization.education.documentType
                    this.Element_DocumentType = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DocumentType",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 28. Immunization.education.reference
                    this.Element_Reference = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reference",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Uri()                                                                       // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 29. Immunization.education.publicationDate
                    this.Element_PublicationDate = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PublicationDate",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 30. Immunization.education.presentationDate
                    this.Element_PresentationDate = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PresentationDate",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 33. Immunization.reaction
        public class Type_Reaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 34. Immunization.reaction.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 35. Immunization.reaction.detail
            public MakerElementInstance Element_Detail;                                                                                     // MakerGen.cs:232
            // 36. Immunization.reaction.reported
            public MakerElementInstance Element_Reported;                                                                                   // MakerGen.cs:232
            public Type_Reaction()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 34. Immunization.reaction.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 35. Immunization.reaction.detail
                    this.Element_Detail = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Detail",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 36. Immunization.reaction.reported
                    this.Element_Reported = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reported",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 37. Immunization.protocolApplied
        public class Type_ProtocolApplied : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 38. Immunization.protocolApplied.series
            public MakerElementInstance Element_Series;                                                                                     // MakerGen.cs:232
            // 39. Immunization.protocolApplied.authority
            public MakerElementInstance Element_Authority;                                                                                  // MakerGen.cs:232
            // 40. Immunization.protocolApplied.targetDisease
            public MakerElementInstance Element_TargetDisease;                                                                              // MakerGen.cs:232
            // 41. Immunization.protocolApplied.doseNumber[x]
            public MakerElementInstance Element_DoseNumber;                                                                                 // MakerGen.cs:232
            // 42. Immunization.protocolApplied.seriesDoses[x]
            public MakerElementInstance Element_SeriesDoses;                                                                                // MakerGen.cs:232
            public Type_ProtocolApplied()                                                                                                   // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 38. Immunization.protocolApplied.series
                    this.Element_Series = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Series",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 39. Immunization.protocolApplied.authority
                    this.Element_Authority = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Authority",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 40. Immunization.protocolApplied.targetDisease
                    this.Element_TargetDisease = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TargetDisease",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 41. Immunization.protocolApplied.doseNumber[x]
                    this.Element_DoseNumber = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DoseNumber",                                                                                        // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt(),                                                              // MakerGen.cs:286
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 42. Immunization.protocolApplied.seriesDoses[x]
                    this.Element_SeriesDoses = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SeriesDoses",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt(),                                                              // MakerGen.cs:286
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. Immunization.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Immunization.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. Immunization.statusReason
        public MakerElementInstance Element_StatusReason;                                                                                   // MakerGen.cs:232
        // 4. Immunization.vaccineCode
        public MakerElementInstance Element_VaccineCode;                                                                                    // MakerGen.cs:232
        // 5. Immunization.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 6. Immunization.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 7. Immunization.occurrence[x]
        public MakerElementInstance Element_Occurrence;                                                                                     // MakerGen.cs:232
        // 8. Immunization.recorded
        public MakerElementInstance Element_Recorded;                                                                                       // MakerGen.cs:232
        // 9. Immunization.primarySource
        public MakerElementInstance Element_PrimarySource;                                                                                  // MakerGen.cs:232
        // 10. Immunization.reportOrigin
        public MakerElementInstance Element_ReportOrigin;                                                                                   // MakerGen.cs:232
        // 11. Immunization.location
        public MakerElementInstance Element_Location;                                                                                       // MakerGen.cs:232
        // 12. Immunization.manufacturer
        public MakerElementInstance Element_Manufacturer;                                                                                   // MakerGen.cs:232
        // 13. Immunization.lotNumber
        public MakerElementInstance Element_LotNumber;                                                                                      // MakerGen.cs:232
        // 14. Immunization.expirationDate
        public MakerElementInstance Element_ExpirationDate;                                                                                 // MakerGen.cs:232
        // 15. Immunization.site
        public MakerElementInstance Element_Site;                                                                                           // MakerGen.cs:232
        // 16. Immunization.route
        public MakerElementInstance Element_Route;                                                                                          // MakerGen.cs:232
        // 17. Immunization.doseQuantity
        public MakerElementInstance Element_DoseQuantity;                                                                                   // MakerGen.cs:232
        // 21. Immunization.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 22. Immunization.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 23. Immunization.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 24. Immunization.isSubpotent
        public MakerElementInstance Element_IsSubpotent;                                                                                    // MakerGen.cs:232
        // 25. Immunization.subpotentReason
        public MakerElementInstance Element_SubpotentReason;                                                                                // MakerGen.cs:232
        // 31. Immunization.programEligibility
        public MakerElementInstance Element_ProgramEligibility;                                                                             // MakerGen.cs:232
        // 32. Immunization.fundingSource
        public MakerElementInstance Element_FundingSource;                                                                                  // MakerGen.cs:232
        public Immunization()                                                                                                               // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Immunization.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. Immunization.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. Immunization.statusReason
                this.Element_StatusReason = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. Immunization.vaccineCode
                this.Element_VaccineCode = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_VaccineCode",                                                                                           // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. Immunization.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. Immunization.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. Immunization.occurrence[x]
                this.Element_Occurrence = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime(),                                                                     // MakerGen.cs:286
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. Immunization.recorded
                this.Element_Recorded = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Recorded",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. Immunization.primarySource
                this.Element_PrimarySource = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PrimarySource",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. Immunization.reportOrigin
                this.Element_ReportOrigin = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReportOrigin",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. Immunization.location
                this.Element_Location = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Location",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. Immunization.manufacturer
                this.Element_Manufacturer = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. Immunization.lotNumber
                this.Element_LotNumber = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LotNumber",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. Immunization.expirationDate
                this.Element_ExpirationDate = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExpirationDate",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. Immunization.site
                this.Element_Site = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Site",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. Immunization.route
                this.Element_Route = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Route",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. Immunization.doseQuantity
                this.Element_DoseQuantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DoseQuantity",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 21. Immunization.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. Immunization.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. Immunization.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 24. Immunization.isSubpotent
                this.Element_IsSubpotent = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_IsSubpotent",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 25. Immunization.subpotentReason
                this.Element_SubpotentReason = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SubpotentReason",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 31. Immunization.programEligibility
                this.Element_ProgramEligibility = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProgramEligibility",                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 32. Immunization.fundingSource
                this.Element_FundingSource = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FundingSource",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
