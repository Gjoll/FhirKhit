using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
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
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "normative"
    ///           },
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-normative-version",
    ///             "valueCode": "4.0.0"
    ///           }
    ///         ],
    ///         "path": "Period",
    ///         "short": "Time range defined by start and end date/time",
    ///         "definition": "A time period defined by a start and end date and optionally time.",
    ///         "comment": "A Period specifies a range of time; the context of use will specify whether the entire range applies (e.g. \"the patient was an inpatient of the hospital for this time range\") or one value from the range applies (e.g. \"give to the patient between these two times\").\n\nPeriod is not used for a duration (a measure of elapsed time). See [Duration](datatypes.html#Duration).",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "per-1",
    ///             "severity": "error",
    ///             "human": "If present, start SHALL have a lower value than end",
    ///             "expression": "start.hasValue().not() or end.hasValue().not() or (start <= end)",
    ///             "xpath": "not(exists(f:start/@value)) or not(exists(f:end/@value)) or (xs:dateTime(f:start/@value) <= xs:dateTime(f:end/@value))"
    ///           }
    ///         ]
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
    public class Period_Item : Complex_Item
    {
    }
}
