using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Duration",
      "url": "http://hl7.org/fhir/StructureDefinition/Duration",
      "version": "4.0.0",
      "name": "Duration",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Duration Type: A length of time.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Duration",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Duration",
            "path": "Duration",
            "short": "A length of time",
            "definition": "A length of time.",
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
                  "valueString": "DurationUnits"
                }
              ],
              "strength": "extensible",
              "description": "Appropriate units for Duration.",
              "valueSet": "http://hl7.org/fhir/ValueSet/duration-units"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Duration'
    /// </summary>
    // 0. Duration
    public class Type_Duration : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Duration",                                                                                                          // MakerGen.cs:388
                ElementId = "Duration"                                                                                                      // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Duration()                                                                                                              // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
