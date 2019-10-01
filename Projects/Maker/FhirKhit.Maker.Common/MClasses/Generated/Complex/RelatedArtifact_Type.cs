using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'RelatedArtifact'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "RelatedArtifact",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/RelatedArtifact",
    ///   "version": "4.0.0",
    ///   "name": "RelatedArtifact",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for RelatedArtifact Type: Related artifacts such as additional documentation, justification, or bibliographic references.",
    ///   "purpose": "Knowledge resources must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "RelatedArtifact",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "RelatedArtifact",
    ///         "path": "RelatedArtifact",
    ///         "short": "Related artifacts for a knowledge resource",
    ///         "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
    ///         "comment": "Each related artifact is either an attachment, or a reference to another knowledge resource, but not both.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.type",
    ///         "path": "RelatedArtifact.type",
    ///         "short": "documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of",
    ///         "definition": "The type of relationship to the related artifact.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "RelatedArtifactType"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The type of relationship to the related artifact.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/related-artifact-type|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.label",
    ///         "path": "RelatedArtifact.label",
    ///         "short": "Short label",
    ///         "definition": "A short label that can be used to reference the citation from elsewhere in the containing artifact, such as a footnote index.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.display",
    ///         "path": "RelatedArtifact.display",
    ///         "short": "Brief description of the related artifact",
    ///         "definition": "A brief description of the document or knowledge resource being referenced, suitable for display to a consumer.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.citation",
    ///         "path": "RelatedArtifact.citation",
    ///         "short": "Bibliographic citation for the artifact",
    ///         "definition": "A bibliographic citation for the related artifact. This text SHOULD be formatted according to an accepted citation format.",
    ///         "comment": "Additional structured information about citations should be captured as extensions.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "markdown"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.url",
    ///         "path": "RelatedArtifact.url",
    ///         "short": "Where the artifact can be accessed",
    ///         "definition": "A url for the artifact that can be followed to access the actual content.",
    ///         "comment": "If a document or resource element is present, this element SHALL NOT be provided (use the url or reference in the Attachment or resource reference).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "url"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.document",
    ///         "path": "RelatedArtifact.document",
    ///         "short": "What document is being referenced",
    ///         "definition": "The document being referenced, represented as an attachment. This is exclusive with the resource element.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Attachment"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "RelatedArtifact.resource",
    ///         "path": "RelatedArtifact.resource",
    ///         "short": "What resource is being referenced",
    ///         "definition": "The related resource, such as a library, value set, profile, or other knowledge resource.",
    ///         "comment": "If the type is predecessor, this is a reference to the succeeding knowledge resource. If the type is successor, this is a reference to the prior knowledge resource.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "canonical",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Resource"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. RelatedArtifact
    public class RelatedArtifact_Type : MakerComplex_Type                                                                                   // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. RelatedArtifact.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 2. RelatedArtifact.label
        public MakerElementInstance Label;                                                                                                  // MakerGen.cs:217
        // 3. RelatedArtifact.display
        public MakerElementInstance Display;                                                                                                // MakerGen.cs:217
        // 4. RelatedArtifact.citation
        public MakerElementInstance Citation;                                                                                               // MakerGen.cs:217
        // 5. RelatedArtifact.url
        public MakerElementInstance Url;                                                                                                    // MakerGen.cs:217
        // 6. RelatedArtifact.document
        public MakerElementInstance Document;                                                                                               // MakerGen.cs:217
        // 7. RelatedArtifact.resource
        public MakerElementInstance Resource;                                                                                               // MakerGen.cs:217
        public RelatedArtifact_Type()                                                                                                       // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. RelatedArtifact.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. RelatedArtifact.label
                this.Label = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Label",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. RelatedArtifact.display
                this.Display = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Display",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. RelatedArtifact.citation
                this.Citation = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Citation",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Markdown_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. RelatedArtifact.url
                this.Url = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Url",                                                                                                           // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Url_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 6. RelatedArtifact.document
                this.Document = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Document",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 7. RelatedArtifact.resource
                this.Resource = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Resource",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Canonical_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
