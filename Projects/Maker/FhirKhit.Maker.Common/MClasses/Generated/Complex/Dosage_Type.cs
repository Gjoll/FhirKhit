using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'Dosage'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Dosage",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Dosage",
    ///   "version": "4.0.0",
    ///   "name": "Dosage",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Dosage Type: Indicates how the medication is/was taken or should be taken by the patient.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Dosage",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Dosage",
    ///         "path": "Dosage",
    ///         "short": "How the medication is/was taken or should be taken",
    ///         "definition": "Indicates how the medication is/was taken or should be taken by the patient.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Dosage.sequence",
    ///         "path": "Dosage.sequence",
    ///         "short": "The order of the dosage instructions",
    ///         "definition": "Indicates the order in which the dosage instructions should be applied or interpreted.",
    ///         "requirements": "If the sequence number of multiple Dosages is the same, then it is implied that the instructions are to be treated as concurrent.  If the sequence number is different, then the Dosages are intended to be sequential.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "integer"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.text",
    ///         "path": "Dosage.text",
    ///         "short": "Free text dosage instructions e.g. SIG",
    ///         "definition": "Free text dosage instructions e.g. SIG.",
    ///         "requirements": "Free text dosage instructions can be used for cases where the instructions are too complex to code.  The content of this attribute does not include the name or description of the medication. When coded instructions are present, the free text instructions may still be present for display to humans taking or administering the medication. It is expected that the text instructions will always be populated.  If the dosage.timing attribute is also populated, then the dosage.text should reflect the same information as the timing.  Additional information about administration or preparation of the medication should be included as text.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.additionalInstruction",
    ///         "path": "Dosage.additionalInstruction",
    ///         "short": "Supplemental instruction or warnings to the patient - e.g. \"with meals\", \"may cause drowsiness\"",
    ///         "definition": "Supplemental instructions to the patient on how to take the medication  (e.g. \"with meals\" or\"take half to one hour before food\") or warnings for the patient about the medication (e.g. \"may cause drowsiness\" or \"avoid exposure of skin to direct sunlight or sunlamps\").",
    ///         "comment": "Information about administration or preparation of the medication (e.g. \"infuse as rapidly as possibly via intraperitoneal port\" or \"immediately following drug x\") should be populated in dosage.text.",
    ///         "requirements": "Additional instruction is intended to be coded, but where no code exists, the element could include text.  For example, \"Swallow with plenty of water\" which might or might not be coded.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "AdditionalInstruction"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A coded concept identifying additional instructions such as \"take with water\" or \"avoid operating heavy machinery\".",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/additional-instruction-codes"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.patientInstruction",
    ///         "path": "Dosage.patientInstruction",
    ///         "short": "Patient or consumer oriented instructions",
    ///         "definition": "Instructions in terms that are understood by the patient or consumer.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.timing",
    ///         "path": "Dosage.timing",
    ///         "short": "When medication should be administered",
    ///         "definition": "When medication should be administered.",
    ///         "comment": "This attribute might not always be populated while the Dosage.text is expected to be populated.  If both are populated, then the Dosage.text should reflect the content of the Dosage.timing.",
    ///         "requirements": "The timing schedule for giving the medication to the patient. This  data type allows many different expressions. For example: \"Every 8 hours\"; \"Three times a day\"; \"1/2 an hour before breakfast for 10 days from 23-Dec 2011:\"; \"15 Oct 2013, 17 Oct 2013 and 1 Nov 2013\".  Sometimes, a rate can imply duration when expressed as total volume / duration (e.g.  500mL/2 hours implies a duration of 2 hours).  However, when rate doesn't imply duration (e.g. 250mL/hour), then the timing.repeat.duration is needed to convey the infuse over time period.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Timing"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.asNeeded[x]",
    ///         "path": "Dosage.asNeeded[x]",
    ///         "short": "Take \"as needed\" (for x)",
    ///         "definition": "Indicates whether the Medication is only taken when needed within a specific dosing schedule (Boolean option), or it indicates the precondition for taking the Medication (CodeableConcept).",
    ///         "comment": "Can express \"as needed\" without a reason by setting the Boolean = True.  In this case the CodeableConcept is not populated.  Or you can express \"as needed\" with a reason by including the CodeableConcept.  In this case the Boolean is assumed to be True.  If you set the Boolean to False, then the dose is given according to the schedule and is not \"prn\" or \"as needed\".",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "boolean"
    ///           },
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "MedicationAsNeededReason"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A coded concept identifying the precondition that should be met or evaluated prior to consuming or administering a medication dose.  For example \"pain\", \"30 minutes prior to sexual intercourse\", \"on flare-up\" etc.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/medication-as-needed-reason"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.site",
    ///         "path": "Dosage.site",
    ///         "short": "Body site to administer to",
    ///         "definition": "Body site to administer to.",
    ///         "comment": "If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.",
    ///         "requirements": "A coded specification of the anatomic site where the medication first enters the body.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "MedicationAdministrationSite"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A coded concept describing the site location the medicine enters into or onto the body.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/approach-site-codes"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.route",
    ///         "path": "Dosage.route",
    ///         "short": "How drug should enter body",
    ///         "definition": "How drug should enter body.",
    ///         "requirements": "A code specifying the route or physiological path of administration of a therapeutic agent into or onto a patient's body.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "RouteOfAdministration"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A coded concept describing the route or physiological path of administration of a therapeutic agent into or onto the body of a subject.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/route-codes"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.method",
    ///         "path": "Dosage.method",
    ///         "short": "Technique for administering medication",
    ///         "definition": "Technique for administering medication.",
    ///         "comment": "Terminologies used often pre-coordinate this term with the route and or form of administration.",
    ///         "requirements": "A coded value indicating the method by which the medication is introduced into or onto the body. Most commonly used for injections.  For examples, Slow Push; Deep IV.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "MedicationAdministrationMethod"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A coded concept describing the technique by which the medicine is administered.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/administration-method-codes"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.doseAndRate",
    ///         "path": "Dosage.doseAndRate",
    ///         "short": "Amount of medication administered",
    ///         "definition": "The amount of medication administered.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Element"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.doseAndRate.type",
    ///         "path": "Dosage.doseAndRate.type",
    ///         "short": "The kind of dose or rate specified",
    ///         "definition": "The kind of dose or rate specified, for example, ordered or calculated.",
    ///         "requirements": "If the type is not populated, assume to be \"ordered\".",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "DoseAndRateType"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "The kind of dose or rate specified.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/dose-rate-type"
    ///         }
    ///       },
    ///       {
    ///         "id": "Dosage.doseAndRate.dose[x]",
    ///         "path": "Dosage.doseAndRate.dose[x]",
    ///         "short": "Amount of medication per dose",
    ///         "definition": "Amount of medication per dose.",
    ///         "comment": "Note that this specifies the quantity of the specified medication, not the quantity for each active ingredient(s). Each ingredient amount can be communicated in the Medication resource. For example, if one wants to communicate that a tablet was 375 mg, where the dose was one tablet, you can use the Medication resource to document that the tablet was comprised of 375 mg of drug XYZ. Alternatively if the dose was 375 mg, then you may only need to use the Medication resource to indicate this was a tablet. If the example were an IV such as dopamine and you wanted to communicate that 400mg of dopamine was mixed in 500 ml of some IV solution, then this would all be communicated in the Medication resource. If the administration is not intended to be instantaneous (rate is present or timing has a duration), this can be specified to convey the total amount to be administered over the period of time as indicated by the schedule e.g. 500 ml in dose, with timing used to convey that this should be done over 4 hours.",
    ///         "requirements": "The amount of therapeutic or other substance given at one administration event.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Range"
    ///           },
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.doseAndRate.rate[x]",
    ///         "path": "Dosage.doseAndRate.rate[x]",
    ///         "short": "Amount of medication per unit of time",
    ///         "definition": "Amount of medication per unit of time.",
    ///         "comment": "It is possible to supply both a rate and a doseQuantity to provide full details about how the medication is to be administered and supplied. If the rate is intended to change over time, depending on local rules/regulations, each change should be captured as a new version of the MedicationRequest with an updated rate, or captured with a new MedicationRequest with the new rate.\r\rIt is possible to specify a rate over time (for example, 100 ml/hour) using either the rateRatio and rateQuantity.  The rateQuantity approach requires systems to have the capability to parse UCUM grammer where ml/hour is included rather than a specific ratio where the time is specified as the denominator.  Where a rate such as 500ml over 2 hours is specified, the use of rateRatio may be more semantically correct than specifying using a rateQuantity of 250 mg/hour.",
    ///         "requirements": "Identifies the speed with which the medication was or will be introduced into the patient. Typically the rate for an infusion e.g. 100 ml per 1 hour or 100 ml/hr.  May also be expressed as a rate per unit of time e.g. 500 ml per 2 hours.   Other examples: 200 mcg/min or 200 mcg/1 minute; 1 liter/8 hours.  Sometimes, a rate can imply duration when expressed as total volume / duration (e.g.  500mL/2 hours implies a duration of 2 hours).  However, when rate doesn't imply duration (e.g. 250mL/hour), then the timing.repeat.duration is needed to convey the infuse over time period.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Ratio"
    ///           },
    ///           {
    ///             "code": "Range"
    ///           },
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.maxDosePerPeriod",
    ///         "path": "Dosage.maxDosePerPeriod",
    ///         "short": "Upper limit on medication per unit of time",
    ///         "definition": "Upper limit on medication per unit of time.",
    ///         "comment": "This is intended for use as an adjunct to the dosage when there is an upper cap.  For example \"2 tablets every 4 hours to a maximum of 8/day\".",
    ///         "requirements": "The maximum total quantity of a therapeutic substance that may be administered to a subject over the period of time.  For example, 1000mg in 24 hours.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Ratio"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.maxDosePerAdministration",
    ///         "path": "Dosage.maxDosePerAdministration",
    ///         "short": "Upper limit on medication per administration",
    ///         "definition": "Upper limit on medication per administration.",
    ///         "comment": "This is intended for use as an adjunct to the dosage when there is an upper cap.  For example, a body surface area related dose with a maximum amount, such as 1.5 mg/m2 (maximum 2 mg) IV over 5 – 10 minutes would have doseQuantity of 1.5 mg/m2 and maxDosePerAdministration of 2 mg.",
    ///         "requirements": "The maximum total quantity of a therapeutic substance that may be administered to a subject per administration.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Dosage.maxDosePerLifetime",
    ///         "path": "Dosage.maxDosePerLifetime",
    ///         "short": "Upper limit on medication per lifetime of the patient",
    ///         "definition": "Upper limit on medication per lifetime of the patient.",
    ///         "requirements": "The maximum total quantity of a therapeutic substance that may be administered per lifetime of the subject.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Dosage
    public class Dosage_Type : Complex_Type                                                                                                 // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 11. Dosage.doseAndRate.type
        public class Type_Type : Complex_Type                                                                                               // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Type_Type()                                                                                                              // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 12. Dosage.doseAndRate.dose[x]
        public class DoseX_Type : Complex_Type                                                                                              // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public DoseX_Type()                                                                                                             // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 13. Dosage.doseAndRate.rate[x]
        public class RateX_Type : Complex_Type                                                                                              // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public RateX_Type()                                                                                                             // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 1. Dosage.sequence
        public ElementInstance Sequence;                                                                                                    // MakerGen.cs:203
        // 2. Dosage.text
        public ElementInstance Text;                                                                                                        // MakerGen.cs:203
        // 3. Dosage.additionalInstruction
        public ElementInstance AdditionalInstruction;                                                                                       // MakerGen.cs:203
        // 4. Dosage.patientInstruction
        public ElementInstance PatientInstruction;                                                                                          // MakerGen.cs:203
        // 5. Dosage.timing
        public ElementInstance Timing;                                                                                                      // MakerGen.cs:203
        // 6. Dosage.asNeeded[x]
        public ElementInstance AsNeededX;                                                                                                   // MakerGen.cs:203
        // 7. Dosage.site
        public ElementInstance Site;                                                                                                        // MakerGen.cs:203
        // 8. Dosage.route
        public ElementInstance Route;                                                                                                       // MakerGen.cs:203
        // 9. Dosage.method
        public ElementInstance Method;                                                                                                      // MakerGen.cs:203
        // 10. Dosage.doseAndRate
        public ElementInstance DoseAndRate;                                                                                                 // MakerGen.cs:203
        // 14. Dosage.maxDosePerPeriod
        public ElementInstance MaxDosePerPeriod;                                                                                            // MakerGen.cs:203
        // 15. Dosage.maxDosePerAdministration
        public ElementInstance MaxDosePerAdministration;                                                                                    // MakerGen.cs:203
        // 16. Dosage.maxDosePerLifetime
        public ElementInstance MaxDosePerLifetime;                                                                                          // MakerGen.cs:203
        public Dosage_Type()                                                                                                                // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275