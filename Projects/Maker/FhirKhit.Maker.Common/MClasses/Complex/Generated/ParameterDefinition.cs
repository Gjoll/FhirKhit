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
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'ParameterDefinition'
    /// </summary>
    // 0. ParameterDefinition
    public class ParameterDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ParameterDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. ParameterDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:236
            // 2. ParameterDefinition.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:236
            // 3. ParameterDefinition.min
            public ElementDefinitionInfo Min;                                                                                               // MakerGen.cs:236
            // 4. ParameterDefinition.max
            public ElementDefinitionInfo Max;                                                                                               // MakerGen.cs:236
            // 5. ParameterDefinition.documentation
            public ElementDefinitionInfo Documentation;                                                                                     // MakerGen.cs:236
            // 6. ParameterDefinition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 7. ParameterDefinition.profile
            public ElementDefinitionInfo Profile;                                                                                           // MakerGen.cs:236
            public ParameterDefinition_Elements()                                                                                           // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ParameterDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Name",                                                                                                      // MakerGen.cs:255
                        Path= "ParameterDefinition.name",                                                                                   // MakerGen.cs:256
                        Id = "ParameterDefinition.name",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. ParameterDefinition.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Use",                                                                                                       // MakerGen.cs:255
                        Path= "ParameterDefinition.use",                                                                                    // MakerGen.cs:256
                        Id = "ParameterDefinition.use",                                                                                     // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. ParameterDefinition.min
                    this.Min = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Min",                                                                                                       // MakerGen.cs:255
                        Path= "ParameterDefinition.min",                                                                                    // MakerGen.cs:256
                        Id = "ParameterDefinition.min",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. ParameterDefinition.max
                    this.Max = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Max",                                                                                                       // MakerGen.cs:255
                        Path= "ParameterDefinition.max",                                                                                    // MakerGen.cs:256
                        Id = "ParameterDefinition.max",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. ParameterDefinition.documentation
                    this.Documentation = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Documentation",                                                                                             // MakerGen.cs:255
                        Path= "ParameterDefinition.documentation",                                                                          // MakerGen.cs:256
                        Id = "ParameterDefinition.documentation",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. ParameterDefinition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "ParameterDefinition.type",                                                                                   // MakerGen.cs:256
                        Id = "ParameterDefinition.type",                                                                                    // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. ParameterDefinition.profile
                    this.Profile = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Profile",                                                                                                   // MakerGen.cs:255
                        Path= "ParameterDefinition.profile",                                                                                // MakerGen.cs:256
                        Id = "ParameterDefinition.profile",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                                TargetProfile = new String[]                                                                                // MakerGen.cs:302
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                           // MakerGen.cs:302
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Name.Write(sDef);                                                                                                           // MakerGen.cs:240
                Use.Write(sDef);                                                                                                            // MakerGen.cs:240
                Min.Write(sDef);                                                                                                            // MakerGen.cs:240
                Max.Write(sDef);                                                                                                            // MakerGen.cs:240
                Documentation.Write(sDef);                                                                                                  // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                Profile.Write(sDef);                                                                                                        // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ParameterDefinition_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ParameterDefinition()                                                                                                        // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ParameterDefinition_Elements();                                                                             // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
