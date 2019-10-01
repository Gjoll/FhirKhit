using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Duration'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Duration",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Duration",
    ///   "version": "4.0.0",
    ///   "name": "Duration",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Duration Type: A length of time.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Duration",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Duration",
    ///         "path": "Duration",
    ///         "short": "A length of time",
    ///         "definition": "A length of time.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://hl7.org/fhir/ValueSet/all-time-units"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "DurationUnits"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Appropriate units for Duration.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/duration-units"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Duration
    public class Duration_Type : MakerComplex_Type                                                                                          // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        public Duration_Type()                                                                                                              // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
