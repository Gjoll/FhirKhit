using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'MarketingStatus'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "MarketingStatus",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/MarketingStatus",
    ///   "version": "4.0.0",
    ///   "name": "MarketingStatus",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for MarketingStatus Type: The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "MarketingStatus",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "MarketingStatus",
    ///         "path": "MarketingStatus",
    ///         "short": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available",
    ///         "definition": "The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "MarketingStatus.country",
    ///         "path": "MarketingStatus.country",
    ///         "short": "The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements",
    ///         "definition": "The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "MarketingStatus.jurisdiction",
    ///         "path": "MarketingStatus.jurisdiction",
    ///         "short": "Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified",
    ///         "definition": "Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "MarketingStatus.status",
    ///         "path": "MarketingStatus.status",
    ///         "short": "This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples",
    ///         "definition": "This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "MarketingStatus.dateRange",
    ///         "path": "MarketingStatus.dateRange",
    ///         "short": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain",
    ///         "definition": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Period"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "MarketingStatus.restoreDate",
    ///         "path": "MarketingStatus.restoreDate",
    ///         "short": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain",
    ///         "definition": "The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. MarketingStatus
    public class MarketingStatus_Type : MakerComplex_Type                                                                                   // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. MarketingStatus.country
        public MakerElementInstance Country;                                                                                                // MakerGen.cs:217
        // 2. MarketingStatus.jurisdiction
        public MakerElementInstance Jurisdiction;                                                                                           // MakerGen.cs:217
        // 3. MarketingStatus.status
        public MakerElementInstance Status;                                                                                                 // MakerGen.cs:217
        // 4. MarketingStatus.dateRange
        public MakerElementInstance DateRange;                                                                                              // MakerGen.cs:217
        // 5. MarketingStatus.restoreDate
        public MakerElementInstance RestoreDate;                                                                                            // MakerGen.cs:217
        public MarketingStatus_Type()                                                                                                       // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. MarketingStatus.country
                this.Country = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Country",                                                                                                       // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. MarketingStatus.jurisdiction
                this.Jurisdiction = new MakerElementInstance                                                                                // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Jurisdiction",                                                                                                  // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. MarketingStatus.status
                this.Status = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Status",                                                                                                        // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. MarketingStatus.dateRange
                this.DateRange = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "DateRange",                                                                                                     // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. MarketingStatus.restoreDate
                this.RestoreDate = new MakerElementInstance                                                                                 // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "RestoreDate",                                                                                                   // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new DateTime_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
