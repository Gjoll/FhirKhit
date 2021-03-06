using System;                                                                                                                               // MakerGen.cs:168
using System.Diagnostics;                                                                                                                   // MakerGen.cs:169
using System.IO;                                                                                                                            // MakerGen.cs:170
using System.Linq;                                                                                                                          // MakerGen.cs:171
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:172
                                                                                                                                            // MakerGen.cs:173
namespace FhirKhit.Maker.Common.Primitive                                                                                                   // MakerGen.cs:174
{                                                                                                                                           // MakerGen.cs:175
    #region Json                                                                                                                            // MakerGen.cs:176
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "markdown",
      "url": "http://hl7.org/fhir/StructureDefinition/markdown",
      "version": "4.0.0",
      "name": "markdown",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for markdown type: A string that may contain Github Flavored Markdown syntax for optional processing by a mark down presentation engine",
      "fhirVersion": "4.0.0",
      "kind": "primitive-type",
      "abstract": false,
      "type": "markdown",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/string",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "markdown",
            "path": "markdown",
            "short": "Primitive Type markdown",
            "definition": "A string that may contain Github Flavored Markdown syntax for optional processing by a mark down presentation engine",
            "comment": "Systems are not required to have markdown support, so the text should be readable without markdown processing. The markdown syntax is GFM - see https://github.github.com/gfm/",
            "min": 0,
            "max": "*"
          },
          {
            "id": "markdown.value",
            "path": "markdown.value",
            "representation": [
              "xmlAttr"
            ],
            "short": "Primitive value for markdown",
            "definition": "Primitive value for markdown",
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
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:180
    /// <summary>
    /// Fhir primitive 'markdown'
    /// </summary>
    public partial class Primitive_Markdown : FhirKhit.Maker.Common.Primitive.PrimitiveBase                                                 // MakerGen.cs:184
    {                                                                                                                                       // MakerGen.cs:185
    }                                                                                                                                       // MakerGen.cs:186
}                                                                                                                                           // MakerGen.cs:187
