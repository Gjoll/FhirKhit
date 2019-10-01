using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Count'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Count",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Count",
    ///   "version": "4.0.0",
    ///   "name": "Count",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Count Type: A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///   "purpose": "Need to able to capture all sorts of measured values, even if the measured value are not precisely quantified. Values include exact measures such as 3.51g, customary units such as 3 tablets, and currencies such as $100.32USD.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Count",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Count",
    ///         "path": "Count",
    ///         "short": "A measured or measurable amount",
    ///         "definition": "A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///         "comment": "The context of use may frequently define what kind of quantity this is and therefore what kind of units can be used. The context of use may also restrict the values for the comparator.",
    ///         "min": 0,
    ///         "max": "*"
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Count
    public class Count_Type : MakerComplex_Type                                                                                             // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        public Count_Type()                                                                                                                 // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
