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
      "id": "Period",
      "url": "http://hl7.org/fhir/StructureDefinition/Period",
      "version": "4.0.0",
      "name": "Period",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Period Type: A time period defined by a start and end date and optionally time.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Period",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Period",
            "path": "Period",
            "short": "Time range defined by start and end date/time",
            "definition": "A time period defined by a start and end date and optionally time.",
            "comment": "A Period specifies a range of time; the context of use will specify whether the entire range applies (e.g. \"the patient was an inpatient of the hospital for this time range\") or one value from the range applies (e.g. \"give to the patient between these two times\").\n\nPeriod is not used for a duration (a measure of elapsed time). See [Duration](datatypes.html#Duration).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Period.start",
            "path": "Period.start",
            "short": "Starting time with inclusive boundary",
            "definition": "The start of the period. The boundary is inclusive.",
            "comment": "If the low element is missing, the meaning is that the low boundary is not known.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "condition": [
              "per-1"
            ],
            "isSummary": true
          },
          {
            "id": "Period.end",
            "path": "Period.end",
            "short": "End time with inclusive boundary, if not ongoing",
            "definition": "The end of the period. If the end of the period is missing, it means no end was known or planned at the time the instance was created. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time.",
            "comment": "The high value includes any matching date/time. i.e. 2012-02-03T10:00:00 is in a period that has an end value of 2012-02-03.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "meaningWhenMissing": "If the end of the period is missing, it means that the period is ongoing",
            "condition": [
              "per-1"
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'Period'
    /// </summary>
    // 0. Period
    public class Period : FhirKhit.Maker.Common.Complex.ComplexBase                                                                         // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Period_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                          // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. Period.start
            public ElementDefinitionInfo Start;                                                                                             // MakerGen.cs:216
            // 2. Period.end
            public ElementDefinitionInfo End;                                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public Period_Elements()                                                                                                        // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Period.start
                    this.Start = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Start",                                                                                                     // MakerGen.cs:235
                        Path= "Period.start",                                                                                               // MakerGen.cs:236
                        Id = "Period.start",                                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Period.end
                    this.End = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "End",                                                                                                       // MakerGen.cs:235
                        Path= "Period.end",                                                                                                 // MakerGen.cs:236
                        Id = "Period.end",                                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Start.Write(sDef);                                                                                                          // MakerGen.cs:220
                End.Write(sDef);                                                                                                            // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Period_Elements Elements                                                                                                     // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Period_Elements();                                                                                  // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Period_Elements elements;                                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Period()                                                                                                                     // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Period",                                                                                                            // MakerGen.cs:428
                ElementId = "Period"                                                                                                        // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
