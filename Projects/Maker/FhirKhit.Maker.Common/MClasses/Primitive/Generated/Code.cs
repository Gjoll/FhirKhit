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
      "id": "code",
      "url": "http://hl7.org/fhir/StructureDefinition/code",
      "version": "4.0.0",
      "name": "code",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for code type: A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "code",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/string",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "code",
            "path": "code",
            "short": "Primitive Type code",
            "definition": "A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents",
            "min": 0,
            "max": "*"
          },
          {
            "id": "code.value",
            "path": "code.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for code",
            "definition": "Primitive value for code",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "[^\\s]+(\\s[^\\s]+)*"
                  }
                ],
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xsd:token"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:token"
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
    /// Fhir primitive 'code'
    /// </summary>
    public class Code : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                                       // MakerGen.cs:176
    {                                                                                                                                       // MakerGen.cs:177
    }                                                                                                                                       // MakerGen.cs:178
}                                                                                                                                           // MakerGen.cs:179
