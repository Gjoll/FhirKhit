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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'MedicinalProduct'
    /// </summary>
    // 0. MedicinalProduct
    public class MedicinalProduct : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MedicinalProduct_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 17. MedicinalProduct.name
            public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Name_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 19. MedicinalProduct.name.namePart
                    public class Type_NamePart : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_NamePart_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 20. MedicinalProduct.name.namePart.part
                            public ElementDefinitionInfo Part;                                                                              // MakerGen.cs:236
                            // 21. MedicinalProduct.name.namePart.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:236
                            public Type_NamePart_Elements()                                                                                 // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 20. MedicinalProduct.name.namePart.part
                                    this.Part = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Part",                                                                                      // MakerGen.cs:255
                                        Path= "MedicinalProduct.name.namePart.part",                                                        // MakerGen.cs:256
                                        Id = "MedicinalProduct.name.namePart.part",                                                         // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 21. MedicinalProduct.name.namePart.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Type",                                                                                      // MakerGen.cs:255
                                        Path= "MedicinalProduct.name.namePart.type",                                                        // MakerGen.cs:256
                                        Id = "MedicinalProduct.name.namePart.type",                                                         // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Part.Write(sDef);                                                                                           // MakerGen.cs:240
                                Type.Write(sDef);                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_NamePart_Elements Elements { get; }                                                                     // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_NamePart()                                                                                              // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_NamePart_Elements();                                                                   // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 22. MedicinalProduct.name.countryLanguage
                    public class Type_CountryLanguage : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_CountryLanguage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 23. MedicinalProduct.name.countryLanguage.country
                            public ElementDefinitionInfo Country;                                                                           // MakerGen.cs:236
                            // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                            public ElementDefinitionInfo Jurisdiction;                                                                      // MakerGen.cs:236
                            // 25. MedicinalProduct.name.countryLanguage.language
                            public ElementDefinitionInfo Language;                                                                          // MakerGen.cs:236
                            public Type_CountryLanguage_Elements()                                                                          // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 23. MedicinalProduct.name.countryLanguage.country
                                    this.Country = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Country",                                                                                   // MakerGen.cs:255
                                        Path= "MedicinalProduct.name.countryLanguage.country",                                              // MakerGen.cs:256
                                        Id = "MedicinalProduct.name.countryLanguage.country",                                               // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                                    this.Jurisdiction = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Jurisdiction",                                                                              // MakerGen.cs:255
                                        Path= "MedicinalProduct.name.countryLanguage.jurisdiction",                                         // MakerGen.cs:256
                                        Id = "MedicinalProduct.name.countryLanguage.jurisdiction",                                          // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 25. MedicinalProduct.name.countryLanguage.language
                                    this.Language = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Language",                                                                                  // MakerGen.cs:255
                                        Path= "MedicinalProduct.name.countryLanguage.language",                                             // MakerGen.cs:256
                                        Id = "MedicinalProduct.name.countryLanguage.language",                                              // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Country.Write(sDef);                                                                                        // MakerGen.cs:240
                                Jurisdiction.Write(sDef);                                                                                   // MakerGen.cs:240
                                Language.Write(sDef);                                                                                       // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_CountryLanguage_Elements Elements { get; }                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_CountryLanguage()                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_CountryLanguage_Elements();                                                            // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 18. MedicinalProduct.name.productName
                    public ElementDefinitionInfo ProductName;                                                                               // MakerGen.cs:236
                    public Type_Name_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. MedicinalProduct.name.productName
                            this.ProductName = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProductName",                                                                                       // MakerGen.cs:255
                                Path= "MedicinalProduct.name.productName",                                                                  // MakerGen.cs:256
                                Id = "MedicinalProduct.name.productName",                                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        ProductName.Write(sDef);                                                                                            // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Name_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Name()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Name_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 27. MedicinalProduct.manufacturingBusinessOperation
            public class Type_ManufacturingBusinessOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_ManufacturingBusinessOperation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
                    public ElementDefinitionInfo OperationType;                                                                             // MakerGen.cs:236
                    // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
                    public ElementDefinitionInfo AuthorisationReferenceNumber;                                                              // MakerGen.cs:236
                    // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
                    public ElementDefinitionInfo EffectiveDate;                                                                             // MakerGen.cs:236
                    // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
                    public ElementDefinitionInfo ConfidentialityIndicator;                                                                  // MakerGen.cs:236
                    // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
                    public ElementDefinitionInfo Manufacturer;                                                                              // MakerGen.cs:236
                    // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
                    public ElementDefinitionInfo Regulator;                                                                                 // MakerGen.cs:236
                    public Type_ManufacturingBusinessOperation_Elements()                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
                            this.OperationType = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "OperationType",                                                                                     // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.operationType",                                      // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.operationType",                                       // MakerGen.cs:257
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
                            // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
                            this.AuthorisationReferenceNumber = new ElementDefinitionInfo                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AuthorisationReferenceNumber",                                                                      // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",                       // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
                            this.EffectiveDate = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "EffectiveDate",                                                                                     // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",                                      // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",                                       // MakerGen.cs:257
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
                            // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
                            this.ConfidentialityIndicator = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ConfidentialityIndicator",                                                                          // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",                           // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",                            // MakerGen.cs:257
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
                            // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
                            this.Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Manufacturer",                                                                                      // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.manufacturer",                                       // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.manufacturer",                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
                            this.Regulator = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Regulator",                                                                                         // MakerGen.cs:255
                                Path= "MedicinalProduct.manufacturingBusinessOperation.regulator",                                          // MakerGen.cs:256
                                Id = "MedicinalProduct.manufacturingBusinessOperation.regulator",                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        OperationType.Write(sDef);                                                                                          // MakerGen.cs:240
                        AuthorisationReferenceNumber.Write(sDef);                                                                           // MakerGen.cs:240
                        EffectiveDate.Write(sDef);                                                                                          // MakerGen.cs:240
                        ConfidentialityIndicator.Write(sDef);                                                                               // MakerGen.cs:240
                        Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:240
                        Regulator.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_ManufacturingBusinessOperation_Elements Elements { get; }                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_ManufacturingBusinessOperation()                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_ManufacturingBusinessOperation_Elements();                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 34. MedicinalProduct.specialDesignation
            public class Type_SpecialDesignation : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_SpecialDesignation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 35. MedicinalProduct.specialDesignation.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:236
                    // 36. MedicinalProduct.specialDesignation.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 37. MedicinalProduct.specialDesignation.intendedUse
                    public ElementDefinitionInfo IntendedUse;                                                                               // MakerGen.cs:236
                    // 38. MedicinalProduct.specialDesignation.indication[x]
                    public ElementDefinitionInfo Indication;                                                                                // MakerGen.cs:236
                    // 39. MedicinalProduct.specialDesignation.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:236
                    // 40. MedicinalProduct.specialDesignation.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 41. MedicinalProduct.specialDesignation.species
                    public ElementDefinitionInfo Species;                                                                                   // MakerGen.cs:236
                    public Type_SpecialDesignation_Elements()                                                                               // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 35. MedicinalProduct.specialDesignation.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Identifier",                                                                                        // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.identifier",                                                     // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.identifier",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 36. MedicinalProduct.specialDesignation.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.type",                                                           // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.type",                                                            // MakerGen.cs:257
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
                            // 37. MedicinalProduct.specialDesignation.intendedUse
                            this.IntendedUse = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "IntendedUse",                                                                                       // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.intendedUse",                                                    // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.intendedUse",                                                     // MakerGen.cs:257
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
                            // 38. MedicinalProduct.specialDesignation.indication[x]
                            this.Indication = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Indication",                                                                                        // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.indication[x]",                                                  // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.indication[x]",                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"                            // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 39. MedicinalProduct.specialDesignation.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Status",                                                                                            // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.status",                                                         // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.status",                                                          // MakerGen.cs:257
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
                            // 40. MedicinalProduct.specialDesignation.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.date",                                                           // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.date",                                                            // MakerGen.cs:257
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
                            // 41. MedicinalProduct.specialDesignation.species
                            this.Species = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Species",                                                                                           // MakerGen.cs:255
                                Path= "MedicinalProduct.specialDesignation.species",                                                        // MakerGen.cs:256
                                Id = "MedicinalProduct.specialDesignation.species",                                                         // MakerGen.cs:257
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
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        IntendedUse.Write(sDef);                                                                                            // MakerGen.cs:240
                        Indication.Write(sDef);                                                                                             // MakerGen.cs:240
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Species.Write(sDef);                                                                                                // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_SpecialDesignation_Elements Elements { get; }                                                                   // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_SpecialDesignation()                                                                                            // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_SpecialDesignation_Elements();                                                                 // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. MedicinalProduct.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. MedicinalProduct.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 3. MedicinalProduct.domain
            public ElementDefinitionInfo Domain;                                                                                            // MakerGen.cs:236
            // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
            public ElementDefinitionInfo CombinedPharmaceuticalDoseForm;                                                                    // MakerGen.cs:236
            // 5. MedicinalProduct.legalStatusOfSupply
            public ElementDefinitionInfo LegalStatusOfSupply;                                                                               // MakerGen.cs:236
            // 6. MedicinalProduct.additionalMonitoringIndicator
            public ElementDefinitionInfo AdditionalMonitoringIndicator;                                                                     // MakerGen.cs:236
            // 7. MedicinalProduct.specialMeasures
            public ElementDefinitionInfo SpecialMeasures;                                                                                   // MakerGen.cs:236
            // 8. MedicinalProduct.paediatricUseIndicator
            public ElementDefinitionInfo PaediatricUseIndicator;                                                                            // MakerGen.cs:236
            // 9. MedicinalProduct.productClassification
            public ElementDefinitionInfo ProductClassification;                                                                             // MakerGen.cs:236
            // 10. MedicinalProduct.marketingStatus
            public ElementDefinitionInfo MarketingStatus;                                                                                   // MakerGen.cs:236
            // 11. MedicinalProduct.pharmaceuticalProduct
            public ElementDefinitionInfo PharmaceuticalProduct;                                                                             // MakerGen.cs:236
            // 12. MedicinalProduct.packagedMedicinalProduct
            public ElementDefinitionInfo PackagedMedicinalProduct;                                                                          // MakerGen.cs:236
            // 13. MedicinalProduct.attachedDocument
            public ElementDefinitionInfo AttachedDocument;                                                                                  // MakerGen.cs:236
            // 14. MedicinalProduct.masterFile
            public ElementDefinitionInfo MasterFile;                                                                                        // MakerGen.cs:236
            // 15. MedicinalProduct.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:236
            // 16. MedicinalProduct.clinicalTrial
            public ElementDefinitionInfo ClinicalTrial;                                                                                     // MakerGen.cs:236
            // 26. MedicinalProduct.crossReference
            public ElementDefinitionInfo CrossReference;                                                                                    // MakerGen.cs:236
            public MedicinalProduct_Elements()                                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MedicinalProduct.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProduct.identifier",                                                                                // MakerGen.cs:256
                        Id = "MedicinalProduct.identifier",                                                                                 // MakerGen.cs:257
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
                    // 2. MedicinalProduct.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "MedicinalProduct.type",                                                                                      // MakerGen.cs:256
                        Id = "MedicinalProduct.type",                                                                                       // MakerGen.cs:257
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
                    // 3. MedicinalProduct.domain
                    this.Domain = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Domain",                                                                                                    // MakerGen.cs:255
                        Path= "MedicinalProduct.domain",                                                                                    // MakerGen.cs:256
                        Id = "MedicinalProduct.domain",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
                    this.CombinedPharmaceuticalDoseForm = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "CombinedPharmaceuticalDoseForm",                                                                            // MakerGen.cs:255
                        Path= "MedicinalProduct.combinedPharmaceuticalDoseForm",                                                            // MakerGen.cs:256
                        Id = "MedicinalProduct.combinedPharmaceuticalDoseForm",                                                             // MakerGen.cs:257
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
                    // 5. MedicinalProduct.legalStatusOfSupply
                    this.LegalStatusOfSupply = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LegalStatusOfSupply",                                                                                       // MakerGen.cs:255
                        Path= "MedicinalProduct.legalStatusOfSupply",                                                                       // MakerGen.cs:256
                        Id = "MedicinalProduct.legalStatusOfSupply",                                                                        // MakerGen.cs:257
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
                    // 6. MedicinalProduct.additionalMonitoringIndicator
                    this.AdditionalMonitoringIndicator = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AdditionalMonitoringIndicator",                                                                             // MakerGen.cs:255
                        Path= "MedicinalProduct.additionalMonitoringIndicator",                                                             // MakerGen.cs:256
                        Id = "MedicinalProduct.additionalMonitoringIndicator",                                                              // MakerGen.cs:257
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
                    // 7. MedicinalProduct.specialMeasures
                    this.SpecialMeasures = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SpecialMeasures",                                                                                           // MakerGen.cs:255
                        Path= "MedicinalProduct.specialMeasures",                                                                           // MakerGen.cs:256
                        Id = "MedicinalProduct.specialMeasures",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. MedicinalProduct.paediatricUseIndicator
                    this.PaediatricUseIndicator = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PaediatricUseIndicator",                                                                                    // MakerGen.cs:255
                        Path= "MedicinalProduct.paediatricUseIndicator",                                                                    // MakerGen.cs:256
                        Id = "MedicinalProduct.paediatricUseIndicator",                                                                     // MakerGen.cs:257
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
                    // 9. MedicinalProduct.productClassification
                    this.ProductClassification = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ProductClassification",                                                                                     // MakerGen.cs:255
                        Path= "MedicinalProduct.productClassification",                                                                     // MakerGen.cs:256
                        Id = "MedicinalProduct.productClassification",                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. MedicinalProduct.marketingStatus
                    this.MarketingStatus = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "MarketingStatus",                                                                                           // MakerGen.cs:255
                        Path= "MedicinalProduct.marketingStatus",                                                                           // MakerGen.cs:256
                        Id = "MedicinalProduct.marketingStatus",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.MarketingStatus                                                               // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. MedicinalProduct.pharmaceuticalProduct
                    this.PharmaceuticalProduct = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PharmaceuticalProduct",                                                                                     // MakerGen.cs:255
                        Path= "MedicinalProduct.pharmaceuticalProduct",                                                                     // MakerGen.cs:256
                        Id = "MedicinalProduct.pharmaceuticalProduct",                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical"                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. MedicinalProduct.packagedMedicinalProduct
                    this.PackagedMedicinalProduct = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PackagedMedicinalProduct",                                                                                  // MakerGen.cs:255
                        Path= "MedicinalProduct.packagedMedicinalProduct",                                                                  // MakerGen.cs:256
                        Id = "MedicinalProduct.packagedMedicinalProduct",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. MedicinalProduct.attachedDocument
                    this.AttachedDocument = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AttachedDocument",                                                                                          // MakerGen.cs:255
                        Path= "MedicinalProduct.attachedDocument",                                                                          // MakerGen.cs:256
                        Id = "MedicinalProduct.attachedDocument",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. MedicinalProduct.masterFile
                    this.MasterFile = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "MasterFile",                                                                                                // MakerGen.cs:255
                        Path= "MedicinalProduct.masterFile",                                                                                // MakerGen.cs:256
                        Id = "MedicinalProduct.masterFile",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. MedicinalProduct.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contact",                                                                                                   // MakerGen.cs:255
                        Path= "MedicinalProduct.contact",                                                                                   // MakerGen.cs:256
                        Id = "MedicinalProduct.contact",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 16. MedicinalProduct.clinicalTrial
                    this.ClinicalTrial = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ClinicalTrial",                                                                                             // MakerGen.cs:255
                        Path= "MedicinalProduct.clinicalTrial",                                                                             // MakerGen.cs:256
                        Id = "MedicinalProduct.clinicalTrial",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 26. MedicinalProduct.crossReference
                    this.CrossReference = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "CrossReference",                                                                                            // MakerGen.cs:255
                        Path= "MedicinalProduct.crossReference",                                                                            // MakerGen.cs:256
                        Id = "MedicinalProduct.crossReference",                                                                             // MakerGen.cs:257
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
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                Domain.Write(sDef);                                                                                                         // MakerGen.cs:240
                CombinedPharmaceuticalDoseForm.Write(sDef);                                                                                 // MakerGen.cs:240
                LegalStatusOfSupply.Write(sDef);                                                                                            // MakerGen.cs:240
                AdditionalMonitoringIndicator.Write(sDef);                                                                                  // MakerGen.cs:240
                SpecialMeasures.Write(sDef);                                                                                                // MakerGen.cs:240
                PaediatricUseIndicator.Write(sDef);                                                                                         // MakerGen.cs:240
                ProductClassification.Write(sDef);                                                                                          // MakerGen.cs:240
                MarketingStatus.Write(sDef);                                                                                                // MakerGen.cs:240
                PharmaceuticalProduct.Write(sDef);                                                                                          // MakerGen.cs:240
                PackagedMedicinalProduct.Write(sDef);                                                                                       // MakerGen.cs:240
                AttachedDocument.Write(sDef);                                                                                               // MakerGen.cs:240
                MasterFile.Write(sDef);                                                                                                     // MakerGen.cs:240
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:240
                ClinicalTrial.Write(sDef);                                                                                                  // MakerGen.cs:240
                CrossReference.Write(sDef);                                                                                                 // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MedicinalProduct_Elements Elements { get; }                                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MedicinalProduct()                                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MedicinalProduct_Elements();                                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
