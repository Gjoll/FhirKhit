using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
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
    #endregion
    /// <summary>
    /// Fhir complex 'MarketingStatus'
    /// </summary>
    // 0. MarketingStatus
    public partial class Type_MarketingStatus : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. MarketingStatus.country
        public ElementDefinitionInfo Element_Country;
        // 2. MarketingStatus.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 3. MarketingStatus.status
        public ElementDefinitionInfo Element_Status;
        // 4. MarketingStatus.dateRange
        public ElementDefinitionInfo Element_DateRange;
        // 5. MarketingStatus.restoreDate
        public ElementDefinitionInfo Element_RestoreDate;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MarketingStatus",
                ElementId = "MarketingStatus"
            });
            Element_Country.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Status.Write(sDef);
            Element_DateRange.Write(sDef);
            Element_RestoreDate.Write(sDef);
        }
        
        public Type_MarketingStatus()
        {
            {
                // 1. MarketingStatus.country
                this.Element_Country = new ElementDefinitionInfo
                {
                    Name = "Element_Country",
                    Path= "MarketingStatus.country",
                    Id = "MarketingStatus.country",
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
                // 2. MarketingStatus.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "MarketingStatus.jurisdiction",
                    Id = "MarketingStatus.jurisdiction",
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
                // 3. MarketingStatus.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "MarketingStatus.status",
                    Id = "MarketingStatus.status",
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
                // 4. MarketingStatus.dateRange
                this.Element_DateRange = new ElementDefinitionInfo
                {
                    Name = "Element_DateRange",
                    Path= "MarketingStatus.dateRange",
                    Id = "MarketingStatus.dateRange",
                    Min = 1,
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
                // 5. MarketingStatus.restoreDate
                this.Element_RestoreDate = new ElementDefinitionInfo
                {
                    Name = "Element_RestoreDate",
                    Path= "MarketingStatus.restoreDate",
                    Id = "MarketingStatus.restoreDate",
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
        }
    }
}
