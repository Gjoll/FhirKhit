using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'RelatedArtifact'
    /// </summary>
    // 0. RelatedArtifact
    public class Type_RelatedArtifact : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. RelatedArtifact.type
        public ElementDefinitionInfo Element_Type;
        // 2. RelatedArtifact.label
        public ElementDefinitionInfo Element_Label;
        // 3. RelatedArtifact.display
        public ElementDefinitionInfo Element_Display;
        // 4. RelatedArtifact.citation
        public ElementDefinitionInfo Element_Citation;
        // 5. RelatedArtifact.url
        public ElementDefinitionInfo Element_Url;
        // 6. RelatedArtifact.document
        public ElementDefinitionInfo Element_Document;
        // 7. RelatedArtifact.resource
        public ElementDefinitionInfo Element_Resource;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "RelatedArtifact",
                ElementId = "RelatedArtifact"
            });
            Element_Type.Write(sDef);
            Element_Label.Write(sDef);
            Element_Display.Write(sDef);
            Element_Citation.Write(sDef);
            Element_Url.Write(sDef);
            Element_Document.Write(sDef);
            Element_Resource.Write(sDef);
        }
        
        public Type_RelatedArtifact()
        {
            {
                // 1. RelatedArtifact.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "RelatedArtifact.type",
                    Id = "RelatedArtifact.type",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 2. RelatedArtifact.label
                this.Element_Label = new ElementDefinitionInfo
                {
                    Name = "Element_Label",
                    Path= "RelatedArtifact.label",
                    Id = "RelatedArtifact.label",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 3. RelatedArtifact.display
                this.Element_Display = new ElementDefinitionInfo
                {
                    Name = "Element_Display",
                    Path= "RelatedArtifact.display",
                    Id = "RelatedArtifact.display",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 4. RelatedArtifact.citation
                this.Element_Citation = new ElementDefinitionInfo
                {
                    Name = "Element_Citation",
                    Path= "RelatedArtifact.citation",
                    Id = "RelatedArtifact.citation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 5. RelatedArtifact.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "RelatedArtifact.url",
                    Id = "RelatedArtifact.url",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Url
                        {
                        }
                    }
                };
            }
            {
                // 6. RelatedArtifact.document
                this.Element_Document = new ElementDefinitionInfo
                {
                    Name = "Element_Document",
                    Path= "RelatedArtifact.document",
                    Id = "RelatedArtifact.document",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        }
                    }
                };
            }
            {
                // 7. RelatedArtifact.resource
                this.Element_Resource = new ElementDefinitionInfo
                {
                    Name = "Element_Resource",
                    Path= "RelatedArtifact.resource",
                    Id = "RelatedArtifact.resource",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
        }
    }
}
