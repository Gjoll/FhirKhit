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
      "id": "time",
      "url": "http://hl7.org/fhir/StructureDefinition/time",
      "version": "4.0.0",
      "name": "time",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for time Type: A time during the day, with no date specified",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "time",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "time",
            "path": "time",
            "short": "Primitive Type time",
            "definition": "A time during the day, with no date specified",
            "min": 0,
            "max": "*"
          },
          {
            "id": "time.value",
            "path": "time.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for time",
            "definition": "Primitive value for time",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\\.[0-9]+)?"
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
                      "valueString": "xsd:time"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:time"
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
    /// Fhir primitive 'time'
    /// </summary>
    public class Primitive_Time : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
