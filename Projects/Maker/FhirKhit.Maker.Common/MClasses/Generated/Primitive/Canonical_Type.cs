using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:151
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:152
{                                                                                                                                           // MakerGen.cs:153
    /// <summary>
    /// Fhir primitive 'canonical'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "canonical",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/canonical",
    ///   "version": "4.0.0",
    ///   "name": "canonical",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for canonical type: A URI that is a reference to a canonical URL on a FHIR resource",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "canonical",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/uri",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "canonical",
    ///         "path": "canonical",
    ///         "short": "Primitive Type canonical",
    ///         "definition": "A URI that is a reference to a canonical URL on a FHIR resource",
    ///         "comment": "see [Canonical References](references.html#canonical)",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "canonical.value",
    ///         "path": "canonical.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for canonical",
    ///         "definition": "Primitive value for canonical",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "\\S*"
    ///               }
    ///             ],
    ///             "_code": {
    ///               "extension": [
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
    ///                   "valueString": "string"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
    ///                   "valueString": "xsd:anyURI"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "xsd:string"
    ///                 }
    ///               ]
    ///             }
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Canonical_Type : Primitive_Type                                                                                            // MakerGen.cs:158
    {                                                                                                                                       // MakerGen.cs:159
    }                                                                                                                                       // MakerGen.cs:160
}                                                                                                                                           // MakerGen.cs:161