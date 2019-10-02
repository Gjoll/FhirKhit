using System;                                                                                                                               // MakerGen.cs:498
using System.Diagnostics;                                                                                                                   // MakerGen.cs:499
using System.IO;                                                                                                                            // MakerGen.cs:500
using System.Linq;                                                                                                                          // MakerGen.cs:501
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:502
                                                                                                                                            // MakerGen.cs:503
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:504
{                                                                                                                                           // MakerGen.cs:505
    #region Json                                                                                                                            // MakerGen.cs:506
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "ParameterDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ParameterDefinition",
      "version": "4.0.0",
      "name": "ParameterDefinition",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ParameterDefinition Type: The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ParameterDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ParameterDefinition",
            "path": "ParameterDefinition",
            "short": "Definition of a parameter to a module",
            "definition": "The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ParameterDefinition.name",
            "path": "ParameterDefinition.name",
            "short": "Name used to access the parameter value",
            "definition": "The name of the parameter used to allow access to the value of the parameter in evaluation contexts.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ParameterDefinition.use",
            "path": "ParameterDefinition.use",
            "short": "in | out",
            "definition": "Whether the parameter is input or output for the module.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ParameterUse"
                }
              ],
              "strength": "required",
              "description": "Whether the parameter is input or output.",
              "valueSet": "http://hl7.org/fhir/ValueSet/operation-parameter-use|4.0.0"
            }
          },
          {
            "id": "ParameterDefinition.min",
            "path": "ParameterDefinition.min",
            "short": "Minimum cardinality",
            "definition": "The minimum number of times this parameter SHALL appear in the request or response.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ParameterDefinition.max",
            "path": "ParameterDefinition.max",
            "short": "Maximum cardinality (a number of *)",
            "definition": "The maximum number of times this element is permitted to appear in the request or response.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ParameterDefinition.documentation",
            "path": "ParameterDefinition.documentation",
            "short": "A brief description of the parameter",
            "definition": "A brief discussion of what the parameter is for and how it is used by the module.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ParameterDefinition.type",
            "path": "ParameterDefinition.type",
            "short": "What type of value",
            "definition": "The type of the parameter.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRAllTypes"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A list of all the concrete types defined in this version of the FHIR specification - Abstract Types, Data Types and Resource Types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/all-types|4.0.0"
            }
          },
          {
            "id": "ParameterDefinition.profile",
            "path": "ParameterDefinition.profile",
            "short": "What profile the value is expected to be",
            "definition": "If specified, this indicates a profile that the input data must conform to, or that the output data will conform to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:510
    /// <summary>
    /// Fhir complex 'ParameterDefinition'
    /// </summary>
    // 0. ParameterDefinition
    public class Type_ParameterDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. ParameterDefinition.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 2. ParameterDefinition.use
        public ElementDefinitionInfo Element_Use;                                                                                           // MakerGen.cs:219
        // 3. ParameterDefinition.min
        public ElementDefinitionInfo Element_Min;                                                                                           // MakerGen.cs:219
        // 4. ParameterDefinition.max
        public ElementDefinitionInfo Element_Max;                                                                                           // MakerGen.cs:219
        // 5. ParameterDefinition.documentation
        public ElementDefinitionInfo Element_Documentation;                                                                                 // MakerGen.cs:219
        // 6. ParameterDefinition.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 7. ParameterDefinition.profile
        public ElementDefinitionInfo Element_Profile;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "ParameterDefinition",                                                                                               // MakerGen.cs:395
                ElementId = "ParameterDefinition"                                                                                           // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Use.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Min.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Max.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Documentation.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Profile.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_ParameterDefinition()                                                                                                   // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. ParameterDefinition.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "ParameterDefinition.name",                                                                                       // MakerGen.cs:239
                    Id = "ParameterDefinition.name",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. ParameterDefinition.use
                this.Element_Use = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:238
                    Path= "ParameterDefinition.use",                                                                                        // MakerGen.cs:239
                    Id = "ParameterDefinition.use",                                                                                         // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. ParameterDefinition.min
                this.Element_Min = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Min",                                                                                                   // MakerGen.cs:238
                    Path= "ParameterDefinition.min",                                                                                        // MakerGen.cs:239
                    Id = "ParameterDefinition.min",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. ParameterDefinition.max
                this.Element_Max = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Max",                                                                                                   // MakerGen.cs:238
                    Path= "ParameterDefinition.max",                                                                                        // MakerGen.cs:239
                    Id = "ParameterDefinition.max",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. ParameterDefinition.documentation
                this.Element_Documentation = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Documentation",                                                                                         // MakerGen.cs:238
                    Path= "ParameterDefinition.documentation",                                                                              // MakerGen.cs:239
                    Id = "ParameterDefinition.documentation",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. ParameterDefinition.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "ParameterDefinition.type",                                                                                       // MakerGen.cs:239
                    Id = "ParameterDefinition.type",                                                                                        // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. ParameterDefinition.profile
                this.Element_Profile = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Profile",                                                                                               // MakerGen.cs:238
                    Path= "ParameterDefinition.profile",                                                                                    // MakerGen.cs:239
                    Id = "ParameterDefinition.profile",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:306
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                               // MakerGen.cs:306
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
