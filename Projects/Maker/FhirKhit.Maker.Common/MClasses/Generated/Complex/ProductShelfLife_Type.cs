using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'ProductShelfLife'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ProductShelfLife",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ProductShelfLife",
    ///   "version": "4.0.0",
    ///   "name": "ProductShelfLife",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ProductShelfLife Type: The shelf-life and storage information for a medicinal product item or container can be described using this class.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ProductShelfLife",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ProductShelfLife",
    ///         "path": "ProductShelfLife",
    ///         "short": "The shelf-life and storage information for a medicinal product item or container can be described using this class",
    ///         "definition": "The shelf-life and storage information for a medicinal product item or container can be described using this class.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ProductShelfLife.identifier",
    ///         "path": "ProductShelfLife.identifier",
    ///         "short": "Unique identifier for the packaged Medicinal Product",
    ///         "definition": "Unique identifier for the packaged Medicinal Product.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Identifier"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProductShelfLife.type",
    ///         "path": "ProductShelfLife.type",
    ///         "short": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
    ///         "definition": "This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProductShelfLife.period",
    ///         "path": "ProductShelfLife.period",
    ///         "short": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProductShelfLife.specialPrecautionsForStorage",
    ///         "path": "ProductShelfLife.specialPrecautionsForStorage",
    ///         "short": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified",
    ///         "definition": "Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. ProductShelfLife
    public class ProductShelfLife_Type : Complex_Type                                                                                       // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. ProductShelfLife.identifier
        public ElementInstance Identifier;                                                                                                  // MakerGen.cs:203
        // 2. ProductShelfLife.type
        public ElementInstance Type;                                                                                                        // MakerGen.cs:203
        // 3. ProductShelfLife.period
        public ElementInstance Period;                                                                                                      // MakerGen.cs:203
        // 4. ProductShelfLife.specialPrecautionsForStorage
        public ElementInstance SpecialPrecautionsForStorage;                                                                                // MakerGen.cs:203
        public ProductShelfLife_Type()                                                                                                      // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
