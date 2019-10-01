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
      "id": "xhtml",
      "url": "http://hl7.org/fhir/StructureDefinition/xhtml",
      "version": "4.0.0",
      "name": "xhtml",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for xhtml Type",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "xhtml",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "xhtml",
            "path": "xhtml",
            "short": "Primitive Type xhtml",
            "definition": "XHTML",
            "min": 0,
            "max": "*"
          },
          {
            "id": "xhtml.extension",
            "path": "xhtml.extension",
            "max": "0"
          },
          {
            "id": "xhtml.value",
            "path": "xhtml.value",
            "representation": [
              "xhtml"
            ],
            "short": "Actual xhtml",
            "definition": "Actual xhtml",
            "min": 1,
            "max": "1",
            "type": [
              {
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xhtml:div"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "string"
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
    /// Fhir primitive 'xhtml'
    /// </summary>
    public class Primitive_Xhtml : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                            // MakerGen.cs:177
    {                                                                                                                                       // MakerGen.cs:178
    }                                                                                                                                       // MakerGen.cs:179
}                                                                                                                                           // MakerGen.cs:180
