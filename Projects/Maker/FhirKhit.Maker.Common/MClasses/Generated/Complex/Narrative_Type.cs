using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
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
    public class Narrative_Type : MakerComplex_Type                                                                                         // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Narrative.status
        public MakerElementInstance Status;                                                                                                 // MakerGen.cs:217
        // 2. Narrative.div
        public MakerElementInstance Div;                                                                                                    // MakerGen.cs:217
        public Narrative_Type()                                                                                                             // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Narrative.status
                this.Status = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Status",                                                                                                        // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Narrative.div
                this.Div = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Div",                                                                                                           // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Xhtml_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
