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
    #endregion
    /// <summary>
    /// Fhir resource 'MedicinalProductAuthorization'
    /// </summary>
    // 0. MedicinalProductAuthorization
    public partial class Resource_MedicinalProductAuthorization : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
        public partial class Type_JurisdictionalAuthorization : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
            public ElementDefinitionInfo Element_Country;
            // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;
            // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
            public ElementDefinitionInfo Element_LegalStatusOfSupply;
            // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
            public ElementDefinitionInfo Element_ValidityPeriod;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductAuthorization.jurisdictionalAuthorization",
                    ElementId = "MedicinalProductAuthorization.jurisdictionalAuthorization"
                });
                Element_Identifier.Write(sDef);
                Element_Country.Write(sDef);
                Element_Jurisdiction.Write(sDef);
                Element_LegalStatusOfSupply.Write(sDef);
                Element_ValidityPeriod.Write(sDef);
            }
            
            public Type_JurisdictionalAuthorization()
            {
                {
                    // 14. MedicinalProductAuthorization.jurisdictionalAuthorization.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.identifier",
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
                    // 15. MedicinalProductAuthorization.jurisdictionalAuthorization.country
                    this.Element_Country = new ElementDefinitionInfo
                    {
                        Name = "Element_Country",
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.country",
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.country",
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
                    // 16. MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo
                    {
                        Name = "Element_Jurisdiction",
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.jurisdiction",
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
                    // 17. MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply
                    this.Element_LegalStatusOfSupply = new ElementDefinitionInfo
                    {
                        Name = "Element_LegalStatusOfSupply",
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.legalStatusOfSupply",
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
                    // 18. MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod
                    this.Element_ValidityPeriod = new ElementDefinitionInfo
                    {
                        Name = "Element_ValidityPeriod",
                        Path= "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",
                        Id = "MedicinalProductAuthorization.jurisdictionalAuthorization.validityPeriod",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 21. MedicinalProductAuthorization.procedure
        public partial class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. MedicinalProductAuthorization.procedure.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 23. MedicinalProductAuthorization.procedure.type
            public ElementDefinitionInfo Element_Type;
            // 24. MedicinalProductAuthorization.procedure.date[x]
            public ElementDefinitionInfo Element_Date;
            // 25. MedicinalProductAuthorization.procedure.application
            public ElementDefinitionInfo Element_Application;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MedicinalProductAuthorization.procedure",
                    ElementId = "MedicinalProductAuthorization.procedure"
                });
                Element_Identifier.Write(sDef);
                Element_Type.Write(sDef);
                Element_Date.Write(sDef);
                Element_Application.Write(sDef);
            }
            
            public Type_Procedure()
            {
                {
                    // 22. MedicinalProductAuthorization.procedure.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "MedicinalProductAuthorization.procedure.identifier",
                        Id = "MedicinalProductAuthorization.procedure.identifier",
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
                    // 23. MedicinalProductAuthorization.procedure.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MedicinalProductAuthorization.procedure.type",
                        Id = "MedicinalProductAuthorization.procedure.type",
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
                    // 24. MedicinalProductAuthorization.procedure.date[x]
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "MedicinalProductAuthorization.procedure.date[x]",
                        Id = "MedicinalProductAuthorization.procedure.date[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            }
                        }
                    };
                }
                {
                    // 25. MedicinalProductAuthorization.procedure.application
                    this.Element_Application = new ElementDefinitionInfo
                    {
                        Name = "Element_Application",
                        Path= "MedicinalProductAuthorization.procedure.application",
                        Id = "MedicinalProductAuthorization.procedure.application",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. MedicinalProductAuthorization.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MedicinalProductAuthorization.subject
        public ElementDefinitionInfo Element_Subject;
        // 3. MedicinalProductAuthorization.country
        public ElementDefinitionInfo Element_Country;
        // 4. MedicinalProductAuthorization.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 5. MedicinalProductAuthorization.status
        public ElementDefinitionInfo Element_Status;
        // 6. MedicinalProductAuthorization.statusDate
        public ElementDefinitionInfo Element_StatusDate;
        // 7. MedicinalProductAuthorization.restoreDate
        public ElementDefinitionInfo Element_RestoreDate;
        // 8. MedicinalProductAuthorization.validityPeriod
        public ElementDefinitionInfo Element_ValidityPeriod;
        // 9. MedicinalProductAuthorization.dataExclusivityPeriod
        public ElementDefinitionInfo Element_DataExclusivityPeriod;
        // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
        public ElementDefinitionInfo Element_DateOfFirstAuthorization;
        // 11. MedicinalProductAuthorization.internationalBirthDate
        public ElementDefinitionInfo Element_InternationalBirthDate;
        // 12. MedicinalProductAuthorization.legalBasis
        public ElementDefinitionInfo Element_LegalBasis;
        // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
        public ElementDefinitionInfo Element_JurisdictionalAuthorization;
        // 19. MedicinalProductAuthorization.holder
        public ElementDefinitionInfo Element_Holder;
        // 20. MedicinalProductAuthorization.regulator
        public ElementDefinitionInfo Element_Regulator;
        // 21. MedicinalProductAuthorization.procedure
        public ElementDefinitionInfo Element_Procedure;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MedicinalProductAuthorization",
                ElementId = "MedicinalProductAuthorization"
            });
            Element_Identifier.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Country.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusDate.Write(sDef);
            Element_RestoreDate.Write(sDef);
            Element_ValidityPeriod.Write(sDef);
            Element_DataExclusivityPeriod.Write(sDef);
            Element_DateOfFirstAuthorization.Write(sDef);
            Element_InternationalBirthDate.Write(sDef);
            Element_LegalBasis.Write(sDef);
            Element_JurisdictionalAuthorization.Write(sDef);
            Element_Holder.Write(sDef);
            Element_Regulator.Write(sDef);
            Element_Procedure.Write(sDef);
        }
        
        public Resource_MedicinalProductAuthorization()
        {
            {
                // 1. MedicinalProductAuthorization.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MedicinalProductAuthorization.identifier",
                    Id = "MedicinalProductAuthorization.identifier",
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
                // 2. MedicinalProductAuthorization.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MedicinalProductAuthorization.subject",
                    Id = "MedicinalProductAuthorization.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProduct",
                                "http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged"
                            }
                        }
                    }
                };
            }
            {
                // 3. MedicinalProductAuthorization.country
                this.Element_Country = new ElementDefinitionInfo
                {
                    Name = "Element_Country",
                    Path= "MedicinalProductAuthorization.country",
                    Id = "MedicinalProductAuthorization.country",
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
                // 4. MedicinalProductAuthorization.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "MedicinalProductAuthorization.jurisdiction",
                    Id = "MedicinalProductAuthorization.jurisdiction",
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
                // 5. MedicinalProductAuthorization.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "MedicinalProductAuthorization.status",
                    Id = "MedicinalProductAuthorization.status",
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
                // 6. MedicinalProductAuthorization.statusDate
                this.Element_StatusDate = new ElementDefinitionInfo
                {
                    Name = "Element_StatusDate",
                    Path= "MedicinalProductAuthorization.statusDate",
                    Id = "MedicinalProductAuthorization.statusDate",
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
                // 7. MedicinalProductAuthorization.restoreDate
                this.Element_RestoreDate = new ElementDefinitionInfo
                {
                    Name = "Element_RestoreDate",
                    Path= "MedicinalProductAuthorization.restoreDate",
                    Id = "MedicinalProductAuthorization.restoreDate",
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
                // 8. MedicinalProductAuthorization.validityPeriod
                this.Element_ValidityPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_ValidityPeriod",
                    Path= "MedicinalProductAuthorization.validityPeriod",
                    Id = "MedicinalProductAuthorization.validityPeriod",
                    Min = 0,
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
                // 9. MedicinalProductAuthorization.dataExclusivityPeriod
                this.Element_DataExclusivityPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_DataExclusivityPeriod",
                    Path= "MedicinalProductAuthorization.dataExclusivityPeriod",
                    Id = "MedicinalProductAuthorization.dataExclusivityPeriod",
                    Min = 0,
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
                // 10. MedicinalProductAuthorization.dateOfFirstAuthorization
                this.Element_DateOfFirstAuthorization = new ElementDefinitionInfo
                {
                    Name = "Element_DateOfFirstAuthorization",
                    Path= "MedicinalProductAuthorization.dateOfFirstAuthorization",
                    Id = "MedicinalProductAuthorization.dateOfFirstAuthorization",
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
                // 11. MedicinalProductAuthorization.internationalBirthDate
                this.Element_InternationalBirthDate = new ElementDefinitionInfo
                {
                    Name = "Element_InternationalBirthDate",
                    Path= "MedicinalProductAuthorization.internationalBirthDate",
                    Id = "MedicinalProductAuthorization.internationalBirthDate",
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
                // 12. MedicinalProductAuthorization.legalBasis
                this.Element_LegalBasis = new ElementDefinitionInfo
                {
                    Name = "Element_LegalBasis",
                    Path= "MedicinalProductAuthorization.legalBasis",
                    Id = "MedicinalProductAuthorization.legalBasis",
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
                // 13. MedicinalProductAuthorization.jurisdictionalAuthorization
                this.Element_JurisdictionalAuthorization = new ElementDefinitionInfo
                {
                    Name = "Element_JurisdictionalAuthorization",
                    Path= "MedicinalProductAuthorization.jurisdictionalAuthorization",
                    Id = "MedicinalProductAuthorization.jurisdictionalAuthorization",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_JurisdictionalAuthorization
                        {
                        }
                    }
                };
            }
            {
                // 19. MedicinalProductAuthorization.holder
                this.Element_Holder = new ElementDefinitionInfo
                {
                    Name = "Element_Holder",
                    Path= "MedicinalProductAuthorization.holder",
                    Id = "MedicinalProductAuthorization.holder",
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
            {
                // 20. MedicinalProductAuthorization.regulator
                this.Element_Regulator = new ElementDefinitionInfo
                {
                    Name = "Element_Regulator",
                    Path= "MedicinalProductAuthorization.regulator",
                    Id = "MedicinalProductAuthorization.regulator",
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
            {
                // 21. MedicinalProductAuthorization.procedure
                this.Element_Procedure = new ElementDefinitionInfo
                {
                    Name = "Element_Procedure",
                    Path= "MedicinalProductAuthorization.procedure",
                    Id = "MedicinalProductAuthorization.procedure",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Procedure
                        {
                        }
                    }
                };
            }
            this.Name = "MedicinalProductAuthorization";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization";
        }
    }
}
