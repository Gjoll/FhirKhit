using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Coding'
    /// </summary>
    // 0. Coding
    public class Type_Coding : FhirKhit.Maker.Common.Complex.ComplexBase                                                                    // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Coding.system
        public ElementDefinitionInfo Element_System;                                                                                        // MakerGen.cs:212
        // 2. Coding.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:212
        // 3. Coding.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 4. Coding.display
        public ElementDefinitionInfo Element_Display;                                                                                       // MakerGen.cs:212
        // 5. Coding.userSelected
        public ElementDefinitionInfo Element_UserSelected;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Coding",                                                                                                            // MakerGen.cs:388
                ElementId = "Coding"                                                                                                        // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_System.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Display.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_UserSelected.Write(sDef);                                                                                               // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Coding()                                                                                                                // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Coding.system
                this.Element_System = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_System",                                                                                                // MakerGen.cs:231
                    Path= "Coding.system",                                                                                                  // MakerGen.cs:232
                    Id = "Coding.system",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Coding.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Version",                                                                                               // MakerGen.cs:231
                    Path= "Coding.version",                                                                                                 // MakerGen.cs:232
                    Id = "Coding.version",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Coding.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "Coding.code",                                                                                                    // MakerGen.cs:232
                    Id = "Coding.code",                                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Coding.display
                this.Element_Display = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Display",                                                                                               // MakerGen.cs:231
                    Path= "Coding.display",                                                                                                 // MakerGen.cs:232
                    Id = "Coding.display",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Coding.userSelected
                this.Element_UserSelected = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UserSelected",                                                                                          // MakerGen.cs:231
                    Path= "Coding.userSelected",                                                                                            // MakerGen.cs:232
                    Id = "Coding.userSelected",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
