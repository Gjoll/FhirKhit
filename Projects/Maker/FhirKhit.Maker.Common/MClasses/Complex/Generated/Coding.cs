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
      "id": "Coding",
      "url": "http://hl7.org/fhir/StructureDefinition/Coding",
      "version": "4.0.0",
      "name": "Coding",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Coding Type: A reference to a code defined by a terminology system.",
      "purpose": "References to codes are very common in healthcare models.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Coding",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Coding",
            "path": "Coding",
            "short": "A reference to a code defined by a terminology system",
            "definition": "A reference to a code defined by a terminology system.",
            "comment": "Codes may be defined very casually in enumerations or code lists, up to very formal definitions such as SNOMED CT - see the HL7 v3 Core Principles for more information.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Coding.system",
            "path": "Coding.system",
            "short": "Identity of the terminology system",
            "definition": "The identification of the code system that defines the meaning of the symbol in the code.",
            "comment": "The URI may be an OID (urn:oid:...) or a UUID (urn:uuid:...).  OIDs and UUIDs SHALL be references to the HL7 OID registry. Otherwise, the URI should come from HL7's list of FHIR defined special URIs or it should reference to some definition that establishes the system clearly and unambiguously.",
            "requirements": "Need to be unambiguous about the source of the definition of the symbol.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Coding.version",
            "path": "Coding.version",
            "short": "Version of the system - if relevant",
            "definition": "The version of the code system which was used when choosing this code. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged.",
            "comment": "Where the terminology does not clearly define what string should be used to identify code system versions, the recommendation is to use the date (expressed in FHIR date format) on which that version was officially published as the version date.",
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
            "id": "Coding.code",
            "path": "Coding.code",
            "short": "Symbol in syntax defined by the system",
            "definition": "A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a syntax defined by the coding system (e.g. post-coordination).",
            "requirements": "Need to refer to a particular code in the system.",
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
            "id": "Coding.display",
            "path": "Coding.display",
            "short": "Representation defined by the system",
            "definition": "A representation of the meaning of the code in the system, following the rules of the system.",
            "requirements": "Need to be able to carry a human-readable meaning of the code for readers that do not know  the system.",
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
            "id": "Coding.userSelected",
            "path": "Coding.userSelected",
            "short": "If this coding was chosen directly by the user",
            "definition": "Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items (codes or displays).",
            "comment": "Amongst a set of alternatives, a directly chosen code is the most appropriate starting point for new translations. There is some ambiguity about what exactly 'directly chosen' implies, and trading partner agreement may be needed to clarify the use of this element and its consequences more completely.",
            "requirements": "This has been identified as a clinical safety criterium - that this exact system/code pair was chosen explicitly, rather than inferred by the system based on some rules or language processing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
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
    /// Fhir complex 'Coding'
    /// </summary>
    // 0. Coding
    public class Coding : FhirKhit.Maker.Common.Complex.ComplexBase                                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Coding_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                          // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Coding.system
            public ElementDefinitionInfo System;                                                                                            // MakerGen.cs:236
            // 2. Coding.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:236
            // 3. Coding.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 4. Coding.display
            public ElementDefinitionInfo Display;                                                                                           // MakerGen.cs:236
            // 5. Coding.userSelected
            public ElementDefinitionInfo UserSelected;                                                                                      // MakerGen.cs:236
            public Coding_Elements()                                                                                                        // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Coding.system
                    this.System = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "System",                                                                                                    // MakerGen.cs:255
                        Path= "Coding.system",                                                                                              // MakerGen.cs:256
                        Id = "Coding.system",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Coding.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Version",                                                                                                   // MakerGen.cs:255
                        Path= "Coding.version",                                                                                             // MakerGen.cs:256
                        Id = "Coding.version",                                                                                              // MakerGen.cs:257
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
                    // 3. Coding.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "Coding.code",                                                                                                // MakerGen.cs:256
                        Id = "Coding.code",                                                                                                 // MakerGen.cs:257
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
                    // 4. Coding.display
                    this.Display = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Display",                                                                                                   // MakerGen.cs:255
                        Path= "Coding.display",                                                                                             // MakerGen.cs:256
                        Id = "Coding.display",                                                                                              // MakerGen.cs:257
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
                    // 5. Coding.userSelected
                    this.UserSelected = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "UserSelected",                                                                                              // MakerGen.cs:255
                        Path= "Coding.userSelected",                                                                                        // MakerGen.cs:256
                        Id = "Coding.userSelected",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                System.Write(sDef);                                                                                                         // MakerGen.cs:240
                Version.Write(sDef);                                                                                                        // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Display.Write(sDef);                                                                                                        // MakerGen.cs:240
                UserSelected.Write(sDef);                                                                                                   // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Coding_Elements Elements { get; }                                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Coding()                                                                                                                     // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Coding_Elements();                                                                                          // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
