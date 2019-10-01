using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'RelatedArtifact'
    /// </summary>
    // 0. RelatedArtifact
    public class Type_RelatedArtifact : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_RelatedArtifact_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. RelatedArtifact.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 2. RelatedArtifact.label
            public ElementDefinitionInfo Element_Label;                                                                                     // MakerGen.cs:211
            // 3. RelatedArtifact.display
            public ElementDefinitionInfo Element_Display;                                                                                   // MakerGen.cs:211
            // 4. RelatedArtifact.citation
            public ElementDefinitionInfo Element_Citation;                                                                                  // MakerGen.cs:211
            // 5. RelatedArtifact.url
            public ElementDefinitionInfo Element_Url;                                                                                       // MakerGen.cs:211
            // 6. RelatedArtifact.document
            public ElementDefinitionInfo Element_Document;                                                                                  // MakerGen.cs:211
            // 7. RelatedArtifact.resource
            public ElementDefinitionInfo Element_Resource;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_RelatedArtifact_Elements()                                                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. RelatedArtifact.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "RelatedArtifact.type",                                                                                       // MakerGen.cs:231
                        Id = "RelatedArtifact.type",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. RelatedArtifact.label
                    this.Element_Label = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Label",                                                                                             // MakerGen.cs:230
                        Path= "RelatedArtifact.label",                                                                                      // MakerGen.cs:231
                        Id = "RelatedArtifact.label",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. RelatedArtifact.display
                    this.Element_Display = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Display",                                                                                           // MakerGen.cs:230
                        Path= "RelatedArtifact.display",                                                                                    // MakerGen.cs:231
                        Id = "RelatedArtifact.display",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. RelatedArtifact.citation
                    this.Element_Citation = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Citation",                                                                                          // MakerGen.cs:230
                        Path= "RelatedArtifact.citation",                                                                                   // MakerGen.cs:231
                        Id = "RelatedArtifact.citation",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. RelatedArtifact.url
                    this.Element_Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Url",                                                                                               // MakerGen.cs:230
                        Path= "RelatedArtifact.url",                                                                                        // MakerGen.cs:231
                        Id = "RelatedArtifact.url",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Url                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. RelatedArtifact.document
                    this.Element_Document = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Document",                                                                                          // MakerGen.cs:230
                        Path= "RelatedArtifact.document",                                                                                   // MakerGen.cs:231
                        Id = "RelatedArtifact.document",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Attachment                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. RelatedArtifact.resource
                    this.Element_Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Resource",                                                                                          // MakerGen.cs:230
                        Path= "RelatedArtifact.resource",                                                                                   // MakerGen.cs:231
                        Id = "RelatedArtifact.resource",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Label.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Display.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Citation.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Url.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Document.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Resource.Write(sDef);                                                                                               // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_RelatedArtifact_Elements Elements                                                                                       // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_RelatedArtifact_Elements();                                                                    // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_RelatedArtifact_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_RelatedArtifact()                                                                                                       // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "RelatedArtifact",                                                                                                   // MakerGen.cs:420
                ElementId = "RelatedArtifact"                                                                                               // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
