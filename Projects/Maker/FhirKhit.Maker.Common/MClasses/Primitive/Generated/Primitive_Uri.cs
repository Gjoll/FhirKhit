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
      "id": "uri",
      "url": "http://hl7.org/fhir/StructureDefinition/uri",
      "version": "4.0.0",
      "name": "uri",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for uri Type: String of characters used to identify a name or a resource",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "uri",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "uri",
            "path": "uri",
            "short": "Primitive Type uri",
            "definition": "String of characters used to identify a name or a resource",
            "comment": "see http://en.wikipedia.org/wiki/Uniform_resource_identifier",
            "min": 0,
            "max": "*"
          },
          {
            "id": "uri.value",
            "path": "uri.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for uri",
            "definition": "Primitive value for uri",
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
    /// Fhir primitive 'uri'
    /// </summary>
    public class Primitive_Uri : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
