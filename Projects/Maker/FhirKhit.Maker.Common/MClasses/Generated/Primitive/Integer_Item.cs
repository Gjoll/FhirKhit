using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'integer'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "integer",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/integer",
    ///   "version": "4.0.0",
    ///   "name": "integer",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for integer Type: A whole number",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "integer",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "integer",
    ///         "path": "integer",
    ///         "short": "Primitive Type integer",
    ///         "definition": "A whole number",
    ///         "comment": "32 bit number; for values larger than this, use decimal",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "integer.value",
    ///         "path": "integer.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for integer",
    ///         "definition": "Primitive value for integer",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "-?([0]|([1-9][0-9]*))"
    ///               }
    ///             ],
    ///             "_code": {
    ///               "extension": [
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
    ///                   "valueString": "number"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
    ///                   "valueString": "xsd:int"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "xsd:int"
    ///                 }
    ///               ]
    ///             }
    ///           }
    ///         ],
    ///         "minValueInteger": -2147483648,
    ///         "maxValueInteger": 2147483647
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Integer_Item : Primitive_Item
    {
    }
}
