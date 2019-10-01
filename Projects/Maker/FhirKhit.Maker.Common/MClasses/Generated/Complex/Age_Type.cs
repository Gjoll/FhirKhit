using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Age'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Age",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Age",
    ///   "version": "4.0.0",
    ///   "name": "Age",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Age Type: A duration of time during which an organism (or a process) has existed.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Age",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Age",
    ///         "path": "Age",
    ///         "short": "A duration of time during which an organism (or a process) has existed",
    ///         "definition": "A duration of time during which an organism (or a process) has existed.",
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
    ///               "valueString": "AgeUnits"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Appropriate units for Age.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/age-units"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Age
    public class Age_Type : MakerComplex_Type                                                                                               // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        public Age_Type()                                                                                                                   // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
