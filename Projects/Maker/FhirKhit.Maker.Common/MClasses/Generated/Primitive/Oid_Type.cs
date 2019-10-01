using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:151
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:152
{                                                                                                                                           // MakerGen.cs:153
    /// <summary>
    /// Fhir primitive 'oid'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "oid",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/oid",
    ///   "version": "4.0.0",
    ///   "name": "oid",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for oid type: An OID represented as a URI",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "oid",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/uri",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "oid",
    ///         "path": "oid",
    ///         "short": "Primitive Type oid",
    ///         "definition": "An OID represented as a URI",
    ///         "comment": "RFC 3001. See also ISO/IEC 8824:1990 €",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "oid.value",
    ///         "path": "oid.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for oid",
    ///         "definition": "Primitive value for oid",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "urn:oid:[0-2](\\.(0|[1-9][0-9]*))+"
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
    public class Oid_Type : Primitive_Type                                                                                                  // MakerGen.cs:158
    {                                                                                                                                       // MakerGen.cs:159
    }                                                                                                                                       // MakerGen.cs:160
}                                                                                                                                           // MakerGen.cs:161
