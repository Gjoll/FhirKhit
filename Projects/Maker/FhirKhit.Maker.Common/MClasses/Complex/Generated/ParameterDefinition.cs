using System;                                                                                                                               // MakerGen.cs:516
using System.Diagnostics;                                                                                                                   // MakerGen.cs:517
using System.IO;                                                                                                                            // MakerGen.cs:518
using System.Linq;                                                                                                                          // MakerGen.cs:519
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:520
                                                                                                                                            // MakerGen.cs:521
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:522
{                                                                                                                                           // MakerGen.cs:523
    #region Json                                                                                                                            // MakerGen.cs:524
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
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'ParameterDefinition'
    /// </summary>
    // 0. ParameterDefinition
    public class ParameterDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ParameterDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. ParameterDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 2. ParameterDefinition.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:216
            // 3. ParameterDefinition.min
            public ElementDefinitionInfo Min;                                                                                               // MakerGen.cs:216
            // 4. ParameterDefinition.max
            public ElementDefinitionInfo Max;                                                                                               // MakerGen.cs:216
            // 5. ParameterDefinition.documentation
            public ElementDefinitionInfo Documentation;                                                                                     // MakerGen.cs:216
            // 6. ParameterDefinition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 7. ParameterDefinition.profile
            public ElementDefinitionInfo Profile;                                                                                           // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ParameterDefinition_Elements()                                                                                           // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ParameterDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "ParameterDefinition.name",                                                                                   // MakerGen.cs:236
                        Id = "ParameterDefinition.name",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. ParameterDefinition.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Use",                                                                                                       // MakerGen.cs:235
                        Path= "ParameterDefinition.use",                                                                                    // MakerGen.cs:236
                        Id = "ParameterDefinition.use",                                                                                     // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. ParameterDefinition.min
                    this.Min = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Min",                                                                                                       // MakerGen.cs:235
                        Path= "ParameterDefinition.min",                                                                                    // MakerGen.cs:236
                        Id = "ParameterDefinition.min",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. ParameterDefinition.max
                    this.Max = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Max",                                                                                                       // MakerGen.cs:235
                        Path= "ParameterDefinition.max",                                                                                    // MakerGen.cs:236
                        Id = "ParameterDefinition.max",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. ParameterDefinition.documentation
                    this.Documentation = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Documentation",                                                                                             // MakerGen.cs:235
                        Path= "ParameterDefinition.documentation",                                                                          // MakerGen.cs:236
                        Id = "ParameterDefinition.documentation",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ParameterDefinition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "ParameterDefinition.type",                                                                                   // MakerGen.cs:236
                        Id = "ParameterDefinition.type",                                                                                    // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. ParameterDefinition.profile
                    this.Profile = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Profile",                                                                                                   // MakerGen.cs:235
                        Path= "ParameterDefinition.profile",                                                                                // MakerGen.cs:236
                        Id = "ParameterDefinition.profile",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                           // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Use.Write(sDef);                                                                                                            // MakerGen.cs:220
                Min.Write(sDef);                                                                                                            // MakerGen.cs:220
                Max.Write(sDef);                                                                                                            // MakerGen.cs:220
                Documentation.Write(sDef);                                                                                                  // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Profile.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ParameterDefinition_Elements Elements                                                                                        // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ParameterDefinition_Elements();                                                                     // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ParameterDefinition_Elements elements;                                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ParameterDefinition()                                                                                                        // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ParameterDefinition",                                                                                               // MakerGen.cs:428
                ElementId = "ParameterDefinition"                                                                                           // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
