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
      "id": "DomainResource",
      "url": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "version": "4.0.0",
      "name": "DomainResource",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A resource that includes narrative, extensions, and contained resources.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": true,
      "type": "DomainResource",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Resource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DomainResource",
            "path": "DomainResource",
            "short": "A resource with narrative, extensions, and contained resources",
            "definition": "A resource that includes narrative, extensions, and contained resources.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DomainResource.text",
            "path": "DomainResource.text",
            "short": "Text summary of the resource, for human interpretation",
            "definition": "A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it \"clinically safe\" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.",
            "comment": "Contained resources do not have narrative. Resources that are not contained SHOULD have a narrative. In some cases, a resource may only have text with little or no additional discrete data (as long as all minOccurs=1 elements are satisfied).  This may be necessary for data from legacy systems where information is captured as a \"text blob\" or where text is additionally entered raw or narrated and encoded information is added later.",
            "alias": [
              "narrative",
              "html",
              "xhtml",
              "display"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Narrative"
              }
            ]
          },
          {
            "id": "DomainResource.contained",
            "path": "DomainResource.contained",
            "short": "Contained, inline Resources",
            "definition": "These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.",
            "comment": "This should never be done when the content can be identified properly, as once identification is lost, it is extremely difficult (and context dependent) to restore it again. Contained resources may have profiles and tags In their meta elements, but SHALL NOT have security labels.",
            "alias": [
              "inline resources",
              "anonymous resources",
              "contained resources"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Resource"
              }
            ]
          },
          {
            "id": "DomainResource.extension",
            "path": "DomainResource.extension",
            "slicing": {
              "discriminator": [
                {
                  "type": "value",
                  "path": "url"
                }
              ],
              "description": "Extensions are always sliced by (at least) url",
              "rules": "open"
            },
            "short": "Additional content defined by implementations",
            "definition": "May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.",
            "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
            "alias": [
              "extensions",
              "user content"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Extension"
              }
            ]
          },
          {
            "id": "DomainResource.modifierExtension",
            "path": "DomainResource.modifierExtension",
            "slicing": {
              "discriminator": [
                {
                  "type": "value",
                  "path": "url"
                }
              ],
              "description": "Extensions are always sliced by (at least) url",
              "rules": "open"
            },
            "short": "Extensions that cannot be ignored",
            "definition": "May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.\n\nModifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).",
            "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
            "requirements": "Modifier extensions allow for extensions that *cannot* be safely ignored to be clearly distinguished from the vast majority of extensions which can be safely ignored.  This promotes interoperability by eliminating the need for implementers to prohibit the presence of extensions. For further information, see the [definition of modifier extensions](extensibility.html#modifierExtension).",
            "alias": [
              "extensions",
              "user content"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Extension"
              }
            ],
            "isModifier": true,
            "isModifierReason": "Modifier extensions are expected to modify the meaning or interpretation of the resource that contains them"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'DomainResource'
    /// </summary>
    // 0. DomainResource
    public class DomainResource : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class DomainResource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                  // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. DomainResource.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:236
            // 2. DomainResource.contained
            public ElementDefinitionInfo Contained;                                                                                         // MakerGen.cs:236
            // 3. DomainResource.extension
            public ElementDefinitionInfo Extension;                                                                                         // MakerGen.cs:236
            // 4. DomainResource.modifierExtension
            public ElementDefinitionInfo ModifierExtension;                                                                                 // MakerGen.cs:236
            public DomainResource_Elements()                                                                                                // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. DomainResource.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Text",                                                                                                      // MakerGen.cs:255
                        Path= "DomainResource.text",                                                                                        // MakerGen.cs:256
                        Id = "DomainResource.text",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Narrative                                                                     // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. DomainResource.contained
                    this.Contained = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contained",                                                                                                 // MakerGen.cs:255
                        Path= "DomainResource.contained",                                                                                   // MakerGen.cs:256
                        Id = "DomainResource.contained",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Resource.Resource                                                                     // MakerGen.cs:331
                            {                                                                                                               // MakerGen.cs:332
                            }                                                                                                               // MakerGen.cs:335
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. DomainResource.extension
                    this.Extension = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Extension",                                                                                                 // MakerGen.cs:255
                        Path= "DomainResource.extension",                                                                                   // MakerGen.cs:256
                        Id = "DomainResource.extension",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. DomainResource.modifierExtension
                    this.ModifierExtension = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ModifierExtension",                                                                                         // MakerGen.cs:255
                        Path= "DomainResource.modifierExtension",                                                                           // MakerGen.cs:256
                        Id = "DomainResource.modifierExtension",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Text.Write(sDef);                                                                                                           // MakerGen.cs:240
                Contained.Write(sDef);                                                                                                      // MakerGen.cs:240
                Extension.Write(sDef);                                                                                                      // MakerGen.cs:240
                ModifierExtension.Write(sDef);                                                                                              // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public DomainResource_Elements Elements { get; }                                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public DomainResource()                                                                                                             // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new DomainResource_Elements();                                                                                  // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
