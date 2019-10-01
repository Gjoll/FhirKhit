using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
    {
      "resourceType": "StructureDefinition",
      "id": "MedicationAdministration",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
      "version": "4.0.0",
      "name": "MedicationAdministration",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "Describes the event of a patient consuming or otherwise being administered a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.  Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicationAdministration",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicationAdministration",
            "path": "MedicationAdministration",
            "short": "Administration of medication to a patient",
            "definition": "Describes the event of a patient consuming or otherwise being administered a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.  Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicationAdministration.identifier",
            "path": "MedicationAdministration.identifier",
            "short": "External identifier",
            "definition": "Identifiers associated with this Medication Administration that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate. They are business identifiers assigned to this resource by the performer or other systems and remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "MedicationAdministration.instantiates",
            "path": "MedicationAdministration.instantiates",
            "short": "Instantiates protocol or definition",
            "definition": "A protocol, guideline, orderset, or other definition that was adhered to in whole or in part by this event.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationAdministration.partOf",
            "path": "MedicationAdministration.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular event is a component or step.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationAdministration.status",
            "path": "MedicationAdministration.status",
            "short": "in-progress | not-done | on-hold | completed | entered-in-error | stopped | unknown",
            "definition": "Will generally be set to show that the administration has been completed.  For some long running administrations such as infusions, it is possible for an administration to be started but not completed or it may be paused while some other process is under way.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "MedicationAdministrationStatus"
                }
              ],
              "strength": "required",
              "description": "A set of codes indicating the current status of a MedicationAdministration.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-admin-status|4.0.0"
            }
          },
          {
            "id": "MedicationAdministration.statusReason",
            "path": "MedicationAdministration.statusReason",
            "short": "Reason administration not performed",
            "definition": "A code indicating why the administration was not performed.",
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
                  "valueString": "MedicationAdministrationNegationReason"
                }
              ],
              "strength": "example",
              "description": "A set of codes indicating the reason why the MedicationAdministration is negated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reason-medication-not-given-codes"
            }
          },
          {
            "id": "MedicationAdministration.category",
            "path": "MedicationAdministration.category",
            "short": "Type of medication usage",
            "definition": "Indicates where the medication is expected to be consumed or administered.",
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
                  "valueString": "MedicationAdministrationCategory"
                }
              ],
              "strength": "preferred",
              "description": "A coded concept describing where the medication administered is expected to occur.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-admin-category"
            }
          },
          {
            "id": "MedicationAdministration.medication[x]",
            "path": "MedicationAdministration.medication[x]",
            "short": "What was administered",
            "definition": "Identifies the medication that was administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.",
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
              "description": "Codes identifying substance or product that can be administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "MedicationAdministration.subject",
            "path": "MedicationAdministration.subject",
            "short": "Who received medication",
            "definition": "The person or animal or group receiving the medication.",
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
            "id": "MedicationAdministration.context",
            "path": "MedicationAdministration.context",
            "short": "Encounter or Episode of Care administered as part of",
            "definition": "The visit, admission, or other contact between patient and health care provider during which the medication administration was performed.",
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
            ]
          },
          {
            "id": "MedicationAdministration.supportingInformation",
            "path": "MedicationAdministration.supportingInformation",
            "short": "Additional information to support administration",
            "definition": "Additional information (for example, patient height and weight) that supports the administration of the medication.",
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
            "id": "MedicationAdministration.effective[x]",
            "path": "MedicationAdministration.effective[x]",
            "short": "Start and end time of administration",
            "definition": "A specific date/time or interval of time during which the administration took place (or did not take place, when the 'notGiven' attribute is true). For many administrations, such as swallowing a tablet the use of dateTime is more appropriate.",
            "min": 1,
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
            "id": "MedicationAdministration.performer",
            "path": "MedicationAdministration.performer",
            "short": "Who performed the medication administration and what they did",
            "definition": "Indicates who or what performed the medication administration and how they were involved.",
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
            "id": "MedicationAdministration.performer.function",
            "path": "MedicationAdministration.performer.function",
            "short": "Type of performance",
            "definition": "Distinguishes the type of involvement of the performer in the medication administration.",
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
                  "valueString": "MedicationAdministrationPerformerFunction"
                }
              ],
              "strength": "example",
              "description": "A code describing the role an individual played in administering the medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/med-admin-perform-function"
            }
          },
          {
            "id": "MedicationAdministration.performer.actor",
            "path": "MedicationAdministration.performer.actor",
            "short": "Who performed the medication administration",
            "definition": "Indicates who or what performed the medication administration.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationAdministration.reasonCode",
            "path": "MedicationAdministration.reasonCode",
            "short": "Reason administration performed",
            "definition": "A code indicating why the medication was given.",
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
                  "valueString": "MedicationAdministrationReason"
                }
              ],
              "strength": "example",
              "description": "A set of codes indicating the reason why the MedicationAdministration was made.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reason-medication-given-codes"
            }
          },
          {
            "id": "MedicationAdministration.reasonReference",
            "path": "MedicationAdministration.reasonReference",
            "short": "Condition or observation that supports why the medication was administered",
            "definition": "Condition or observation that supports why the medication was administered.",
            "comment": "This is a reference to a condition that is the reason for the medication request.  If only a code exists, use reasonCode.",
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
            "id": "MedicationAdministration.request",
            "path": "MedicationAdministration.request",
            "short": "Request administration performed against",
            "definition": "The original request, instruction or authority to perform the administration.",
            "comment": "This is a reference to the MedicationRequest  where the intent is either order or instance-order.  It should not reference MedicationRequests where the intent is any other value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                ]
              }
            ]
          },
          {
            "id": "MedicationAdministration.device",
            "path": "MedicationAdministration.device",
            "short": "Device used to administer",
            "definition": "The device used in administering the medication to the patient.  For example, a particular infusion pump.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "MedicationAdministration.note",
            "path": "MedicationAdministration.note",
            "short": "Information about the administration",
            "definition": "Extra information about the medication administration that is not conveyed by the other attributes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "MedicationAdministration.dosage",
            "path": "MedicationAdministration.dosage",
            "short": "Details of how medication was taken",
            "definition": "Describes the medication dosage information details e.g. dose, rate, site, route, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationAdministration.dosage.text",
            "path": "MedicationAdministration.dosage.text",
            "short": "Free text dosage instructions e.g. SIG",
            "definition": "Free text dosage can be used for cases where the dosage administered is too complex to code. When coded dosage is present, the free text dosage may still be present for display to humans.\r\rThe dosage instructions should reflect the dosage of the medication that was administered.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "MedicationAdministration.dosage.site",
            "path": "MedicationAdministration.dosage.site",
            "short": "Body site administered to",
            "definition": "A coded specification of the anatomic site where the medication first entered the body.  For example, \"left arm\".",
            "comment": "If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.",
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
                  "valueString": "MedicationAdministrationSite"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the site location the medicine enters into or onto the body.",
              "valueSet": "http://hl7.org/fhir/ValueSet/approach-site-codes"
            }
          },
          {
            "id": "MedicationAdministration.dosage.route",
            "path": "MedicationAdministration.dosage.route",
            "short": "Path of substance into body",
            "definition": "A code specifying the route or physiological path of administration of a therapeutic agent into or onto the patient.  For example, topical, intravenous, etc.",
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
                  "valueString": "RouteOfAdministration"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the route or physiological path of administration of a therapeutic agent into or onto the body of a subject.",
              "valueSet": "http://hl7.org/fhir/ValueSet/route-codes"
            }
          },
          {
            "id": "MedicationAdministration.dosage.method",
            "path": "MedicationAdministration.dosage.method",
            "short": "How drug was administered",
            "definition": "A coded value indicating the method by which the medication is intended to be or was introduced into or on the body.  This attribute will most often NOT be populated.  It is most commonly used for injections.  For example, Slow Push, Deep IV.",
            "comment": "One of the reasons this attribute is not used often, is that the method is often pre-coordinated with the route and/or form of administration.  This means the codes used in route or form may pre-coordinate the method in the route code or the form code.  The implementation decision about what coding system to use for route or form code will determine how frequently the method code will be populated e.g. if route or form code pre-coordinate method code, then this attribute will not be populated often; if there is no pre-coordination then method code may  be used frequently.",
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
                  "valueString": "MedicationAdministrationMethod"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the technique by which the medicine is administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/administration-method-codes"
            }
          },
          {
            "id": "MedicationAdministration.dosage.dose",
            "path": "MedicationAdministration.dosage.dose",
            "short": "Amount of medication per dose",
            "definition": "The amount of the medication given at one administration event.   Use this value when the administration is essentially an instantaneous event such as a swallowing a tablet or giving an injection.",
            "comment": "If the administration is not instantaneous (rate is present), this can be specified to convey the total amount administered over period of time of a single administration.",
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
            "id": "MedicationAdministration.dosage.rate[x]",
            "path": "MedicationAdministration.dosage.rate[x]",
            "short": "Dose quantity per unit of time",
            "definition": "Identifies the speed with which the medication was or will be introduced into the patient.  Typically, the rate for an infusion e.g. 100 ml per 1 hour or 100 ml/hr.  May also be expressed as a rate per unit of time, e.g. 500 ml per 2 hours.  Other examples:  200 mcg/min or 200 mcg/1 minute; 1 liter/8 hours.",
            "comment": "If the rate changes over time, and you want to capture this in MedicationAdministration, then each change should be captured as a distinct MedicationAdministration, with a specific MedicationAdministration.dosage.rate, and the date time when the rate change occurred. Typically, the MedicationAdministration.dosage.rate element is not used to convey an average rate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              },
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "MedicationAdministration.eventHistory",
            "path": "MedicationAdministration.eventHistory",
            "short": "A list of events of interest in the lifecycle",
            "definition": "A summary of the events of interest that have occurred, such as when the administration was verified.",
            "comment": "This might not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the Provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the Provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Provenance"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicationAdministration'
    /// </summary>
    // 0. MedicationAdministration
    public class Resource_MedicationAdministration : FhirKhit.Maker.Common.Resource.ResourceBase                                            // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 12. MedicationAdministration.performer
        public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 13. MedicationAdministration.performer.function
            public ElementDefinitionInfo Element_Function;                                                                                  // MakerGen.cs:212
            // 14. MedicationAdministration.performer.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicationAdministration.performer",                                                                            // MakerGen.cs:388
                    ElementId = "MedicationAdministration.performer"                                                                        // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Function.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Performer()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. MedicationAdministration.performer.function
                    this.Element_Function = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Function",                                                                                          // MakerGen.cs:231
                        Path= "MedicationAdministration.performer.function",                                                                // MakerGen.cs:232
                        Id = "MedicationAdministration.performer.function",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. MedicationAdministration.performer.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:231
                        Path= "MedicationAdministration.performer.actor",                                                                   // MakerGen.cs:232
                        Id = "MedicationAdministration.performer.actor",                                                                    // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 20. MedicationAdministration.dosage
        public class Type_Dosage : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 21. MedicationAdministration.dosage.text
            public ElementDefinitionInfo Element_Text;                                                                                      // MakerGen.cs:212
            // 22. MedicationAdministration.dosage.site
            public ElementDefinitionInfo Element_Site;                                                                                      // MakerGen.cs:212
            // 23. MedicationAdministration.dosage.route
            public ElementDefinitionInfo Element_Route;                                                                                     // MakerGen.cs:212
            // 24. MedicationAdministration.dosage.method
            public ElementDefinitionInfo Element_Method;                                                                                    // MakerGen.cs:212
            // 25. MedicationAdministration.dosage.dose
            public ElementDefinitionInfo Element_Dose;                                                                                      // MakerGen.cs:212
            // 26. MedicationAdministration.dosage.rate[x]
            public ElementDefinitionInfo Element_Rate;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicationAdministration.dosage",                                                                               // MakerGen.cs:388
                    ElementId = "MedicationAdministration.dosage"                                                                           // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Text.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Site.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Route.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Method.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Dose.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Rate.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Dosage()                                                                                                            // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 21. MedicationAdministration.dosage.text
                    this.Element_Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Text",                                                                                              // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.text",                                                                       // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.text",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 22. MedicationAdministration.dosage.site
                    this.Element_Site = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Site",                                                                                              // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.site",                                                                       // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.site",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 23. MedicationAdministration.dosage.route
                    this.Element_Route = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Route",                                                                                             // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.route",                                                                      // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.route",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. MedicationAdministration.dosage.method
                    this.Element_Method = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Method",                                                                                            // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.method",                                                                     // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.method",                                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 25. MedicationAdministration.dosage.dose
                    this.Element_Dose = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Dose",                                                                                              // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.dose",                                                                       // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.dose",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 26. MedicationAdministration.dosage.rate[x]
                    this.Element_Rate = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Rate",                                                                                              // MakerGen.cs:231
                        Path= "MedicationAdministration.dosage.rate[x]",                                                                    // MakerGen.cs:232
                        Id = "MedicationAdministration.dosage.rate[x]",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. MedicationAdministration.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. MedicationAdministration.instantiates
        public ElementDefinitionInfo Element_Instantiates;                                                                                  // MakerGen.cs:212
        // 3. MedicationAdministration.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:212
        // 4. MedicationAdministration.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 5. MedicationAdministration.statusReason
        public ElementDefinitionInfo Element_StatusReason;                                                                                  // MakerGen.cs:212
        // 6. MedicationAdministration.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 7. MedicationAdministration.medication[x]
        public ElementDefinitionInfo Element_Medication;                                                                                    // MakerGen.cs:212
        // 8. MedicationAdministration.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 9. MedicationAdministration.context
        public ElementDefinitionInfo Element_Context;                                                                                       // MakerGen.cs:212
        // 10. MedicationAdministration.supportingInformation
        public ElementDefinitionInfo Element_SupportingInformation;                                                                         // MakerGen.cs:212
        // 11. MedicationAdministration.effective[x]
        public ElementDefinitionInfo Element_Effective;                                                                                     // MakerGen.cs:212
        // 12. MedicationAdministration.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:212
        // 15. MedicationAdministration.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:212
        // 16. MedicationAdministration.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:212
        // 17. MedicationAdministration.request
        public ElementDefinitionInfo Element_Request;                                                                                       // MakerGen.cs:212
        // 18. MedicationAdministration.device
        public ElementDefinitionInfo Element_Device;                                                                                        // MakerGen.cs:212
        // 19. MedicationAdministration.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 20. MedicationAdministration.dosage
        public ElementDefinitionInfo Element_Dosage;                                                                                        // MakerGen.cs:212
        // 27. MedicationAdministration.eventHistory
        public ElementDefinitionInfo Element_EventHistory;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicationAdministration",                                                                                          // MakerGen.cs:388
                ElementId = "MedicationAdministration"                                                                                      // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Instantiates.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_StatusReason.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Medication.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Context.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_SupportingInformation.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_Effective.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Request.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Device.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Dosage.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_EventHistory.Write(sDef);                                                                                               // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicationAdministration()                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicationAdministration.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "MedicationAdministration.identifier",                                                                            // MakerGen.cs:232
                    Id = "MedicationAdministration.identifier",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicationAdministration.instantiates
                this.Element_Instantiates = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Instantiates",                                                                                          // MakerGen.cs:231
                    Path= "MedicationAdministration.instantiates",                                                                          // MakerGen.cs:232
                    Id = "MedicationAdministration.instantiates",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. MedicationAdministration.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:231
                    Path= "MedicationAdministration.partOf",                                                                                // MakerGen.cs:232
                    Id = "MedicationAdministration.partOf",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",                                         // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Procedure"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. MedicationAdministration.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "MedicationAdministration.status",                                                                                // MakerGen.cs:232
                    Id = "MedicationAdministration.status",                                                                                 // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicationAdministration.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:231
                    Path= "MedicationAdministration.statusReason",                                                                          // MakerGen.cs:232
                    Id = "MedicationAdministration.statusReason",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. MedicationAdministration.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "MedicationAdministration.category",                                                                              // MakerGen.cs:232
                    Id = "MedicationAdministration.category",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. MedicationAdministration.medication[x]
                this.Element_Medication = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Medication",                                                                                            // MakerGen.cs:231
                    Path= "MedicationAdministration.medication[x]",                                                                         // MakerGen.cs:232
                    Id = "MedicationAdministration.medication[x]",                                                                          // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Medication"                                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. MedicationAdministration.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "MedicationAdministration.subject",                                                                               // MakerGen.cs:232
                    Id = "MedicationAdministration.subject",                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. MedicationAdministration.context
                this.Element_Context = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Context",                                                                                               // MakerGen.cs:231
                    Path= "MedicationAdministration.context",                                                                               // MakerGen.cs:232
                    Id = "MedicationAdministration.context",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. MedicationAdministration.supportingInformation
                this.Element_SupportingInformation = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SupportingInformation",                                                                                 // MakerGen.cs:231
                    Path= "MedicationAdministration.supportingInformation",                                                                 // MakerGen.cs:232
                    Id = "MedicationAdministration.supportingInformation",                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. MedicationAdministration.effective[x]
                this.Element_Effective = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Effective",                                                                                             // MakerGen.cs:231
                    Path= "MedicationAdministration.effective[x]",                                                                          // MakerGen.cs:232
                    Id = "MedicationAdministration.effective[x]",                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. MedicationAdministration.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:231
                    Path= "MedicationAdministration.performer",                                                                             // MakerGen.cs:232
                    Id = "MedicationAdministration.performer",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Performer                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. MedicationAdministration.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:231
                    Path= "MedicationAdministration.reasonCode",                                                                            // MakerGen.cs:232
                    Id = "MedicationAdministration.reasonCode",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. MedicationAdministration.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:231
                    Path= "MedicationAdministration.reasonReference",                                                                       // MakerGen.cs:232
                    Id = "MedicationAdministration.reasonReference",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. MedicationAdministration.request
                this.Element_Request = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Request",                                                                                               // MakerGen.cs:231
                    Path= "MedicationAdministration.request",                                                                               // MakerGen.cs:232
                    Id = "MedicationAdministration.request",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 18. MedicationAdministration.device
                this.Element_Device = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Device",                                                                                                // MakerGen.cs:231
                    Path= "MedicationAdministration.device",                                                                                // MakerGen.cs:232
                    Id = "MedicationAdministration.device",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 19. MedicationAdministration.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "MedicationAdministration.note",                                                                                  // MakerGen.cs:232
                    Id = "MedicationAdministration.note",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 20. MedicationAdministration.dosage
                this.Element_Dosage = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Dosage",                                                                                                // MakerGen.cs:231
                    Path= "MedicationAdministration.dosage",                                                                                // MakerGen.cs:232
                    Id = "MedicationAdministration.dosage",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Dosage                                                                                                     // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 27. MedicationAdministration.eventHistory
                this.Element_EventHistory = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_EventHistory",                                                                                          // MakerGen.cs:231
                    Path= "MedicationAdministration.eventHistory",                                                                          // MakerGen.cs:232
                    Id = "MedicationAdministration.eventHistory",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Provenance"                                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicationAdministration";                                                                                         // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationAdministration";                                                  // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
