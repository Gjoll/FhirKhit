using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'Duration'
    /// </summary>
    // 0. Duration
    public partial class Type_Duration : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Duration",
                ElementId = "Duration"
            });
        }
        
        public Type_Duration()
        {
        }
    }
}
