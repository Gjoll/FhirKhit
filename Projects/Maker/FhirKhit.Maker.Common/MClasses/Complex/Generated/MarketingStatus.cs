using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
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
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'MarketingStatus'
    /// </summary>
    // 0. MarketingStatus
    public class MarketingStatus : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class MarketingStatus_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. MarketingStatus.country
            public ElementDefinitionInfo Country;                                                                                           // MakerGen.cs:236
            // 2. MarketingStatus.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:236
            // 3. MarketingStatus.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 4. MarketingStatus.dateRange
            public ElementDefinitionInfo DateRange;                                                                                         // MakerGen.cs:236
            // 5. MarketingStatus.restoreDate
            public ElementDefinitionInfo RestoreDate;                                                                                       // MakerGen.cs:236
            public MarketingStatus_Elements()                                                                                               // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. MarketingStatus.country
                    this.Country = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Country",                                                                                                   // MakerGen.cs:255
                        Path= "MarketingStatus.country",                                                                                    // MakerGen.cs:256
                        Id = "MarketingStatus.country",                                                                                     // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 2. MarketingStatus.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:255
                        Path= "MarketingStatus.jurisdiction",                                                                               // MakerGen.cs:256
                        Id = "MarketingStatus.jurisdiction",                                                                                // MakerGen.cs:257
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
                    // 3. MarketingStatus.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "MarketingStatus.status",                                                                                     // MakerGen.cs:256
                        Id = "MarketingStatus.status",                                                                                      // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 4. MarketingStatus.dateRange
                    this.DateRange = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DateRange",                                                                                                 // MakerGen.cs:255
                        Path= "MarketingStatus.dateRange",                                                                                  // MakerGen.cs:256
                        Id = "MarketingStatus.dateRange",                                                                                   // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. MarketingStatus.restoreDate
                    this.RestoreDate = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "RestoreDate",                                                                                               // MakerGen.cs:255
                        Path= "MarketingStatus.restoreDate",                                                                                // MakerGen.cs:256
                        Id = "MarketingStatus.restoreDate",                                                                                 // MakerGen.cs:257
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
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Country.Write(sDef);                                                                                                        // MakerGen.cs:240
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                DateRange.Write(sDef);                                                                                                      // MakerGen.cs:240
                RestoreDate.Write(sDef);                                                                                                    // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public MarketingStatus_Elements Elements { get; }                                                                                   // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public MarketingStatus()                                                                                                            // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new MarketingStatus_Elements();                                                                                 // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
