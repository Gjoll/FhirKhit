using System;                                                                                                                               // MakerGen.cs:160
using System.Diagnostics;                                                                                                                   // MakerGen.cs:161
using System.IO;                                                                                                                            // MakerGen.cs:162
using System.Linq;                                                                                                                          // MakerGen.cs:163
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:164
                                                                                                                                            // MakerGen.cs:165
namespace FhirKhit.Maker.Common.Primitive                                                                                                   // MakerGen.cs:166
{                                                                                                                                           // MakerGen.cs:167
    #region Json                                                                                                                            // MakerGen.cs:168
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "positiveInt",
      "url": "http://hl7.org/fhir/StructureDefinition/positiveInt",
      "version": "4.0.0",
      "name": "positiveInt",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for positiveInt type: An integer with a value that is positive (e.g. >0)",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "positiveInt",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/integer",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "positiveInt",
            "path": "positiveInt",
            "short": "Primitive Type positiveInt",
            "definition": "An integer with a value that is positive (e.g. >0)",
            "min": 0,
            "max": "*"
          },
          {
            "id": "positiveInt.value",
            "path": "positiveInt.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for positiveInt",
            "definition": "Primitive value for positiveInt",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "[1-9][0-9]*"
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
                      "valueString": "xsd:positiveInteger"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:positiveInteger"
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
    #endregion                                                                                                                              // MakerGen.cs:172
    /// <summary>
    /// Fhir primitive 'positiveInt'
    /// </summary>
    public class PositiveInt : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                                // MakerGen.cs:176
    {                                                                                                                                       // MakerGen.cs:177
    }                                                                                                                                       // MakerGen.cs:178
}                                                                                                                                           // MakerGen.cs:179
