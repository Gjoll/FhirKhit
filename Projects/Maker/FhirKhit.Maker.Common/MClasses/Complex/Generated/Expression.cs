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
      "id": "Expression",
      "url": "http://hl7.org/fhir/StructureDefinition/Expression",
      "version": "4.0.0",
      "name": "Expression",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Expression Type: A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Expression",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Expression",
            "path": "Expression",
            "short": "An expression that can be used to generate a value",
            "definition": "A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Expression.description",
            "path": "Expression.description",
            "short": "Natural language description of the condition",
            "definition": "A brief, natural language description of the condition that effectively communicates the intended semantics.",
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
            "id": "Expression.name",
            "path": "Expression.name",
            "short": "Short name assigned to expression for reuse",
            "definition": "A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Expression.language",
            "path": "Expression.language",
            "short": "text/cql | text/fhirpath | application/x-fhir-query | etc.",
            "definition": "The media type of the language for the expression.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://www.rfc-editor.org/bcp/bcp13.txt"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ExpressionLanguage"
                }
              ],
              "strength": "extensible",
              "description": "The media type of the expression language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/expression-language"
            }
          },
          {
            "id": "Expression.expression",
            "path": "Expression.expression",
            "short": "Expression in specified language",
            "definition": "An expression in the specified language that returns a value.",
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
            "id": "Expression.reference",
            "path": "Expression.reference",
            "short": "Where the expression is found",
            "definition": "A URI that defines where the expression is found.",
            "comment": "If both a reference and an expression is found, the reference SHALL point to the same expression.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'Expression'
    /// </summary>
    // 0. Expression
    public class Expression : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Expression_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. Expression.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 2. Expression.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 3. Expression.language
            public ElementDefinitionInfo Language;                                                                                          // MakerGen.cs:216
            // 4. Expression.expression
            public ElementDefinitionInfo Expression;                                                                                        // MakerGen.cs:216
            // 5. Expression.reference
            public ElementDefinitionInfo Reference;                                                                                         // MakerGen.cs:216
            public Expression_Elements()                                                                                                    // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Expression.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "Expression.description",                                                                                     // MakerGen.cs:236
                        Id = "Expression.description",                                                                                      // MakerGen.cs:237
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
                    // 2. Expression.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "Expression.name",                                                                                            // MakerGen.cs:236
                        Id = "Expression.name",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. Expression.language
                    this.Language = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Language",                                                                                                  // MakerGen.cs:235
                        Path= "Expression.language",                                                                                        // MakerGen.cs:236
                        Id = "Expression.language",                                                                                         // MakerGen.cs:237
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
                    // 4. Expression.expression
                    this.Expression = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Expression",                                                                                                // MakerGen.cs:235
                        Path= "Expression.expression",                                                                                      // MakerGen.cs:236
                        Id = "Expression.expression",                                                                                       // MakerGen.cs:237
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
                    // 5. Expression.reference
                    this.Reference = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reference",                                                                                                 // MakerGen.cs:235
                        Path= "Expression.reference",                                                                                       // MakerGen.cs:236
                        Id = "Expression.reference",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Language.Write(sDef);                                                                                                       // MakerGen.cs:220
                Expression.Write(sDef);                                                                                                     // MakerGen.cs:220
                Reference.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Expression_Elements Elements { get; }                                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Expression()                                                                                                                 // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Expression_Elements();                                                                                      // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
