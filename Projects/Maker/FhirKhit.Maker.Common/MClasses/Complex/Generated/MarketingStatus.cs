using System;                                                                                                                               // MakerGen.cs:516
using System.Diagnostics;                                                                                                                   // MakerGen.cs:517
using System.IO;                                                                                                                            // MakerGen.cs:518
using System.Linq;                                                                                                                          // MakerGen.cs:519
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:520
                                                                                                                                            // MakerGen.cs:521
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:522
{                                                                                                                                           // MakerGen.cs:523
    #region Json                                                                                                                            // MakerGen.cs:524
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "MarketingStatus",
      "url": "http://hl7.org/fhir/StructureDefinition/MarketingStatus",
      "version": "4.0.0",
      "name": "MarketingStatus",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for MarketingStatus Type: The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "MarketingStatus",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MarketingStatus",
            "path": "MarketingStatus",
            "short": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available",
            "definition": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MarketingStatus.country",
            "path": "MarketingStatus.country",
            "short": "The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements",
            "definition": "The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements.",
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
            "id": "MarketingStatus.jurisdiction",
            "path": "MarketingStatus.jurisdiction",
            "short": "Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified",
            "definition": "Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified.",
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
            "id": "MarketingStatus.status",
            "path": "MarketingStatus.status",
            "short": "This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples",
            "definition": "This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples.",
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
            "id": "MarketingStatus.dateRange",
            "path": "MarketingStatus.dateRange",
            "short": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain",
            "definition": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MarketingStatus.restoreDate",
            "path": "MarketingStatus.restoreDate",
            "short": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain",
            "definition": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'MarketingStatus'
    /// </summary>
    // 0. MarketingStatus
    public class MarketingStatus : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MarketingStatus_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. MarketingStatus.country
            public ElementDefinitionInfo Country;                                                                                           // MakerGen.cs:216
            // 2. MarketingStatus.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 3. MarketingStatus.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 4. MarketingStatus.dateRange
            public ElementDefinitionInfo DateRange;                                                                                         // MakerGen.cs:216
            // 5. MarketingStatus.restoreDate
            public ElementDefinitionInfo RestoreDate;                                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MarketingStatus_Elements()                                                                                               // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MarketingStatus.country
                    this.Country = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Country",                                                                                                   // MakerGen.cs:235
                        Path= "MarketingStatus.country",                                                                                    // MakerGen.cs:236
                        Id = "MarketingStatus.country",                                                                                     // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MarketingStatus.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "MarketingStatus.jurisdiction",                                                                               // MakerGen.cs:236
                        Id = "MarketingStatus.jurisdiction",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MarketingStatus.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "MarketingStatus.status",                                                                                     // MakerGen.cs:236
                        Id = "MarketingStatus.status",                                                                                      // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. MarketingStatus.dateRange
                    this.DateRange = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DateRange",                                                                                                 // MakerGen.cs:235
                        Path= "MarketingStatus.dateRange",                                                                                  // MakerGen.cs:236
                        Id = "MarketingStatus.dateRange",                                                                                   // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MarketingStatus.restoreDate
                    this.RestoreDate = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RestoreDate",                                                                                               // MakerGen.cs:235
                        Path= "MarketingStatus.restoreDate",                                                                                // MakerGen.cs:236
                        Id = "MarketingStatus.restoreDate",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Country.Write(sDef);                                                                                                        // MakerGen.cs:220
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                DateRange.Write(sDef);                                                                                                      // MakerGen.cs:220
                RestoreDate.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MarketingStatus_Elements Elements                                                                                            // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MarketingStatus_Elements();                                                                         // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MarketingStatus_Elements elements;                                                                                                  // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MarketingStatus()                                                                                                            // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MarketingStatus",                                                                                                   // MakerGen.cs:428
                ElementId = "MarketingStatus"                                                                                               // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
