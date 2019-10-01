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
      "id": "List",
      "url": "http://hl7.org/fhir/StructureDefinition/List",
      "version": "4.0.0",
      "name": "List",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A list is a curated collection of resources.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "List",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "List",
            "path": "List",
            "short": "A list is a curated collection of resources",
            "definition": "A list is a curated collection of resources.",
            "alias": [
              "Collection",
              "WorkingList",
              "Organizer"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "List.identifier",
            "path": "List.identifier",
            "short": "Business identifier",
            "definition": "Identifier for the List assigned for business purposes outside the context of FHIR.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "List.status",
            "path": "List.status",
            "short": "current | retired | entered-in-error",
            "definition": "Indicates the current state of this list.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListStatus"
                }
              ],
              "strength": "required",
              "description": "The current state of the list.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-status|4.0.0"
            }
          },
          {
            "id": "List.mode",
            "path": "List.mode",
            "short": "working | snapshot | changes",
            "definition": "How this list was prepared - whether it is a working list that is suitable for being maintained on an ongoing basis, or if it represents a snapshot of a list of items from another source, or whether it is a prepared list where items may be marked as added, modified or deleted.",
            "comment": "This element is labeled as a modifier because a change list must not be misunderstood as a complete list.",
            "requirements": "Lists are used in various ways, and it must be known in what way it is safe to use them.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If set to \"changes\", the list is considered incomplete, while the other two codes indicate the list is complete, which changes the understanding of the elements listed",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListMode"
                }
              ],
              "strength": "required",
              "description": "The processing mode that applies to this list.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-mode|4.0.0"
            }
          },
          {
            "id": "List.title",
            "path": "List.title",
            "short": "Descriptive name for the list",
            "definition": "A label for the list assigned by the author.",
            "requirements": "Allows customization beyond just the code identifying the kind of list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "Dr. Jane's Patients"
              }
            ],
            "isSummary": true
          },
          {
            "id": "List.code",
            "path": "List.code",
            "short": "What the purpose of this list is",
            "definition": "This code defines the purpose of the list - why it was created.",
            "comment": "If there is no code, the purpose of the list is implied where it is used, such as in a document section using Document.section.code.",
            "requirements": "Lists often contain subsets of resources rather than an exhaustive list.  The code identifies what type of subset is included.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListPurpose"
                }
              ],
              "strength": "example",
              "description": "What the purpose of a list is.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-example-codes"
            }
          },
          {
            "id": "List.subject",
            "path": "List.subject",
            "short": "If all resources have the same subject",
            "definition": "The common subject (or patient) of the resources that are in the list if there is one.",
            "comment": "Some purely arbitrary lists do not have a common subject, so this is optional.",
            "requirements": "The primary purpose of listing the subject explicitly is to help with finding the right list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "List.encounter",
            "path": "List.encounter",
            "short": "Context in which list created",
            "definition": "The encounter that is the context in which this list was created.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "List.date",
            "path": "List.date",
            "short": "When the list was prepared",
            "definition": "The date that the list was prepared.",
            "comment": "The actual important date is the date of currency of the resources that were summarized, but it is usually assumed that these are current when the preparation occurs.",
            "requirements": "Identifies how current the list is which affects relevance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "List.source",
            "path": "List.source",
            "short": "Who and/or what defined the list contents (aka Author)",
            "definition": "The entity responsible for deciding what the contents of the list were. Where the list was created by a human, this is the same as the author of the list.",
            "comment": "The primary source is the entity that made the decisions what items are in the list. This may be software or user.",
            "requirements": "Allows follow-up as well as context.",
            "alias": [
              "Author"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "List.orderedBy",
            "path": "List.orderedBy",
            "short": "What order the list has",
            "definition": "What order applies to the items in the list.",
            "comment": "Applications SHOULD render ordered lists in the order provided, but MAY allow users to re-order based on their own preferences as well. If there is no order specified, the order is unknown, though there may still be some order.",
            "requirements": "Important for presentation and rendering.  Lists may be sorted to place more important information first or to group related entries.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListOrder"
                }
              ],
              "strength": "preferred",
              "description": "What order applies to the items in a list.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-order"
            }
          },
          {
            "id": "List.note",
            "path": "List.note",
            "short": "Comments about the list",
            "definition": "Comments that apply to the overall list.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "List.entry",
            "path": "List.entry",
            "short": "Entries in the list",
            "definition": "Entries in this list.",
            "comment": "If there are no entries in the list, an emptyReason SHOULD be provided.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "lst-1"
            ]
          },
          {
            "id": "List.entry.flag",
            "path": "List.entry.flag",
            "short": "Status/Workflow information about this item",
            "definition": "The flag allows the system constructing the list to indicate the role and significance of the item in the list.",
            "comment": "The flag can only be understood in the context of the List.code. If the flag means that the entry has actually been deleted from the list, the deleted element SHALL be true. Deleted can only be used if the List.mode is \"changes\".",
            "requirements": "This field is present to support various clinical uses of lists, such as a discharge summary medication list, where flags specify whether the medication was added, modified, or deleted from the list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListItemFlag"
                }
              ],
              "strength": "example",
              "description": "Codes that provide further information about the reason and meaning of the item in the list.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-item-flag"
            }
          },
          {
            "id": "List.entry.deleted",
            "path": "List.entry.deleted",
            "short": "If this item is actually marked as deleted",
            "definition": "True if this item is marked as deleted in the list.",
            "comment": "If the flag means that the entry has actually been deleted from the list, the deleted element SHALL be true. Both flag and deleted can only be used if the List.mode is \"changes\". A deleted entry should be displayed in narrative as deleted.  This element is labeled as a modifier because it indicates that an item is (to be) no longer in the list.",
            "requirements": "The flag element may contain codes that an application processing the list does not understand. However there can be no ambiguity if a list item is actually marked as \"deleted\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "List items are generally only treated as deleted when this element explicitly carries a value of true. Systems SHOULD always populate this value when mode is 'changes'",
            "condition": [
              "lst-2"
            ],
            "isModifier": true,
            "isModifierReason": "If deleted is true, then the item included in the list isn't actually part of the list anymore"
          },
          {
            "id": "List.entry.date",
            "path": "List.entry.date",
            "short": "When item added to list",
            "definition": "When this item was added to the list.",
            "requirements": "The date may be significant for understanding the meaning of items in a working list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "List.entry.item",
            "path": "List.entry.item",
            "short": "Actual entry",
            "definition": "A reference to the actual resource from which data was derived.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "List.emptyReason",
            "path": "List.emptyReason",
            "short": "Why list is empty",
            "definition": "If the list is empty, why the list is empty.",
            "comment": "The various reasons for an empty list make a significant interpretation to its interpretation. Note that this code is for use when the entire list has been suppressed, and not for when individual items are omitted - implementers may consider using a text note or a flag on an entry in these cases.",
            "requirements": "Allows capturing things like \"none exist\" or \"not asked\" which can be important for most lists.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "lst-1"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ListEmptyReason"
                }
              ],
              "strength": "preferred",
              "description": "If a list is empty, why it is empty.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-empty-reason"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'List'
    /// </summary>
    // 0. List
    public class List : FhirKhit.Maker.Common.Resource.ResourceBase                                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class List_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                            // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 12. List.entry
            public class Type_Entry : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Entry_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 13. List.entry.flag
                    public ElementDefinitionInfo Flag;                                                                                      // MakerGen.cs:236
                    // 14. List.entry.deleted
                    public ElementDefinitionInfo Deleted;                                                                                   // MakerGen.cs:236
                    // 15. List.entry.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 16. List.entry.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:236
                    public Type_Entry_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. List.entry.flag
                            this.Flag = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Flag",                                                                                              // MakerGen.cs:255
                                Path= "List.entry.flag",                                                                                    // MakerGen.cs:256
                                Id = "List.entry.flag",                                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. List.entry.deleted
                            this.Deleted = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Deleted",                                                                                           // MakerGen.cs:255
                                Path= "List.entry.deleted",                                                                                 // MakerGen.cs:256
                                Id = "List.entry.deleted",                                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. List.entry.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "List.entry.date",                                                                                    // MakerGen.cs:256
                                Id = "List.entry.date",                                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. List.entry.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Item",                                                                                              // MakerGen.cs:255
                                Path= "List.entry.item",                                                                                    // MakerGen.cs:256
                                Id = "List.entry.item",                                                                                     // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Flag.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Deleted.Write(sDef);                                                                                                // MakerGen.cs:240
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Entry_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Entry()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Entry_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. List.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. List.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. List.mode
            public ElementDefinitionInfo Mode;                                                                                              // MakerGen.cs:236
            // 4. List.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:236
            // 5. List.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 6. List.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 7. List.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 8. List.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:236
            // 9. List.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:236
            // 10. List.orderedBy
            public ElementDefinitionInfo OrderedBy;                                                                                         // MakerGen.cs:236
            // 11. List.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            // 17. List.emptyReason
            public ElementDefinitionInfo EmptyReason;                                                                                       // MakerGen.cs:236
            public List_Elements()                                                                                                          // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. List.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "List.identifier",                                                                                            // MakerGen.cs:256
                        Id = "List.identifier",                                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. List.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "List.status",                                                                                                // MakerGen.cs:256
                        Id = "List.status",                                                                                                 // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. List.mode
                    this.Mode = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Mode",                                                                                                      // MakerGen.cs:255
                        Path= "List.mode",                                                                                                  // MakerGen.cs:256
                        Id = "List.mode",                                                                                                   // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. List.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Title",                                                                                                     // MakerGen.cs:255
                        Path= "List.title",                                                                                                 // MakerGen.cs:256
                        Id = "List.title",                                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. List.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "List.code",                                                                                                  // MakerGen.cs:256
                        Id = "List.code",                                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. List.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "List.subject",                                                                                               // MakerGen.cs:256
                        Id = "List.subject",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. List.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "List.encounter",                                                                                             // MakerGen.cs:256
                        Id = "List.encounter",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. List.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Date",                                                                                                      // MakerGen.cs:255
                        Path= "List.date",                                                                                                  // MakerGen.cs:256
                        Id = "List.date",                                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. List.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Source",                                                                                                    // MakerGen.cs:255
                        Path= "List.source",                                                                                                // MakerGen.cs:256
                        Id = "List.source",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. List.orderedBy
                    this.OrderedBy = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OrderedBy",                                                                                                 // MakerGen.cs:255
                        Path= "List.orderedBy",                                                                                             // MakerGen.cs:256
                        Id = "List.orderedBy",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. List.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "List.note",                                                                                                  // MakerGen.cs:256
                        Id = "List.note",                                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 17. List.emptyReason
                    this.EmptyReason = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "EmptyReason",                                                                                               // MakerGen.cs:255
                        Path= "List.emptyReason",                                                                                           // MakerGen.cs:256
                        Id = "List.emptyReason",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Mode.Write(sDef);                                                                                                           // MakerGen.cs:240
                Title.Write(sDef);                                                                                                          // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                Date.Write(sDef);                                                                                                           // MakerGen.cs:240
                Source.Write(sDef);                                                                                                         // MakerGen.cs:240
                OrderedBy.Write(sDef);                                                                                                      // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
                EmptyReason.Write(sDef);                                                                                                    // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public List_Elements Elements { get; }                                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public List()                                                                                                                       // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new List_Elements();                                                                                            // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
