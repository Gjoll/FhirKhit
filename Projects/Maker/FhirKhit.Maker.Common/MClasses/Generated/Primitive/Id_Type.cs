using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:160
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:161
{                                                                                                                                           // MakerGen.cs:162
    /// <summary>
    /// Fhir primitive 'id'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "id",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/id",
    ///   "version": "4.0.0",
    ///   "name": "id",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for id type: Any combination of letters, numerals, \"-\" and \".\", with a length limit of 64 characters.  (This might be an integer, an unprefixed OID, UUID or any other identifier pattern that meets these constraints.)  Ids are case-insensitive.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "id",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/string",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "id",
    ///         "path": "id",
    ///         "short": "Primitive Type id",
    ///         "definition": "Any combination of letters, numerals, \"-\" and \".\", with a length limit of 64 characters.  (This might be an integer, an unprefixed OID, UUID or any other identifier pattern that meets these constraints.)  Ids are case-insensitive.",
    ///         "comment": "RFC 4122",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "id.value",
    ///         "path": "id.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for id",
    ///         "definition": "Primitive value for id",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "[A-Za-z0-9\\-\\.]{1,64}"
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
    ///                   "valueString": "xsd:string"
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
    public class Id_Type : MakerPrimitive_Type                                                                                              // MakerGen.cs:167
    {                                                                                                                                       // MakerGen.cs:168
    }                                                                                                                                       // MakerGen.cs:169
}                                                                                                                                           // MakerGen.cs:170
