using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Expression'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Expression",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Expression",
    ///   "version": "4.0.0",
    ///   "name": "Expression",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Expression Type: A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Expression",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Expression",
    ///         "path": "Expression",
    ///         "short": "An expression that can be used to generate a value",
    ///         "definition": "A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Expression.description",
    ///         "path": "Expression.description",
    ///         "short": "Natural language description of the condition",
    ///         "definition": "A brief, natural language description of the condition that effectively communicates the intended semantics.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Expression.name",
    ///         "path": "Expression.name",
    ///         "short": "Short name assigned to expression for reuse",
    ///         "definition": "A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "id"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Expression.language",
    ///         "path": "Expression.language",
    ///         "short": "text/cql | text/fhirpath | application/x-fhir-query | etc.",
    ///         "definition": "The media type of the language for the expression.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://www.rfc-editor.org/bcp/bcp13.txt"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "ExpressionLanguage"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "The media type of the expression language.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/expression-language"
    ///         }
    ///       },
    ///       {
    ///         "id": "Expression.expression",
    ///         "path": "Expression.expression",
    ///         "short": "Expression in specified language",
    ///         "definition": "An expression in the specified language that returns a value.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Expression.reference",
    ///         "path": "Expression.reference",
    ///         "short": "Where the expression is found",
    ///         "definition": "A URI that defines where the expression is found.",
    ///         "comment": "If both a reference and an expression is found, the reference SHALL point to the same expression.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Expression
    public class Expression_Type : MakerComplex_Type                                                                                        // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Expression.description
        public MakerElementInstance Description;                                                                                            // MakerGen.cs:217
        // 2. Expression.name
        public MakerElementInstance Name;                                                                                                   // MakerGen.cs:217
        // 3. Expression.language
        public MakerElementInstance Language;                                                                                               // MakerGen.cs:217
        // 4. Expression.expression
        public MakerElementInstance Expression;                                                                                             // MakerGen.cs:217
        // 5. Expression.reference
        public MakerElementInstance Reference;                                                                                              // MakerGen.cs:217
        public Expression_Type()                                                                                                            // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Expression.description
                this.Description = new MakerElementInstance                                                                                 // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Description",                                                                                                   // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Expression.name
                this.Name = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Name",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Id_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Expression.language
                this.Language = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Language",                                                                                                      // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. Expression.expression
                this.Expression = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Expression",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. Expression.reference
                this.Reference = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Reference",                                                                                                     // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Uri_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
