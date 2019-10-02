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
      "id": "dateTime",
      "url": "http://hl7.org/fhir/StructureDefinition/dateTime",
      "version": "4.0.0",
      "name": "dateTime",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for dateTime Type: A date, date-time or partial date (e.g. just year or year + month).  If hours and minutes are specified, a time zone SHALL be populated. The format is a union of the schema types gYear, gYearMonth, date and dateTime. Seconds must be provided due to schema type constraints but may be zero-filled and may be ignored.                 Dates SHALL be valid dates.",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "dateTime",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "dateTime",
            "path": "dateTime",
            "short": "Primitive Type dateTime",
            "definition": "A date, date-time or partial date (e.g. just year or year + month).  If hours and minutes are specified, a time zone SHALL be populated. The format is a union of the schema types gYear, gYearMonth, date and dateTime. Seconds must be provided due to schema type constraints but may be zero-filled and may be ignored.                 Dates SHALL be valid dates.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "dateTime.value",
            "path": "dateTime.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for dateTime",
            "definition": "Primitive value for dateTime",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[1-9]|[1-2][0-9]|3[0-1])(T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\\.[0-9]+)?(Z|(\\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00)))?)?)?"
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
                      "valueString": "xsd:gYear OR xsd:gYearMonth OR xsd:date OR xsd:dateTime"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:gYear OR xsd:gYearMonth OR xsd:date OR xsd:dateTime"
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
    /// Fhir primitive 'dateTime'
    /// </summary>
    public class Primitive_DateTime : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
