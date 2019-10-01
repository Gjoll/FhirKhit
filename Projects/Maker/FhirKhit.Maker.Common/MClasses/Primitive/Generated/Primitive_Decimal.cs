using System;                                                                                                                               // MakerGen.cs:161
using System.Diagnostics;                                                                                                                   // MakerGen.cs:162
using System.IO;                                                                                                                            // MakerGen.cs:163
using System.Linq;                                                                                                                          // MakerGen.cs:164
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:165
                                                                                                                                            // MakerGen.cs:166
namespace FhirKhit.Maker.Common.Primitive                                                                                                   // MakerGen.cs:167
{                                                                                                                                           // MakerGen.cs:168
    #region Json                                                                                                                            // MakerGen.cs:169
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "decimal",
      "url": "http://hl7.org/fhir/StructureDefinition/decimal",
      "version": "4.0.0",
      "name": "decimal",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for decimal Type: A rational number with implicit precision",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "decimal",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "decimal",
            "path": "decimal",
            "short": "Primitive Type decimal",
            "definition": "A rational number with implicit precision",
            "comment": "Do not use an IEEE type floating point type, instead use something that works like a true decimal, with inbuilt precision (e.g. Java BigInteger)",
            "min": 0,
            "max": "*"
          },
          {
            "id": "decimal.value",
            "path": "decimal.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for decimal",
            "definition": "Primitive value for decimal",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "-?(0|[1-9][0-9]*)(\\.[0-9]+)?([eE][+-]?[0-9]+)?"
                  }
                ],
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "number"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xsd:decimal OR xsd:double"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:decimal OR xsd:double"
                    }
                  ]
                }
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:173
    /// <summary>
    /// Fhir primitive 'decimal'
    /// </summary>
    public class Primitive_Decimal : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                          // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
