using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
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
    public class SimpleQuantity_Type : Complex_Type                                                                                         // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Quantity.comparator
        public ElementInstance Comparator;                                                                                                  // MakerGen.cs:208
        public SimpleQuantity_Type()                                                                                                        // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
