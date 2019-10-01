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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'List'
    /// </summary>
    // 0. List
    public class Resource_List : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 12. List.entry
        public class Type_Entry : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 13. List.entry.flag
            public ElementDefinitionInfo Element_Flag;                                                                                      // MakerGen.cs:212
            // 14. List.entry.deleted
            public ElementDefinitionInfo Element_Deleted;                                                                                   // MakerGen.cs:212
            // 15. List.entry.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:212
            // 16. List.entry.item
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "List.entry",                                                                                                    // MakerGen.cs:388
                    ElementId = "List.entry"                                                                                                // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Flag.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Deleted.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Entry()                                                                                                             // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. List.entry.flag
                    this.Element_Flag = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Flag",                                                                                              // MakerGen.cs:231
                        Path= "List.entry.flag",                                                                                            // MakerGen.cs:232
                        Id = "List.entry.flag",                                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. List.entry.deleted
                    this.Element_Deleted = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Deleted",                                                                                           // MakerGen.cs:231
                        Path= "List.entry.deleted",                                                                                         // MakerGen.cs:232
                        Id = "List.entry.deleted",                                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. List.entry.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Date",                                                                                              // MakerGen.cs:231
                        Path= "List.entry.date",                                                                                            // MakerGen.cs:232
                        Id = "List.entry.date",                                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. List.entry.item
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Item",                                                                                              // MakerGen.cs:231
                        Path= "List.entry.item",                                                                                            // MakerGen.cs:232
                        Id = "List.entry.item",                                                                                             // MakerGen.cs:233
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
        // 1. List.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. List.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. List.mode
        public ElementDefinitionInfo Element_Mode;                                                                                          // MakerGen.cs:212
        // 4. List.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:212
        // 5. List.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 6. List.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 7. List.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 8. List.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 9. List.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:212
        // 10. List.orderedBy
        public ElementDefinitionInfo Element_OrderedBy;                                                                                     // MakerGen.cs:212
        // 11. List.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 12. List.entry
        public ElementDefinitionInfo Element_Entry;                                                                                         // MakerGen.cs:212
        // 17. List.emptyReason
        public ElementDefinitionInfo Element_EmptyReason;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "List",                                                                                                              // MakerGen.cs:388
                ElementId = "List"                                                                                                          // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Mode.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Title.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_OrderedBy.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Entry.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_EmptyReason.Write(sDef);                                                                                                // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_List()                                                                                                              // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. List.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "List.identifier",                                                                                                // MakerGen.cs:232
                    Id = "List.identifier",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. List.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "List.status",                                                                                                    // MakerGen.cs:232
                    Id = "List.status",                                                                                                     // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. List.mode
                this.Element_Mode = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Mode",                                                                                                  // MakerGen.cs:231
                    Path= "List.mode",                                                                                                      // MakerGen.cs:232
                    Id = "List.mode",                                                                                                       // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. List.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:231
                    Path= "List.title",                                                                                                     // MakerGen.cs:232
                    Id = "List.title",                                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. List.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "List.code",                                                                                                      // MakerGen.cs:232
                    Id = "List.code",                                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. List.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "List.subject",                                                                                                   // MakerGen.cs:232
                    Id = "List.subject",                                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. List.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "List.encounter",                                                                                                 // MakerGen.cs:232
                    Id = "List.encounter",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. List.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "List.date",                                                                                                      // MakerGen.cs:232
                    Id = "List.date",                                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. List.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Source",                                                                                                // MakerGen.cs:231
                    Path= "List.source",                                                                                                    // MakerGen.cs:232
                    Id = "List.source",                                                                                                     // MakerGen.cs:233
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
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. List.orderedBy
                this.Element_OrderedBy = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_OrderedBy",                                                                                             // MakerGen.cs:231
                    Path= "List.orderedBy",                                                                                                 // MakerGen.cs:232
                    Id = "List.orderedBy",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. List.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "List.note",                                                                                                      // MakerGen.cs:232
                    Id = "List.note",                                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. List.entry
                this.Element_Entry = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Entry",                                                                                                 // MakerGen.cs:231
                    Path= "List.entry",                                                                                                     // MakerGen.cs:232
                    Id = "List.entry",                                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Entry                                                                                                      // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. List.emptyReason
                this.Element_EmptyReason = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_EmptyReason",                                                                                           // MakerGen.cs:231
                    Path= "List.emptyReason",                                                                                               // MakerGen.cs:232
                    Id = "List.emptyReason",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "List";                                                                                                             // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/List";                                                                      // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
