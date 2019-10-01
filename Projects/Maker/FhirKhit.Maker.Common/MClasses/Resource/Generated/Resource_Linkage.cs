using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
    {
      "resourceType": "StructureDefinition",
      "id": "Linkage",
      "url": "http://hl7.org/fhir/StructureDefinition/Linkage",
      "version": "4.0.0",
      "name": "Linkage",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Identifies two or more records (resource instances) that refer to the same real-world \"occurrence\".",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Linkage",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Linkage",
            "path": "Linkage",
            "short": "Links records for 'same' item",
            "definition": "Identifies two or more records (resource instances) that refer to the same real-world \"occurrence\".",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Linkage.active",
            "path": "Linkage.active",
            "short": "Whether this linkage assertion is active or not",
            "definition": "Indicates whether the asserted set of linkages are considered to be \"in effect\".",
            "comment": "If false, any asserted linkages should not be considered current/relevant/applicable.",
            "requirements": "Need to be able to mark a linkage record as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isSummary": true
          },
          {
            "id": "Linkage.author",
            "path": "Linkage.author",
            "short": "Who is responsible for linkages",
            "definition": "Identifies the user or organization responsible for asserting the linkages as well as the user or organization who establishes the context in which the nature of each linkage is evaluated.",
            "requirements": "\"Primary\" for the same set of linked resources may be different from different user's/organization's perspectives.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Linkage.item",
            "path": "Linkage.item",
            "short": "Item to be linked",
            "definition": "Identifies which record considered as the reference to the same real-world occurrence as well as how the items should be evaluated within the collection of linked items.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "lnk-1"
            ],
            "isSummary": true
          },
          {
            "id": "Linkage.item.type",
            "path": "Linkage.item.type",
            "short": "source | alternate | historical",
            "definition": "Distinguishes which item is \"source of truth\" (if any) and which items are no longer considered to be current representations.",
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
                  "valueString": "LinkageType"
                }
              ],
              "strength": "required",
              "description": "Used to distinguish different roles a resource can play within a set of linked resources.",
              "valueSet": "http://hl7.org/fhir/ValueSet/linkage-type|4.0.0"
            }
          },
          {
            "id": "Linkage.item.resource",
            "path": "Linkage.item.resource",
            "short": "Resource being linked",
            "definition": "The resource instance being linked as part of the group.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Linkage'
    /// </summary>
    // 0. Linkage
    public class Resource_Linkage : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Linkage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 3. Linkage.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 4. Linkage.item.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 5. Linkage.item.resource
                    public ElementDefinitionInfo Element_Resource;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 4. Linkage.item.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "Linkage.item.type",                                                                                  // MakerGen.cs:231
                                Id = "Linkage.item.type",                                                                                   // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 5. Linkage.item.resource
                            this.Element_Resource = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Resource",                                                                                  // MakerGen.cs:230
                                Path= "Linkage.item.resource",                                                                              // MakerGen.cs:231
                                Id = "Linkage.item.resource",                                                                               // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Resource.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Item_Elements Elements                                                                                          // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Item_Elements();                                                                       // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Item_Elements elements;                                                                                                // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Item()                                                                                                          // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Linkage.item",                                                                                              // MakerGen.cs:420
                        ElementId = "Linkage.item"                                                                                          // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Linkage.active
            public ElementDefinitionInfo Element_Active;                                                                                    // MakerGen.cs:211
            // 2. Linkage.author
            public ElementDefinitionInfo Element_Author;                                                                                    // MakerGen.cs:211
            // 3. Linkage.item
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Linkage_Elements()                                                                                              // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Linkage.active
                    this.Element_Active = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Active",                                                                                            // MakerGen.cs:230
                        Path= "Linkage.active",                                                                                             // MakerGen.cs:231
                        Id = "Linkage.active",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Linkage.author
                    this.Element_Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Author",                                                                                            // MakerGen.cs:230
                        Path= "Linkage.author",                                                                                             // MakerGen.cs:231
                        Id = "Linkage.author",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Linkage.item
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Item",                                                                                              // MakerGen.cs:230
                        Path= "Linkage.item",                                                                                               // MakerGen.cs:231
                        Id = "Linkage.item",                                                                                                // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Item                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Active.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Author.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Linkage_Elements Elements                                                                                           // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Linkage_Elements();                                                                        // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Linkage_Elements elements;                                                                                                 // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Linkage()                                                                                                           // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Linkage";                                                                                                          // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Linkage";                                                                   // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Linkage",                                                                                                           // MakerGen.cs:420
                ElementId = "Linkage"                                                                                                       // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
