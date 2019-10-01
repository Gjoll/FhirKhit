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
      "id": "Distance",
      "url": "http://hl7.org/fhir/StructureDefinition/Distance",
      "version": "4.0.0",
      "name": "Distance",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Distance Type: A length - a value with a unit that is a physical distance.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Distance",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Distance",
            "path": "Distance",
            "short": "A length - a value with a unit that is a physical distance",
            "definition": "A length - a value with a unit that is a physical distance.",
            "min": 0,
            "max": "*",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-distance-units"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DistanceUnits"
                }
              ],
              "strength": "extensible",
              "description": "Appropriate units for Distance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/distance-units"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'Distance'
    /// </summary>
    // 0. Distance
    public class Distance : FhirKhit.Maker.Common.Complex.ComplexBase                                                                       // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Distance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            public Distance_Elements()                                                                                                      // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Distance_Elements Elements { get; }                                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Distance()                                                                                                                   // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Distance_Elements();                                                                                        // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
