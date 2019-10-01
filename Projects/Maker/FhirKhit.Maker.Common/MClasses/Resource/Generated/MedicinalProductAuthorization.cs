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
      "id": "MedicinalProductAuthorization",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization",
      "version": "4.0.0",
      "name": "MedicinalProductAuthorization",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The regulatory authorization of a medicinal product.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicinalProductAuthorization",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicinalProductAuthorization",
            "path": "MedicinalProductAuthorization",
            "short": "The regulatory authorization of a medicinal product",
            "definition": "The regulatory authorization of a medicinal product.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicinalProductAuthorization.identifier",
            "path": "MedicinalProductAuthorization.identifier",
            "short": "Business identifier for the marketing authorization, as assigned by a regulator",
            "definition": "Business identifier for the marketing authorization, as assigned by a regulator.",
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
            "id": "MedicinalProductAuthorization.subject",
            "path": "MedicinalProductAuthorization.subject",
            "short": "The medicinal product that is being authorized",
            "definition": "The medicinal product that is being authorized.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                  "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.country",
            "path": "MedicinalProductAuthorization.country",
            "short": "The country in which the marketing authorization has been granted",
            "definition": "The country in which the marketing authorization has been granted.",
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
            "id": "MedicinalProductAuthorization.jurisdiction",
            "path": "MedicinalProductAuthorization.jurisdiction",
            "short": "Jurisdiction within a country",
            "definition": "Jurisdiction within a country.",
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
            "id": "MedicinalProductAuthorization.status",
            "path": "MedicinalProductAuthorization.status",
            "short": "The status of the marketing authorization",
            "definition": "The status of the marketing authorization.",
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
            "id": "MedicinalProductAuthorization.statusDate",
            "path": "MedicinalProductAuthorization.statusDate",
            "short": "The date at which the given status has become applicable",
            "definition": "The date at which the given status has become applicable.",
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
            "id": "MedicinalProductAuthorization.restoreDate",
            "path": "MedicinalProductAuthorization.restoreDate",
            "short": "The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored",
            "definition": "The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored.",
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
            "id": "MedicinalProductAuthorization.validityPeriod",
            "path": "MedicinalProductAuthorization.validityPeriod",
            "short": "The beginning of the time period in which the marketing authorization is in the specific status shall be specified A complete date consisting of day, month and year shall be specified using the ISO 8601 date format",
            "definition": "The beginning of the time period in which the marketing authorization is in the specific status shall be specified A complete date consisting of day, month and year shall be specified using the ISO 8601 date format.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.dataExclusivityPeriod",
            "path": "MedicinalProductAuthorization.dataExclusivityPeriod",
            "short": "A period of time after authorization before generic product applicatiosn can be submitted",
            "definition": "A period of time after authorization before generic product applicatiosn can be submitted.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.dateOfFirstAuthorization",
            "path": "MedicinalProductAuthorization.dateOfFirstAuthorization",
            "short": "The date when the first authorization was granted by a Medicines Regulatory Agency",
            "definition": "The date when the first authorization was granted by a Medicines Regulatory Agency.",
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
            "id": "MedicinalProductAuthorization.internationalBirthDate",
            "path": "MedicinalProductAuthorization.internationalBirthDate",
            "short": "Date of first marketing authorization for a company's new medicinal product in any country in the World",
            "definition": "Date of first marketing authorization for a company's new medicinal product in any country in the World.",
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
            "id": "MedicinalProductAuthorization.legalBasis",
            "path": "MedicinalProductAuthorization.legalBasis",
            "short": "The legal framework against which this authorization is granted",
            "definition": "The legal framework against which this authorization is granted.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization",
            "short": "Authorization in areas within a country",
            "definition": "Authorization in areas within a country.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",
            "short": "The assigned number for the marketing authorization",
            "definition": "The assigned number for the marketing authorization.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization.country",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization.country",
            "short": "Country of authorization",
            "definition": "Country of authorization.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",
            "short": "Jurisdiction within a country",
            "definition": "Jurisdiction within a country.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",
            "short": "The legal status of supply in a jurisdiction or region",
            "definition": "The legal status of supply in a jurisdiction or region.",
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
            "id": "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",
            "path": "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",
            "short": "The start and expected end date of the authorization",
            "definition": "The start and expected end date of the authorization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.holder",
            "path": "MedicinalProductAuthorization.holder",
            "short": "Marketing Authorization Holder",
            "definition": "Marketing Authorization Holder.",
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
            "id": "MedicinalProductAuthorization.regulator",
            "path": "MedicinalProductAuthorization.regulator",
            "short": "Medicines Regulatory Agency",
            "definition": "Medicines Regulatory Agency.",
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
            "id": "MedicinalProductAuthorization.procedure",
            "path": "MedicinalProductAuthorization.procedure",
            "short": "The regulatory procedure for granting or amending a marketing authorization",
            "definition": "The regulatory procedure for granting or amending a marketing authorization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.procedure.identifier",
            "path": "MedicinalProductAuthorization.procedure.identifier",
            "short": "Identifier for this procedure",
            "definition": "Identifier for this procedure.",
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
            "id": "MedicinalProductAuthorization.procedure.type",
            "path": "MedicinalProductAuthorization.procedure.type",
            "short": "Type of procedure",
            "definition": "Type of procedure.",
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
            "id": "MedicinalProductAuthorization.procedure.date[x]",
            "path": "MedicinalProductAuthorization.procedure.date[x]",
            "short": "Date of procedure",
            "definition": "Date of procedure.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              },
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicinalProductAuthorization.procedure.application",
            "path": "MedicinalProductAuthorization.procedure.application",
            "short": "Applcations submitted to obtain a marketing authorization",
            "definition": "Applcations submitted to obtain a marketing authorization.",
            "min": 0,
            "max": "*",
            "contentReference": "#MedicinalProductAuthorization.procedure",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'MedicinalProductAuthorization'
    /// </summary>
    // 0. MedicinalProductAuthorization
    public class MedicinalProductAuthorization : FhirKhit.Maker.Common.Resource.ResourceBase                                                // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
        public class Type_JurisdictionalAuthorization : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
            public MakerElementInstance Element_Country;                                                                                    // MakerGen.cs:232
            // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
            public MakerElementInstance Element_Jurisdiction;                                                                               // MakerGen.cs:232
            // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
            public MakerElementInstance Element_LegalStatusOfSupply;                                                                        // MakerGen.cs:232
            // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
            public MakerElementInstance Element_ValidityPeriod;                                                                             // MakerGen.cs:232
            public Type_JurisdictionalAuthorization()                                                                                       // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
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
                    // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
                    this.Element_Country = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Country",                                                                                           // MakerGen.cs:247
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
                    // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
                    this.Element_Jurisdiction = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
                    this.Element_LegalStatusOfSupply = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_LegalStatusOfSupply",                                                                               // MakerGen.cs:247
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
                    // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
                    this.Element_ValidityPeriod = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ValidityPeriod",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 21. MedicinalProductAuthorization.procedure
        public class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 22. MedicinalProductAuthorization.procedure.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            // 23. MedicinalProductAuthorization.procedure.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 24. MedicinalProductAuthorization.procedure.date[x]
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 25. MedicinalProductAuthorization.procedure.application
            public MakerElementInstance Element_Application;                                                                                // MakerGen.cs:232
            public Type_Procedure()                                                                                                         // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 22. MedicinalProductAuthorization.procedure.identifier
                    this.Element_Identifier = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 23. MedicinalProductAuthorization.procedure.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
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
                    // 24. MedicinalProductAuthorization.procedure.date[x]
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
                    // 25. MedicinalProductAuthorization.procedure.application
                    this.Element_Application = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Application",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. MedicinalProductAuthorization.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. MedicinalProductAuthorization.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 3. MedicinalProductAuthorization.country
        public MakerElementInstance Element_Country;                                                                                        // MakerGen.cs:232
        // 4. MedicinalProductAuthorization.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 5. MedicinalProductAuthorization.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 6. MedicinalProductAuthorization.statusDate
        public MakerElementInstance Element_StatusDate;                                                                                     // MakerGen.cs:232
        // 7. MedicinalProductAuthorization.restoreDate
        public MakerElementInstance Element_RestoreDate;                                                                                    // MakerGen.cs:232
        // 8. MedicinalProductAuthorization.validityPeriod
        public MakerElementInstance Element_ValidityPeriod;                                                                                 // MakerGen.cs:232
        // 9. MedicinalProductAuthorization.dataExclusivityPeriod
        public MakerElementInstance Element_DataExclusivityPeriod;                                                                          // MakerGen.cs:232
        // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
        public MakerElementInstance Element_DateOfFirstAuthorization;                                                                       // MakerGen.cs:232
        // 11. MedicinalProductAuthorization.internationalBirthDate
        public MakerElementInstance Element_InternationalBirthDate;                                                                         // MakerGen.cs:232
        // 12. MedicinalProductAuthorization.legalBasis
        public MakerElementInstance Element_LegalBasis;                                                                                     // MakerGen.cs:232
        // 19. MedicinalProductAuthorization.holder
        public MakerElementInstance Element_Holder;                                                                                         // MakerGen.cs:232
        // 20. MedicinalProductAuthorization.regulator
        public MakerElementInstance Element_Regulator;                                                                                      // MakerGen.cs:232
        public MedicinalProductAuthorization()                                                                                              // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. MedicinalProductAuthorization.identifier
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
                // 2. MedicinalProductAuthorization.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. MedicinalProductAuthorization.country
                this.Element_Country = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Country",                                                                                               // MakerGen.cs:247
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
                // 4. MedicinalProductAuthorization.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
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
                // 5. MedicinalProductAuthorization.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
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
                // 6. MedicinalProductAuthorization.statusDate
                this.Element_StatusDate = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusDate",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 7. MedicinalProductAuthorization.restoreDate
                this.Element_RestoreDate = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_RestoreDate",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 8. MedicinalProductAuthorization.validityPeriod
                this.Element_ValidityPeriod = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ValidityPeriod",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 9. MedicinalProductAuthorization.dataExclusivityPeriod
                this.Element_DataExclusivityPeriod = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DataExclusivityPeriod",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
                this.Element_DateOfFirstAuthorization = new MakerElementInstance                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DateOfFirstAuthorization",                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 11. MedicinalProductAuthorization.internationalBirthDate
                this.Element_InternationalBirthDate = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InternationalBirthDate",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 12. MedicinalProductAuthorization.legalBasis
                this.Element_LegalBasis = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LegalBasis",                                                                                            // MakerGen.cs:247
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
                // 19. MedicinalProductAuthorization.holder
                this.Element_Holder = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Holder",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 20. MedicinalProductAuthorization.regulator
                this.Element_Regulator = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Regulator",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
