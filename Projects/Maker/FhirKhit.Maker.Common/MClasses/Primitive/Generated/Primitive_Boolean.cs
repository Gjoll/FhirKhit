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
      "id": "boolean",
      "url": "http://hl7.org/fhir/StructureDefinition/boolean",
      "version": "4.0.0",
      "name": "boolean",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for boolean Type: Value of \"true\" or \"false\"",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "boolean",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "boolean",
            "path": "boolean",
            "short": "Primitive Type boolean",
            "definition": "Value of \"true\" or \"false\"",
            "min": 0,
            "max": "*"
          },
          {
            "id": "boolean.value",
            "path": "boolean.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for boolean",
            "definition": "Primitive value for boolean",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "true|false"
                  }
                ],
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "boolean"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xsd:boolean"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:boolean"
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
    /// Fhir primitive 'boolean'
    /// </summary>
    public class Primitive_Boolean : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                          // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
