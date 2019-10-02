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
      "id": "url",
      "url": "http://hl7.org/fhir/StructureDefinition/url",
      "version": "4.0.0",
      "name": "url",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for url type: A URI that is a literal reference",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "url",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/uri",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "url",
            "path": "url",
            "short": "Primitive Type url",
            "definition": "A URI that is a literal reference",
            "min": 0,
            "max": "*"
          },
          {
            "id": "url.value",
            "path": "url.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for url",
            "definition": "Primitive value for url",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "\\S*"
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
                      "valueString": "xsd:anyURI"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:string"
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
    #endregion
    /// <summary>
    /// Fhir primitive 'url'
    /// </summary>
    public class Primitive_Url : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
