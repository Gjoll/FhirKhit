using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
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
    public class Expression_Type : Complex_Type                                                                                             // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Expression.description
        public ElementInstance Description;                                                                                                 // MakerGen.cs:208
        // 2. Expression.name
        public ElementInstance Name;                                                                                                        // MakerGen.cs:208
        // 3. Expression.language
        public ElementInstance Language;                                                                                                    // MakerGen.cs:208
        // 4. Expression.expression
        public ElementInstance Expression;                                                                                                  // MakerGen.cs:208
        // 5. Expression.reference
        public ElementInstance Reference;                                                                                                   // MakerGen.cs:208
        public Expression_Type()                                                                                                            // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
