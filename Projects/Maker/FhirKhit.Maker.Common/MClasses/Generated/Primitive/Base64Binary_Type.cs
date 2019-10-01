using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:160
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:161
{                                                                                                                                           // MakerGen.cs:162
    /// <summary>
    /// Fhir primitive 'base64Binary'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "base64Binary",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/base64Binary",
    ///   "version": "4.0.0",
    ///   "name": "base64Binary",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for base64Binary Type: A stream of bytes",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "base64Binary",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "base64Binary",
    ///         "path": "base64Binary",
    ///         "short": "Primitive Type base64Binary",
    ///         "definition": "A stream of bytes",
    ///         "comment": "A stream of bytes, base64 encoded",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "base64Binary.value",
    ///         "path": "base64Binary.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for base64Binary",
    ///         "definition": "Primitive value for base64Binary",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "(\\s*([0-9a-zA-Z\\+/=]){4}\\s*)+"
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
    ///                   "valueString": "xsd:base64Binary"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "xsd:base64Binary"
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
    public class Base64Binary_Type : MakerPrimitive_Type                                                                                    // MakerGen.cs:167
    {                                                                                                                                       // MakerGen.cs:168
    }                                                                                                                                       // MakerGen.cs:169
}                                                                                                                                           // MakerGen.cs:170
