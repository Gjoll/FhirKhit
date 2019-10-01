using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'MedicinalProductAuthorization'
    /// </summary>
    // 0. MedicinalProductAuthorization
    public class Resource_MedicinalProductAuthorization : FhirKhit.Maker.Common.Resource.ResourceBase                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
        public class Type_JurisdictionalAuthorization : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
            public ElementDefinitionInfo Element_Country;                                                                                   // MakerGen.cs:212
            // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;                                                                              // MakerGen.cs:212
            // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
            public ElementDefinitionInfo Element_LegalStatusOfSupply;                                                                       // MakerGen.cs:212
            // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
            public ElementDefinitionInfo Element_ValidityPeriod;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicinalProductAuthorization.jurisdictionalAuthorization",                                                     // MakerGen.cs:388
                    ElementId = "MedicinalProductAuthorization.jurisdictionalAuthorization"                                                 // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Country.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_LegalStatusOfSupply.Write(sDef);                                                                                    // MakerGen.cs:216
                Element_ValidityPeriod.Write(sDef);                                                                                         // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_JurisdictionalAuthorization()                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",                                       // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
                    this.Element_Country = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Country",                                                                                           // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.country",                                          // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.country",                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",                                     // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
                    this.Element_LegalStatusOfSupply = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_LegalStatusOfSupply",                                                                               // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",                              // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
                    this.Element_ValidityPeriod = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ValidityPeriod",                                                                                    // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",                                   // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 21. MedicinalProductAuthorization.procedure
        public class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 22. MedicinalProductAuthorization.procedure.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 23. MedicinalProductAuthorization.procedure.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 24. MedicinalProductAuthorization.procedure.date[x]
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:212
            // 25. MedicinalProductAuthorization.procedure.application
            public ElementDefinitionInfo Element_Application;                                                                               // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "MedicinalProductAuthorization.procedure",                                                                       // MakerGen.cs:388
                    ElementId = "MedicinalProductAuthorization.procedure"                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Application.Write(sDef);                                                                                            // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Procedure()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 22. MedicinalProductAuthorization.procedure.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.procedure.identifier",                                                         // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.procedure.identifier",                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 23. MedicinalProductAuthorization.procedure.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.procedure.type",                                                               // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.procedure.type",                                                                // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. MedicinalProductAuthorization.procedure.date[x]
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Date",                                                                                              // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.procedure.date[x]",                                                            // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.procedure.date[x]",                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 25. MedicinalProductAuthorization.procedure.application
                    this.Element_Application = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Application",                                                                                       // MakerGen.cs:231
                        Path= "MedicinalProductAuthorization.procedure.application",                                                        // MakerGen.cs:232
                        Id = "MedicinalProductAuthorization.procedure.application",                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. MedicinalProductAuthorization.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. MedicinalProductAuthorization.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 3. MedicinalProductAuthorization.country
        public ElementDefinitionInfo Element_Country;                                                                                       // MakerGen.cs:212
        // 4. MedicinalProductAuthorization.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:212
        // 5. MedicinalProductAuthorization.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 6. MedicinalProductAuthorization.statusDate
        public ElementDefinitionInfo Element_StatusDate;                                                                                    // MakerGen.cs:212
        // 7. MedicinalProductAuthorization.restoreDate
        public ElementDefinitionInfo Element_RestoreDate;                                                                                   // MakerGen.cs:212
        // 8. MedicinalProductAuthorization.validityPeriod
        public ElementDefinitionInfo Element_ValidityPeriod;                                                                                // MakerGen.cs:212
        // 9. MedicinalProductAuthorization.dataExclusivityPeriod
        public ElementDefinitionInfo Element_DataExclusivityPeriod;                                                                         // MakerGen.cs:212
        // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
        public ElementDefinitionInfo Element_DateOfFirstAuthorization;                                                                      // MakerGen.cs:212
        // 11. MedicinalProductAuthorization.internationalBirthDate
        public ElementDefinitionInfo Element_InternationalBirthDate;                                                                        // MakerGen.cs:212
        // 12. MedicinalProductAuthorization.legalBasis
        public ElementDefinitionInfo Element_LegalBasis;                                                                                    // MakerGen.cs:212
        // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
        public ElementDefinitionInfo Element_JurisdictionalAuthorization;                                                                   // MakerGen.cs:212
        // 19. MedicinalProductAuthorization.holder
        public ElementDefinitionInfo Element_Holder;                                                                                        // MakerGen.cs:212
        // 20. MedicinalProductAuthorization.regulator
        public ElementDefinitionInfo Element_Regulator;                                                                                     // MakerGen.cs:212
        // 21. MedicinalProductAuthorization.procedure
        public ElementDefinitionInfo Element_Procedure;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "MedicinalProductAuthorization",                                                                                     // MakerGen.cs:388
                ElementId = "MedicinalProductAuthorization"                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Country.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_StatusDate.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_RestoreDate.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_ValidityPeriod.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_DataExclusivityPeriod.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_DateOfFirstAuthorization.Write(sDef);                                                                                   // MakerGen.cs:216
            Element_InternationalBirthDate.Write(sDef);                                                                                     // MakerGen.cs:216
            Element_LegalBasis.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_JurisdictionalAuthorization.Write(sDef);                                                                                // MakerGen.cs:216
            Element_Holder.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Regulator.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Procedure.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_MedicinalProductAuthorization()                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. MedicinalProductAuthorization.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.identifier",                                                                       // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.identifier",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. MedicinalProductAuthorization.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.subject",                                                                          // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.subject",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. MedicinalProductAuthorization.country
                this.Element_Country = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Country",                                                                                               // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.country",                                                                          // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.country",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. MedicinalProductAuthorization.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.jurisdiction",                                                                     // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.jurisdiction",                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. MedicinalProductAuthorization.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.status",                                                                           // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.status",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. MedicinalProductAuthorization.statusDate
                this.Element_StatusDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StatusDate",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.statusDate",                                                                       // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.statusDate",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. MedicinalProductAuthorization.restoreDate
                this.Element_RestoreDate = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_RestoreDate",                                                                                           // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.restoreDate",                                                                      // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.restoreDate",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. MedicinalProductAuthorization.validityPeriod
                this.Element_ValidityPeriod = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ValidityPeriod",                                                                                        // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.validityPeriod",                                                                   // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.validityPeriod",                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. MedicinalProductAuthorization.dataExclusivityPeriod
                this.Element_DataExclusivityPeriod = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DataExclusivityPeriod",                                                                                 // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.dataExclusivityPeriod",                                                            // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.dataExclusivityPeriod",                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
                this.Element_DateOfFirstAuthorization = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DateOfFirstAuthorization",                                                                              // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.dateOfFirstAuthorization",                                                         // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.dateOfFirstAuthorization",                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. MedicinalProductAuthorization.internationalBirthDate
                this.Element_InternationalBirthDate = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_InternationalBirthDate",                                                                                // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.internationalBirthDate",                                                           // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.internationalBirthDate",                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. MedicinalProductAuthorization.legalBasis
                this.Element_LegalBasis = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LegalBasis",                                                                                            // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.legalBasis",                                                                       // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.legalBasis",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
                this.Element_JurisdictionalAuthorization = new ElementDefinitionInfo                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_JurisdictionalAuthorization",                                                                           // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.jurisdictionalAuthorization",                                                      // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.jurisdictionalAuthorization",                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_JurisdictionalAuthorization                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 19. MedicinalProductAuthorization.holder
                this.Element_Holder = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Holder",                                                                                                // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.holder",                                                                           // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.holder",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 20. MedicinalProductAuthorization.regulator
                this.Element_Regulator = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Regulator",                                                                                             // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.regulator",                                                                        // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.regulator",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. MedicinalProductAuthorization.procedure
                this.Element_Procedure = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Procedure",                                                                                             // MakerGen.cs:231
                    Path= "MedicinalProductAuthorization.procedure",                                                                        // MakerGen.cs:232
                    Id = "MedicinalProductAuthorization.procedure",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Procedure                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "MedicinalProductAuthorization";                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization";                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
