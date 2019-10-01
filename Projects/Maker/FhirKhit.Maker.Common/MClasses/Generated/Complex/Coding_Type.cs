using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Coding'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Coding",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Coding",
    ///   "version": "4.0.0",
    ///   "name": "Coding",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Coding Type: A reference to a code defined by a terminology system.",
    ///   "purpose": "References to codes are very common in healthcare models.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Coding",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Coding",
    ///         "path": "Coding",
    ///         "short": "A reference to a code defined by a terminology system",
    ///         "definition": "A reference to a code defined by a terminology system.",
    ///         "comment": "Codes may be defined very casually in enumerations or code lists, up to very formal definitions such as SNOMED CT - see the HL7 v3 Core Principles for more information.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Coding.system",
    ///         "path": "Coding.system",
    ///         "short": "Identity of the terminology system",
    ///         "definition": "The identification of the code system that defines the meaning of the symbol in the code.",
    ///         "comment": "The URI may be an OID (urn:oid:...) or a UUID (urn:uuid:...).  OIDs and UUIDs SHALL be references to the HL7 OID registry. Otherwise, the URI should come from HL7's list of FHIR defined special URIs or it should reference to some definition that establishes the system clearly and unambiguously.",
    ///         "requirements": "Need to be unambiguous about the source of the definition of the symbol.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Coding.version",
    ///         "path": "Coding.version",
    ///         "short": "Version of the system - if relevant",
    ///         "definition": "The version of the code system which was used when choosing this code. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged.",
    ///         "comment": "Where the terminology does not clearly define what string should be used to identify code system versions, the recommendation is to use the date (expressed in FHIR date format) on which that version was officially published as the version date.",
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
    ///         "id": "Coding.code",
    ///         "path": "Coding.code",
    ///         "short": "Symbol in syntax defined by the system",
    ///         "definition": "A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a syntax defined by the coding system (e.g. post-coordination).",
    ///         "requirements": "Need to refer to a particular code in the system.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Coding.display",
    ///         "path": "Coding.display",
    ///         "short": "Representation defined by the system",
    ///         "definition": "A representation of the meaning of the code in the system, following the rules of the system.",
    ///         "requirements": "Need to be able to carry a human-readable meaning of the code for readers that do not know  the system.",
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
    ///         "id": "Coding.userSelected",
    ///         "path": "Coding.userSelected",
    ///         "short": "If this coding was chosen directly by the user",
    ///         "definition": "Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items (codes or displays).",
    ///         "comment": "Amongst a set of alternatives, a directly chosen code is the most appropriate starting point for new translations. There is some ambiguity about what exactly 'directly chosen' implies, and trading partner agreement may be needed to clarify the use of this element and its consequences more completely.",
    ///         "requirements": "This has been identified as a clinical safety criterium - that this exact system/code pair was chosen explicitly, rather than inferred by the system based on some rules or language processing.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "boolean"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Coding
    public class Coding_Type : MakerComplex_Type                                                                                            // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Coding.system
        public MakerElementInstance System;                                                                                                 // MakerGen.cs:217
        // 2. Coding.version
        public MakerElementInstance Version;                                                                                                // MakerGen.cs:217
        // 3. Coding.code
        public MakerElementInstance Code;                                                                                                   // MakerGen.cs:217
        // 4. Coding.display
        public MakerElementInstance Display;                                                                                                // MakerGen.cs:217
        // 5. Coding.userSelected
        public MakerElementInstance UserSelected;                                                                                           // MakerGen.cs:217
        public Coding_Type()                                                                                                                // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Coding.system
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
                // 2. Coding.version
                this.Version = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Version",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Coding.code
                this.Code = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Code",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. Coding.display
                this.Display = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Display",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. Coding.userSelected
                this.UserSelected = new MakerElementInstance                                                                                // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "UserSelected",                                                                                                  // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Boolean_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
