using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'Element'
    /// </summary>
    // 0. Element
    public class Type_Element : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Element_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. Element.id
            public ElementDefinitionInfo Element_Id;                                                                                        // MakerGen.cs:211
            // 2. Element.extension
            public ElementDefinitionInfo Element_Extension;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Element_Elements()                                                                                                  // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Element.id
                    this.Element_Id = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Id",                                                                                                // MakerGen.cs:230
                        Path= "Element.id",                                                                                                 // MakerGen.cs:231
                        Id = "Element.id",                                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Element.extension
                    this.Element_Extension = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Extension",                                                                                         // MakerGen.cs:230
                        Path= "Element.extension",                                                                                          // MakerGen.cs:231
                        Id = "Element.extension",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Extension                                                                // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Id.Write(sDef);                                                                                                     // MakerGen.cs:215
                Element_Extension.Write(sDef);                                                                                              // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Element_Elements Elements                                                                                               // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Element_Elements();                                                                            // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Element_Elements elements;                                                                                                     // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Element()                                                                                                               // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Element",                                                                                                           // MakerGen.cs:420
                ElementId = "Element"                                                                                                       // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
