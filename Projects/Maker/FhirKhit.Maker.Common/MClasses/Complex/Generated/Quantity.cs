using System;                                                                                                                               // MakerGen.cs:471
using System.Diagnostics;                                                                                                                   // MakerGen.cs:472
using System.IO;                                                                                                                            // MakerGen.cs:473
using System.Linq;                                                                                                                          // MakerGen.cs:474
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:475
                                                                                                                                            // MakerGen.cs:476
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:477
{                                                                                                                                           // MakerGen.cs:478
    #region Json                                                                                                                            // MakerGen.cs:479
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "SimpleQuantity",
      "url": "http://hl7.org/fhir/StructureDefinition/SimpleQuantity",
      "version": "4.0.0",
      "name": "SimpleQuantity",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "A fixed quantity (no comparator)",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Quantity",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
      "derivation": "constraint",
      "differential": {
        "element": [
          {
            "id": "Quantity",
            "path": "Quantity",
            "short": "A fixed quantity (no comparator)",
            "definition": "The comparator is not used on a SimpleQuantity",
            "min": 0,
            "max": "*",
            "isModifier": false
          },
          {
            "id": "Quantity.comparator",
            "path": "Quantity.comparator",
            "definition": "Not allowed to be used in this context",
            "max": "0"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:483
    /// <summary>
    /// Fhir complex 'SimpleQuantity'
    /// </summary>
    // 0. Quantity
    public class Quantity : FhirKhit.Maker.Common.Complex.ComplexBase                                                                       // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 1. Quantity.comparator
        public MakerElementInstance Element_Comparator;                                                                                     // MakerGen.cs:232
        public Quantity()                                                                                                                   // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. Quantity.comparator
                this.Element_Comparator = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Comparator",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 0,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:488
