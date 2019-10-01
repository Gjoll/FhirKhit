using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
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
    public class SimpleQuantity_Type : MakerComplex_Type                                                                                    // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Quantity.comparator
        public MakerElementInstance Comparator;                                                                                             // MakerGen.cs:217
        public SimpleQuantity_Type()                                                                                                        // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Quantity.comparator
                this.Comparator = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Comparator",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 0,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
