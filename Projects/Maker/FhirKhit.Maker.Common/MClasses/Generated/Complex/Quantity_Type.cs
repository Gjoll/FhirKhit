using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'SimpleQuantity'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "SimpleQuantity",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/SimpleQuantity",
    ///   "version": "4.0.0",
    ///   "name": "SimpleQuantity",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "A fixed quantity (no comparator)",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Quantity",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "constraint",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Quantity",
    ///         "path": "Quantity",
    ///         "short": "A fixed quantity (no comparator)",
    ///         "definition": "The comparator is not used on a SimpleQuantity",
    ///         "min": 0,
    ///         "max": "*",
    ///         "isModifier": false
    ///       },
    ///       {
    ///         "id": "Quantity.comparator",
    ///         "path": "Quantity.comparator",
    ///         "definition": "Not allowed to be used in this context",
    ///         "max": "0"
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Quantity
    public class SimpleQuantity_Type : Complex_Type                                                                                         // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. Quantity.comparator
        public ElementInstance Comparator;                                                                                                  // MakerGen.cs:203
        public SimpleQuantity_Type()                                                                                                        // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
