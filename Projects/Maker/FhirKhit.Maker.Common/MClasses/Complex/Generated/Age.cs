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
      "id": "Age",
      "url": "http://hl7.org/fhir/StructureDefinition/Age",
      "version": "4.0.0",
      "name": "Age",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Age Type: A duration of time during which an organism (or a process) has existed.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Age",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Age",
            "path": "Age",
            "short": "A duration of time during which an organism (or a process) has existed",
            "definition": "A duration of time during which an organism (or a process) has existed.",
            "min": 0,
            "max": "*",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-time-units"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AgeUnits"
                }
              ],
              "strength": "extensible",
              "description": "Appropriate units for Age.",
              "valueSet": "http://hl7.org/fhir/ValueSet/age-units"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:483
    /// <summary>
    /// Fhir complex 'Age'
    /// </summary>
    // 0. Age
    public class Age : FhirKhit.Maker.Common.Complex.ComplexBase                                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public Age()                                                                                                                        // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:488
