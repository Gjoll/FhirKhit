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
      "id": "Group",
      "url": "http://hl7.org/fhir/StructureDefinition/Group",
      "version": "4.0.0",
      "name": "Group",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively, and are not formally or legally recognized; i.e. a collection of entities that isn't an Organization.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Group",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Group",
            "path": "Group",
            "short": "Group of multiple entities",
            "definition": "Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively, and are not formally or legally recognized; i.e. a collection of entities that isn't an Organization.",
            "comment": "If both Group.characteristic and Group.member are present, then the members are the individuals who were found who met the characteristic.  It's possible that there might be other candidate members who meet the characteristic and aren't (yet) in the list.  All members SHALL have the listed characteristics.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Group.identifier",
            "path": "Group.identifier",
            "short": "Unique id",
            "definition": "A unique business identifier for this group.",
            "requirements": "Allows the group to be referenced from external specifications.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Group.active",
            "path": "Group.active",
            "short": "Whether this group's record is in active use",
            "definition": "Indicates whether the record for the group is available for use or is merely being retained for historical purposes.",
            "requirements": "Need to be able to mark a group record as not to be used because it was created in error or is otherwise no longer available (e.g. a herd that no longer exists).",
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
            "id": "Group.type",
            "path": "Group.type",
            "short": "person | animal | practitioner | device | medication | substance",
            "definition": "Identifies the broad classification of the kind of resources the group includes.",
            "comment": "Group members SHALL be of the appropriate resource type (Patient for person or animal; or Practitioner, Device, Medication or Substance for the other types.).",
            "requirements": "Identifies what type of resources the group is made up of.",
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
                  "valueString": "GroupType"
                }
              ],
              "strength": "required",
              "description": "Types of resources that are part of group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/group-type|4.0.0"
            }
          },
          {
            "id": "Group.actual",
            "path": "Group.actual",
            "short": "Descriptive or actual",
            "definition": "If true, indicates that the resource refers to a specific group of real individuals.  If false, the group defines a set of intended individuals.",
            "requirements": "There are use-cases for groups that define specific collections of individuals, and other groups that define \"types\" of intended individuals.  The requirements for both kinds of groups are similar, so we use a single resource, distinguished by this flag.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "condition": [
              "grp-1"
            ],
            "isSummary": true
          },
          {
            "id": "Group.code",
            "path": "Group.code",
            "short": "Kind of Group members",
            "definition": "Provides a specific type of resource the group includes; e.g. \"cow\", \"syringe\", etc.",
            "comment": "This would generally be omitted for Person resources.",
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
                  "valueString": "GroupKind"
                }
              ],
              "strength": "example",
              "description": "Kind of particular resource; e.g. cow, syringe, lake, etc."
            }
          },
          {
            "id": "Group.name",
            "path": "Group.name",
            "short": "Label for Group",
            "definition": "A label assigned to the group for human identification and communication.",
            "requirements": "Used to identify the group in human communication.",
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
            "id": "Group.quantity",
            "path": "Group.quantity",
            "short": "Number of members",
            "definition": "A count of the number of resource instances that are part of the group.",
            "comment": "Note that the quantity may be less than the number of members if some of the members are not active.",
            "requirements": "Group size is a common defining characteristic.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Group.managingEntity",
            "path": "Group.managingEntity",
            "short": "Entity that is the custodian of the Group's definition",
            "definition": "Entity responsible for defining and maintaining Group characteristics and/or registered members.",
            "comment": "This does not strictly align with ownership of a herd or flock, but may suffice to represent that relationship in simple cases. More complex cases will require an extension.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Group.characteristic",
            "path": "Group.characteristic",
            "short": "Include / Exclude group members by Trait",
            "definition": "Identifies traits whose presence r absence is shared by members of the group.",
            "comment": "All the identified characteristics must be true for an entity to a member of the group.",
            "requirements": "Needs to be a generic mechanism for identifying what individuals can be part of a group.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Group.characteristic.code",
            "path": "Group.characteristic.code",
            "short": "Kind of characteristic",
            "definition": "A code that identifies the kind of trait being asserted.",
            "requirements": "Need a formal way of identifying the characteristic being described.",
            "min": 1,
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
                  "valueString": "GroupCharacteristicKind"
                }
              ],
              "strength": "example",
              "description": "List of characteristics used to describe group members; e.g. gender, age, owner, location, etc."
            }
          },
          {
            "id": "Group.characteristic.value[x]",
            "path": "Group.characteristic.value[x]",
            "short": "Value held by characteristic",
            "definition": "The value of the trait that holds (or does not hold - see 'exclude') for members of the group.",
            "comment": "For Range, it means members of the group have a value that falls somewhere within the specified range.",
            "requirements": "The value of the characteristic is what determines group membership.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "boolean"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Reference"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GroupCharacteristicValue"
                }
              ],
              "strength": "example",
              "description": "Value of descriptive member characteristic; e.g. red, male, pneumonia, Caucasian, etc."
            }
          },
          {
            "id": "Group.characteristic.exclude",
            "path": "Group.characteristic.exclude",
            "short": "Group includes or excludes",
            "definition": "If true, indicates the characteristic is one that is NOT held by members of the group.",
            "comment": "This is labeled as \"Is Modifier\" because applications cannot wrongly include excluded members as included or vice versa.",
            "requirements": "Sometimes group membership is determined by characteristics not possessed.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Group.characteristic.period",
            "path": "Group.characteristic.period",
            "short": "Period over which characteristic is tested",
            "definition": "The period over which the characteristic is tested; e.g. the patient had an operation during the month of June.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Group.member",
            "path": "Group.member",
            "short": "Who or what is in group",
            "definition": "Identifies the resource instances that are members of the group.",
            "requirements": "Often the only thing of interest about a group is \"who's in it\".",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "grp-1"
            ]
          },
          {
            "id": "Group.member.entity",
            "path": "Group.member.entity",
            "short": "Reference to the group member",
            "definition": "A reference to the entity that is a member of the group. Must be consistent with Group.type. If the entity is another group, then the type must be the same.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ]
          },
          {
            "id": "Group.member.period",
            "path": "Group.member.period",
            "short": "Period member belonged to the group",
            "definition": "The period that the member was in the group, if known.",
            "requirements": "Need to track who was in a group at a  particular time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "meaningWhenMissing": "The member is in the group at this time"
          },
          {
            "id": "Group.member.inactive",
            "path": "Group.member.inactive",
            "short": "If member is no longer in group",
            "definition": "A flag to indicate that the member is no longer in the group, but previously may have been a member.",
            "requirements": "Sometimes you don't know when someone stopped being in a group, but not when.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "Members are considered active unless explicitly specified otherwise"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Group'
    /// </summary>
    // 0. Group
    public class Resource_Group : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                    // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 9. Group.characteristic
        public class Type_Characteristic : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 10. Group.characteristic.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 11. Group.characteristic.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
            // 12. Group.characteristic.exclude
            public ElementDefinitionInfo Element_Exclude;                                                                                   // MakerGen.cs:219
            // 13. Group.characteristic.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Group.characteristic",                                                                                          // MakerGen.cs:395
                    ElementId = "Group.characteristic"                                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Exclude.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Characteristic()                                                                                                    // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 10. Group.characteristic.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "Group.characteristic.code",                                                                                  // MakerGen.cs:239
                        Id = "Group.characteristic.code",                                                                                   // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 11. Group.characteristic.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "Group.characteristic.value[x]",                                                                              // MakerGen.cs:239
                        Id = "Group.characteristic.value[x]",                                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:322
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            },                                                                                                              // MakerGen.cs:307
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. Group.characteristic.exclude
                    this.Element_Exclude = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Exclude",                                                                                           // MakerGen.cs:238
                        Path= "Group.characteristic.exclude",                                                                               // MakerGen.cs:239
                        Id = "Group.characteristic.exclude",                                                                                // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. Group.characteristic.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Period",                                                                                            // MakerGen.cs:238
                        Path= "Group.characteristic.period",                                                                                // MakerGen.cs:239
                        Id = "Group.characteristic.period",                                                                                 // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 14. Group.member
        public class Type_Member : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 15. Group.member.entity
            public ElementDefinitionInfo Element_Entity;                                                                                    // MakerGen.cs:219
            // 16. Group.member.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:219
            // 17. Group.member.inactive
            public ElementDefinitionInfo Element_Inactive;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Group.member",                                                                                                  // MakerGen.cs:395
                    ElementId = "Group.member"                                                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Entity.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Inactive.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Member()                                                                                                            // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 15. Group.member.entity
                    this.Element_Entity = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Entity",                                                                                            // MakerGen.cs:238
                        Path= "Group.member.entity",                                                                                        // MakerGen.cs:239
                        Id = "Group.member.entity",                                                                                         // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. Group.member.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Period",                                                                                            // MakerGen.cs:238
                        Path= "Group.member.period",                                                                                        // MakerGen.cs:239
                        Id = "Group.member.period",                                                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. Group.member.inactive
                    this.Element_Inactive = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Inactive",                                                                                          // MakerGen.cs:238
                        Path= "Group.member.inactive",                                                                                      // MakerGen.cs:239
                        Id = "Group.member.inactive",                                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Group.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Group.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:219
        // 3. Group.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 4. Group.actual
        public ElementDefinitionInfo Element_Actual;                                                                                        // MakerGen.cs:219
        // 5. Group.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:219
        // 6. Group.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 7. Group.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:219
        // 8. Group.managingEntity
        public ElementDefinitionInfo Element_ManagingEntity;                                                                                // MakerGen.cs:219
        // 9. Group.characteristic
        public ElementDefinitionInfo Element_Characteristic;                                                                                // MakerGen.cs:219
        // 14. Group.member
        public ElementDefinitionInfo Element_Member;                                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Group",                                                                                                             // MakerGen.cs:395
                ElementId = "Group"                                                                                                         // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Actual.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_ManagingEntity.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_Characteristic.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_Member.Write(sDef);                                                                                                     // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Group()                                                                                                             // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Group.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Group.identifier",                                                                                               // MakerGen.cs:239
                    Id = "Group.identifier",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Group.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Active",                                                                                                // MakerGen.cs:238
                    Path= "Group.active",                                                                                                   // MakerGen.cs:239
                    Id = "Group.active",                                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Group.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "Group.type",                                                                                                     // MakerGen.cs:239
                    Id = "Group.type",                                                                                                      // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Group.actual
                this.Element_Actual = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Actual",                                                                                                // MakerGen.cs:238
                    Path= "Group.actual",                                                                                                   // MakerGen.cs:239
                    Id = "Group.actual",                                                                                                    // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Group.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:238
                    Path= "Group.code",                                                                                                     // MakerGen.cs:239
                    Id = "Group.code",                                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Group.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "Group.name",                                                                                                     // MakerGen.cs:239
                    Id = "Group.name",                                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Group.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:238
                    Path= "Group.quantity",                                                                                                 // MakerGen.cs:239
                    Id = "Group.quantity",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                                           // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Group.managingEntity
                this.Element_ManagingEntity = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ManagingEntity",                                                                                        // MakerGen.cs:238
                    Path= "Group.managingEntity",                                                                                           // MakerGen.cs:239
                    Id = "Group.managingEntity",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. Group.characteristic
                this.Element_Characteristic = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Characteristic",                                                                                        // MakerGen.cs:238
                    Path= "Group.characteristic",                                                                                           // MakerGen.cs:239
                    Id = "Group.characteristic",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Characteristic                                                                                             // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. Group.member
                this.Element_Member = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Member",                                                                                                // MakerGen.cs:238
                    Path= "Group.member",                                                                                                   // MakerGen.cs:239
                    Id = "Group.member",                                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Member                                                                                                     // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Group";                                                                                                            // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Group";                                                                     // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
