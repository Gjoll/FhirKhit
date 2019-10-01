using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'Narrative'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Narrative",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Narrative",
    ///   "version": "4.0.0",
    ///   "name": "Narrative",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Narrative Type: A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Narrative",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Narrative",
    ///         "path": "Narrative",
    ///         "short": "Human-readable summary of the resource (essential clinical and business information)",
    ///         "definition": "A human-readable summary of the resource conveying the essential clinical and business information for the resource.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Narrative.status",
    ///         "path": "Narrative.status",
    ///         "short": "generated | extensions | additional | empty",
    ///         "definition": "The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "NarrativeStatus"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The status of a resource narrative.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/narrative-status|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Narrative.div",
    ///         "path": "Narrative.div",
    ///         "short": "Limited xhtml content",
    ///         "definition": "The actual narrative content, a stripped down version of XHTML.",
    ///         "comment": "The contents of the html element are an XHTML fragment containing only the basic html formatting elements described in chapters 7-11 and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained stylesheets. The XHTML content SHALL NOT contain a head, a body, external stylesheet references, scripts, forms, base/link/xlink, frames, iframes and objects.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "xhtml"
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Narrative
    public class Narrative_Type : Complex_Type                                                                                              // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. Narrative.status
        public ElementInstance Status;                                                                                                      // MakerGen.cs:203
        // 2. Narrative.div
        public ElementInstance Div;                                                                                                         // MakerGen.cs:203
        public Narrative_Type()                                                                                                             // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
