using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
    /// <summary>
    /// Fhir primitive 'Distance'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Distance",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Distance",
    ///   "version": "4.0.0",
    ///   "name": "Distance",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Distance Type: A length - a value with a unit that is a physical distance.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Distance",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Distance",
    ///         "path": "Distance",
    ///         "short": "A length - a value with a unit that is a physical distance",
    ///         "definition": "A length - a value with a unit that is a physical distance.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://hl7.org/fhir/ValueSet/all-distance-units"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "DistanceUnits"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Appropriate units for Distance.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/distance-units"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Distance
    public class Distance_Type : Complex_Type                                                                                               // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        public Distance_Type()                                                                                                              // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
