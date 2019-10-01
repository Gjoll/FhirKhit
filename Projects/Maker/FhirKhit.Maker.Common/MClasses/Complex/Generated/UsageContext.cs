using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "UsageContext",
      "url": "http://hl7.org/fhir/StructureDefinition/UsageContext",
      "version": "4.0.0",
      "name": "UsageContext",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for UsageContext Type: Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).",
      "purpose": "Consumers of the resource must be able to determine the intended applicability for the resource. Ideally, this information would be used programmatically to determine when and how it should be incorporated or exposed.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "UsageContext",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "UsageContext",
            "path": "UsageContext",
            "short": "Describes the context of use for a conformance or knowledge resource",
            "definition": "Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "UsageContext.code",
            "path": "UsageContext.code",
            "short": "Type of context being specified",
            "definition": "A code that identifies the type of context being specified by this usage context.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "UsageContextType"
                }
              ],
              "strength": "extensible",
              "description": "A code that specifies a type of context being specified by a usage context.",
              "valueSet": "http://hl7.org/fhir/ValueSet/usage-context-type"
            }
          },
          {
            "id": "UsageContext.value[x]",
            "path": "UsageContext.value[x]",
            "short": "Value that defines the context",
            "definition": "A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ResearchStudy",
                  "http://hl7.org/fhir/StructureDefinition/InsurancePlan",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "UsageContextValue"
                }
              ],
              "strength": "example",
              "description": "A code that defines the specific value for the context being specified.",
              "valueSet": "http://hl7.org/fhir/ValueSet/use-context"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'UsageContext'
    /// </summary>
    // 0. UsageContext
    public class UsageContext : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class UsageContext_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. UsageContext.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:216
            // 2. UsageContext.value[x]
            public ElementDefinitionInfo Value;                                                                                             // MakerGen.cs:216
            public UsageContext_Elements()                                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. UsageContext.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Code",                                                                                                      // MakerGen.cs:235
                        Path= "UsageContext.code",                                                                                          // MakerGen.cs:236
                        Id = "UsageContext.code",                                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. UsageContext.value[x]
                    this.Value = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Value",                                                                                                     // MakerGen.cs:235
                        Path= "UsageContext.value[x]",                                                                                      // MakerGen.cs:236
                        Id = "UsageContext.value[x]",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            },                                                                                                              // MakerGen.cs:360
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/InsurancePlan",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Code.Write(sDef);                                                                                                           // MakerGen.cs:220
                Value.Write(sDef);                                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public UsageContext_Elements Elements { get; }                                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public UsageContext()                                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new UsageContext_Elements();                                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
