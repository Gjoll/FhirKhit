using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'ProdCharacteristic'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ProdCharacteristic",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ProdCharacteristic",
    ///   "version": "4.0.0",
    ///   "name": "ProdCharacteristic",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ProdCharacteristic Type: The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ProdCharacteristic",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ProdCharacteristic",
    ///         "path": "ProdCharacteristic",
    ///         "short": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available",
    ///         "definition": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.height",
    ///         "path": "ProdCharacteristic.height",
    ///         "short": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.width",
    ///         "path": "ProdCharacteristic.width",
    ///         "short": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.depth",
    ///         "path": "ProdCharacteristic.depth",
    ///         "short": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.weight",
    ///         "path": "ProdCharacteristic.weight",
    ///         "short": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.nominalVolume",
    ///         "path": "ProdCharacteristic.nominalVolume",
    ///         "short": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.externalDiameter",
    ///         "path": "ProdCharacteristic.externalDiameter",
    ///         "short": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used",
    ///         "definition": "Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.shape",
    ///         "path": "ProdCharacteristic.shape",
    ///         "short": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.color",
    ///         "path": "ProdCharacteristic.color",
    ///         "short": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.imprint",
    ///         "path": "ProdCharacteristic.imprint",
    ///         "short": "Where applicable, the imprint can be specified as text",
    ///         "definition": "Where applicable, the imprint can be specified as text.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.image",
    ///         "path": "ProdCharacteristic.image",
    ///         "short": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations",
    ///         "definition": "Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Attachment"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ProdCharacteristic.scoring",
    ///         "path": "ProdCharacteristic.scoring",
    ///         "short": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used",
    ///         "definition": "Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used.",
    ///         "min": 0,
    ///         "max": "1",
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
    // 0. ProdCharacteristic
    public class ProdCharacteristic_Type : Complex_Type                                                                                     // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. ProdCharacteristic.height
        public ElementInstance Height;                                                                                                      // MakerGen.cs:203
        // 2. ProdCharacteristic.width
        public ElementInstance Width;                                                                                                       // MakerGen.cs:203
        // 3. ProdCharacteristic.depth
        public ElementInstance Depth;                                                                                                       // MakerGen.cs:203
        // 4. ProdCharacteristic.weight
        public ElementInstance Weight;                                                                                                      // MakerGen.cs:203
        // 5. ProdCharacteristic.nominalVolume
        public ElementInstance NominalVolume;                                                                                               // MakerGen.cs:203
        // 6. ProdCharacteristic.externalDiameter
        public ElementInstance ExternalDiameter;                                                                                            // MakerGen.cs:203
        // 7. ProdCharacteristic.shape
        public ElementInstance Shape;                                                                                                       // MakerGen.cs:203
        // 8. ProdCharacteristic.color
        public ElementInstance Color;                                                                                                       // MakerGen.cs:203
        // 9. ProdCharacteristic.imprint
        public ElementInstance Imprint;                                                                                                     // MakerGen.cs:203
        // 10. ProdCharacteristic.image
        public ElementInstance Image;                                                                                                       // MakerGen.cs:203
        // 11. ProdCharacteristic.scoring
        public ElementInstance Scoring;                                                                                                     // MakerGen.cs:203
        public ProdCharacteristic_Type()                                                                                                    // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
