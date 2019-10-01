using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'Age'
    /// </summary>
    // 0. Age
    public class Age : FhirKhit.Maker.Common.Complex.ComplexBase                                                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Age_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                             // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            public Age_Elements()                                                                                                           // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Age_Elements Elements { get; }                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Age()                                                                                                                        // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Age_Elements();                                                                                             // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
