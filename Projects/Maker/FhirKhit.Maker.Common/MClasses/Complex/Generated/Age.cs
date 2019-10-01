using System;                                                                                                                               // MakerGen.cs:439
using System.Diagnostics;                                                                                                                   // MakerGen.cs:440
using System.IO;                                                                                                                            // MakerGen.cs:441
using System.Linq;                                                                                                                          // MakerGen.cs:442
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:443
                                                                                                                                            // MakerGen.cs:444
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:445
{                                                                                                                                           // MakerGen.cs:446
    #region Json                                                                                                                            // MakerGen.cs:447
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
    #endregion                                                                                                                              // MakerGen.cs:451
    /// <summary>
    /// Fhir complex 'Age'
    /// </summary>
    // 0. Age
    public class Age : FhirKhit.Maker.Common.Complex.ComplexBase                                                                            // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        public Age()                                                                                                                        // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:456
