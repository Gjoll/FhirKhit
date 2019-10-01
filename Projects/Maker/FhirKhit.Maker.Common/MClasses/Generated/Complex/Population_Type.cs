using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'Population'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Population",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Population",
    ///   "version": "4.0.0",
    ///   "name": "Population",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Population Type: A populatioof people with some set of grouping criteria.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Population",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Population",
    ///         "path": "Population",
    ///         "short": "A definition of a set of people that apply to some clinically related context, for example people contraindicated for a certain medication",
    ///         "definition": "A populatioof people with some set of grouping criteria.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Population.age[x]",
    ///         "path": "Population.age[x]",
    ///         "short": "The age of the specific population",
    ///         "definition": "The age of the specific population.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Range"
    ///           },
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Population.gender",
    ///         "path": "Population.gender",
    ///         "short": "The gender of the specific population",
    ///         "definition": "The gender of the specific population.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Population.race",
    ///         "path": "Population.race",
    ///         "short": "Race of the specific population",
    ///         "definition": "Race of the specific population.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Population.physiologicalCondition",
    ///         "path": "Population.physiologicalCondition",
    ///         "short": "The existing physiological conditions of the specific population to which this applies",
    ///         "definition": "The existing physiological conditions of the specific population to which this applies.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Population
    public class Population_Type : Complex_Type                                                                                             // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. Population.age[x]
        public ElementInstance AgeX;                                                                                                        // MakerGen.cs:203
        // 2. Population.gender
        public ElementInstance Gender;                                                                                                      // MakerGen.cs:203
        // 3. Population.race
        public ElementInstance Race;                                                                                                        // MakerGen.cs:203
        // 4. Population.physiologicalCondition
        public ElementInstance PhysiologicalCondition;                                                                                      // MakerGen.cs:203
        public Population_Type()                                                                                                            // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
