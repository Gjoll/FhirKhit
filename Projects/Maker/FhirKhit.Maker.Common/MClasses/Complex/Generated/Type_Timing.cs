using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'Timing'
    /// </summary>
    // 0. Timing
    public class Type_Timing : FhirKhit.Maker.Common.Complex.ComplexBase                                                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Timing_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                     // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 2. Timing.repeat
            public class Type_Repeat : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Repeat_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 3. Timing.repeat.bounds[x]
                    public ElementDefinitionInfo Element_Bounds;                                                                            // MakerGen.cs:211
                    // 4. Timing.repeat.count
                    public ElementDefinitionInfo Element_Count;                                                                             // MakerGen.cs:211
                    // 5. Timing.repeat.countMax
                    public ElementDefinitionInfo Element_CountMax;                                                                          // MakerGen.cs:211
                    // 6. Timing.repeat.duration
                    public ElementDefinitionInfo Element_Duration;                                                                          // MakerGen.cs:211
                    // 7. Timing.repeat.durationMax
                    public ElementDefinitionInfo Element_DurationMax;                                                                       // MakerGen.cs:211
                    // 8. Timing.repeat.durationUnit
                    public ElementDefinitionInfo Element_DurationUnit;                                                                      // MakerGen.cs:211
                    // 9. Timing.repeat.frequency
                    public ElementDefinitionInfo Element_Frequency;                                                                         // MakerGen.cs:211
                    // 10. Timing.repeat.frequencyMax
                    public ElementDefinitionInfo Element_FrequencyMax;                                                                      // MakerGen.cs:211
                    // 11. Timing.repeat.period
                    public ElementDefinitionInfo Element_Period;                                                                            // MakerGen.cs:211
                    // 12. Timing.repeat.periodMax
                    public ElementDefinitionInfo Element_PeriodMax;                                                                         // MakerGen.cs:211
                    // 13. Timing.repeat.periodUnit
                    public ElementDefinitionInfo Element_PeriodUnit;                                                                        // MakerGen.cs:211
                    // 14. Timing.repeat.dayOfWeek
                    public ElementDefinitionInfo Element_DayOfWeek;                                                                         // MakerGen.cs:211
                    // 15. Timing.repeat.timeOfDay
                    public ElementDefinitionInfo Element_TimeOfDay;                                                                         // MakerGen.cs:211
                    // 16. Timing.repeat.when
                    public ElementDefinitionInfo Element_When;                                                                              // MakerGen.cs:211
                    // 17. Timing.repeat.offset
                    public ElementDefinitionInfo Element_Offset;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Repeat_Elements()                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 3. Timing.repeat.bounds[x]
                            this.Element_Bounds = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Bounds",                                                                                    // MakerGen.cs:230
                                Path= "Timing.repeat.bounds[x]",                                                                            // MakerGen.cs:231
                                Id = "Timing.repeat.bounds[x]",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Duration                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    },                                                                                                      // MakerGen.cs:352
                                    new FhirKhit.Maker.Common.Complex.Type_Range                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    },                                                                                                      // MakerGen.cs:352
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 4. Timing.repeat.count
                            this.Element_Count = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Count",                                                                                     // MakerGen.cs:230
                                Path= "Timing.repeat.count",                                                                                // MakerGen.cs:231
                                Id = "Timing.repeat.count",                                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 5. Timing.repeat.countMax
                            this.Element_CountMax = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_CountMax",                                                                                  // MakerGen.cs:230
                                Path= "Timing.repeat.countMax",                                                                             // MakerGen.cs:231
                                Id = "Timing.repeat.countMax",                                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. Timing.repeat.duration
                            this.Element_Duration = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Duration",                                                                                  // MakerGen.cs:230
                                Path= "Timing.repeat.duration",                                                                             // MakerGen.cs:231
                                Id = "Timing.repeat.duration",                                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. Timing.repeat.durationMax
                            this.Element_DurationMax = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DurationMax",                                                                               // MakerGen.cs:230
                                Path= "Timing.repeat.durationMax",                                                                          // MakerGen.cs:231
                                Id = "Timing.repeat.durationMax",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. Timing.repeat.durationUnit
                            this.Element_DurationUnit = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DurationUnit",                                                                              // MakerGen.cs:230
                                Path= "Timing.repeat.durationUnit",                                                                         // MakerGen.cs:231
                                Id = "Timing.repeat.durationUnit",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. Timing.repeat.frequency
                            this.Element_Frequency = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Frequency",                                                                                 // MakerGen.cs:230
                                Path= "Timing.repeat.frequency",                                                                            // MakerGen.cs:231
                                Id = "Timing.repeat.frequency",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. Timing.repeat.frequencyMax
                            this.Element_FrequencyMax = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_FrequencyMax",                                                                              // MakerGen.cs:230
                                Path= "Timing.repeat.frequencyMax",                                                                         // MakerGen.cs:231
                                Id = "Timing.repeat.frequencyMax",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. Timing.repeat.period
                            this.Element_Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Period",                                                                                    // MakerGen.cs:230
                                Path= "Timing.repeat.period",                                                                               // MakerGen.cs:231
                                Id = "Timing.repeat.period",                                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Timing.repeat.periodMax
                            this.Element_PeriodMax = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_PeriodMax",                                                                                 // MakerGen.cs:230
                                Path= "Timing.repeat.periodMax",                                                                            // MakerGen.cs:231
                                Id = "Timing.repeat.periodMax",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. Timing.repeat.periodUnit
                            this.Element_PeriodUnit = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_PeriodUnit",                                                                                // MakerGen.cs:230
                                Path= "Timing.repeat.periodUnit",                                                                           // MakerGen.cs:231
                                Id = "Timing.repeat.periodUnit",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. Timing.repeat.dayOfWeek
                            this.Element_DayOfWeek = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DayOfWeek",                                                                                 // MakerGen.cs:230
                                Path= "Timing.repeat.dayOfWeek",                                                                            // MakerGen.cs:231
                                Id = "Timing.repeat.dayOfWeek",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. Timing.repeat.timeOfDay
                            this.Element_TimeOfDay = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_TimeOfDay",                                                                                 // MakerGen.cs:230
                                Path= "Timing.repeat.timeOfDay",                                                                            // MakerGen.cs:231
                                Id = "Timing.repeat.timeOfDay",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. Timing.repeat.when
                            this.Element_When = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_When",                                                                                      // MakerGen.cs:230
                                Path= "Timing.repeat.when",                                                                                 // MakerGen.cs:231
                                Id = "Timing.repeat.when",                                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. Timing.repeat.offset
                            this.Element_Offset = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Offset",                                                                                    // MakerGen.cs:230
                                Path= "Timing.repeat.offset",                                                                               // MakerGen.cs:231
                                Id = "Timing.repeat.offset",                                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Bounds.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Count.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_CountMax.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Duration.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_DurationMax.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_DurationUnit.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_Frequency.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_FrequencyMax.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_Period.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_PeriodMax.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_PeriodUnit.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_DayOfWeek.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_TimeOfDay.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_When.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Offset.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Repeat_Elements Elements                                                                                        // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Repeat_Elements();                                                                     // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Repeat_Elements elements;                                                                                              // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Repeat()                                                                                                        // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Timing.repeat",                                                                                             // MakerGen.cs:420
                        ElementId = "Timing.repeat"                                                                                         // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Timing.event
            public ElementDefinitionInfo Element_Event;                                                                                     // MakerGen.cs:211
            // 2. Timing.repeat
            public ElementDefinitionInfo Element_Repeat;                                                                                    // MakerGen.cs:211
            // 18. Timing.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Timing_Elements()                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Timing.event
                    this.Element_Event = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Event",                                                                                             // MakerGen.cs:230
                        Path= "Timing.event",                                                                                               // MakerGen.cs:231
                        Id = "Timing.event",                                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Timing.repeat
                    this.Element_Repeat = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Repeat",                                                                                            // MakerGen.cs:230
                        Path= "Timing.repeat",                                                                                              // MakerGen.cs:231
                        Id = "Timing.repeat",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Repeat                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. Timing.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "Timing.code",                                                                                                // MakerGen.cs:231
                        Id = "Timing.code",                                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Event.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Repeat.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Timing_Elements Elements                                                                                                // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Timing_Elements();                                                                             // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Timing_Elements elements;                                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Timing()                                                                                                                // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Timing",                                                                                                            // MakerGen.cs:420
                ElementId = "Timing"                                                                                                        // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
