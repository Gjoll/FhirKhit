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
    #endregion
    /// <summary>
    /// Fhir resource 'Linkage'
    /// </summary>
    // 0. Linkage
    public partial class Resource_Linkage : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 3. Linkage.item
        public partial class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 4. Linkage.item.type
            public ElementDefinitionInfo Element_Type;
            // 5. Linkage.item.resource
            public ElementDefinitionInfo Element_Resource;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Linkage.item",
                    ElementId = "Linkage.item"
                });
                Element_Type.Write(sDef);
                Element_Resource.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 4. Linkage.item.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Linkage.item.type",
                        Id = "Linkage.item.type",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 5. Linkage.item.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "Linkage.item.resource",
                        Id = "Linkage.item.resource",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. Linkage.active
        public ElementDefinitionInfo Element_Active;
        // 2. Linkage.author
        public ElementDefinitionInfo Element_Author;
        // 3. Linkage.item
        public ElementDefinitionInfo Element_Item;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Linkage",
                ElementId = "Linkage"
            });
            Element_Active.Write(sDef);
            Element_Author.Write(sDef);
            Element_Item.Write(sDef);
        }
        
        public Resource_Linkage()
        {
            {
                // 1. Linkage.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "Linkage.active",
                    Id = "Linkage.active",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 2. Linkage.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "Linkage.author",
                    Id = "Linkage.author",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 3. Linkage.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "Linkage.item",
                    Id = "Linkage.item",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Item
                        {
                        }
                    }
                };
            }
            this.Name = "Linkage";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Linkage";
        }
    }
}
