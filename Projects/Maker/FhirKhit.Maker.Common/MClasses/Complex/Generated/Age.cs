using System;                                                                                                                               // MakerGen.cs:516
using System.Diagnostics;                                                                                                                   // MakerGen.cs:517
using System.IO;                                                                                                                            // MakerGen.cs:518
using System.Linq;                                                                                                                          // MakerGen.cs:519
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:520
                                                                                                                                            // MakerGen.cs:521
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:522
{                                                                                                                                           // MakerGen.cs:523
    #region Json                                                                                                                            // MakerGen.cs:524
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
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'Age'
    /// </summary>
    // 0. Age
    public class Age : FhirKhit.Maker.Common.Complex.ComplexBase                                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Age_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                             // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:391
            public Age_Elements()                                                                                                           // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Age_Elements Elements                                                                                                        // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Age_Elements();                                                                                     // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Age_Elements elements;                                                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Age()                                                                                                                        // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Age",                                                                                                               // MakerGen.cs:428
                ElementId = "Age"                                                                                                           // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
