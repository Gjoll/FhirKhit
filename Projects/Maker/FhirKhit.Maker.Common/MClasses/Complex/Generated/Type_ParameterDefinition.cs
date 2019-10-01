using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'ParameterDefinition'
    /// </summary>
    // 0. ParameterDefinition
    public class Type_ParameterDefinition : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_ParameterDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. ParameterDefinition.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:211
            // 2. ParameterDefinition.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 3. ParameterDefinition.min
            public ElementDefinitionInfo Element_Min;                                                                                       // MakerGen.cs:211
            // 4. ParameterDefinition.max
            public ElementDefinitionInfo Element_Max;                                                                                       // MakerGen.cs:211
            // 5. ParameterDefinition.documentation
            public ElementDefinitionInfo Element_Documentation;                                                                             // MakerGen.cs:211
            // 6. ParameterDefinition.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 7. ParameterDefinition.profile
            public ElementDefinitionInfo Element_Profile;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_ParameterDefinition_Elements()                                                                                      // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ParameterDefinition.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Name",                                                                                              // MakerGen.cs:230
                        Path= "ParameterDefinition.name",                                                                                   // MakerGen.cs:231
                        Id = "ParameterDefinition.name",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ParameterDefinition.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "ParameterDefinition.use",                                                                                    // MakerGen.cs:231
                        Id = "ParameterDefinition.use",                                                                                     // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ParameterDefinition.min
                    this.Element_Min = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Min",                                                                                               // MakerGen.cs:230
                        Path= "ParameterDefinition.min",                                                                                    // MakerGen.cs:231
                        Id = "ParameterDefinition.min",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ParameterDefinition.max
                    this.Element_Max = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Max",                                                                                               // MakerGen.cs:230
                        Path= "ParameterDefinition.max",                                                                                    // MakerGen.cs:231
                        Id = "ParameterDefinition.max",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ParameterDefinition.documentation
                    this.Element_Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:230
                        Path= "ParameterDefinition.documentation",                                                                          // MakerGen.cs:231
                        Id = "ParameterDefinition.documentation",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ParameterDefinition.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "ParameterDefinition.type",                                                                                   // MakerGen.cs:231
                        Id = "ParameterDefinition.type",                                                                                    // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ParameterDefinition.profile
                    this.Element_Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Profile",                                                                                           // MakerGen.cs:230
                        Path= "ParameterDefinition.profile",                                                                                // MakerGen.cs:231
                        Id = "ParameterDefinition.profile",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                           // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Use.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Min.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Max.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Documentation.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Profile.Write(sDef);                                                                                                // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_ParameterDefinition_Elements Elements                                                                                   // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_ParameterDefinition_Elements();                                                                // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_ParameterDefinition_Elements elements;                                                                                         // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_ParameterDefinition()                                                                                                   // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ParameterDefinition",                                                                                               // MakerGen.cs:420
                ElementId = "ParameterDefinition"                                                                                           // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
