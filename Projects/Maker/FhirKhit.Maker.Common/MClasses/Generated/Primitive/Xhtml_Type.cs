using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:160
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:161
{                                                                                                                                           // MakerGen.cs:162
    /// <summary>
    /// Fhir primitive 'xhtml'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "xhtml",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/xhtml",
    ///   "version": "4.0.0",
    ///   "name": "xhtml",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for xhtml Type",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "xhtml",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "xhtml",
    ///         "path": "xhtml",
    ///         "short": "Primitive Type xhtml",
    ///         "definition": "XHTML",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "xhtml.extension",
    ///         "path": "xhtml.extension",
    ///         "max": "0"
    ///       },
    ///       {
    ///         "id": "xhtml.value",
    ///         "path": "xhtml.value",
    ///         "representation": [
    ///           "xhtml"
    ///         ],
    ///         "short": "Actual xhtml",
    ///         "definition": "Actual xhtml",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "_code": {
    ///               "extension": [
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
    ///                   "valueString": "string"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
    ///                   "valueString": "xhtml:div"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "string"
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
    public class Xhtml_Type : MakerPrimitive_Type                                                                                           // MakerGen.cs:167
    {                                                                                                                                       // MakerGen.cs:168
    }                                                                                                                                       // MakerGen.cs:169
}                                                                                                                                           // MakerGen.cs:170
