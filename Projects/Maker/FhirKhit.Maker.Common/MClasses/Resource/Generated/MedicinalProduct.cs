using System;                                                                                                                               // MakerGen.cs:399
using System.Diagnostics;                                                                                                                   // MakerGen.cs:400
using System.IO;                                                                                                                            // MakerGen.cs:401
using System.Linq;                                                                                                                          // MakerGen.cs:402
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:403
                                                                                                                                            // MakerGen.cs:404
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:405
{                                                                                                                                           // MakerGen.cs:406
    #region Json                                                                                                                            // MakerGen.cs:407
    #if NEVER                                                                                                                               // MakerGen.cs:408
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
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'MedicinalProduct'
    /// </summary>
    // 0. MedicinalProduct
    public class MedicinalProduct : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 17. MedicinalProduct.name
        public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 19. MedicinalProduct.name.namePart
            public class Type_NamePart : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 20. MedicinalProduct.name.namePart.part
                public MakerElementInstance Element_Part;                                                                                   // MakerGen.cs:232
                // 21. MedicinalProduct.name.namePart.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                public Type_NamePart()                                                                                                      // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 20. MedicinalProduct.name.namePart.part
                        this.Element_Part = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Part",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 21. MedicinalProduct.name.namePart.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding                                                                    // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 22. MedicinalProduct.name.countryLanguage
            public class Type_CountryLanguage : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 23. MedicinalProduct.name.countryLanguage.country
                public MakerElementInstance Element_Country;                                                                                // MakerGen.cs:232
                // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                public MakerElementInstance Element_Jurisdiction;                                                                           // MakerGen.cs:232
                // 25. MedicinalProduct.name.countryLanguage.language
                public MakerElementInstance Element_Language;                                                                               // MakerGen.cs:232
                public Type_CountryLanguage()                                                                                               // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 23. MedicinalProduct.name.countryLanguage.country
                        this.Element_Country = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Country",                                                                                       // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                        this.Element_Jurisdiction = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Jurisdiction",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 25. MedicinalProduct.name.countryLanguage.language
                        this.Element_Language = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Language",                                                                                      // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 18. MedicinalProduct.name.productName
            public MakerElementInstance Element_ProductName;                                                                                // MakerGen.cs:232
            public Type_Name()                                                                                                              // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 18. MedicinalProduct.name.productName
                    this.Element_ProductName = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProductName",                                                                                       // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 27. MedicinalProduct.manufacturingBusinessOperation
        public class Type_ManufacturingBusinessOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                        // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
            public MakerElementInstance Element_OperationType;                                                                              // MakerGen.cs:232
            // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
            public MakerElementInstance Element_AuthorisationReferenceNumber;                                                               // MakerGen.cs:232
            // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
            public MakerElementInstance Element_EffectiveDate;                                                                              // MakerGen.cs:232
            // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
            public MakerElementInstance Element_ConfidentialityIndicator;                                                                   // MakerGen.cs:232
            // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
            public MakerElementInstance Element_Manufacturer;                                                                               // MakerGen.cs:232
            // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
            public MakerElementInstance Element_Regulator;                                                                                  // MakerGen.cs:232
            public Type_ManufacturingBusinessOperation()                                                                                    // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
                    this.Element_OperationType = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OperationType",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
                    this.Element_AuthorisationReferenceNumber = new MakerElementInstance                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AuthorisationReferenceNumber",                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
                    this.Element_EffectiveDate = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_EffectiveDate",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
                    this.Element_ConfidentialityIndicator = new MakerElementInstance                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ConfidentialityIndicator",                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
                    this.Element_Manufacturer = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Manufacturer",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
                    this.Element_Regulator = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Regulator",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 34. MedicinalProduct.specialDesignation
        public class Type_SpecialDesignation : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 35. MedicinalProduct.specialDesignation.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            // 36. MedicinalProduct.specialDesignation.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 37. MedicinalProduct.specialDesignation.intendedUse
            public MakerElementInstance Element_IntendedUse;                                                                                // MakerGen.cs:232
            // 38. MedicinalProduct.specialDesignation.indication[x]
            public MakerElementInstance Element_Indication;                                                                                 // MakerGen.cs:232
            // 39. MedicinalProduct.specialDesignation.status
            public MakerElementInstance Element_Status;                                                                                     // MakerGen.cs:232
            // 40. MedicinalProduct.specialDesignation.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 41. MedicinalProduct.specialDesignation.species
            public MakerElementInstance Element_Species;                                                                                    // MakerGen.cs:232
            public Type_SpecialDesignation()                                                                                                // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 35. MedicinalProduct.specialDesignation.identifier
                    this.Element_Identifier = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 36. MedicinalProduct.specialDesignation.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 37. MedicinalProduct.specialDesignation.intendedUse
                    this.Element_IntendedUse = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_IntendedUse",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 38. MedicinalProduct.specialDesignation.indication[x]
                    this.Element_Indication = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Indication",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            },                                                                                                              // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 39. MedicinalProduct.specialDesignation.status
                    this.Element_Status = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Status",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 40. MedicinalProduct.specialDesignation.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 41. MedicinalProduct.specialDesignation.species
                    this.Element_Species = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Species",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. MedicinalProduct.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. MedicinalProduct.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 3. MedicinalProduct.domain
        public MakerElementInstance Element_Domain;                                                                                         // MakerGen.cs:232
        // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
        public MakerElementInstance Element_CombinedPharmaceuticalDoseForm;                                                                 // MakerGen.cs:232
        // 5. MedicinalProduct.legalStatusOfSupply
        public MakerElementInstance Element_LegalStatusOfSupply;                                                                            // MakerGen.cs:232
        // 6. MedicinalProduct.additionalMonitoringIndicator
        public MakerElementInstance Element_AdditionalMonitoringIndicator;                                                                  // MakerGen.cs:232
        // 7. MedicinalProduct.specialMeasures
        public MakerElementInstance Element_SpecialMeasures;                                                                                // MakerGen.cs:232
        // 8. MedicinalProduct.paediatricUseIndicator
        public MakerElementInstance Element_PaediatricUseIndicator;                                                                         // MakerGen.cs:232
        // 9. MedicinalProduct.productClassification
        public MakerElementInstance Element_ProductClassification;                                                                          // MakerGen.cs:232
        // 10. MedicinalProduct.marketingStatus
        public MakerElementInstance Element_MarketingStatus;                                                                                // MakerGen.cs:232
        // 11. MedicinalProduct.pharmaceuticalProduct
        public MakerElementInstance Element_PharmaceuticalProduct;                                                                          // MakerGen.cs:232
        // 12. MedicinalProduct.packagedMedicinalProduct
        public MakerElementInstance Element_PackagedMedicinalProduct;                                                                       // MakerGen.cs:232
        // 13. MedicinalProduct.attachedDocument
        public MakerElementInstance Element_AttachedDocument;                                                                               // MakerGen.cs:232
        // 14. MedicinalProduct.masterFile
        public MakerElementInstance Element_MasterFile;                                                                                     // MakerGen.cs:232
        // 15. MedicinalProduct.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 16. MedicinalProduct.clinicalTrial
        public MakerElementInstance Element_ClinicalTrial;                                                                                  // MakerGen.cs:232
        // 26. MedicinalProduct.crossReference
        public MakerElementInstance Element_CrossReference;                                                                                 // MakerGen.cs:232
        public MedicinalProduct()                                                                                                           // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. MedicinalProduct.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 2. MedicinalProduct.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. MedicinalProduct.domain
                this.Element_Domain = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Domain",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Coding                                                                            // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
                this.Element_CombinedPharmaceuticalDoseForm = new MakerElementInstance                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CombinedPharmaceuticalDoseForm",                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 5. MedicinalProduct.legalStatusOfSupply
                this.Element_LegalStatusOfSupply = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LegalStatusOfSupply",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 6. MedicinalProduct.additionalMonitoringIndicator
                this.Element_AdditionalMonitoringIndicator = new MakerElementInstance                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AdditionalMonitoringIndicator",                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 7. MedicinalProduct.specialMeasures
                this.Element_SpecialMeasures = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SpecialMeasures",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 8. MedicinalProduct.paediatricUseIndicator
                this.Element_PaediatricUseIndicator = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PaediatricUseIndicator",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 9. MedicinalProduct.productClassification
                this.Element_ProductClassification = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProductClassification",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 10. MedicinalProduct.marketingStatus
                this.Element_MarketingStatus = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_MarketingStatus",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 11. MedicinalProduct.pharmaceuticalProduct
                this.Element_PharmaceuticalProduct = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PharmaceuticalProduct",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 12. MedicinalProduct.packagedMedicinalProduct
                this.Element_PackagedMedicinalProduct = new MakerElementInstance                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PackagedMedicinalProduct",                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 13. MedicinalProduct.attachedDocument
                this.Element_AttachedDocument = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AttachedDocument",                                                                                      // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 14. MedicinalProduct.masterFile
                this.Element_MasterFile = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_MasterFile",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 15. MedicinalProduct.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 16. MedicinalProduct.clinicalTrial
                this.Element_ClinicalTrial = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ClinicalTrial",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 26. MedicinalProduct.crossReference
                this.Element_CrossReference = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CrossReference",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
