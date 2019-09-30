using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Annotation'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Annotation",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Annotation",
    ///   "version": "4.0.0",
    ///   "name": "Annotation",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Annotation Type: A  text note which also  contains information about who made the statement and when.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Annotation",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Annotation",
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
    ///         "path": "Annotation",
    ///         "short": "Text node with attribution",
    ///         "definition": "A  text note which also  contains information about who made the statement and when.",
    ///         "comment": "For systems that do not have structured annotations, they can simply communicate a single annotation with no author or time.  This element may need to be included in narrative because of the potential for modifying information.  *Annotations SHOULD NOT* be used to communicate \"modifying\" information that could be computable. (This is a SHOULD because enforcing user behavior is nearly impossible).",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Annotation.author[x]",
    ///         "path": "Annotation.author[x]",
    ///         "short": "Individual responsible for the annotation",
    ///         "definition": "The individual responsible for making the annotation.",
    ///         "comment": "Organization is used when there's no need for specific attribution as to who made the comment.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Practitioner",
    ///               "http://hl7.org/fhir/StructureDefinition/Patient",
    ///               "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
    ///               "http://hl7.org/fhir/StructureDefinition/Organization"
    ///             ]
    ///           },
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Annotation.time",
    ///         "path": "Annotation.time",
    ///         "short": "When the annotation was made",
    ///         "definition": "Indicates when this particular annotation was made.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Annotation.text",
    ///         "path": "Annotation.text",
    ///         "short": "The annotation  - text content (as markdown)",
    ///         "definition": "The text of the annotation in markdown format.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "markdown"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Annotation_Type : Complex_Type
    {
    }
}
