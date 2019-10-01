using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Linkage'
    /// </summary>
    // 0. Linkage
    public class Resource_Linkage : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 3. Linkage.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 4. Linkage.item.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 5. Linkage.item.resource
            public ElementDefinitionInfo Element_Resource;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Linkage.item",                                                                                                  // MakerGen.cs:388
                    ElementId = "Linkage.item"                                                                                              // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Resource.Write(sDef);                                                                                               // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Item()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 4. Linkage.item.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "Linkage.item.type",                                                                                          // MakerGen.cs:232
                        Id = "Linkage.item.type",                                                                                           // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 5. Linkage.item.resource
                    this.Element_Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Resource",                                                                                          // MakerGen.cs:231
                        Path= "Linkage.item.resource",                                                                                      // MakerGen.cs:232
                        Id = "Linkage.item.resource",                                                                                       // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Linkage.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:212
        // 2. Linkage.author
        public ElementDefinitionInfo Element_Author;                                                                                        // MakerGen.cs:212
        // 3. Linkage.item
        public ElementDefinitionInfo Element_Item;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Linkage",                                                                                                           // MakerGen.cs:388
                ElementId = "Linkage"                                                                                                       // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Author.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Item.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Linkage()                                                                                                           // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Linkage.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Active",                                                                                                // MakerGen.cs:231
                    Path= "Linkage.active",                                                                                                 // MakerGen.cs:232
                    Id = "Linkage.active",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Linkage.author
                this.Element_Author = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Author",                                                                                                // MakerGen.cs:231
                    Path= "Linkage.author",                                                                                                 // MakerGen.cs:232
                    Id = "Linkage.author",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Linkage.item
                this.Element_Item = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Item",                                                                                                  // MakerGen.cs:231
                    Path= "Linkage.item",                                                                                                   // MakerGen.cs:232
                    Id = "Linkage.item",                                                                                                    // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Item                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Linkage";                                                                                                          // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Linkage";                                                                   // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
