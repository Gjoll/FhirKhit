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
      "id": "oid",
      "url": "http://hl7.org/fhir/StructureDefinition/oid",
      "version": "4.0.0",
      "name": "oid",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for oid type: An OID represented as a URI",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "oid",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/uri",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "oid",
            "path": "oid",
            "short": "Primitive Type oid",
            "definition": "An OID represented as a URI",
            "comment": "RFC 3001. See also ISO/IEC 8824:1990 €",
            "min": 0,
            "max": "*"
          },
          {
            "id": "oid.value",
            "path": "oid.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for oid",
            "definition": "Primitive value for oid",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/regex",
                    "valueString": "urn:oid:[0-2](\\.(0|[1-9][0-9]*))+"
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
    #endregion                                                                                                                              // MakerGen.cs:173
    /// <summary>
    /// Fhir primitive 'oid'
    /// </summary>
    public class Primitive_Oid : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                              // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
