using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Resource'
    /// </summary>
    // 0. Resource
    public class Resource : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Resource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Resource.id
            public ElementDefinitionInfo Id;                                                                                                // MakerGen.cs:236
            // 2. Resource.meta
            public ElementDefinitionInfo Meta;                                                                                              // MakerGen.cs:236
            // 3. Resource.implicitRules
            public ElementDefinitionInfo ImplicitRules;                                                                                     // MakerGen.cs:236
            // 4. Resource.language
            public ElementDefinitionInfo Language;                                                                                          // MakerGen.cs:236
            public Resource_Elements()                                                                                                      // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Resource.id
                    this.Id = new ElementDefinitionInfo                                                                                     // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Id",                                                                                                        // MakerGen.cs:255
                        Path= "Resource.id",                                                                                                // MakerGen.cs:256
                        Id = "Resource.id",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Resource.meta
                    this.Meta = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Meta",                                                                                                      // MakerGen.cs:255
                        Path= "Resource.meta",                                                                                              // MakerGen.cs:256
                        Id = "Resource.meta",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Meta                                                                          // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Resource.implicitRules
                    this.ImplicitRules = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ImplicitRules",                                                                                             // MakerGen.cs:255
                        Path= "Resource.implicitRules",                                                                                     // MakerGen.cs:256
                        Id = "Resource.implicitRules",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Resource.language
                    this.Language = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Language",                                                                                                  // MakerGen.cs:255
                        Path= "Resource.language",                                                                                          // MakerGen.cs:256
                        Id = "Resource.language",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Id.Write(sDef);                                                                                                             // MakerGen.cs:240
                Meta.Write(sDef);                                                                                                           // MakerGen.cs:240
                ImplicitRules.Write(sDef);                                                                                                  // MakerGen.cs:240
                Language.Write(sDef);                                                                                                       // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Resource_Elements Elements { get; }                                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Resource()                                                                                                                   // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Resource_Elements();                                                                                        // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
