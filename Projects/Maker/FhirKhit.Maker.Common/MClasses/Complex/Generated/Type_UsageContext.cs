using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'UsageContext'
    /// </summary>
    // 0. UsageContext
    public class Type_UsageContext : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. UsageContext.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 2. UsageContext.value[x]
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "UsageContext",                                                                                                      // MakerGen.cs:388
                ElementId = "UsageContext"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_UsageContext()                                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. UsageContext.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "UsageContext.code",                                                                                              // MakerGen.cs:232
                    Id = "UsageContext.code",                                                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. UsageContext.value[x]
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:231
                    Path= "UsageContext.value[x]",                                                                                          // MakerGen.cs:232
                    Id = "UsageContext.value[x]",                                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                                   // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/InsurancePlan",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                                // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
