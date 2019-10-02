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
      "id": "CatalogEntry",
      "url": "http://hl7.org/fhir/StructureDefinition/CatalogEntry",
      "version": "4.0.0",
      "name": "CatalogEntry",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Catalog entries are wrappers that contextualize items included in a catalog.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CatalogEntry",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CatalogEntry",
            "path": "CatalogEntry",
            "short": "An entry in a catalog",
            "definition": "Catalog entries are wrappers that contextualize items included in a catalog.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CatalogEntry.identifier",
            "path": "CatalogEntry.identifier",
            "short": "Unique identifier of the catalog item",
            "definition": "Used in supporting different identifiers for the same product, e.g. manufacturer code and retailer code.",
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
            "id": "CatalogEntry.type",
            "path": "CatalogEntry.type",
            "short": "The type of item - medication, device, service, protocol or other",
            "definition": "The type of item - medication, device, service, protocol or other.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.orderable",
            "path": "CatalogEntry.orderable",
            "short": "Whether the entry represents an orderable item",
            "definition": "Whether the entry represents an orderable item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CatalogEntry.referencedItem",
            "path": "CatalogEntry.referencedItem",
            "short": "The item that is being defined",
            "definition": "The item in a catalog or definition.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Binary"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CatalogEntry.additionalIdentifier",
            "path": "CatalogEntry.additionalIdentifier",
            "short": "Any additional identifier(s) for the catalog item, in the same granularity or concept",
            "definition": "Used in supporting related concepts, e.g. NDC to RxNorm.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "CatalogEntry.classification",
            "path": "CatalogEntry.classification",
            "short": "Classification (category or class) of the item entry",
            "definition": "Classes of devices, or ATC for medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.status",
            "path": "CatalogEntry.status",
            "short": "draft | active | retired | unknown",
            "definition": "Used to support catalog exchange even for unsupported products, e.g. getting list of medications even if not prescribable.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PublicationStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The lifecycle status of an artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/publication-status|4.0.0"
            }
          },
          {
            "id": "CatalogEntry.validityPeriod",
            "path": "CatalogEntry.validityPeriod",
            "short": "The time period in which this catalog entry is expected to be active",
            "definition": "The time period in which this catalog entry is expected to be active.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "CatalogEntry.validTo",
            "path": "CatalogEntry.validTo",
            "short": "The date until which this catalog entry is expected to be active",
            "definition": "The date until which this catalog entry is expected to be active.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "CatalogEntry.lastUpdated",
            "path": "CatalogEntry.lastUpdated",
            "short": "When was this catalog last updated",
            "definition": "Typically date of issue is different from the beginning of the validity. This can be used to see when an item was last updated.",
            "comment": "Perhaps not needed - if we use fhir resource metadata.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "CatalogEntry.additionalCharacteristic",
            "path": "CatalogEntry.additionalCharacteristic",
            "short": "Additional characteristics of the catalog entry",
            "definition": "Used for examplefor Out of Formulary, or any specifics.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.additionalClassification",
            "path": "CatalogEntry.additionalClassification",
            "short": "Additional classification of the catalog entry",
            "definition": "User for example for ATC classification, or.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "CatalogEntry.relatedEntry",
            "path": "CatalogEntry.relatedEntry",
            "short": "An item that this catalog entry is related to",
            "definition": "Used for example, to point to a substance, or to a device used to administer a medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CatalogEntry.relatedEntry.relationtype",
            "path": "CatalogEntry.relatedEntry.relationtype",
            "short": "triggers | is-replaced-by",
            "definition": "The type of relation to the related item: child, parent, packageContent, containerPackage, usedIn, uses, requires, etc.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CatalogEntryRelationType"
                }
              ],
              "strength": "required",
              "description": "The type of relations between entries.",
              "valueSet": "http://hl7.org/fhir/ValueSet/relation-type|4.0.0"
            }
          },
          {
            "id": "CatalogEntry.relatedEntry.item",
            "path": "CatalogEntry.relatedEntry.item",
            "short": "The reference to the related item",
            "definition": "The reference to the related item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CatalogEntry"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'CatalogEntry'
    /// </summary>
    // 0. CatalogEntry
    public partial class Resource_CatalogEntry : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 13. CatalogEntry.relatedEntry
        public partial class Type_RelatedEntry : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. CatalogEntry.relatedEntry.relationtype
            public ElementDefinitionInfo Element_Relationtype;
            // 15. CatalogEntry.relatedEntry.item
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CatalogEntry.relatedEntry",
                    ElementId = "CatalogEntry.relatedEntry"
                });
                Element_Relationtype.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_RelatedEntry()
            {
                {
                    // 14. CatalogEntry.relatedEntry.relationtype
                    this.Element_Relationtype = new ElementDefinitionInfo
                    {
                        Name = "Element_Relationtype",
                        Path= "CatalogEntry.relatedEntry.relationtype",
                        Id = "CatalogEntry.relatedEntry.relationtype",
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
                    // 15. CatalogEntry.relatedEntry.item
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "CatalogEntry.relatedEntry.item",
                        Id = "CatalogEntry.relatedEntry.item",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/CatalogEntry"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. CatalogEntry.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. CatalogEntry.type
        public ElementDefinitionInfo Element_Type;
        // 3. CatalogEntry.orderable
        public ElementDefinitionInfo Element_Orderable;
        // 4. CatalogEntry.referencedItem
        public ElementDefinitionInfo Element_ReferencedItem;
        // 5. CatalogEntry.additionalIdentifier
        public ElementDefinitionInfo Element_AdditionalIdentifier;
        // 6. CatalogEntry.classification
        public ElementDefinitionInfo Element_Classification;
        // 7. CatalogEntry.status
        public ElementDefinitionInfo Element_Status;
        // 8. CatalogEntry.validityPeriod
        public ElementDefinitionInfo Element_ValidityPeriod;
        // 9. CatalogEntry.validTo
        public ElementDefinitionInfo Element_ValidTo;
        // 10. CatalogEntry.lastUpdated
        public ElementDefinitionInfo Element_LastUpdated;
        // 11. CatalogEntry.additionalCharacteristic
        public ElementDefinitionInfo Element_AdditionalCharacteristic;
        // 12. CatalogEntry.additionalClassification
        public ElementDefinitionInfo Element_AdditionalClassification;
        // 13. CatalogEntry.relatedEntry
        public ElementDefinitionInfo Element_RelatedEntry;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "CatalogEntry",
                ElementId = "CatalogEntry"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_Orderable.Write(sDef);
            Element_ReferencedItem.Write(sDef);
            Element_AdditionalIdentifier.Write(sDef);
            Element_Classification.Write(sDef);
            Element_Status.Write(sDef);
            Element_ValidityPeriod.Write(sDef);
            Element_ValidTo.Write(sDef);
            Element_LastUpdated.Write(sDef);
            Element_AdditionalCharacteristic.Write(sDef);
            Element_AdditionalClassification.Write(sDef);
            Element_RelatedEntry.Write(sDef);
        }
        
        public Resource_CatalogEntry()
        {
            {
                // 1. CatalogEntry.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "CatalogEntry.identifier",
                    Id = "CatalogEntry.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. CatalogEntry.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "CatalogEntry.type",
                    Id = "CatalogEntry.type",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 3. CatalogEntry.orderable
                this.Element_Orderable = new ElementDefinitionInfo
                {
                    Name = "Element_Orderable",
                    Path= "CatalogEntry.orderable",
                    Id = "CatalogEntry.orderable",
                    Min = 1,
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
                // 4. CatalogEntry.referencedItem
                this.Element_ReferencedItem = new ElementDefinitionInfo
                {
                    Name = "Element_ReferencedItem",
                    Path= "CatalogEntry.referencedItem",
                    Id = "CatalogEntry.referencedItem",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Medication",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                                "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition",
                                "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",
                                "http://hl7.org/fhir/StructureDefinition/Binary"
                            }
                        }
                    }
                };
            }
            {
                // 5. CatalogEntry.additionalIdentifier
                this.Element_AdditionalIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_AdditionalIdentifier",
                    Path= "CatalogEntry.additionalIdentifier",
                    Id = "CatalogEntry.additionalIdentifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 6. CatalogEntry.classification
                this.Element_Classification = new ElementDefinitionInfo
                {
                    Name = "Element_Classification",
                    Path= "CatalogEntry.classification",
                    Id = "CatalogEntry.classification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 7. CatalogEntry.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "CatalogEntry.status",
                    Id = "CatalogEntry.status",
                    Min = 0,
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
                // 8. CatalogEntry.validityPeriod
                this.Element_ValidityPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_ValidityPeriod",
                    Path= "CatalogEntry.validityPeriod",
                    Id = "CatalogEntry.validityPeriod",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 9. CatalogEntry.validTo
                this.Element_ValidTo = new ElementDefinitionInfo
                {
                    Name = "Element_ValidTo",
                    Path= "CatalogEntry.validTo",
                    Id = "CatalogEntry.validTo",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 10. CatalogEntry.lastUpdated
                this.Element_LastUpdated = new ElementDefinitionInfo
                {
                    Name = "Element_LastUpdated",
                    Path= "CatalogEntry.lastUpdated",
                    Id = "CatalogEntry.lastUpdated",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 11. CatalogEntry.additionalCharacteristic
                this.Element_AdditionalCharacteristic = new ElementDefinitionInfo
                {
                    Name = "Element_AdditionalCharacteristic",
                    Path= "CatalogEntry.additionalCharacteristic",
                    Id = "CatalogEntry.additionalCharacteristic",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 12. CatalogEntry.additionalClassification
                this.Element_AdditionalClassification = new ElementDefinitionInfo
                {
                    Name = "Element_AdditionalClassification",
                    Path= "CatalogEntry.additionalClassification",
                    Id = "CatalogEntry.additionalClassification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 13. CatalogEntry.relatedEntry
                this.Element_RelatedEntry = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedEntry",
                    Path= "CatalogEntry.relatedEntry",
                    Id = "CatalogEntry.relatedEntry",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_RelatedEntry
                        {
                        }
                    }
                };
            }
            this.Name = "CatalogEntry";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CatalogEntry";
        }
    }
}
