using System;                                                                                                                               // MakerGen.cs:461
using System.Diagnostics;                                                                                                                   // MakerGen.cs:462
using System.IO;                                                                                                                            // MakerGen.cs:463
using System.Linq;                                                                                                                          // MakerGen.cs:464
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:465
                                                                                                                                            // MakerGen.cs:466
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:467
{                                                                                                                                           // MakerGen.cs:468
    #region Json                                                                                                                            // MakerGen.cs:469
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
    #endregion                                                                                                                              // MakerGen.cs:473
    /// <summary>
    /// Fhir complex 'Distance'
    /// </summary>
    // 0. Distance
    public class Distance : FhirKhit.Maker.Common.Complex.ComplexBase                                                                       // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        public Distance()                                                                                                                   // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:478
