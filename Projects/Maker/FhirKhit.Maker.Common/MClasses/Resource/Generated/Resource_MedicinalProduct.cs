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
      "id": "MedicinalProduct",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
      "version": "4.0.0",
      "name": "MedicinalProduct",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProduct",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProduct",
            "path": "MedicinalProduct",
            "short": "Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use)",
            "definition": "Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProduct.identifier",
            "path": "MedicinalProduct.identifier",
            "short": "Business identifier for this product. Could be an MPID",
            "definition": "Business identifier for this product. Could be an MPID.",
            "alias": [
              "MPID"
            ],
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
            "id": "MedicinalProduct.type",
            "path": "MedicinalProduct.type",
            "short": "Regulatory type, e.g. Investigational or Authorized",
            "definition": "Regulatory type, e.g. Investigational or Authorized.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.domain",
            "path": "MedicinalProduct.domain",
            "short": "If this medicine applies to human or veterinary uses",
            "definition": "If this medicine applies to human or veterinary uses.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.combinedPharmaceuticalDoseForm",
            "path": "MedicinalProduct.combinedPharmaceuticalDoseForm",
            "short": "The dose form for a single part product, or combined form of a multiple part product",
            "definition": "The dose form for a single part product, or combined form of a multiple part product.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.legalStatusOfSupply",
            "path": "MedicinalProduct.legalStatusOfSupply",
            "short": "The legal status of supply of the medicinal product as classified by the regulator",
            "definition": "The legal status of supply of the medicinal product as classified by the regulator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.additionalMonitoringIndicator",
            "path": "MedicinalProduct.additionalMonitoringIndicator",
            "short": "Whether the Medicinal Product is subject to additional monitoring for regulatory reasons",
            "definition": "Whether the Medicinal Product is subject to additional monitoring for regulatory reasons.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialMeasures",
            "path": "MedicinalProduct.specialMeasures",
            "short": "Whether the Medicinal Product is subject to special measures for regulatory reasons",
            "definition": "Whether the Medicinal Product is subject to special measures for regulatory reasons.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.paediatricUseIndicator",
            "path": "MedicinalProduct.paediatricUseIndicator",
            "short": "If authorised for use in children",
            "definition": "If authorised for use in children.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.productClassification",
            "path": "MedicinalProduct.productClassification",
            "short": "Allows the product to be classified by various systems",
            "definition": "Allows the product to be classified by various systems.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.marketingStatus",
            "path": "MedicinalProduct.marketingStatus",
            "short": "Marketing status of the medicinal product, in contrast to marketing authorizaton",
            "definition": "Marketing status of the medicinal product, in contrast to marketing authorizaton.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "MarketingStatus"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.pharmaceuticalProduct",
            "path": "MedicinalProduct.pharmaceuticalProduct",
            "short": "Pharmaceutical aspects of product",
            "definition": "Pharmaceutical aspects of product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.packagedMedicinalProduct",
            "path": "MedicinalProduct.packagedMedicinalProduct",
            "short": "Package representation for the product",
            "definition": "Package representation for the product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.attachedDocument",
            "path": "MedicinalProduct.attachedDocument",
            "short": "Supporting documentation, typically for regulatory submission",
            "definition": "Supporting documentation, typically for regulatory submission.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.masterFile",
            "path": "MedicinalProduct.masterFile",
            "short": "A master file for to the medicinal product (e.g. Pharmacovigilance System Master File)",
            "definition": "A master file for to the medicinal product (e.g. Pharmacovigilance System Master File).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.contact",
            "path": "MedicinalProduct.contact",
            "short": "A product specific contact, person (in a role), or an organization",
            "definition": "A product specific contact, person (in a role), or an organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.clinicalTrial",
            "path": "MedicinalProduct.clinicalTrial",
            "short": "Clinical trials or studies that this product is involved in",
            "definition": "Clinical trials or studies that this product is involved in.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name",
            "path": "MedicinalProduct.name",
            "short": "The product's name, including full name and possibly coded parts",
            "definition": "The product's name, including full name and possibly coded parts.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.productName",
            "path": "MedicinalProduct.name.productName",
            "short": "The full product name",
            "definition": "The full product name.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.namePart",
            "path": "MedicinalProduct.name.namePart",
            "short": "Coding words or phrases of the name",
            "definition": "Coding words or phrases of the name.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.namePart.part",
            "path": "MedicinalProduct.name.namePart.part",
            "short": "A fragment of a product name",
            "definition": "A fragment of a product name.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.namePart.type",
            "path": "MedicinalProduct.name.namePart.type",
            "short": "Idenifying type for this part of the name (e.g. strength part)",
            "definition": "Idenifying type for this part of the name (e.g. strength part).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.countryLanguage",
            "path": "MedicinalProduct.name.countryLanguage",
            "short": "Country where the name applies",
            "definition": "Country where the name applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.countryLanguage.country",
            "path": "MedicinalProduct.name.countryLanguage.country",
            "short": "Country code for where this name applies",
            "definition": "Country code for where this name applies.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.countryLanguage.jurisdiction",
            "path": "MedicinalProduct.name.countryLanguage.jurisdiction",
            "short": "Jurisdiction code for where this name applies",
            "definition": "Jurisdiction code for where this name applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.name.countryLanguage.language",
            "path": "MedicinalProduct.name.countryLanguage.language",
            "short": "Language code for this name",
            "definition": "Language code for this name.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.crossReference",
            "path": "MedicinalProduct.crossReference",
            "short": "Reference to another product, e.g. for linking authorised to investigational product",
            "definition": "Reference to another product, e.g. for linking authorised to investigational product.",
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
            "id": "MedicinalProduct.manufacturingBusinessOperation",
            "path": "MedicinalProduct.manufacturingBusinessOperation",
            "short": "An operation applied to the product, for manufacturing or adminsitrative purpose",
            "definition": "An operation applied to the product, for manufacturing or adminsitrative purpose.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.manufacturingBusinessOperation.operationType",
            "path": "MedicinalProduct.manufacturingBusinessOperation.operationType",
            "short": "The type of manufacturing operation",
            "definition": "The type of manufacturing operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",
            "path": "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",
            "short": "Regulatory authorization reference number",
            "definition": "Regulatory authorization reference number.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",
            "path": "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",
            "short": "Regulatory authorization date",
            "definition": "Regulatory authorization date.",
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
            "id": "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",
            "path": "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",
            "short": "To indicate if this proces is commercially confidential",
            "definition": "To indicate if this proces is commercially confidential.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.manufacturingBusinessOperation.manufacturer",
            "path": "MedicinalProduct.manufacturingBusinessOperation.manufacturer",
            "short": "The manufacturer or establishment associated with the process",
            "definition": "The manufacturer or establishment associated with the process.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.manufacturingBusinessOperation.regulator",
            "path": "MedicinalProduct.manufacturingBusinessOperation.regulator",
            "short": "A regulator which oversees the operation",
            "definition": "A regulator which oversees the operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation",
            "path": "MedicinalProduct.specialDesignation",
            "short": "Indicates if the medicinal product has an orphan designation for the treatment of a rare disease",
            "definition": "Indicates if the medicinal product has an orphan designation for the treatment of a rare disease.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation.identifier",
            "path": "MedicinalProduct.specialDesignation.identifier",
            "short": "Identifier for the designation, or procedure number",
            "definition": "Identifier for the designation, or procedure number.",
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
            "id": "MedicinalProduct.specialDesignation.type",
            "path": "MedicinalProduct.specialDesignation.type",
            "short": "The type of special designation, e.g. orphan drug, minor use",
            "definition": "The type of special designation, e.g. orphan drug, minor use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation.intendedUse",
            "path": "MedicinalProduct.specialDesignation.intendedUse",
            "short": "The intended use of the product, e.g. prevention, treatment",
            "definition": "The intended use of the product, e.g. prevention, treatment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation.indication[x]",
            "path": "MedicinalProduct.specialDesignation.indication[x]",
            "short": "Condition for which the medicinal use applies",
            "definition": "Condition for which the medicinal use applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation.status",
            "path": "MedicinalProduct.specialDesignation.status",
            "short": "For example granted, pending, expired or withdrawn",
            "definition": "For example granted, pending, expired or withdrawn.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProduct.specialDesignation.date",
            "path": "MedicinalProduct.specialDesignation.date",
            "short": "Date when the designation was granted",
            "definition": "Date when the designation was granted.",
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
            "id": "MedicinalProduct.specialDesignation.species",
            "path": "MedicinalProduct.specialDesignation.species",
            "short": "Animal species for which this applies",
            "definition": "Animal species for which this applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
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
    /// Fhir resource 'MedicinalProduct'
    /// </summary>
    // 0. MedicinalProduct
    public partial class Resource_MedicinalProduct : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 17. MedicinalProduct.name
        public partial class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. MedicinalProduct.name.namePart
            public partial class Type_NamePart : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 20. MedicinalProduct.name.namePart.part
                public ElementDefinitionInfo Element_Part;
                // 21. MedicinalProduct.name.namePart.type
                public ElementDefinitionInfo Element_Type;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicinalProduct.name.namePart",
                        ElementId = "MedicinalProduct.name.namePart"
                    });
                    Element_Part.Write(sDef);
                    Element_Type.Write(sDef);
                }
                
                public Type_NamePart()
                {
                    {
                        // 20. MedicinalProduct.name.namePart.part
                        this.Element_Part = new ElementDefinitionInfo
                        {
                            Name = "Element_Part",
                            Path= "MedicinalProduct.name.namePart.part",
                            Id = "MedicinalProduct.name.namePart.part",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 21. MedicinalProduct.name.namePart.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "MedicinalProduct.name.namePart.type",
                            Id = "MedicinalProduct.name.namePart.type",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 22. MedicinalProduct.name.countryLanguage
            public partial class Type_CountryLanguage : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 23. MedicinalProduct.name.countryLanguage.country
                public ElementDefinitionInfo Element_Country;
                // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                public ElementDefinitionInfo Element_Jurisdiction;
                // 25. MedicinalProduct.name.countryLanguage.language
                public ElementDefinitionInfo Element_Language;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MedicinalProduct.name.countryLanguage",
                        ElementId = "MedicinalProduct.name.countryLanguage"
                    });
                    Element_Country.Write(sDef);
                    Element_Jurisdiction.Write(sDef);
                    Element_Language.Write(sDef);
                }
                
                public Type_CountryLanguage()
                {
                    {
                        // 23. MedicinalProduct.name.countryLanguage.country
                        this.Element_Country = new ElementDefinitionInfo
                        {
                            Name = "Element_Country",
                            Path= "MedicinalProduct.name.countryLanguage.country",
                            Id = "MedicinalProduct.name.countryLanguage.country",
                            Min = 1,
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
                        // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                        this.Element_Jurisdiction = new ElementDefinitionInfo
                        {
                            Name = "Element_Jurisdiction",
                            Path= "MedicinalProduct.name.countryLanguage.jurisdiction",
                            Id = "MedicinalProduct.name.countryLanguage.jurisdiction",
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
                        // 25. MedicinalProduct.name.countryLanguage.language
                        this.Element_Language = new ElementDefinitionInfo
                        {
                            Name = "Element_Language",
                            Path= "MedicinalProduct.name.countryLanguage.language",
                            Id = "MedicinalProduct.name.countryLanguage.language",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 18. MedicinalProduct.name.productName
            public ElementDefinitionInfo Element_ProductName;
            // 19. MedicinalProduct.name.namePart
            public ElementDefinitionInfo Element_NamePart;
            // 22. MedicinalProduct.name.countryLanguage
            public ElementDefinitionInfo Element_CountryLanguage;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProduct.name",
                    ElementId = "MedicinalProduct.name"
                });
                Element_ProductName.Write(sDef);
                Element_NamePart.Write(sDef);
                Element_CountryLanguage.Write(sDef);
            }
            
            public Type_Name()
            {
                {
                    // 18. MedicinalProduct.name.productName
                    this.Element_ProductName = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductName",
                        Path= "MedicinalProduct.name.productName",
                        Id = "MedicinalProduct.name.productName",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 19. MedicinalProduct.name.namePart
                    this.Element_NamePart = new ElementDefinitionInfo
                    {
                        Name = "Element_NamePart",
                        Path= "MedicinalProduct.name.namePart",
                        Id = "MedicinalProduct.name.namePart",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_NamePart
                            {
                            }
                        }
                    };
                }
                {
                    // 22. MedicinalProduct.name.countryLanguage
                    this.Element_CountryLanguage = new ElementDefinitionInfo
                    {
                        Name = "Element_CountryLanguage",
                        Path= "MedicinalProduct.name.countryLanguage",
                        Id = "MedicinalProduct.name.countryLanguage",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_CountryLanguage
                            {
                            }
                        }
                    };
                }
            }
        }
        // 27. MedicinalProduct.manufacturingBusinessOperation
        public partial class Type_ManufacturingBusinessOperation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
            public ElementDefinitionInfo Element_OperationType;
            // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
            public ElementDefinitionInfo Element_AuthorisationReferenceNumber;
            // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
            public ElementDefinitionInfo Element_EffectiveDate;
            // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
            public ElementDefinitionInfo Element_ConfidentialityIndicator;
            // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;
            // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
            public ElementDefinitionInfo Element_Regulator;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProduct.manufacturingBusinessOperation",
                    ElementId = "MedicinalProduct.manufacturingBusinessOperation"
                });
                Element_OperationType.Write(sDef);
                Element_AuthorisationReferenceNumber.Write(sDef);
                Element_EffectiveDate.Write(sDef);
                Element_ConfidentialityIndicator.Write(sDef);
                Element_Manufacturer.Write(sDef);
                Element_Regulator.Write(sDef);
            }
            
            public Type_ManufacturingBusinessOperation()
            {
                {
                    // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
                    this.Element_OperationType = new ElementDefinitionInfo
                    {
                        Name = "Element_OperationType",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.operationType",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.operationType",
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
                    // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
                    this.Element_AuthorisationReferenceNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_AuthorisationReferenceNumber",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
                    this.Element_EffectiveDate = new ElementDefinitionInfo
                    {
                        Name = "Element_EffectiveDate",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",
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
                    // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
                    this.Element_ConfidentialityIndicator = new ElementDefinitionInfo
                    {
                        Name = "Element_ConfidentialityIndicator",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",
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
                    // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
                    this.Element_Manufacturer = new ElementDefinitionInfo
                    {
                        Name = "Element_Manufacturer",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.manufacturer",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.manufacturer",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
                    this.Element_Regulator = new ElementDefinitionInfo
                    {
                        Name = "Element_Regulator",
                        Path= "MedicinalProduct.manufacturingBusinessOperation.regulator",
                        Id = "MedicinalProduct.manufacturingBusinessOperation.regulator",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 34. MedicinalProduct.specialDesignation
        public partial class Type_SpecialDesignation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. MedicinalProduct.specialDesignation.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 36. MedicinalProduct.specialDesignation.type
            public ElementDefinitionInfo Element_Type;
            // 37. MedicinalProduct.specialDesignation.intendedUse
            public ElementDefinitionInfo Element_IntendedUse;
            // 38. MedicinalProduct.specialDesignation.indication[x]
            public ElementDefinitionInfo Element_Indication;
            // 39. MedicinalProduct.specialDesignation.status
            public ElementDefinitionInfo Element_Status;
            // 40. MedicinalProduct.specialDesignation.date
            public ElementDefinitionInfo Element_Date;
            // 41. MedicinalProduct.specialDesignation.species
            public ElementDefinitionInfo Element_Species;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProduct.specialDesignation",
                    ElementId = "MedicinalProduct.specialDesignation"
                });
                Element_Identifier.Write(sDef);
                Element_Type.Write(sDef);
                Element_IntendedUse.Write(sDef);
                Element_Indication.Write(sDef);
                Element_Status.Write(sDef);
                Element_Date.Write(sDef);
                Element_Species.Write(sDef);
            }
            
            public Type_SpecialDesignation()
            {
                {
                    // 35. MedicinalProduct.specialDesignation.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "MedicinalProduct.specialDesignation.identifier",
                        Id = "MedicinalProduct.specialDesignation.identifier",
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
                    // 36. MedicinalProduct.specialDesignation.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicinalProduct.specialDesignation.type",
                        Id = "MedicinalProduct.specialDesignation.type",
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
                    // 37. MedicinalProduct.specialDesignation.intendedUse
                    this.Element_IntendedUse = new ElementDefinitionInfo
                    {
                        Name = "Element_IntendedUse",
                        Path= "MedicinalProduct.specialDesignation.intendedUse",
                        Id = "MedicinalProduct.specialDesignation.intendedUse",
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
                    // 38. MedicinalProduct.specialDesignation.indication[x]
                    this.Element_Indication = new ElementDefinitionInfo
                    {
                        Name = "Element_Indication",
                        Path= "MedicinalProduct.specialDesignation.indication[x]",
                        Id = "MedicinalProduct.specialDesignation.indication[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"
                                }
                            }
                        }
                    };
                }
                {
                    // 39. MedicinalProduct.specialDesignation.status
                    this.Element_Status = new ElementDefinitionInfo
                    {
                        Name = "Element_Status",
                        Path= "MedicinalProduct.specialDesignation.status",
                        Id = "MedicinalProduct.specialDesignation.status",
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
                    // 40. MedicinalProduct.specialDesignation.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "MedicinalProduct.specialDesignation.date",
                        Id = "MedicinalProduct.specialDesignation.date",
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
                    // 41. MedicinalProduct.specialDesignation.species
                    this.Element_Species = new ElementDefinitionInfo
                    {
                        Name = "Element_Species",
                        Path= "MedicinalProduct.specialDesignation.species",
                        Id = "MedicinalProduct.specialDesignation.species",
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
            }
        }
        // 1. MedicinalProduct.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicinalProduct.type
        public ElementDefinitionInfo Element_Type;
        // 3. MedicinalProduct.domain
        public ElementDefinitionInfo Element_Domain;
        // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
        public ElementDefinitionInfo Element_CombinedPharmaceuticalDoseForm;
        // 5. MedicinalProduct.legalStatusOfSupply
        public ElementDefinitionInfo Element_LegalStatusOfSupply;
        // 6. MedicinalProduct.additionalMonitoringIndicator
        public ElementDefinitionInfo Element_AdditionalMonitoringIndicator;
        // 7. MedicinalProduct.specialMeasures
        public ElementDefinitionInfo Element_SpecialMeasures;
        // 8. MedicinalProduct.paediatricUseIndicator
        public ElementDefinitionInfo Element_PaediatricUseIndicator;
        // 9. MedicinalProduct.productClassification
        public ElementDefinitionInfo Element_ProductClassification;
        // 10. MedicinalProduct.marketingStatus
        public ElementDefinitionInfo Element_MarketingStatus;
        // 11. MedicinalProduct.pharmaceuticalProduct
        public ElementDefinitionInfo Element_PharmaceuticalProduct;
        // 12. MedicinalProduct.packagedMedicinalProduct
        public ElementDefinitionInfo Element_PackagedMedicinalProduct;
        // 13. MedicinalProduct.attachedDocument
        public ElementDefinitionInfo Element_AttachedDocument;
        // 14. MedicinalProduct.masterFile
        public ElementDefinitionInfo Element_MasterFile;
        // 15. MedicinalProduct.contact
        public ElementDefinitionInfo Element_Contact;
        // 16. MedicinalProduct.clinicalTrial
        public ElementDefinitionInfo Element_ClinicalTrial;
        // 17. MedicinalProduct.name
        public ElementDefinitionInfo Element_Name;
        // 26. MedicinalProduct.crossReference
        public ElementDefinitionInfo Element_CrossReference;
        // 27. MedicinalProduct.manufacturingBusinessOperation
        public ElementDefinitionInfo Element_ManufacturingBusinessOperation;
        // 34. MedicinalProduct.specialDesignation
        public ElementDefinitionInfo Element_SpecialDesignation;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProduct",
                ElementId = "MedicinalProduct"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_Domain.Write(sDef);
            Element_CombinedPharmaceuticalDoseForm.Write(sDef);
            Element_LegalStatusOfSupply.Write(sDef);
            Element_AdditionalMonitoringIndicator.Write(sDef);
            Element_SpecialMeasures.Write(sDef);
            Element_PaediatricUseIndicator.Write(sDef);
            Element_ProductClassification.Write(sDef);
            Element_MarketingStatus.Write(sDef);
            Element_PharmaceuticalProduct.Write(sDef);
            Element_PackagedMedicinalProduct.Write(sDef);
            Element_AttachedDocument.Write(sDef);
            Element_MasterFile.Write(sDef);
            Element_Contact.Write(sDef);
            Element_ClinicalTrial.Write(sDef);
            Element_Name.Write(sDef);
            Element_CrossReference.Write(sDef);
            Element_ManufacturingBusinessOperation.Write(sDef);
            Element_SpecialDesignation.Write(sDef);
        }
        
        public Resource_MedicinalProduct()
        {
            {
                // 1. MedicinalProduct.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicinalProduct.identifier",
                    Id = "MedicinalProduct.identifier",
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
                // 2. MedicinalProduct.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "MedicinalProduct.type",
                    Id = "MedicinalProduct.type",
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
                // 3. MedicinalProduct.domain
                this.Element_Domain = new ElementDefinitionInfo
                {
                    Name = "Element_Domain",
                    Path= "MedicinalProduct.domain",
                    Id = "MedicinalProduct.domain",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
                this.Element_CombinedPharmaceuticalDoseForm = new ElementDefinitionInfo
                {
                    Name = "Element_CombinedPharmaceuticalDoseForm",
                    Path= "MedicinalProduct.combinedPharmaceuticalDoseForm",
                    Id = "MedicinalProduct.combinedPharmaceuticalDoseForm",
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
                // 5. MedicinalProduct.legalStatusOfSupply
                this.Element_LegalStatusOfSupply = new ElementDefinitionInfo
                {
                    Name = "Element_LegalStatusOfSupply",
                    Path= "MedicinalProduct.legalStatusOfSupply",
                    Id = "MedicinalProduct.legalStatusOfSupply",
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
                // 6. MedicinalProduct.additionalMonitoringIndicator
                this.Element_AdditionalMonitoringIndicator = new ElementDefinitionInfo
                {
                    Name = "Element_AdditionalMonitoringIndicator",
                    Path= "MedicinalProduct.additionalMonitoringIndicator",
                    Id = "MedicinalProduct.additionalMonitoringIndicator",
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
                // 7. MedicinalProduct.specialMeasures
                this.Element_SpecialMeasures = new ElementDefinitionInfo
                {
                    Name = "Element_SpecialMeasures",
                    Path= "MedicinalProduct.specialMeasures",
                    Id = "MedicinalProduct.specialMeasures",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 8. MedicinalProduct.paediatricUseIndicator
                this.Element_PaediatricUseIndicator = new ElementDefinitionInfo
                {
                    Name = "Element_PaediatricUseIndicator",
                    Path= "MedicinalProduct.paediatricUseIndicator",
                    Id = "MedicinalProduct.paediatricUseIndicator",
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
                // 9. MedicinalProduct.productClassification
                this.Element_ProductClassification = new ElementDefinitionInfo
                {
                    Name = "Element_ProductClassification",
                    Path= "MedicinalProduct.productClassification",
                    Id = "MedicinalProduct.productClassification",
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
                // 10. MedicinalProduct.marketingStatus
                this.Element_MarketingStatus = new ElementDefinitionInfo
                {
                    Name = "Element_MarketingStatus",
                    Path= "MedicinalProduct.marketingStatus",
                    Id = "MedicinalProduct.marketingStatus",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_MarketingStatus
                        {
                        }
                    }
                };
            }
            {
                // 11. MedicinalProduct.pharmaceuticalProduct
                this.Element_PharmaceuticalProduct = new ElementDefinitionInfo
                {
                    Name = "Element_PharmaceuticalProduct",
                    Path= "MedicinalProduct.pharmaceuticalProduct",
                    Id = "MedicinalProduct.pharmaceuticalProduct",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical"
                            }
                        }
                    }
                };
            }
            {
                // 12. MedicinalProduct.packagedMedicinalProduct
                this.Element_PackagedMedicinalProduct = new ElementDefinitionInfo
                {
                    Name = "Element_PackagedMedicinalProduct",
                    Path= "MedicinalProduct.packagedMedicinalProduct",
                    Id = "MedicinalProduct.packagedMedicinalProduct",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"
                            }
                        }
                    }
                };
            }
            {
                // 13. MedicinalProduct.attachedDocument
                this.Element_AttachedDocument = new ElementDefinitionInfo
                {
                    Name = "Element_AttachedDocument",
                    Path= "MedicinalProduct.attachedDocument",
                    Id = "MedicinalProduct.attachedDocument",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 14. MedicinalProduct.masterFile
                this.Element_MasterFile = new ElementDefinitionInfo
                {
                    Name = "Element_MasterFile",
                    Path= "MedicinalProduct.masterFile",
                    Id = "MedicinalProduct.masterFile",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 15. MedicinalProduct.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "MedicinalProduct.contact",
                    Id = "MedicinalProduct.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 16. MedicinalProduct.clinicalTrial
                this.Element_ClinicalTrial = new ElementDefinitionInfo
                {
                    Name = "Element_ClinicalTrial",
                    Path= "MedicinalProduct.clinicalTrial",
                    Id = "MedicinalProduct.clinicalTrial",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                            }
                        }
                    }
                };
            }
            {
                // 17. MedicinalProduct.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "MedicinalProduct.name",
                    Id = "MedicinalProduct.name",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Name
                        {
                        }
                    }
                };
            }
            {
                // 26. MedicinalProduct.crossReference
                this.Element_CrossReference = new ElementDefinitionInfo
                {
                    Name = "Element_CrossReference",
                    Path= "MedicinalProduct.crossReference",
                    Id = "MedicinalProduct.crossReference",
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
                // 27. MedicinalProduct.manufacturingBusinessOperation
                this.Element_ManufacturingBusinessOperation = new ElementDefinitionInfo
                {
                    Name = "Element_ManufacturingBusinessOperation",
                    Path= "MedicinalProduct.manufacturingBusinessOperation",
                    Id = "MedicinalProduct.manufacturingBusinessOperation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ManufacturingBusinessOperation
                        {
                        }
                    }
                };
            }
            {
                // 34. MedicinalProduct.specialDesignation
                this.Element_SpecialDesignation = new ElementDefinitionInfo
                {
                    Name = "Element_SpecialDesignation",
                    Path= "MedicinalProduct.specialDesignation",
                    Id = "MedicinalProduct.specialDesignation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_SpecialDesignation
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProduct";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProduct";
        }
    }
}
