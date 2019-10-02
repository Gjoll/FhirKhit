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
    #endregion
    /// <summary>
    /// Fhir resource 'Immunization'
    /// </summary>
    // 0. Immunization
    public partial class Resource_Immunization : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 18. Immunization.performer
        public partial class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. Immunization.performer.function
            public ElementDefinitionInfo Element_Function;
            // 20. Immunization.performer.actor
            public ElementDefinitionInfo Element_Actor;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Immunization.performer",
                    ElementId = "Immunization.performer"
                });
                Element_Function.Write(sDef);
                Element_Actor.Write(sDef);
            }
            
            public Type_Performer()
            {
                {
                    // 19. Immunization.performer.function
                    this.Element_Function = new ElementDefinitionInfo
                    {
                        Name = "Element_Function",
                        Path= "Immunization.performer.function",
                        Id = "Immunization.performer.function",
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
                    // 20. Immunization.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo
                    {
                        Name = "Element_Actor",
                        Path= "Immunization.performer.actor",
                        Id = "Immunization.performer.actor",
                        Min = 1,
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
            }
        }
        // 26. Immunization.education
        public partial class Type_Education : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 27. Immunization.education.documentType
            public ElementDefinitionInfo Element_DocumentType;
            // 28. Immunization.education.reference
            public ElementDefinitionInfo Element_Reference;
            // 29. Immunization.education.publicationDate
            public ElementDefinitionInfo Element_PublicationDate;
            // 30. Immunization.education.presentationDate
            public ElementDefinitionInfo Element_PresentationDate;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Immunization.education",
                    ElementId = "Immunization.education"
                });
                Element_DocumentType.Write(sDef);
                Element_Reference.Write(sDef);
                Element_PublicationDate.Write(sDef);
                Element_PresentationDate.Write(sDef);
            }
            
            public Type_Education()
            {
                {
                    // 27. Immunization.education.documentType
                    this.Element_DocumentType = new ElementDefinitionInfo
                    {
                        Name = "Element_DocumentType",
                        Path= "Immunization.education.documentType",
                        Id = "Immunization.education.documentType",
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
                    // 28. Immunization.education.reference
                    this.Element_Reference = new ElementDefinitionInfo
                    {
                        Name = "Element_Reference",
                        Path= "Immunization.education.reference",
                        Id = "Immunization.education.reference",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
                {
                    // 29. Immunization.education.publicationDate
                    this.Element_PublicationDate = new ElementDefinitionInfo
                    {
                        Name = "Element_PublicationDate",
                        Path= "Immunization.education.publicationDate",
                        Id = "Immunization.education.publicationDate",
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
                    // 30. Immunization.education.presentationDate
                    this.Element_PresentationDate = new ElementDefinitionInfo
                    {
                        Name = "Element_PresentationDate",
                        Path= "Immunization.education.presentationDate",
                        Id = "Immunization.education.presentationDate",
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
            }
        }
        // 33. Immunization.reaction
        public partial class Type_Reaction : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 34. Immunization.reaction.date
            public ElementDefinitionInfo Element_Date;
            // 35. Immunization.reaction.detail
            public ElementDefinitionInfo Element_Detail;
            // 36. Immunization.reaction.reported
            public ElementDefinitionInfo Element_Reported;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Immunization.reaction",
                    ElementId = "Immunization.reaction"
                });
                Element_Date.Write(sDef);
                Element_Detail.Write(sDef);
                Element_Reported.Write(sDef);
            }
            
            public Type_Reaction()
            {
                {
                    // 34. Immunization.reaction.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "Immunization.reaction.date",
                        Id = "Immunization.reaction.date",
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
                    // 35. Immunization.reaction.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "Immunization.reaction.detail",
                        Id = "Immunization.reaction.detail",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Observation"
                                }
                            }
                        }
                    };
                }
                {
                    // 36. Immunization.reaction.reported
                    this.Element_Reported = new ElementDefinitionInfo
                    {
                        Name = "Element_Reported",
                        Path= "Immunization.reaction.reported",
                        Id = "Immunization.reaction.reported",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
            }
        }
        // 37. Immunization.protocolApplied
        public partial class Type_ProtocolApplied : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 38. Immunization.protocolApplied.series
            public ElementDefinitionInfo Element_Series;
            // 39. Immunization.protocolApplied.authority
            public ElementDefinitionInfo Element_Authority;
            // 40. Immunization.protocolApplied.targetDisease
            public ElementDefinitionInfo Element_TargetDisease;
            // 41. Immunization.protocolApplied.doseNumber[x]
            public ElementDefinitionInfo Element_DoseNumber;
            // 42. Immunization.protocolApplied.seriesDoses[x]
            public ElementDefinitionInfo Element_SeriesDoses;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Immunization.protocolApplied",
                    ElementId = "Immunization.protocolApplied"
                });
                Element_Series.Write(sDef);
                Element_Authority.Write(sDef);
                Element_TargetDisease.Write(sDef);
                Element_DoseNumber.Write(sDef);
                Element_SeriesDoses.Write(sDef);
            }
            
            public Type_ProtocolApplied()
            {
                {
                    // 38. Immunization.protocolApplied.series
                    this.Element_Series = new ElementDefinitionInfo
                    {
                        Name = "Element_Series",
                        Path= "Immunization.protocolApplied.series",
                        Id = "Immunization.protocolApplied.series",
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
                    // 39. Immunization.protocolApplied.authority
                    this.Element_Authority = new ElementDefinitionInfo
                    {
                        Name = "Element_Authority",
                        Path= "Immunization.protocolApplied.authority",
                        Id = "Immunization.protocolApplied.authority",
                        Min = 0,
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
                    // 40. Immunization.protocolApplied.targetDisease
                    this.Element_TargetDisease = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetDisease",
                        Path= "Immunization.protocolApplied.targetDisease",
                        Id = "Immunization.protocolApplied.targetDisease",
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
                    // 41. Immunization.protocolApplied.doseNumber[x]
                    this.Element_DoseNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_DoseNumber",
                        Path= "Immunization.protocolApplied.doseNumber[x]",
                        Id = "Immunization.protocolApplied.doseNumber[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 42. Immunization.protocolApplied.seriesDoses[x]
                    this.Element_SeriesDoses = new ElementDefinitionInfo
                    {
                        Name = "Element_SeriesDoses",
                        Path= "Immunization.protocolApplied.seriesDoses[x]",
                        Id = "Immunization.protocolApplied.seriesDoses[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Immunization.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Immunization.status
        public ElementDefinitionInfo Element_Status;
        // 3. Immunization.statusReason
        public ElementDefinitionInfo Element_StatusReason;
        // 4. Immunization.vaccineCode
        public ElementDefinitionInfo Element_VaccineCode;
        // 5. Immunization.patient
        public ElementDefinitionInfo Element_Patient;
        // 6. Immunization.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 7. Immunization.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 8. Immunization.recorded
        public ElementDefinitionInfo Element_Recorded;
        // 9. Immunization.primarySource
        public ElementDefinitionInfo Element_PrimarySource;
        // 10. Immunization.reportOrigin
        public ElementDefinitionInfo Element_ReportOrigin;
        // 11. Immunization.location
        public ElementDefinitionInfo Element_Location;
        // 12. Immunization.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 13. Immunization.lotNumber
        public ElementDefinitionInfo Element_LotNumber;
        // 14. Immunization.expirationDate
        public ElementDefinitionInfo Element_ExpirationDate;
        // 15. Immunization.site
        public ElementDefinitionInfo Element_Site;
        // 16. Immunization.route
        public ElementDefinitionInfo Element_Route;
        // 17. Immunization.doseQuantity
        public ElementDefinitionInfo Element_DoseQuantity;
        // 18. Immunization.performer
        public ElementDefinitionInfo Element_Performer;
        // 21. Immunization.note
        public ElementDefinitionInfo Element_Note;
        // 22. Immunization.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 23. Immunization.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 24. Immunization.isSubpotent
        public ElementDefinitionInfo Element_IsSubpotent;
        // 25. Immunization.subpotentReason
        public ElementDefinitionInfo Element_SubpotentReason;
        // 26. Immunization.education
        public ElementDefinitionInfo Element_Education;
        // 31. Immunization.programEligibility
        public ElementDefinitionInfo Element_ProgramEligibility;
        // 32. Immunization.fundingSource
        public ElementDefinitionInfo Element_FundingSource;
        // 33. Immunization.reaction
        public ElementDefinitionInfo Element_Reaction;
        // 37. Immunization.protocolApplied
        public ElementDefinitionInfo Element_ProtocolApplied;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Immunization",
                ElementId = "Immunization"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_VaccineCode.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_Recorded.Write(sDef);
            Element_PrimarySource.Write(sDef);
            Element_ReportOrigin.Write(sDef);
            Element_Location.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_LotNumber.Write(sDef);
            Element_ExpirationDate.Write(sDef);
            Element_Site.Write(sDef);
            Element_Route.Write(sDef);
            Element_DoseQuantity.Write(sDef);
            Element_Performer.Write(sDef);
            Element_Note.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_IsSubpotent.Write(sDef);
            Element_SubpotentReason.Write(sDef);
            Element_Education.Write(sDef);
            Element_ProgramEligibility.Write(sDef);
            Element_FundingSource.Write(sDef);
            Element_Reaction.Write(sDef);
            Element_ProtocolApplied.Write(sDef);
        }
        
        public Resource_Immunization()
        {
            {
                // 1. Immunization.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Immunization.identifier",
                    Id = "Immunization.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. Immunization.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Immunization.status",
                    Id = "Immunization.status",
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
                // 3. Immunization.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "Immunization.statusReason",
                    Id = "Immunization.statusReason",
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
                // 4. Immunization.vaccineCode
                this.Element_VaccineCode = new ElementDefinitionInfo
                {
                    Name = "Element_VaccineCode",
                    Path= "Immunization.vaccineCode",
                    Id = "Immunization.vaccineCode",
                    Min = 1,
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
                // 5. Immunization.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "Immunization.patient",
                    Id = "Immunization.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 6. Immunization.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Immunization.encounter",
                    Id = "Immunization.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 7. Immunization.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "Immunization.occurrence[x]",
                    Id = "Immunization.occurrence[x]",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 8. Immunization.recorded
                this.Element_Recorded = new ElementDefinitionInfo
                {
                    Name = "Element_Recorded",
                    Path= "Immunization.recorded",
                    Id = "Immunization.recorded",
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
                // 9. Immunization.primarySource
                this.Element_PrimarySource = new ElementDefinitionInfo
                {
                    Name = "Element_PrimarySource",
                    Path= "Immunization.primarySource",
                    Id = "Immunization.primarySource",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 10. Immunization.reportOrigin
                this.Element_ReportOrigin = new ElementDefinitionInfo
                {
                    Name = "Element_ReportOrigin",
                    Path= "Immunization.reportOrigin",
                    Id = "Immunization.reportOrigin",
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
                // 11. Immunization.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "Immunization.location",
                    Id = "Immunization.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 12. Immunization.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "Immunization.manufacturer",
                    Id = "Immunization.manufacturer",
                    Min = 0,
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
                // 13. Immunization.lotNumber
                this.Element_LotNumber = new ElementDefinitionInfo
                {
                    Name = "Element_LotNumber",
                    Path= "Immunization.lotNumber",
                    Id = "Immunization.lotNumber",
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
                // 14. Immunization.expirationDate
                this.Element_ExpirationDate = new ElementDefinitionInfo
                {
                    Name = "Element_ExpirationDate",
                    Path= "Immunization.expirationDate",
                    Id = "Immunization.expirationDate",
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
                // 15. Immunization.site
                this.Element_Site = new ElementDefinitionInfo
                {
                    Name = "Element_Site",
                    Path= "Immunization.site",
                    Id = "Immunization.site",
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
                // 16. Immunization.route
                this.Element_Route = new ElementDefinitionInfo
                {
                    Name = "Element_Route",
                    Path= "Immunization.route",
                    Id = "Immunization.route",
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
                // 17. Immunization.doseQuantity
                this.Element_DoseQuantity = new ElementDefinitionInfo
                {
                    Name = "Element_DoseQuantity",
                    Path= "Immunization.doseQuantity",
                    Id = "Immunization.doseQuantity",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 18. Immunization.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "Immunization.performer",
                    Id = "Immunization.performer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Performer
                        {
                        }
                    }
                };
            }
            {
                // 21. Immunization.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Immunization.note",
                    Id = "Immunization.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 22. Immunization.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "Immunization.reasonCode",
                    Id = "Immunization.reasonCode",
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
                // 23. Immunization.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "Immunization.reasonReference",
                    Id = "Immunization.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"
                            }
                        }
                    }
                };
            }
            {
                // 24. Immunization.isSubpotent
                this.Element_IsSubpotent = new ElementDefinitionInfo
                {
                    Name = "Element_IsSubpotent",
                    Path= "Immunization.isSubpotent",
                    Id = "Immunization.isSubpotent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 25. Immunization.subpotentReason
                this.Element_SubpotentReason = new ElementDefinitionInfo
                {
                    Name = "Element_SubpotentReason",
                    Path= "Immunization.subpotentReason",
                    Id = "Immunization.subpotentReason",
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
                // 26. Immunization.education
                this.Element_Education = new ElementDefinitionInfo
                {
                    Name = "Element_Education",
                    Path= "Immunization.education",
                    Id = "Immunization.education",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Education
                        {
                        }
                    }
                };
            }
            {
                // 31. Immunization.programEligibility
                this.Element_ProgramEligibility = new ElementDefinitionInfo
                {
                    Name = "Element_ProgramEligibility",
                    Path= "Immunization.programEligibility",
                    Id = "Immunization.programEligibility",
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
                // 32. Immunization.fundingSource
                this.Element_FundingSource = new ElementDefinitionInfo
                {
                    Name = "Element_FundingSource",
                    Path= "Immunization.fundingSource",
                    Id = "Immunization.fundingSource",
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
                // 33. Immunization.reaction
                this.Element_Reaction = new ElementDefinitionInfo
                {
                    Name = "Element_Reaction",
                    Path= "Immunization.reaction",
                    Id = "Immunization.reaction",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Reaction
                        {
                        }
                    }
                };
            }
            {
                // 37. Immunization.protocolApplied
                this.Element_ProtocolApplied = new ElementDefinitionInfo
                {
                    Name = "Element_ProtocolApplied",
                    Path= "Immunization.protocolApplied",
                    Id = "Immunization.protocolApplied",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ProtocolApplied
                        {
                        }
                    }
                };
            }
            this.Name = "Immunization";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Immunization";
        }
    }
}
