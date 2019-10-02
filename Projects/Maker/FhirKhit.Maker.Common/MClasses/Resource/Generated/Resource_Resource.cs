using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Resource'
    /// </summary>
    // 0. Resource
    public class Resource_Resource : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. Resource.id
        public ElementDefinitionInfo Element_Id;                                                                                            // MakerGen.cs:219
        // 2. Resource.meta
        public ElementDefinitionInfo Element_Meta;                                                                                          // MakerGen.cs:219
        // 3. Resource.implicitRules
        public ElementDefinitionInfo Element_ImplicitRules;                                                                                 // MakerGen.cs:219
        // 4. Resource.language
        public ElementDefinitionInfo Element_Language;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Resource",                                                                                                          // MakerGen.cs:395
                ElementId = "Resource"                                                                                                      // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Id.Write(sDef);                                                                                                         // MakerGen.cs:223
            Element_Meta.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_ImplicitRules.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Language.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Resource()                                                                                                          // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Resource.id
                this.Element_Id = new ElementDefinitionInfo                                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Id",                                                                                                    // MakerGen.cs:238
                    Path= "Resource.id",                                                                                                    // MakerGen.cs:239
                    Id = "Resource.id",                                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id                                                                    // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Resource.meta
                this.Element_Meta = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Meta",                                                                                                  // MakerGen.cs:238
                    Path= "Resource.meta",                                                                                                  // MakerGen.cs:239
                    Id = "Resource.meta",                                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Meta                                                                         // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Resource.implicitRules
                this.Element_ImplicitRules = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ImplicitRules",                                                                                         // MakerGen.cs:238
                    Path= "Resource.implicitRules",                                                                                         // MakerGen.cs:239
                    Id = "Resource.implicitRules",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Resource.language
                this.Element_Language = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Language",                                                                                              // MakerGen.cs:238
                    Path= "Resource.language",                                                                                              // MakerGen.cs:239
                    Id = "Resource.language",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Resource";                                                                                                         // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Resource";                                                                  // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
