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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'SimpleQuantity'
    /// </summary>
    // 0. Quantity
    public class Type_Quantity : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Quantity_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. Quantity.comparator
            public ElementDefinitionInfo Element_Comparator;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Quantity_Elements()                                                                                                 // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Quantity.comparator
                    this.Element_Comparator = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Comparator",                                                                                        // MakerGen.cs:230
                        Path= "Quantity.comparator",                                                                                        // MakerGen.cs:231
                        Id = "Quantity.comparator",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 0,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Comparator.Write(sDef);                                                                                             // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Quantity_Elements Elements                                                                                              // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Quantity_Elements();                                                                           // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Quantity_Elements elements;                                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Quantity()                                                                                                              // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Quantity",                                                                                                          // MakerGen.cs:420
                ElementId = "Quantity"                                                                                                      // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
