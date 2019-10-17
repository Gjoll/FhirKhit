using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'MedicinalProduct'
    /// </summary>
    // 0. MedicinalProduct
    public partial class Resource_MedicinalProduct : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 17. MedicinalProduct.name
        public partial class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 19. MedicinalProduct.name.namePart
            public partial class Type_NamePart : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 20. MedicinalProduct.name.namePart.part
                public ElementDefinitionInfo Element_Part;                                                                                  // MakerGen.cs:217
                // 21. MedicinalProduct.name.namePart.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "MedicinalProduct.name.namePart",                                                                            // MakerGen.cs:393
                        ElementId = "MedicinalProduct.name.namePart"                                                                        // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Part.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_NamePart()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 20. MedicinalProduct.name.namePart.part
                        this.Element_Part = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Part",                                                                                          // MakerGen.cs:236
                            Path= "MedicinalProduct.name.namePart.part",                                                                    // MakerGen.cs:237
                            Id = "MedicinalProduct.name.namePart.part",                                                                     // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 21. MedicinalProduct.name.namePart.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Type",                                                                                          // MakerGen.cs:236
                            Path= "MedicinalProduct.name.namePart.type",                                                                    // MakerGen.cs:237
                            Id = "MedicinalProduct.name.namePart.type",                                                                     // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_Coding                                                               // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 22. MedicinalProduct.name.countryLanguage
            public partial class Type_CountryLanguage : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 23. MedicinalProduct.name.countryLanguage.country
                public ElementDefinitionInfo Element_Country;                                                                               // MakerGen.cs:217
                // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                public ElementDefinitionInfo Element_Jurisdiction;                                                                          // MakerGen.cs:217
                // 25. MedicinalProduct.name.countryLanguage.language
                public ElementDefinitionInfo Element_Language;                                                                              // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "MedicinalProduct.name.countryLanguage",                                                                     // MakerGen.cs:393
                        ElementId = "MedicinalProduct.name.countryLanguage"                                                                 // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Country.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Jurisdiction.Write(sDef);                                                                                       // MakerGen.cs:221
                    Element_Language.Write(sDef);                                                                                           // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_CountryLanguage()                                                                                               // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 23. MedicinalProduct.name.countryLanguage.country
                        this.Element_Country = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Country",                                                                                       // MakerGen.cs:236
                            Path= "MedicinalProduct.name.countryLanguage.country",                                                          // MakerGen.cs:237
                            Id = "MedicinalProduct.name.countryLanguage.country",                                                           // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 24. MedicinalProduct.name.countryLanguage.jurisdiction
                        this.Element_Jurisdiction = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Jurisdiction",                                                                                  // MakerGen.cs:236
                            Path= "MedicinalProduct.name.countryLanguage.jurisdiction",                                                     // MakerGen.cs:237
                            Id = "MedicinalProduct.name.countryLanguage.jurisdiction",                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 25. MedicinalProduct.name.countryLanguage.language
                        this.Element_Language = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Language",                                                                                      // MakerGen.cs:236
                            Path= "MedicinalProduct.name.countryLanguage.language",                                                         // MakerGen.cs:237
                            Id = "MedicinalProduct.name.countryLanguage.language",                                                          // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 18. MedicinalProduct.name.productName
            public ElementDefinitionInfo Element_ProductName;                                                                               // MakerGen.cs:217
            // 19. MedicinalProduct.name.namePart
            public ElementDefinitionInfo Element_NamePart;                                                                                  // MakerGen.cs:217
            // 22. MedicinalProduct.name.countryLanguage
            public ElementDefinitionInfo Element_CountryLanguage;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProduct.name",                                                                                         // MakerGen.cs:393
                    ElementId = "MedicinalProduct.name"                                                                                     // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_ProductName.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_NamePart.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_CountryLanguage.Write(sDef);                                                                                        // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Name()                                                                                                              // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 18. MedicinalProduct.name.productName
                    this.Element_ProductName = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ProductName",                                                                                       // MakerGen.cs:236
                        Path= "MedicinalProduct.name.productName",                                                                          // MakerGen.cs:237
                        Id = "MedicinalProduct.name.productName",                                                                           // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 19. MedicinalProduct.name.namePart
                    this.Element_NamePart = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_NamePart",                                                                                          // MakerGen.cs:236
                        Path= "MedicinalProduct.name.namePart",                                                                             // MakerGen.cs:237
                        Id = "MedicinalProduct.name.namePart",                                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_NamePart                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. MedicinalProduct.name.countryLanguage
                    this.Element_CountryLanguage = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CountryLanguage",                                                                                   // MakerGen.cs:236
                        Path= "MedicinalProduct.name.countryLanguage",                                                                      // MakerGen.cs:237
                        Id = "MedicinalProduct.name.countryLanguage",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_CountryLanguage                                                                                        // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 27. MedicinalProduct.manufacturingBusinessOperation
        public partial class Type_ManufacturingBusinessOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
            public ElementDefinitionInfo Element_OperationType;                                                                             // MakerGen.cs:217
            // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
            public ElementDefinitionInfo Element_AuthorisationReferenceNumber;                                                              // MakerGen.cs:217
            // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
            public ElementDefinitionInfo Element_EffectiveDate;                                                                             // MakerGen.cs:217
            // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
            public ElementDefinitionInfo Element_ConfidentialityIndicator;                                                                  // MakerGen.cs:217
            // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
            public ElementDefinitionInfo Element_Manufacturer;                                                                              // MakerGen.cs:217
            // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
            public ElementDefinitionInfo Element_Regulator;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProduct.manufacturingBusinessOperation",                                                               // MakerGen.cs:393
                    ElementId = "MedicinalProduct.manufacturingBusinessOperation"                                                           // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_OperationType.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_AuthorisationReferenceNumber.Write(sDef);                                                                           // MakerGen.cs:221
                Element_EffectiveDate.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_ConfidentialityIndicator.Write(sDef);                                                                               // MakerGen.cs:221
                Element_Manufacturer.Write(sDef);                                                                                           // MakerGen.cs:221
                Element_Regulator.Write(sDef);                                                                                              // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_ManufacturingBusinessOperation()                                                                                    // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 28. MedicinalProduct.manufacturingBusinessOperation.operationType
                    this.Element_OperationType = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_OperationType",                                                                                     // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.operationType",                                              // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.operationType",                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 29. MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber
                    this.Element_AuthorisationReferenceNumber = new ElementDefinitionInfo                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AuthorisationReferenceNumber",                                                                      // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",                               // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.authorisationReferenceNumber",                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 30. MedicinalProduct.manufacturingBusinessOperation.effectiveDate
                    this.Element_EffectiveDate = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_EffectiveDate",                                                                                     // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",                                              // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.effectiveDate",                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 31. MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator
                    this.Element_ConfidentialityIndicator = new ElementDefinitionInfo                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ConfidentialityIndicator",                                                                          // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",                                   // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.confidentialityIndicator",                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 32. MedicinalProduct.manufacturingBusinessOperation.manufacturer
                    this.Element_Manufacturer = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Manufacturer",                                                                                      // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.manufacturer",                                               // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.manufacturer",                                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 33. MedicinalProduct.manufacturingBusinessOperation.regulator
                    this.Element_Regulator = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Regulator",                                                                                         // MakerGen.cs:236
                        Path= "MedicinalProduct.manufacturingBusinessOperation.regulator",                                                  // MakerGen.cs:237
                        Id = "MedicinalProduct.manufacturingBusinessOperation.regulator",                                                   // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 34. MedicinalProduct.specialDesignation
        public partial class Type_SpecialDesignation : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 35. MedicinalProduct.specialDesignation.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:217
            // 36. MedicinalProduct.specialDesignation.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 37. MedicinalProduct.specialDesignation.intendedUse
            public ElementDefinitionInfo Element_IntendedUse;                                                                               // MakerGen.cs:217
            // 38. MedicinalProduct.specialDesignation.indication[x]
            public ElementDefinitionInfo Element_Indication;                                                                                // MakerGen.cs:217
            // 39. MedicinalProduct.specialDesignation.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:217
            // 40. MedicinalProduct.specialDesignation.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:217
            // 41. MedicinalProduct.specialDesignation.species
            public ElementDefinitionInfo Element_Species;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "MedicinalProduct.specialDesignation",                                                                           // MakerGen.cs:393
                    ElementId = "MedicinalProduct.specialDesignation"                                                                       // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_IntendedUse.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Indication.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Species.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_SpecialDesignation()                                                                                                // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 35. MedicinalProduct.specialDesignation.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.identifier",                                                             // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.identifier",                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 36. MedicinalProduct.specialDesignation.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.type",                                                                   // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.type",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 37. MedicinalProduct.specialDesignation.intendedUse
                    this.Element_IntendedUse = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_IntendedUse",                                                                                       // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.intendedUse",                                                            // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.intendedUse",                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 38. MedicinalProduct.specialDesignation.indication[x]
                    this.Element_Indication = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Indication",                                                                                        // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.indication[x]",                                                          // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.indication[x]",                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            },                                                                                                              // MakerGen.cs:320
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicinalProductIndication"                                    // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 39. MedicinalProduct.specialDesignation.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Status",                                                                                            // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.status",                                                                 // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.status",                                                                  // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 40. MedicinalProduct.specialDesignation.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Date",                                                                                              // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.date",                                                                   // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.date",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 41. MedicinalProduct.specialDesignation.species
                    this.Element_Species = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Species",                                                                                           // MakerGen.cs:236
                        Path= "MedicinalProduct.specialDesignation.species",                                                                // MakerGen.cs:237
                        Id = "MedicinalProduct.specialDesignation.species",                                                                 // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. MedicinalProduct.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. MedicinalProduct.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 3. MedicinalProduct.domain
        public ElementDefinitionInfo Element_Domain;                                                                                        // MakerGen.cs:217
        // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
        public ElementDefinitionInfo Element_CombinedPharmaceuticalDoseForm;                                                                // MakerGen.cs:217
        // 5. MedicinalProduct.legalStatusOfSupply
        public ElementDefinitionInfo Element_LegalStatusOfSupply;                                                                           // MakerGen.cs:217
        // 6. MedicinalProduct.additionalMonitoringIndicator
        public ElementDefinitionInfo Element_AdditionalMonitoringIndicator;                                                                 // MakerGen.cs:217
        // 7. MedicinalProduct.specialMeasures
        public ElementDefinitionInfo Element_SpecialMeasures;                                                                               // MakerGen.cs:217
        // 8. MedicinalProduct.paediatricUseIndicator
        public ElementDefinitionInfo Element_PaediatricUseIndicator;                                                                        // MakerGen.cs:217
        // 9. MedicinalProduct.productClassification
        public ElementDefinitionInfo Element_ProductClassification;                                                                         // MakerGen.cs:217
        // 10. MedicinalProduct.marketingStatus
        public ElementDefinitionInfo Element_MarketingStatus;                                                                               // MakerGen.cs:217
        // 11. MedicinalProduct.pharmaceuticalProduct
        public ElementDefinitionInfo Element_PharmaceuticalProduct;                                                                         // MakerGen.cs:217
        // 12. MedicinalProduct.packagedMedicinalProduct
        public ElementDefinitionInfo Element_PackagedMedicinalProduct;                                                                      // MakerGen.cs:217
        // 13. MedicinalProduct.attachedDocument
        public ElementDefinitionInfo Element_AttachedDocument;                                                                              // MakerGen.cs:217
        // 14. MedicinalProduct.masterFile
        public ElementDefinitionInfo Element_MasterFile;                                                                                    // MakerGen.cs:217
        // 15. MedicinalProduct.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 16. MedicinalProduct.clinicalTrial
        public ElementDefinitionInfo Element_ClinicalTrial;                                                                                 // MakerGen.cs:217
        // 17. MedicinalProduct.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 26. MedicinalProduct.crossReference
        public ElementDefinitionInfo Element_CrossReference;                                                                                // MakerGen.cs:217
        // 27. MedicinalProduct.manufacturingBusinessOperation
        public ElementDefinitionInfo Element_ManufacturingBusinessOperation;                                                                // MakerGen.cs:217
        // 34. MedicinalProduct.specialDesignation
        public ElementDefinitionInfo Element_SpecialDesignation;                                                                            // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "MedicinalProduct",                                                                                                  // MakerGen.cs:393
                ElementId = "MedicinalProduct"                                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Domain.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_CombinedPharmaceuticalDoseForm.Write(sDef);                                                                             // MakerGen.cs:221
            Element_LegalStatusOfSupply.Write(sDef);                                                                                        // MakerGen.cs:221
            Element_AdditionalMonitoringIndicator.Write(sDef);                                                                              // MakerGen.cs:221
            Element_SpecialMeasures.Write(sDef);                                                                                            // MakerGen.cs:221
            Element_PaediatricUseIndicator.Write(sDef);                                                                                     // MakerGen.cs:221
            Element_ProductClassification.Write(sDef);                                                                                      // MakerGen.cs:221
            Element_MarketingStatus.Write(sDef);                                                                                            // MakerGen.cs:221
            Element_PharmaceuticalProduct.Write(sDef);                                                                                      // MakerGen.cs:221
            Element_PackagedMedicinalProduct.Write(sDef);                                                                                   // MakerGen.cs:221
            Element_AttachedDocument.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_MasterFile.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_ClinicalTrial.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_CrossReference.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_ManufacturingBusinessOperation.Write(sDef);                                                                             // MakerGen.cs:221
            Element_SpecialDesignation.Write(sDef);                                                                                         // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_MedicinalProduct()                                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. MedicinalProduct.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProduct.identifier",                                                                                    // MakerGen.cs:237
                    Id = "MedicinalProduct.identifier",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. MedicinalProduct.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "MedicinalProduct.type",                                                                                          // MakerGen.cs:237
                    Id = "MedicinalProduct.type",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. MedicinalProduct.domain
                this.Element_Domain = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Domain",                                                                                                // MakerGen.cs:236
                    Path= "MedicinalProduct.domain",                                                                                        // MakerGen.cs:237
                    Id = "MedicinalProduct.domain",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. MedicinalProduct.combinedPharmaceuticalDoseForm
                this.Element_CombinedPharmaceuticalDoseForm = new ElementDefinitionInfo                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_CombinedPharmaceuticalDoseForm",                                                                        // MakerGen.cs:236
                    Path= "MedicinalProduct.combinedPharmaceuticalDoseForm",                                                                // MakerGen.cs:237
                    Id = "MedicinalProduct.combinedPharmaceuticalDoseForm",                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. MedicinalProduct.legalStatusOfSupply
                this.Element_LegalStatusOfSupply = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_LegalStatusOfSupply",                                                                                   // MakerGen.cs:236
                    Path= "MedicinalProduct.legalStatusOfSupply",                                                                           // MakerGen.cs:237
                    Id = "MedicinalProduct.legalStatusOfSupply",                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. MedicinalProduct.additionalMonitoringIndicator
                this.Element_AdditionalMonitoringIndicator = new ElementDefinitionInfo                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AdditionalMonitoringIndicator",                                                                         // MakerGen.cs:236
                    Path= "MedicinalProduct.additionalMonitoringIndicator",                                                                 // MakerGen.cs:237
                    Id = "MedicinalProduct.additionalMonitoringIndicator",                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. MedicinalProduct.specialMeasures
                this.Element_SpecialMeasures = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_SpecialMeasures",                                                                                       // MakerGen.cs:236
                    Path= "MedicinalProduct.specialMeasures",                                                                               // MakerGen.cs:237
                    Id = "MedicinalProduct.specialMeasures",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. MedicinalProduct.paediatricUseIndicator
                this.Element_PaediatricUseIndicator = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PaediatricUseIndicator",                                                                                // MakerGen.cs:236
                    Path= "MedicinalProduct.paediatricUseIndicator",                                                                        // MakerGen.cs:237
                    Id = "MedicinalProduct.paediatricUseIndicator",                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. MedicinalProduct.productClassification
                this.Element_ProductClassification = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ProductClassification",                                                                                 // MakerGen.cs:236
                    Path= "MedicinalProduct.productClassification",                                                                         // MakerGen.cs:237
                    Id = "MedicinalProduct.productClassification",                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. MedicinalProduct.marketingStatus
                this.Element_MarketingStatus = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_MarketingStatus",                                                                                       // MakerGen.cs:236
                    Path= "MedicinalProduct.marketingStatus",                                                                               // MakerGen.cs:237
                    Id = "MedicinalProduct.marketingStatus",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_MarketingStatus                                                              // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. MedicinalProduct.pharmaceuticalProduct
                this.Element_PharmaceuticalProduct = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PharmaceuticalProduct",                                                                                 // MakerGen.cs:236
                    Path= "MedicinalProduct.pharmaceuticalProduct",                                                                         // MakerGen.cs:237
                    Id = "MedicinalProduct.pharmaceuticalProduct",                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical"                                    // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. MedicinalProduct.packagedMedicinalProduct
                this.Element_PackagedMedicinalProduct = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PackagedMedicinalProduct",                                                                              // MakerGen.cs:236
                    Path= "MedicinalProduct.packagedMedicinalProduct",                                                                      // MakerGen.cs:237
                    Id = "MedicinalProduct.packagedMedicinalProduct",                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. MedicinalProduct.attachedDocument
                this.Element_AttachedDocument = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AttachedDocument",                                                                                      // MakerGen.cs:236
                    Path= "MedicinalProduct.attachedDocument",                                                                              // MakerGen.cs:237
                    Id = "MedicinalProduct.attachedDocument",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. MedicinalProduct.masterFile
                this.Element_MasterFile = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_MasterFile",                                                                                            // MakerGen.cs:236
                    Path= "MedicinalProduct.masterFile",                                                                                    // MakerGen.cs:237
                    Id = "MedicinalProduct.masterFile",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. MedicinalProduct.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "MedicinalProduct.contact",                                                                                       // MakerGen.cs:237
                    Id = "MedicinalProduct.contact",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 16. MedicinalProduct.clinicalTrial
                this.Element_ClinicalTrial = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ClinicalTrial",                                                                                         // MakerGen.cs:236
                    Path= "MedicinalProduct.clinicalTrial",                                                                                 // MakerGen.cs:237
                    Id = "MedicinalProduct.clinicalTrial",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                     // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 17. MedicinalProduct.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "MedicinalProduct.name",                                                                                          // MakerGen.cs:237
                    Id = "MedicinalProduct.name",                                                                                           // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Name                                                                                                       // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 26. MedicinalProduct.crossReference
                this.Element_CrossReference = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_CrossReference",                                                                                        // MakerGen.cs:236
                    Path= "MedicinalProduct.crossReference",                                                                                // MakerGen.cs:237
                    Id = "MedicinalProduct.crossReference",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 27. MedicinalProduct.manufacturingBusinessOperation
                this.Element_ManufacturingBusinessOperation = new ElementDefinitionInfo                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ManufacturingBusinessOperation",                                                                        // MakerGen.cs:236
                    Path= "MedicinalProduct.manufacturingBusinessOperation",                                                                // MakerGen.cs:237
                    Id = "MedicinalProduct.manufacturingBusinessOperation",                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_ManufacturingBusinessOperation                                                                             // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 34. MedicinalProduct.specialDesignation
                this.Element_SpecialDesignation = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_SpecialDesignation",                                                                                    // MakerGen.cs:236
                    Path= "MedicinalProduct.specialDesignation",                                                                            // MakerGen.cs:237
                    Id = "MedicinalProduct.specialDesignation",                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_SpecialDesignation                                                                                         // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "MedicinalProduct";                                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProduct";                                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
