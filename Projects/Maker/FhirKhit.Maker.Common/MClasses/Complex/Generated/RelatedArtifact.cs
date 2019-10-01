using System;                                                                                                                               // MakerGen.cs:461
using System.Diagnostics;                                                                                                                   // MakerGen.cs:462
using System.IO;                                                                                                                            // MakerGen.cs:463
using System.Linq;                                                                                                                          // MakerGen.cs:464
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:465
                                                                                                                                            // MakerGen.cs:466
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:467
{                                                                                                                                           // MakerGen.cs:468
    #region Json                                                                                                                            // MakerGen.cs:469
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "RelatedArtifact",
      "url": "http://hl7.org/fhir/StructureDefinition/RelatedArtifact",
      "version": "4.0.0",
      "name": "RelatedArtifact",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for RelatedArtifact Type: Related artifacts such as additional documentation, justification, or bibliographic references.",
      "purpose": "Knowledge resources must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "RelatedArtifact",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "RelatedArtifact",
            "path": "RelatedArtifact",
            "short": "Related artifacts for a knowledge resource",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another knowledge resource, but not both.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "RelatedArtifact.type",
            "path": "RelatedArtifact.type",
            "short": "documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of",
            "definition": "The type of relationship to the related artifact.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RelatedArtifactType"
                }
              ],
              "strength": "required",
              "description": "The type of relationship to the related artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/related-artifact-type|4.0.0"
            }
          },
          {
            "id": "RelatedArtifact.label",
            "path": "RelatedArtifact.label",
            "short": "Short label",
            "definition": "A short label that can be used to reference the citation from elsewhere in the containing artifact, such as a footnote index.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedArtifact.display",
            "path": "RelatedArtifact.display",
            "short": "Brief description of the related artifact",
            "definition": "A brief description of the document or knowledge resource being referenced, suitable for display to a consumer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedArtifact.citation",
            "path": "RelatedArtifact.citation",
            "short": "Bibliographic citation for the artifact",
            "definition": "A bibliographic citation for the related artifact. This text SHOULD be formatted according to an accepted citation format.",
            "comment": "Additional structured information about citations should be captured as extensions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedArtifact.url",
            "path": "RelatedArtifact.url",
            "short": "Where the artifact can be accessed",
            "definition": "A url for the artifact that can be followed to access the actual content.",
            "comment": "If a document or resource element is present, this element SHALL NOT be provided (use the url or reference in the Attachment or resource reference).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedArtifact.document",
            "path": "RelatedArtifact.document",
            "short": "What document is being referenced",
            "definition": "The document being referenced, represented as an attachment. This is exclusive with the resource element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedArtifact.resource",
            "path": "RelatedArtifact.resource",
            "short": "What resource is being referenced",
            "definition": "The related resource, such as a library, value set, profile, or other knowledge resource.",
            "comment": "If the type is predecessor, this is a reference to the succeeding knowledge resource. If the type is successor, this is a reference to the prior knowledge resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:473
    /// <summary>
    /// Fhir complex 'RelatedArtifact'
    /// </summary>
    // 0. RelatedArtifact
    public class RelatedArtifact : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 1. RelatedArtifact.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 2. RelatedArtifact.label
        public MakerElementInstance Element_Label;                                                                                          // MakerGen.cs:232
        // 3. RelatedArtifact.display
        public MakerElementInstance Element_Display;                                                                                        // MakerGen.cs:232
        // 4. RelatedArtifact.citation
        public MakerElementInstance Element_Citation;                                                                                       // MakerGen.cs:232
        // 5. RelatedArtifact.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 6. RelatedArtifact.document
        public MakerElementInstance Element_Document;                                                                                       // MakerGen.cs:232
        // 7. RelatedArtifact.resource
        public MakerElementInstance Element_Resource;                                                                                       // MakerGen.cs:232
        public RelatedArtifact()                                                                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. RelatedArtifact.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. RelatedArtifact.label
                this.Element_Label = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Label",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. RelatedArtifact.display
                this.Element_Display = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Display",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. RelatedArtifact.citation
                this.Element_Citation = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Citation",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. RelatedArtifact.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Url                                                                             // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. RelatedArtifact.document
                this.Element_Document = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Document",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Attachment                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. RelatedArtifact.resource
                this.Element_Resource = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Resource",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:292
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:292
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:478
