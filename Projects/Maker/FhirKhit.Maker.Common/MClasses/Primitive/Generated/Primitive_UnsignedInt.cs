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
      "id": "unsignedInt",
      "url": "http://hl7.org/fhir/StructureDefinition/unsignedInt",
      "version": "4.0.0",
      "name": "unsignedInt",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for unsignedInt type: An integer with a value that is not negative (e.g. >= 0)",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "unsignedInt",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/integer",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "unsignedInt",
            "path": "unsignedInt",
            "short": "Primitive Type unsignedInt",
            "definition": "An integer with a value that is not negative (e.g. >= 0)",
            "min": 0,
            "max": "*"
          },
          {
            "id": "unsignedInt.value",
            "path": "unsignedInt.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for unsignedInt",
            "definition": "Primitive value for unsignedInt",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "[0]|([1-9][0-9]*)"
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
                      "valueString": "xsd:nonNegativeInteger"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:nonNegativeInteger"
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
    /// Fhir primitive 'unsignedInt'
    /// </summary>
    public class Primitive_UnsignedInt : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                      // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
