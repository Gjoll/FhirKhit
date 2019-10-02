using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Resource",
      "url": "http://hl7.org/fhir/StructureDefinition/Resource",
      "version": "4.0.0",
      "name": "Resource",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "This is the base resource type for everything.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": true,
      "type": "Resource",
      "differential": {
        "element": [
          {
            "id": "Resource",
            "path": "Resource",
            "short": "Base Resource",
            "definition": "This is the base resource type for everything.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Resource.id",
            "path": "Resource.id",
            "short": "Logical id of this artifact",
            "definition": "The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.",
            "comment": "The only time that a resource does not have an id is when it is being submitted to the server using a create operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Resource.meta",
            "path": "Resource.meta",
            "short": "Metadata about the resource",
            "definition": "The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Meta"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Resource.implicitRules",
            "path": "Resource.implicitRules",
            "short": "A set of rules under which this content was created",
            "definition": "A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.",
            "comment": "Asserting this rule set restricts the content to be only understood by a limited set of trading partners. This inherently limits the usefulness of the data in the long term. However, the existing health eco-system is highly fractured, and not yet ready to define, collect, and exchange data in a generally computable sense. Wherever possible, implementers and/or specification writers should avoid using this element. Often, when used, the URL is a reference to an implementation guide that defines these special rules as part of it's narrative along with other profiles, value sets, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the implicit rules may provide additional knowledge about the resource that modifies it's meaning or interpretation",
            "isSummary": true
          },
          {
            "id": "Resource.language",
            "path": "Resource.language",
            "short": "Language of the resource content",
            "definition": "The base language in which the resource is written.",
            "comment": "Language is provided to support indexing and accessibility (typically, services such as text to speech use the language tag). The html language tag in the narrative applies  to the narrative. The language tag on the resource may be used to specify the language of other presentations generated from the data in the resource. Not all the content has to be in the base language. The Resource.language should not be assumed to apply to the narrative automatically. If a language is specified, it should it also be specified on the div element in the html (see rules in HTML5 for information about the relationship between xml:lang and the html lang attribute).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Language"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "A human language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/languages"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Resource'
    /// </summary>
    // 0. Resource
    public partial class Resource_Resource : FhirKhit.Maker.Common.Resource.ResourceBase
    {
        // 1. Resource.id
        public ElementDefinitionInfo Element_Id;
        // 2. Resource.meta
        public ElementDefinitionInfo Element_Meta;
        // 3. Resource.implicitRules
        public ElementDefinitionInfo Element_ImplicitRules;
        // 4. Resource.language
        public ElementDefinitionInfo Element_Language;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Resource",
                ElementId = "Resource"
            });
            Element_Id.Write(sDef);
            Element_Meta.Write(sDef);
            Element_ImplicitRules.Write(sDef);
            Element_Language.Write(sDef);
        }
        
        public Resource_Resource()
        {
            {
                // 1. Resource.id
                this.Element_Id = new ElementDefinitionInfo
                {
                    Name = "Element_Id",
                    Path= "Resource.id",
                    Id = "Resource.id",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id
                        {
                        }
                    }
                };
            }
            {
                // 2. Resource.meta
                this.Element_Meta = new ElementDefinitionInfo
                {
                    Name = "Element_Meta",
                    Path= "Resource.meta",
                    Id = "Resource.meta",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Meta
                        {
                        }
                    }
                };
            }
            {
                // 3. Resource.implicitRules
                this.Element_ImplicitRules = new ElementDefinitionInfo
                {
                    Name = "Element_ImplicitRules",
                    Path= "Resource.implicitRules",
                    Id = "Resource.implicitRules",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 4. Resource.language
                this.Element_Language = new ElementDefinitionInfo
                {
                    Name = "Element_Language",
                    Path= "Resource.language",
                    Id = "Resource.language",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            this.Name = "Resource";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Resource";
        }
    }
}
