using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'CodeableConcept'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "CodeableConcept",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/CodeableConcept",
    ///   "version": "4.0.0",
    ///   "name": "CodeableConcept",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for CodeableConcept Type: A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.",
    ///   "purpose": "This is a common pattern in healthcare - a concept that may be defined by one or more codes from formal definitions including LOINC and SNOMED CT, and/or defined by the provision of text that captures a human sense of the concept.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "CodeableConcept",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "CodeableConcept",
    ///         "path": "CodeableConcept",
    ///         "short": "Concept - reference to a terminology or just  text",
    ///         "definition": "A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.",
    ///         "comment": "Not all terminology uses fit this general pattern. In some cases, models should not use CodeableConcept and use Coding directly and provide their own structure for managing text, codings, translations and the relationship between elements and pre- and post-coordination.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "CodeableConcept.coding",
    ///         "path": "CodeableConcept.coding",
    ///         "short": "Code defined by a terminology system",
    ///         "definition": "A reference to a code defined by a terminology system.",
    ///         "comment": "Codes may be defined very casually in enumerations, or code lists, up to very formal definitions such as SNOMED CT - see the HL7 v3 Core Principles for more information.  Ordering of codings is undefined and SHALL NOT be used to infer meaning. Generally, at most only one of the coding values will be labeled as UserSelected = true.",
    ///         "requirements": "Allows for alternative encodings within a code system, and translations to other code systems.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Coding"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "CodeableConcept.text",
    ///         "path": "CodeableConcept.text",
    ///         "short": "Plain text representation of the concept",
    ///         "definition": "A human language representation of the concept as seen/selected/uttered by the user who entered the data and/or which represents the intended meaning of the user.",
    ///         "comment": "Very often the text is the same as a displayName of one of the codings.",
    ///         "requirements": "The codes from the terminologies do not always capture the correct meaning with all the nuances of the human using them, or sometimes there is no appropriate code at all. In these cases, the text is used to capture the full meaning of the source.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. CodeableConcept
    public class CodeableConcept_Type : MakerComplex_Type                                                                                   // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. CodeableConcept.coding
        public MakerElementInstance Coding;                                                                                                 // MakerGen.cs:217
        // 2. CodeableConcept.text
        public MakerElementInstance Text;                                                                                                   // MakerGen.cs:217
        public CodeableConcept_Type()                                                                                                       // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. CodeableConcept.coding
                this.Coding = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Coding",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Coding_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. CodeableConcept.text
                this.Text = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Text",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
