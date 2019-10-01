using System;                                                                                                                               // MakerGen.cs:439
using System.Diagnostics;                                                                                                                   // MakerGen.cs:440
using System.IO;                                                                                                                            // MakerGen.cs:441
using System.Linq;                                                                                                                          // MakerGen.cs:442
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:443
                                                                                                                                            // MakerGen.cs:444
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:445
{                                                                                                                                           // MakerGen.cs:446
    #region Json                                                                                                                            // MakerGen.cs:447
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Element",
      "url": "http://hl7.org/fhir/StructureDefinition/Element",
      "version": "4.0.0",
      "name": "Element",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Element Type: Base definition for all elements in a resource.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": true,
      "type": "Element",
      "differential": {
        "element": [
          {
            "id": "Element",
            "path": "Element",
            "short": "Base for all elements",
            "definition": "Base definition for all elements in a resource.",
            "min": 0,
            "max": "*",
            "condition": [
              "ele-1"
            ]
          },
          {
            "id": "Element.id",
            "path": "Element.id",
            "representation": [
              "xmlAttr"
            ],
            "short": "Unique id for inter-element referencing",
            "definition": "Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.",
            "min": 0,
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
          },
          {
            "id": "Element.extension",
            "path": "Element.extension",
            "slicing": {
              "discriminator": [
                {
                  "type": "value",
                  "path": "url"
                }
              ],
              "description": "Extensions are always sliced by (at least) url",
              "rules": "open"
            },
            "short": "Additional content defined by implementations",
            "definition": "May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.",
            "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
            "alias": [
              "extensions",
              "user content"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Extension"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:451
    /// <summary>
    /// Fhir complex 'Element'
    /// </summary>
    // 0. Element
    public class Element : FhirKhit.Maker.Common.Complex.ComplexBase                                                                        // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. Element.id
        public MakerElementInstance Element_Id;                                                                                             // MakerGen.cs:232
        // 2. Element.extension
        public MakerElementInstance Element_Extension;                                                                                      // MakerGen.cs:232
        public Element()                                                                                                                    // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Element.id
                this.Element_Id = new MakerElementInstance                                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Id",                                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. Element.extension
                this.Element_Extension = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Extension",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:456
