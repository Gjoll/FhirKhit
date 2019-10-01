using System;                                                                                                                               // MakerGen.cs:516
using System.Diagnostics;                                                                                                                   // MakerGen.cs:517
using System.IO;                                                                                                                            // MakerGen.cs:518
using System.Linq;                                                                                                                          // MakerGen.cs:519
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:520
                                                                                                                                            // MakerGen.cs:521
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:522
{                                                                                                                                           // MakerGen.cs:523
    #region Json                                                                                                                            // MakerGen.cs:524
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Dosage",
      "url": "http://hl7.org/fhir/StructureDefinition/Dosage",
      "version": "4.0.0",
      "name": "Dosage",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Dosage Type: Indicates how the medication is/was taken or should be taken by the patient.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Dosage",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Dosage",
            "path": "Dosage",
            "short": "How the medication is/was taken or should be taken",
            "definition": "Indicates how the medication is/was taken or should be taken by the patient.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Dosage.sequence",
            "path": "Dosage.sequence",
            "short": "The order of the dosage instructions",
            "definition": "Indicates the order in which the dosage instructions should be applied or interpreted.",
            "requirements": "If the sequence number of multiple Dosages is the same, then it is implied that the instructions are to be treated as concurrent.  If the sequence number is different, then the Dosages are intended to be sequential.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.text",
            "path": "Dosage.text",
            "short": "Free text dosage instructions e.g. SIG",
            "definition": "Free text dosage instructions e.g. SIG.",
            "requirements": "Free text dosage instructions can be used for cases where the instructions are too complex to code.  The content of this attribute does not include the name or description of the medication. When coded instructions are present, the free text instructions may still be present for display to humans taking or administering the medication. It is expected that the text instructions will always be populated.  If the dosage.timing attribute is also populated, then the dosage.text should reflect the same information as the timing.  Additional information about administration or preparation of the medication should be included as text.",
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
            "id": "Dosage.additionalInstruction",
            "path": "Dosage.additionalInstruction",
            "short": "Supplemental instruction or warnings to the patient - e.g. \"with meals\", \"may cause drowsiness\"",
            "definition": "Supplemental instructions to the patient on how to take the medication  (e.g. \"with meals\" or\"take half to one hour before food\") or warnings for the patient about the medication (e.g. \"may cause drowsiness\" or \"avoid exposure of skin to direct sunlight or sunlamps\").",
            "comment": "Information about administration or preparation of the medication (e.g. \"infuse as rapidly as possibly via intraperitoneal port\" or \"immediately following drug x\") should be populated in dosage.text.",
            "requirements": "Additional instruction is intended to be coded, but where no code exists, the element could include text.  For example, \"Swallow with plenty of water\" which might or might not be coded.",
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
                  "valueString": "AdditionalInstruction"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying additional instructions such as \"take with water\" or \"avoid operating heavy machinery\".",
              "valueSet": "http://hl7.org/fhir/ValueSet/additional-instruction-codes"
            }
          },
          {
            "id": "Dosage.patientInstruction",
            "path": "Dosage.patientInstruction",
            "short": "Patient or consumer oriented instructions",
            "definition": "Instructions in terms that are understood by the patient or consumer.",
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
            "id": "Dosage.timing",
            "path": "Dosage.timing",
            "short": "When medication should be administered",
            "definition": "When medication should be administered.",
            "comment": "This attribute might not always be populated while the Dosage.text is expected to be populated.  If both are populated, then the Dosage.text should reflect the content of the Dosage.timing.",
            "requirements": "The timing schedule for giving the medication to the patient. This  data type allows many different expressions. For example: \"Every 8 hours\"; \"Three times a day\"; \"1/2 an hour before breakfast for 10 days from 23-Dec 2011:\"; \"15 Oct 2013, 17 Oct 2013 and 1 Nov 2013\".  Sometimes, a rate can imply duration when expressed as total volume / duration (e.g.  500mL/2 hours implies a duration of 2 hours).  However, when rate doesn't imply duration (e.g. 250mL/hour), then the timing.repeat.duration is needed to convey the infuse over time period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.asNeeded[x]",
            "path": "Dosage.asNeeded[x]",
            "short": "Take \"as needed\" (for x)",
            "definition": "Indicates whether the Medication is only taken when needed within a specific dosing schedule (Boolean option), or it indicates the precondition for taking the Medication (CodeableConcept).",
            "comment": "Can express \"as needed\" without a reason by setting the Boolean = True.  In this case the CodeableConcept is not populated.  Or you can express \"as needed\" with a reason by including the CodeableConcept.  In this case the Boolean is assumed to be True.  If you set the Boolean to False, then the dose is given according to the schedule and is not \"prn\" or \"as needed\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationAsNeededReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying the precondition that should be met or evaluated prior to consuming or administering a medication dose.  For example \"pain\", \"30 minutes prior to sexual intercourse\", \"on flare-up\" etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-as-needed-reason"
            }
          },
          {
            "id": "Dosage.site",
            "path": "Dosage.site",
            "short": "Body site to administer to",
            "definition": "Body site to administer to.",
            "comment": "If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.",
            "requirements": "A coded specification of the anatomic site where the medication first enters the body.",
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
                  "valueString": "MedicationAdministrationSite"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the site location the medicine enters into or onto the body.",
              "valueSet": "http://hl7.org/fhir/ValueSet/approach-site-codes"
            }
          },
          {
            "id": "Dosage.route",
            "path": "Dosage.route",
            "short": "How drug should enter body",
            "definition": "How drug should enter body.",
            "requirements": "A code specifying the route or physiological path of administration of a therapeutic agent into or onto a patient's body.",
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
                  "valueString": "RouteOfAdministration"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the route or physiological path of administration of a therapeutic agent into or onto the body of a subject.",
              "valueSet": "http://hl7.org/fhir/ValueSet/route-codes"
            }
          },
          {
            "id": "Dosage.method",
            "path": "Dosage.method",
            "short": "Technique for administering medication",
            "definition": "Technique for administering medication.",
            "comment": "Terminologies used often pre-coordinate this term with the route and or form of administration.",
            "requirements": "A coded value indicating the method by which the medication is introduced into or onto the body. Most commonly used for injections.  For examples, Slow Push; Deep IV.",
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
                  "valueString": "MedicationAdministrationMethod"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the technique by which the medicine is administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/administration-method-codes"
            }
          },
          {
            "id": "Dosage.doseAndRate",
            "path": "Dosage.doseAndRate",
            "short": "Amount of medication administered",
            "definition": "The amount of medication administered.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.doseAndRate.type",
            "path": "Dosage.doseAndRate.type",
            "short": "The kind of dose or rate specified",
            "definition": "The kind of dose or rate specified, for example, ordered or calculated.",
            "requirements": "If the type is not populated, assume to be \"ordered\".",
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
                  "valueString": "DoseAndRateType"
                }
              ],
              "strength": "example",
              "description": "The kind of dose or rate specified.",
              "valueSet": "http://hl7.org/fhir/ValueSet/dose-rate-type"
            }
          },
          {
            "id": "Dosage.doseAndRate.dose[x]",
            "path": "Dosage.doseAndRate.dose[x]",
            "short": "Amount of medication per dose",
            "definition": "Amount of medication per dose.",
            "comment": "Note that this specifies the quantity of the specified medication, not the quantity for each active ingredient(s). Each ingredient amount can be communicated in the Medication resource. For example, if one wants to communicate that a tablet was 375 mg, where the dose was one tablet, you can use the Medication resource to document that the tablet was comprised of 375 mg of drug XYZ. Alternatively if the dose was 375 mg, then you may only need to use the Medication resource to indicate this was a tablet. If the example were an IV such as dopamine and you wanted to communicate that 400mg of dopamine was mixed in 500 ml of some IV solution, then this would all be communicated in the Medication resource. If the administration is not intended to be instantaneous (rate is present or timing has a duration), this can be specified to convey the total amount to be administered over the period of time as indicated by the schedule e.g. 500 ml in dose, with timing used to convey that this should be done over 4 hours.",
            "requirements": "The amount of therapeutic or other substance given at one administration event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              },
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.doseAndRate.rate[x]",
            "path": "Dosage.doseAndRate.rate[x]",
            "short": "Amount of medication per unit of time",
            "definition": "Amount of medication per unit of time.",
            "comment": "It is possible to supply both a rate and a doseQuantity to provide full details about how the medication is to be administered and supplied. If the rate is intended to change over time, depending on local rules/regulations, each change should be captured as a new version of the MedicationRequest with an updated rate, or captured with a new MedicationRequest with the new rate.\r\rIt is possible to specify a rate over time (for example, 100 ml/hour) using either the rateRatio and rateQuantity.  The rateQuantity approach requires systems to have the capability to parse UCUM grammer where ml/hour is included rather than a specific ratio where the time is specified as the denominator.  Where a rate such as 500ml over 2 hours is specified, the use of rateRatio may be more semantically correct than specifying using a rateQuantity of 250 mg/hour.",
            "requirements": "Identifies the speed with which the medication was or will be introduced into the patient. Typically the rate for an infusion e.g. 100 ml per 1 hour or 100 ml/hr.  May also be expressed as a rate per unit of time e.g. 500 ml per 2 hours.   Other examples: 200 mcg/min or 200 mcg/1 minute; 1 liter/8 hours.  Sometimes, a rate can imply duration when expressed as total volume / duration (e.g.  500mL/2 hours implies a duration of 2 hours).  However, when rate doesn't imply duration (e.g. 250mL/hour), then the timing.repeat.duration is needed to convey the infuse over time period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              },
              {
                "code": "Range"
              },
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.maxDosePerPeriod",
            "path": "Dosage.maxDosePerPeriod",
            "short": "Upper limit on medication per unit of time",
            "definition": "Upper limit on medication per unit of time.",
            "comment": "This is intended for use as an adjunct to the dosage when there is an upper cap.  For example \"2 tablets every 4 hours to a maximum of 8/day\".",
            "requirements": "The maximum total quantity of a therapeutic substance that may be administered to a subject over the period of time.  For example, 1000mg in 24 hours.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.maxDosePerAdministration",
            "path": "Dosage.maxDosePerAdministration",
            "short": "Upper limit on medication per administration",
            "definition": "Upper limit on medication per administration.",
            "comment": "This is intended for use as an adjunct to the dosage when there is an upper cap.  For example, a body surface area related dose with a maximum amount, such as 1.5 mg/m2 (maximum 2 mg) IV over 5 – 10 minutes would have doseQuantity of 1.5 mg/m2 and maxDosePerAdministration of 2 mg.",
            "requirements": "The maximum total quantity of a therapeutic substance that may be administered to a subject per administration.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Dosage.maxDosePerLifetime",
            "path": "Dosage.maxDosePerLifetime",
            "short": "Upper limit on medication per lifetime of the patient",
            "definition": "Upper limit on medication per lifetime of the patient.",
            "requirements": "The maximum total quantity of a therapeutic substance that may be administered per lifetime of the subject.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'Dosage'
    /// </summary>
    // 0. Dosage
    public class Dosage : FhirKhit.Maker.Common.Complex.ComplexBase                                                                         // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Dosage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                          // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 10. Dosage.doseAndRate
            public class Type_DoseAndRate : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_DoseAndRate_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 11. Dosage.doseAndRate.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 12. Dosage.doseAndRate.dose[x]
                    public ElementDefinitionInfo Dose;                                                                                      // MakerGen.cs:216
                    // 13. Dosage.doseAndRate.rate[x]
                    public ElementDefinitionInfo Rate;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_DoseAndRate_Elements()                                                                                      // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. Dosage.doseAndRate.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Dosage.doseAndRate.type",                                                                            // MakerGen.cs:236
                                Id = "Dosage.doseAndRate.type",                                                                             // MakerGen.cs:237
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
                            // 12. Dosage.doseAndRate.dose[x]
                            this.Dose = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Dose",                                                                                              // MakerGen.cs:235
                                Path= "Dosage.doseAndRate.dose[x]",                                                                         // MakerGen.cs:236
                                Id = "Dosage.doseAndRate.dose[x]",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. Dosage.doseAndRate.rate[x]
                            this.Rate = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Rate",                                                                                              // MakerGen.cs:235
                                Path= "Dosage.doseAndRate.rate[x]",                                                                         // MakerGen.cs:236
                                Id = "Dosage.doseAndRate.rate[x]",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Dose.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Rate.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_DoseAndRate_Elements Elements                                                                                   // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_DoseAndRate_Elements();                                                                // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_DoseAndRate_Elements elements;                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_DoseAndRate()                                                                                                   // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Dosage.doseAndRate",                                                                                        // MakerGen.cs:428
                        ElementId = "Dosage.doseAndRate"                                                                                    // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. Dosage.sequence
            public ElementDefinitionInfo Sequence;                                                                                          // MakerGen.cs:216
            // 2. Dosage.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:216
            // 3. Dosage.additionalInstruction
            public ElementDefinitionInfo AdditionalInstruction;                                                                             // MakerGen.cs:216
            // 4. Dosage.patientInstruction
            public ElementDefinitionInfo PatientInstruction;                                                                                // MakerGen.cs:216
            // 5. Dosage.timing
            public ElementDefinitionInfo Timing;                                                                                            // MakerGen.cs:216
            // 6. Dosage.asNeeded[x]
            public ElementDefinitionInfo AsNeeded;                                                                                          // MakerGen.cs:216
            // 7. Dosage.site
            public ElementDefinitionInfo Site;                                                                                              // MakerGen.cs:216
            // 8. Dosage.route
            public ElementDefinitionInfo Route;                                                                                             // MakerGen.cs:216
            // 9. Dosage.method
            public ElementDefinitionInfo Method;                                                                                            // MakerGen.cs:216
            // 10. Dosage.doseAndRate
            public ElementDefinitionInfo DoseAndRate;                                                                                       // MakerGen.cs:216
            // 14. Dosage.maxDosePerPeriod
            public ElementDefinitionInfo MaxDosePerPeriod;                                                                                  // MakerGen.cs:216
            // 15. Dosage.maxDosePerAdministration
            public ElementDefinitionInfo MaxDosePerAdministration;                                                                          // MakerGen.cs:216
            // 16. Dosage.maxDosePerLifetime
            public ElementDefinitionInfo MaxDosePerLifetime;                                                                                // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public Dosage_Elements()                                                                                                        // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Dosage.sequence
                    this.Sequence = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Sequence",                                                                                                  // MakerGen.cs:235
                        Path= "Dosage.sequence",                                                                                            // MakerGen.cs:236
                        Id = "Dosage.sequence",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Dosage.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Text",                                                                                                      // MakerGen.cs:235
                        Path= "Dosage.text",                                                                                                // MakerGen.cs:236
                        Id = "Dosage.text",                                                                                                 // MakerGen.cs:237
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
                    // 3. Dosage.additionalInstruction
                    this.AdditionalInstruction = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdditionalInstruction",                                                                                     // MakerGen.cs:235
                        Path= "Dosage.additionalInstruction",                                                                               // MakerGen.cs:236
                        Id = "Dosage.additionalInstruction",                                                                                // MakerGen.cs:237
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
                    // 4. Dosage.patientInstruction
                    this.PatientInstruction = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PatientInstruction",                                                                                        // MakerGen.cs:235
                        Path= "Dosage.patientInstruction",                                                                                  // MakerGen.cs:236
                        Id = "Dosage.patientInstruction",                                                                                   // MakerGen.cs:237
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
                    // 5. Dosage.timing
                    this.Timing = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Timing",                                                                                                    // MakerGen.cs:235
                        Path= "Dosage.timing",                                                                                              // MakerGen.cs:236
                        Id = "Dosage.timing",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. Dosage.asNeeded[x]
                    this.AsNeeded = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AsNeeded",                                                                                                  // MakerGen.cs:235
                        Path= "Dosage.asNeeded[x]",                                                                                         // MakerGen.cs:236
                        Id = "Dosage.asNeeded[x]",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. Dosage.site
                    this.Site = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Site",                                                                                                      // MakerGen.cs:235
                        Path= "Dosage.site",                                                                                                // MakerGen.cs:236
                        Id = "Dosage.site",                                                                                                 // MakerGen.cs:237
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
                    // 8. Dosage.route
                    this.Route = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Route",                                                                                                     // MakerGen.cs:235
                        Path= "Dosage.route",                                                                                               // MakerGen.cs:236
                        Id = "Dosage.route",                                                                                                // MakerGen.cs:237
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
                    // 9. Dosage.method
                    this.Method = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Method",                                                                                                    // MakerGen.cs:235
                        Path= "Dosage.method",                                                                                              // MakerGen.cs:236
                        Id = "Dosage.method",                                                                                               // MakerGen.cs:237
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
                    // 10. Dosage.doseAndRate
                    this.DoseAndRate = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoseAndRate",                                                                                               // MakerGen.cs:235
                        Path= "Dosage.doseAndRate",                                                                                         // MakerGen.cs:236
                        Id = "Dosage.doseAndRate",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_DoseAndRate                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. Dosage.maxDosePerPeriod
                    this.MaxDosePerPeriod = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MaxDosePerPeriod",                                                                                          // MakerGen.cs:235
                        Path= "Dosage.maxDosePerPeriod",                                                                                    // MakerGen.cs:236
                        Id = "Dosage.maxDosePerPeriod",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Ratio                                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. Dosage.maxDosePerAdministration
                    this.MaxDosePerAdministration = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MaxDosePerAdministration",                                                                                  // MakerGen.cs:235
                        Path= "Dosage.maxDosePerAdministration",                                                                            // MakerGen.cs:236
                        Id = "Dosage.maxDosePerAdministration",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. Dosage.maxDosePerLifetime
                    this.MaxDosePerLifetime = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MaxDosePerLifetime",                                                                                        // MakerGen.cs:235
                        Path= "Dosage.maxDosePerLifetime",                                                                                  // MakerGen.cs:236
                        Id = "Dosage.maxDosePerLifetime",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
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
                Sequence.Write(sDef);                                                                                                       // MakerGen.cs:220
                Text.Write(sDef);                                                                                                           // MakerGen.cs:220
                AdditionalInstruction.Write(sDef);                                                                                          // MakerGen.cs:220
                PatientInstruction.Write(sDef);                                                                                             // MakerGen.cs:220
                Timing.Write(sDef);                                                                                                         // MakerGen.cs:220
                AsNeeded.Write(sDef);                                                                                                       // MakerGen.cs:220
                Site.Write(sDef);                                                                                                           // MakerGen.cs:220
                Route.Write(sDef);                                                                                                          // MakerGen.cs:220
                Method.Write(sDef);                                                                                                         // MakerGen.cs:220
                DoseAndRate.Write(sDef);                                                                                                    // MakerGen.cs:220
                MaxDosePerPeriod.Write(sDef);                                                                                               // MakerGen.cs:220
                MaxDosePerAdministration.Write(sDef);                                                                                       // MakerGen.cs:220
                MaxDosePerLifetime.Write(sDef);                                                                                             // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Dosage_Elements Elements                                                                                                     // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Dosage_Elements();                                                                                  // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Dosage_Elements elements;                                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Dosage()                                                                                                                     // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Dosage",                                                                                                            // MakerGen.cs:428
                ElementId = "Dosage"                                                                                                        // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
