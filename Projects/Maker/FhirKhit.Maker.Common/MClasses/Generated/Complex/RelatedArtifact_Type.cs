using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
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
    public class RelatedArtifact_Type : Complex_Type                                                                                        // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. RelatedArtifact.type
        public ElementInstance Type;                                                                                                        // MakerGen.cs:203
        // 2. RelatedArtifact.label
        public ElementInstance Label;                                                                                                       // MakerGen.cs:203
        // 3. RelatedArtifact.display
        public ElementInstance Display;                                                                                                     // MakerGen.cs:203
        // 4. RelatedArtifact.citation
        public ElementInstance Citation;                                                                                                    // MakerGen.cs:203
        // 5. RelatedArtifact.url
        public ElementInstance Url;                                                                                                         // MakerGen.cs:203
        // 6. RelatedArtifact.document
        public ElementInstance Document;                                                                                                    // MakerGen.cs:203
        // 7. RelatedArtifact.resource
        public ElementInstance Resource;                                                                                                    // MakerGen.cs:203
        public RelatedArtifact_Type()                                                                                                       // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
