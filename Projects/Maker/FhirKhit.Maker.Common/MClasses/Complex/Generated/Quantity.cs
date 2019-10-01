using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
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
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'SimpleQuantity'
    /// </summary>
    // 0. Quantity
    public class Quantity : FhirKhit.Maker.Common.Complex.ComplexBase                                                                       // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Quantity_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Quantity.comparator
            public ElementDefinitionInfo Comparator;                                                                                        // MakerGen.cs:236
            public Quantity_Elements()                                                                                                      // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Quantity.comparator
                    this.Comparator = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Comparator",                                                                                                // MakerGen.cs:255
                        Path= "Quantity.comparator",                                                                                        // MakerGen.cs:256
                        Id = "Quantity.comparator",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 0,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Comparator.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Quantity_Elements Elements { get; }                                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Quantity()                                                                                                                   // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Quantity_Elements();                                                                                        // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
