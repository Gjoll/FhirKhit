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
      "id": "uuid",
      "url": "http://hl7.org/fhir/StructureDefinition/uuid",
      "version": "4.0.0",
      "name": "uuid",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for uuid type: A UUID, represented as a URI",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "uuid",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/uri",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "uuid",
            "path": "uuid",
            "short": "Primitive Type uuid",
            "definition": "A UUID, represented as a URI",
            "comment": "See The Open Group, CDE 1.1 Remote Procedure Call specification, Appendix A.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "uuid.value",
            "path": "uuid.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for uuid",
            "definition": "Primitive value for uuid",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}"
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
    /// Fhir primitive 'uuid'
    /// </summary>
    public class Primitive_Uuid : FhirKhit.Maker.Common.Primitive.PrimitiveBase
    {
    }
}
