using System;                                                                                                                               // MakerGen.cs:447
using System.Diagnostics;                                                                                                                   // MakerGen.cs:448
using System.IO;                                                                                                                            // MakerGen.cs:449
using System.Linq;                                                                                                                          // MakerGen.cs:450
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:451
                                                                                                                                            // MakerGen.cs:452
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:453
{                                                                                                                                           // MakerGen.cs:454
    #region Json                                                                                                                            // MakerGen.cs:455
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
    #endregion                                                                                                                              // MakerGen.cs:459
    /// <summary>
    /// Fhir complex 'Distance'
    /// </summary>
    // 0. Distance
    public class Distance : FhirKhit.Maker.Common.Complex.ComplexBase                                                                       // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        public Distance()                                                                                                                   // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:464
