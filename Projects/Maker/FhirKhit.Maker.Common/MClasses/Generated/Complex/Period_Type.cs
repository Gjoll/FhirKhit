using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
    /// <summary>
    /// Fhir primitive 'Period'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Period",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Period",
    ///   "version": "4.0.0",
    ///   "name": "Period",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Period Type: A time period defined by a start and end date and optionally time.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Period",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Period",
    ///         "path": "Period",
    ///         "short": "Time range defined by start and end date/time",
    ///         "definition": "A time period defined by a start and end date and optionally time.",
    ///         "comment": "A Period specifies a range of time; the context of use will specify whether the entire range applies (e.g. \"the patient was an inpatient of the hospital for this time range\") or one value from the range applies (e.g. \"give to the patient between these two times\").\n\nPeriod is not used for a duration (a measure of elapsed time). See [Duration](datatypes.html#Duration).",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Period.start",
    ///         "path": "Period.start",
    ///         "short": "Starting time with inclusive boundary",
    ///         "definition": "The start of the period. The boundary is inclusive.",
    ///         "comment": "If the low element is missing, the meaning is that the low boundary is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "condition": [
    ///           "per-1"
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Period.end",
    ///         "path": "Period.end",
    ///         "short": "End time with inclusive boundary, if not ongoing",
    ///         "definition": "The end of the period. If the end of the period is missing, it means no end was known or planned at the time the instance was created. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time.",
    ///         "comment": "The high value includes any matching date/time. i.e. 2012-02-03T10:00:00 is in a period that has an end value of 2012-02-03.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "meaningWhenMissing": "If the end of the period is missing, it means that the period is ongoing",
    ///         "condition": [
    ///           "per-1"
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Period
    public class Period_Type : Complex_Type                                                                                                 // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Period.start
        public ElementInstance Start;                                                                                                       // MakerGen.cs:208
        // 2. Period.end
        public ElementInstance End;                                                                                                         // MakerGen.cs:208
        public Period_Type()                                                                                                                // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
