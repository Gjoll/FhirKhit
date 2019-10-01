using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Element'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Element",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "version": "4.0.0",
    ///   "name": "Element",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Element Type: Base definition for all elements in a resource.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": true,
    ///   "type": "Element",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Element",
    ///         "path": "Element",
    ///         "short": "Base for all elements",
    ///         "definition": "Base definition for all elements in a resource.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "condition": [
    ///           "ele-1"
    ///         ]
    ///       },
    ///       {
    ///         "id": "Element.id",
    ///         "path": "Element.id",
    ///         "representation": [
    ///           "xmlAttr"
    ///         ],
    ///         "short": "Unique id for inter-element referencing",
    ///         "definition": "Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "_code": {
    ///               "extension": [
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
    ///                   "valueString": "string"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
    ///                   "valueString": "xsd:string"
    ///                 },
    ///                 {
    ///                   "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
    ///                   "valueString": "xsd:string"
    ///                 }
    ///               ]
    ///             }
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "Element.extension",
    ///         "path": "Element.extension",
    ///         "slicing": {
    ///           "discriminator": [
    ///             {
    ///               "type": "value",
    ///               "path": "url"
    ///             }
    ///           ],
    ///           "description": "Extensions are always sliced by (at least) url",
    ///           "rules": "open"
    ///         },
    ///         "short": "Additional content defined by implementations",
    ///         "definition": "May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.",
    ///         "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
    ///         "alias": [
    ///           "extensions",
    ///           "user content"
    ///         ],
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Extension"
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Element
    public class Element_Type : MakerComplex_Type                                                                                           // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Element.id
        public MakerElementInstance Id;                                                                                                     // MakerGen.cs:217
        // 2. Element.extension
        public MakerElementInstance Extension;                                                                                              // MakerGen.cs:217
        public Element_Type()                                                                                                               // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Element.id
                this.Id = new MakerElementInstance                                                                                          // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Id",                                                                                                            // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Element.extension
                this.Extension = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Extension",                                                                                                     // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
