using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'DomainResource'
    /// </summary>
    // 0. DomainResource
    public class DomainResource : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class DomainResource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. DomainResource.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:211
            // 2. DomainResource.contained
            public ElementDefinitionInfo Contained;                                                                                         // MakerGen.cs:211
            // 3. DomainResource.extension
            public ElementDefinitionInfo Extension;                                                                                         // MakerGen.cs:211
            // 4. DomainResource.modifierExtension
            public ElementDefinitionInfo ModifierExtension;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public DomainResource_Elements()                                                                                                // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. DomainResource.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Text",                                                                                                      // MakerGen.cs:230
                        Path= "DomainResource.text",                                                                                        // MakerGen.cs:231
                        Id = "DomainResource.text",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Narrative                                                                     // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. DomainResource.contained
                    this.Contained = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contained",                                                                                                 // MakerGen.cs:230
                        Path= "DomainResource.contained",                                                                                   // MakerGen.cs:231
                        Id = "DomainResource.contained",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Resource.Resource                                                                     // MakerGen.cs:327
                            {                                                                                                               // MakerGen.cs:328
                            }                                                                                                               // MakerGen.cs:331
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. DomainResource.extension
                    this.Extension = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Extension",                                                                                                 // MakerGen.cs:230
                        Path= "DomainResource.extension",                                                                                   // MakerGen.cs:231
                        Id = "DomainResource.extension",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. DomainResource.modifierExtension
                    this.ModifierExtension = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ModifierExtension",                                                                                         // MakerGen.cs:230
                        Path= "DomainResource.modifierExtension",                                                                           // MakerGen.cs:231
                        Id = "DomainResource.modifierExtension",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Text.Write(sDef);                                                                                                           // MakerGen.cs:215
                Contained.Write(sDef);                                                                                                      // MakerGen.cs:215
                Extension.Write(sDef);                                                                                                      // MakerGen.cs:215
                ModifierExtension.Write(sDef);                                                                                              // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public DomainResource_Elements Elements                                                                                             // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new DomainResource_Elements();                                                                          // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        DomainResource_Elements elements;                                                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public DomainResource()                                                                                                             // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "DomainResource";                                                                                                   // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DomainResource";                                                            // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "DomainResource",                                                                                                    // MakerGen.cs:423
                ElementId = "DomainResource"                                                                                                // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
