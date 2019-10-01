using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:151
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:152
{                                                                                                                                           // MakerGen.cs:153
    /// <summary>
    /// Fhir primitive 'positiveInt'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "positiveInt",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/positiveInt",
    ///   "version": "4.0.0",
    ///   "name": "positiveInt",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for positiveInt type: An integer with a value that is positive (e.g. >0)",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "primitive-type",
    ///   "abstract": false,
    ///   "type": "positiveInt",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/integer",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "positiveInt",
    ///         "path": "positiveInt",
    ///         "short": "Primitive Type positiveInt",
    ///         "definition": "An integer with a value that is positive (e.g. >0)",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "positiveInt.value",
    ///         "path": "positiveInt.value",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Primitive value for positiveInt",
    ///         "definition": "Primitive value for positiveInt",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "extension": [
    ///               {
    ///                 "url": "http://hl7.org/fhir/StructureDefinition/regex",
    ///                 "valueString": "[1-9][0-9]*"
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
    ///                   "valueString": "xsd:positiveInteger"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "xsd:positiveInteger"
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
    public class PositiveInt_Type : Primitive_Type                                                                                          // MakerGen.cs:158
    {                                                                                                                                       // MakerGen.cs:159
    }                                                                                                                                       // MakerGen.cs:160
}                                                                                                                                           // MakerGen.cs:161
