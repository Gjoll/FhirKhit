using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Identifier'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Identifier",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Identifier",
    ///   "version": "4.0.0",
    ///   "name": "Identifier",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Identifier Type: An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.",
    ///   "purpose": "Need to be able to identify things with confidence and be sure that the identification is not subject to misinterpretation.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Identifier",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Identifier",
    ///         "path": "Identifier",
    ///         "short": "An identifier intended for computation",
    ///         "definition": "An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Identifier.use",
    ///         "path": "Identifier.use",
    ///         "short": "usual | official | temp | secondary | old (If known)",
    ///         "definition": "The purpose of this identifier.",
    ///         "comment": "Applications can assume that an identifier is permanent unless it explicitly says that it is temporary.",
    ///         "requirements": "Allows the appropriate identifier for a particular context of use to be selected from among a set of identifiers.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isModifier": true,
    ///         "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary id for a permanent one.",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "IdentifierUse"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "Identifies the purpose for this identifier, if known .",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/identifier-use|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Identifier.type",
    ///         "path": "Identifier.type",
    ///         "short": "Description of identifier",
    ///         "definition": "A coded type for the identifier that can be used to determine which identifier to use for a specific purpose.",
    ///         "comment": "This element deals only with general categories of identifiers.  It SHOULD not be used for codes that correspond 1..1 with the Identifier.system. Some identifiers may fall into multiple categories due to common usage.   Where the system is known, a type is unnecessary because the type is always part of the system definition. However systems often need to handle identifiers where the system is not known. There is not a 1:1 relationship between type and system, since many different systems have the same type.",
    ///         "requirements": "Allows users to make use of identifiers when the identifier system is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "IdentifierType"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "A coded type for an identifier that can be used to determine which identifier to use for a specific purpose.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/identifier-type"
    ///         }
    ///       },
    ///       {
    ///         "id": "Identifier.system",
    ///         "path": "Identifier.system",
    ///         "short": "The namespace for the identifier value",
    ///         "definition": "Establishes the namespace for the value - that is, a URL that describes a set values that are unique.",
    ///         "comment": "Identifier.system is always case sensitive.",
    ///         "requirements": "There are many sets  of identifiers.  To perform matching of two identifiers, we need to know what set we're dealing with. The system identifies a particular set of unique identifiers.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueUri": "http://www.acme.com/identifiers/patient"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Identifier.value",
    ///         "path": "Identifier.value",
    ///         "short": "The value that is unique",
    ///         "definition": "The portion of the identifier typically relevant to the user and which is unique within the context of the system.",
    ///         "comment": "If the value is a full URI, then the system SHALL be urn:ietf:rfc:3986.  The value's primary purpose is computational mapping.  As a result, it may be normalized for comparison purposes (e.g. removing non-significant whitespace, dashes, etc.)  A value formatted for human display can be conveyed using the [Rendered Value extension](extension-rendered-value.html). Identifier.value is to be treated as case sensitive unless knowledge of the Identifier.system allows the processer to be confident that non-case-sensitive processing is safe.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "123456"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Identifier.period",
    ///         "path": "Identifier.period",
    ///         "short": "Time period when id is/was valid for use",
    ///         "definition": "Time period during which identifier is/was valid for use.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Period"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Identifier.assigner",
    ///         "path": "Identifier.assigner",
    ///         "short": "Organization that issued id (may be just text)",
    ///         "definition": "Organization that issued/manages the identifier.",
    ///         "comment": "The Identifier.assigner may omit the .reference element and only contain a .display element reflecting the name or other textual information about the assigning organization.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Organization"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Identifier
    public class Identifier_Type : MakerComplex_Type                                                                                        // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Identifier.use
        public MakerElementInstance Use;                                                                                                    // MakerGen.cs:217
        // 2. Identifier.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 3. Identifier.system
        public MakerElementInstance System;                                                                                                 // MakerGen.cs:217
        // 4. Identifier.value
        public MakerElementInstance Value;                                                                                                  // MakerGen.cs:217
        // 5. Identifier.period
        public MakerElementInstance Period;                                                                                                 // MakerGen.cs:217
        // 6. Identifier.assigner
        public MakerElementInstance Assigner;                                                                                               // MakerGen.cs:217
        public Identifier_Type()                                                                                                            // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Identifier.use
                this.Use = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Use",                                                                                                           // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Identifier.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new CodeableConcept_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Identifier.system
                this.System = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "System",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Uri_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. Identifier.value
                this.Value = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Value",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. Identifier.period
                this.Period = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Period",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 6. Identifier.assigner
                this.Assigner = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Assigner",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
