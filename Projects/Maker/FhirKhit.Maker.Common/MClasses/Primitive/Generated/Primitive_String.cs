using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Primitive
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "string",
      "url": "http://hl7.org/fhir/StructureDefinition/string",
      "version": "4.0.0",
      "name": "string",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for string Type: A sequence of Unicode characters",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "string",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "string",
            "path": "string",
            "short": "Primitive Type string",
            "definition": "A sequence of Unicode characters",
            "comment": "Note that FHIR strings SHALL NOT exceed 1MB in size",
            "min": 0,
            "max": "*"
          },
          {
            "id": "string.value",
            "path": "string.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for string",
            "definition": "Primitive value for string",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "[ \\r\\n\\t\\S]+"
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
                      "valueString": "xsd:string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:string"
                    }
                  ]
                }
              }
            ],
            "maxLength": 1048576
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir primitive 'string'
    /// </summary>
    public class Primitive_String : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
