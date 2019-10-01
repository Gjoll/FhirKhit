using System;                                                                                                                               // MakerGen.cs:439
using System.Diagnostics;                                                                                                                   // MakerGen.cs:440
using System.IO;                                                                                                                            // MakerGen.cs:441
using System.Linq;                                                                                                                          // MakerGen.cs:442
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:443
                                                                                                                                            // MakerGen.cs:444
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:445
{                                                                                                                                           // MakerGen.cs:446
    #region Json                                                                                                                            // MakerGen.cs:447
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Timing",
      "url": "http://hl7.org/fhir/StructureDefinition/Timing",
      "version": "4.0.0",
      "name": "Timing",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Timing Type: Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.",
      "purpose": "Need to able to track proposed timing schedules. There are several different ways to do this: one or more specified times, a simple rules like three times a day, or  before/after meals.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Timing",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Timing",
            "path": "Timing",
            "short": "A timing schedule that specifies an event that may occur multiple times",
            "definition": "Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.",
            "comment": "Describes the occurrence of an event that may occur multiple times. Timing schedules are used for specifying when events are expected or requested to occur, and may also be used to represent the summary of a past or ongoing event.  For simplicity, the definitions of Timing components are expressed as 'future' events, but such components can also be used to describe historic or ongoing events.\n\nA Timing schedule can be a list of events and/or criteria for when the event happens, which can be expressed in a structured form and/or as a code. When both event and a repeating specification are provided, the list of events should be understood as an interpretation of the information in the repeat structure.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Timing.event",
            "path": "Timing.event",
            "short": "When the event occurs",
            "definition": "Identifies specific times when the event occurs.",
            "requirements": "In a Medication Administration Record, for instance, you need to take a general specification, and turn it into a precise specification.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat",
            "path": "Timing.repeat",
            "short": "When the event is to occur",
            "definition": "A set of rules that describe when the event is scheduled.",
            "requirements": "Many timing schedules are determined by regular repetitions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.bounds[x]",
            "path": "Timing.repeat.bounds[x]",
            "short": "Length/Range of lengths, or (Start and/or end) limits",
            "definition": "Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              },
              {
                "code": "Range"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.count",
            "path": "Timing.repeat.count",
            "short": "Number of times to repeat",
            "definition": "A total count of the desired number of repetitions across the duration of the entire timing specification. If countMax is present, this element indicates the lower bound of the allowed range of count values.",
            "comment": "If you have both bounds and count, then this should be understood as within the bounds period, until count times happens.",
            "requirements": "Repetitions may be limited by end time or total occurrences.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.countMax",
            "path": "Timing.repeat.countMax",
            "short": "Maximum number of times to repeat",
            "definition": "If present, indicates that the count is a range - so to perform the action between [count] and [countMax] times.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.duration",
            "path": "Timing.repeat.duration",
            "short": "How long when it happens",
            "definition": "How long this thing happens for when it happens. If durationMax is present, this element indicates the lower bound of the allowed range of the duration.",
            "comment": "For some events the duration is part of the definition of the event (e.g. IV infusions, where the duration is implicit in the specified quantity and rate). For others, it's part of the timing specification (e.g. exercise).",
            "requirements": "Some activities are not instantaneous and need to be maintained for a period of time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.durationMax",
            "path": "Timing.repeat.durationMax",
            "short": "How long when it happens (Max)",
            "definition": "If present, indicates that the duration is a range - so to perform the action between [duration] and [durationMax] time length.",
            "comment": "For some events the duration is part of the definition of the event (e.g. IV infusions, where the duration is implicit in the specified quantity and rate). For others, it's part of the timing specification (e.g. exercise).",
            "requirements": "Some activities are not instantaneous and need to be maintained for a period of time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.durationUnit",
            "path": "Timing.repeat.durationUnit",
            "short": "s | min | h | d | wk | mo | a - unit of time (UCUM)",
            "definition": "The units of time for the duration, in UCUM units.",
            "min": 0,
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
                  "valueString": "UnitsOfTime"
                }
              ],
              "strength": "required",
              "description": "A unit of time (units from UCUM).",
              "valueSet": "http://hl7.org/fhir/ValueSet/units-of-time|4.0.0"
            }
          },
          {
            "id": "Timing.repeat.frequency",
            "path": "Timing.repeat.frequency",
            "short": "Event occurs frequency times per period",
            "definition": "The number of times to repeat the action within the specified period. If frequencyMax is present, this element indicates the lower bound of the allowed range of the frequency.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "meaningWhenMissing": "If no frequency is stated, the assumption is that the event occurs once per period, but systems SHOULD always be specific about this",
            "isSummary": true
          },
          {
            "id": "Timing.repeat.frequencyMax",
            "path": "Timing.repeat.frequencyMax",
            "short": "Event occurs up to frequencyMax times per period",
            "definition": "If present, indicates that the frequency is a range - so to repeat between [frequency] and [frequencyMax] times within the period or period range.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.period",
            "path": "Timing.repeat.period",
            "short": "Event occurs frequency times per period",
            "definition": "Indicates the duration of time over which repetitions are to occur; e.g. to express \"3 times per day\", 3 would be the frequency and \"1 day\" would be the period. If periodMax is present, this element indicates the lower bound of the allowed range of the period length.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.periodMax",
            "path": "Timing.repeat.periodMax",
            "short": "Upper limit of period (3-4 hours)",
            "definition": "If present, indicates that the period is a range from [period] to [periodMax], allowing expressing concepts such as \"do this once every 3-5 days.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.periodUnit",
            "path": "Timing.repeat.periodUnit",
            "short": "s | min | h | d | wk | mo | a - unit of time (UCUM)",
            "definition": "The units of time for the period in UCUM units.",
            "min": 0,
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
                  "valueString": "UnitsOfTime"
                }
              ],
              "strength": "required",
              "description": "A unit of time (units from UCUM).",
              "valueSet": "http://hl7.org/fhir/ValueSet/units-of-time|4.0.0"
            }
          },
          {
            "id": "Timing.repeat.dayOfWeek",
            "path": "Timing.repeat.dayOfWeek",
            "short": "mon | tue | wed | thu | fri | sat | sun",
            "definition": "If one or more days of week is provided, then the action happens only on the specified day(s).",
            "comment": "If no days are specified, the action is assumed to happen every day as otherwise specified. The elements frequency and period cannot be used as well as dayOfWeek.",
            "min": 0,
            "max": "*",
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
                  "valueString": "DayOfWeek"
                }
              ],
              "strength": "required",
              "valueSet": "http://hl7.org/fhir/ValueSet/days-of-week|4.0.0"
            }
          },
          {
            "id": "Timing.repeat.timeOfDay",
            "path": "Timing.repeat.timeOfDay",
            "short": "Time of day for action",
            "definition": "Specified time of day for action to take place.",
            "comment": "When time of day is specified, it is inferred that the action happens every day (as filtered by dayofWeek) on the specified times. The elements when, frequency and period cannot be used as well as timeOfDay.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "time"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.repeat.when",
            "path": "Timing.repeat.when",
            "short": "Code for time period of occurrence",
            "definition": "An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.",
            "comment": "When more than one event is listed, the event is tied to the union of the specified events.",
            "requirements": "Timings are frequently determined by occurrences such as waking, eating and sleep.",
            "min": 0,
            "max": "*",
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
                  "valueString": "EventTiming"
                }
              ],
              "strength": "required",
              "description": "Real world event relating to the schedule.",
              "valueSet": "http://hl7.org/fhir/ValueSet/event-timing|4.0.0"
            }
          },
          {
            "id": "Timing.repeat.offset",
            "path": "Timing.repeat.offset",
            "short": "Minutes from event (before or after)",
            "definition": "The number of minutes from the event. If the event code does not indicate whether the minutes is before or after the event, then the offset is assumed to be after the event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Timing.code",
            "path": "Timing.code",
            "short": "BID | TID | QID | AM | PM | QD | QOD | +",
            "definition": "A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous, but many institutions define their own additional codes. If a code is provided, the code is understood to be a complete statement of whatever is specified in the structured timing data, and either the code or the data may be used to interpret the Timing, with the exception that .repeat.bounds still applies over the code (and is not contained in the code).",
            "comment": "BID etc. are defined as 'at institutionally specified times'. For example, an institution may choose that BID is \"always at 7am and 6pm\".  If it is inappropriate for this choice to be made, the code BID should not be used. Instead, a distinct organization-specific code should be used in place of the HL7-defined BID code and/or a structured representation should be used (in this case, specifying the two event times).",
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
                  "valueString": "TimingAbbreviation"
                }
              ],
              "strength": "preferred",
              "description": "Code for a known / defined timing pattern.",
              "valueSet": "http://hl7.org/fhir/ValueSet/timing-abbreviation"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:451
    /// <summary>
    /// Fhir complex 'Timing'
    /// </summary>
    // 0. Timing
    public class Timing : FhirKhit.Maker.Common.Complex.ComplexBase                                                                         // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 2. Timing.repeat
        public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 3. Timing.repeat.bounds[x]
            public MakerElementInstance Element_Bounds;                                                                                     // MakerGen.cs:232
            // 4. Timing.repeat.count
            public MakerElementInstance Element_Count;                                                                                      // MakerGen.cs:232
            // 5. Timing.repeat.countMax
            public MakerElementInstance Element_CountMax;                                                                                   // MakerGen.cs:232
            // 6. Timing.repeat.duration
            public MakerElementInstance Element_Duration;                                                                                   // MakerGen.cs:232
            // 7. Timing.repeat.durationMax
            public MakerElementInstance Element_DurationMax;                                                                                // MakerGen.cs:232
            // 8. Timing.repeat.durationUnit
            public MakerElementInstance Element_DurationUnit;                                                                               // MakerGen.cs:232
            // 9. Timing.repeat.frequency
            public MakerElementInstance Element_Frequency;                                                                                  // MakerGen.cs:232
            // 10. Timing.repeat.frequencyMax
            public MakerElementInstance Element_FrequencyMax;                                                                               // MakerGen.cs:232
            // 11. Timing.repeat.period
            public MakerElementInstance Element_Period;                                                                                     // MakerGen.cs:232
            // 12. Timing.repeat.periodMax
            public MakerElementInstance Element_PeriodMax;                                                                                  // MakerGen.cs:232
            // 13. Timing.repeat.periodUnit
            public MakerElementInstance Element_PeriodUnit;                                                                                 // MakerGen.cs:232
            // 14. Timing.repeat.dayOfWeek
            public MakerElementInstance Element_DayOfWeek;                                                                                  // MakerGen.cs:232
            // 15. Timing.repeat.timeOfDay
            public MakerElementInstance Element_TimeOfDay;                                                                                  // MakerGen.cs:232
            // 16. Timing.repeat.when
            public MakerElementInstance Element_When;                                                                                       // MakerGen.cs:232
            // 17. Timing.repeat.offset
            public MakerElementInstance Element_Offset;                                                                                     // MakerGen.cs:232
            public Type_Repeat()                                                                                                            // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 3. Timing.repeat.bounds[x]
                    this.Element_Bounds = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Bounds",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 4. Timing.repeat.count
                    this.Element_Count = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Count",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 5. Timing.repeat.countMax
                    this.Element_CountMax = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CountMax",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 6. Timing.repeat.duration
                    this.Element_Duration = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 7. Timing.repeat.durationMax
                    this.Element_DurationMax = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DurationMax",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 8. Timing.repeat.durationUnit
                    this.Element_DurationUnit = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DurationUnit",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 9. Timing.repeat.frequency
                    this.Element_Frequency = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Frequency",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 10. Timing.repeat.frequencyMax
                    this.Element_FrequencyMax = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_FrequencyMax",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 11. Timing.repeat.period
                    this.Element_Period = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Period",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 12. Timing.repeat.periodMax
                    this.Element_PeriodMax = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PeriodMax",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 13. Timing.repeat.periodUnit
                    this.Element_PeriodUnit = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PeriodUnit",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 14. Timing.repeat.dayOfWeek
                    this.Element_DayOfWeek = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DayOfWeek",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 15. Timing.repeat.timeOfDay
                    this.Element_TimeOfDay = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TimeOfDay",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Time()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 16. Timing.repeat.when
                    this.Element_When = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_When",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. Timing.repeat.offset
                    this.Element_Offset = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Offset",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. Timing.event
        public MakerElementInstance Element_Event;                                                                                          // MakerGen.cs:232
        // 18. Timing.code
        public MakerElementInstance Element_Code;                                                                                           // MakerGen.cs:232
        public Timing()                                                                                                                     // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Timing.event
                this.Element_Event = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Event",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. Timing.code
                this.Element_Code = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:456
