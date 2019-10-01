using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
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
    public class CodeableConcept_Type : Complex_Type                                                                                        // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. CodeableConcept.coding
        public ElementInstance Coding;                                                                                                      // MakerGen.cs:203
        // 2. CodeableConcept.text
        public ElementInstance Text;                                                                                                        // MakerGen.cs:203
        public CodeableConcept_Type()                                                                                                       // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275