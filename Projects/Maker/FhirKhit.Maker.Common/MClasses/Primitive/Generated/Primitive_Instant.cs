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
      "id": "instant",
      "url": "http://hl7.org/fhir/StructureDefinition/instant",
      "version": "4.0.0",
      "name": "instant",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for instant Type: An instant in time - known at least to the second",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "instant",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "instant",
            "path": "instant",
            "short": "Primitive Type instant",
            "definition": "An instant in time - known at least to the second",
            "comment": "Note: This is intended for where precisely observed times are required, typically system logs etc., and not human-reported times - for them, see date and dateTime (which can be as precise as instant, but is not required to be) below. Time zone is always required",
            "min": 0,
            "max": "*"
          },
          {
            "id": "instant.value",
            "path": "instant.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for instant",
            "definition": "Primitive value for instant",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\\.[0-9]+)?(Z|(\\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00))"
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
                      "valueString": "xsd:dateTime"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:dateTime"
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
    /// Fhir primitive 'instant'
    /// </summary>
    public class Primitive_Instant : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                          // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
