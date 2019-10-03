using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "SubstanceProtein",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceProtein",
      "version": "4.0.0",
      "name": "SubstanceProtein",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A SubstanceProtein is defined as a single unit of a linear amino acid sequence, or a combination of subunits that are either covalently linked or have a defined invariant stoichiometric relationship. This includes all synthetic, recombinant and purified SubstanceProteins of defined sequence, whether the use is therapeutic or prophylactic. This set of elements will be used to describe albumins, coagulation factors, cytokines, growth factors, peptide/SubstanceProtein hormones, enzymes, toxins, toxoids, recombinant vaccines, and immunomodulators.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceProtein",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceProtein",
            "path": "SubstanceProtein",
            "short": "A SubstanceProtein is defined as a single unit of a linear amino acid sequence, or a combination of subunits that are either covalently linked or have a defined invariant stoichiometric relationship. This includes all synthetic, recombinant and purified SubstanceProteins of defined sequence, whether the use is therapeutic or prophylactic. This set of elements will be used to describe albumins, coagulation factors, cytokines, growth factors, peptide/SubstanceProtein hormones, enzymes, toxins, toxoids, recombinant vaccines, and immunomodulators",
            "definition": "A SubstanceProtein is defined as a single unit of a linear amino acid sequence, or a combination of subunits that are either covalently linked or have a defined invariant stoichiometric relationship. This includes all synthetic, recombinant and purified SubstanceProteins of defined sequence, whether the use is therapeutic or prophylactic. This set of elements will be used to describe albumins, coagulation factors, cytokines, growth factors, peptide/SubstanceProtein hormones, enzymes, toxins, toxoids, recombinant vaccines, and immunomodulators.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceProtein.sequenceType",
            "path": "SubstanceProtein.sequenceType",
            "short": "The SubstanceProtein descriptive elements will only be used when a complete or partial amino acid sequence is available or derivable from a nucleic acid sequence",
            "definition": "The SubstanceProtein descriptive elements will only be used when a complete or partial amino acid sequence is available or derivable from a nucleic acid sequence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.numberOfSubunits",
            "path": "SubstanceProtein.numberOfSubunits",
            "short": "Number of linear sequences of amino acids linked through peptide bonds. The number of subunits constituting the SubstanceProtein shall be described. It is possible that the number of subunits can be variable",
            "definition": "Number of linear sequences of amino acids linked through peptide bonds. The number of subunits constituting the SubstanceProtein shall be described. It is possible that the number of subunits can be variable.",
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
            "id": "SubstanceProtein.disulfideLinkage",
            "path": "SubstanceProtein.disulfideLinkage",
            "short": "The disulphide bond between two cysteine residues either on the same subunit or on two different subunits shall be described. The position of the disulfide bonds in the SubstanceProtein shall be listed in increasing order of subunit number and position within subunit followed by the abbreviation of the amino acids involved. The disulfide linkage positions shall actually contain the amino acid Cysteine at the respective positions",
            "definition": "The disulphide bond between two cysteine residues either on the same subunit or on two different subunits shall be described. The position of the disulfide bonds in the SubstanceProtein shall be listed in increasing order of subunit number and position within subunit followed by the abbreviation of the amino acids involved. The disulfide linkage positions shall actually contain the amino acid Cysteine at the respective positions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.subunit",
            "path": "SubstanceProtein.subunit",
            "short": "This subclause refers to the description of each subunit constituting the SubstanceProtein. A subunit is a linear sequence of amino acids linked through peptide bonds. The Subunit information shall be provided when the finished SubstanceProtein is a complex of multiple sequences; subunits are not used to delineate domains within a single sequence. Subunits are listed in order of decreasing length; sequences of the same length will be ordered by decreasing molecular weight; subunits that have identical sequences will be repeated multiple times",
            "definition": "This subclause refers to the description of each subunit constituting the SubstanceProtein. A subunit is a linear sequence of amino acids linked through peptide bonds. The Subunit information shall be provided when the finished SubstanceProtein is a complex of multiple sequences; subunits are not used to delineate domains within a single sequence. Subunits are listed in order of decreasing length; sequences of the same length will be ordered by decreasing molecular weight; subunits that have identical sequences will be repeated multiple times.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.subunit.subunit",
            "path": "SubstanceProtein.subunit.subunit",
            "short": "Index of primary sequences of amino acids linked through peptide bonds in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts",
            "definition": "Index of primary sequences of amino acids linked through peptide bonds in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts.",
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
            "id": "SubstanceProtein.subunit.sequence",
            "path": "SubstanceProtein.subunit.sequence",
            "short": "The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence",
            "definition": "The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence.",
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
            "id": "SubstanceProtein.subunit.length",
            "path": "SubstanceProtein.subunit.length",
            "short": "Length of linear sequences of amino acids contained in the subunit",
            "definition": "Length of linear sequences of amino acids contained in the subunit.",
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
            "id": "SubstanceProtein.subunit.sequenceAttachment",
            "path": "SubstanceProtein.subunit.sequenceAttachment",
            "short": "The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence",
            "definition": "The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.subunit.nTerminalModificationId",
            "path": "SubstanceProtein.subunit.nTerminalModificationId",
            "short": "Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID",
            "definition": "Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.subunit.nTerminalModification",
            "path": "SubstanceProtein.subunit.nTerminalModification",
            "short": "The name of the fragment modified at the N-terminal of the SubstanceProtein shall be specified",
            "definition": "The name of the fragment modified at the N-terminal of the SubstanceProtein shall be specified.",
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
            "id": "SubstanceProtein.subunit.cTerminalModificationId",
            "path": "SubstanceProtein.subunit.cTerminalModificationId",
            "short": "Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID",
            "definition": "Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceProtein.subunit.cTerminalModification",
            "path": "SubstanceProtein.subunit.cTerminalModification",
            "short": "The modification at the C-terminal shall be specified",
            "definition": "The modification at the C-terminal shall be specified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'SubstanceProtein'
    /// </summary>
    // 0. SubstanceProtein
    public partial class Resource_SubstanceProtein : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 4. SubstanceProtein.subunit
        public partial class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 5. SubstanceProtein.subunit.subunit
            public ElementDefinitionInfo Element_Subunit;                                                                                   // MakerGen.cs:217
            // 6. SubstanceProtein.subunit.sequence
            public ElementDefinitionInfo Element_Sequence;                                                                                  // MakerGen.cs:217
            // 7. SubstanceProtein.subunit.length
            public ElementDefinitionInfo Element_Length;                                                                                    // MakerGen.cs:217
            // 8. SubstanceProtein.subunit.sequenceAttachment
            public ElementDefinitionInfo Element_SequenceAttachment;                                                                        // MakerGen.cs:217
            // 9. SubstanceProtein.subunit.nTerminalModificationId
            public ElementDefinitionInfo Element_NTerminalModificationId;                                                                   // MakerGen.cs:217
            // 10. SubstanceProtein.subunit.nTerminalModification
            public ElementDefinitionInfo Element_NTerminalModification;                                                                     // MakerGen.cs:217
            // 11. SubstanceProtein.subunit.cTerminalModificationId
            public ElementDefinitionInfo Element_CTerminalModificationId;                                                                   // MakerGen.cs:217
            // 12. SubstanceProtein.subunit.cTerminalModification
            public ElementDefinitionInfo Element_CTerminalModification;                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "SubstanceProtein.subunit",                                                                                      // MakerGen.cs:393
                    ElementId = "SubstanceProtein.subunit"                                                                                  // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Subunit.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Sequence.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Length.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_SequenceAttachment.Write(sDef);                                                                                     // MakerGen.cs:221
                Element_NTerminalModificationId.Write(sDef);                                                                                // MakerGen.cs:221
                Element_NTerminalModification.Write(sDef);                                                                                  // MakerGen.cs:221
                Element_CTerminalModificationId.Write(sDef);                                                                                // MakerGen.cs:221
                Element_CTerminalModification.Write(sDef);                                                                                  // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Subunit()                                                                                                           // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 5. SubstanceProtein.subunit.subunit
                    this.Element_Subunit = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Subunit",                                                                                           // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.subunit",                                                                           // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.subunit",                                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 6. SubstanceProtein.subunit.sequence
                    this.Element_Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.sequence",                                                                          // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.sequence",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 7. SubstanceProtein.subunit.length
                    this.Element_Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Length",                                                                                            // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.length",                                                                            // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.length",                                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 8. SubstanceProtein.subunit.sequenceAttachment
                    this.Element_SequenceAttachment = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SequenceAttachment",                                                                                // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.sequenceAttachment",                                                                // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.sequenceAttachment",                                                                 // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Attachment                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 9. SubstanceProtein.subunit.nTerminalModificationId
                    this.Element_NTerminalModificationId = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_NTerminalModificationId",                                                                           // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.nTerminalModificationId",                                                           // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.nTerminalModificationId",                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 10. SubstanceProtein.subunit.nTerminalModification
                    this.Element_NTerminalModification = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_NTerminalModification",                                                                             // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.nTerminalModification",                                                             // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.nTerminalModification",                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 11. SubstanceProtein.subunit.cTerminalModificationId
                    this.Element_CTerminalModificationId = new ElementDefinitionInfo                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CTerminalModificationId",                                                                           // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.cTerminalModificationId",                                                           // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.cTerminalModificationId",                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 12. SubstanceProtein.subunit.cTerminalModification
                    this.Element_CTerminalModification = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_CTerminalModification",                                                                             // MakerGen.cs:236
                        Path= "SubstanceProtein.subunit.cTerminalModification",                                                             // MakerGen.cs:237
                        Id = "SubstanceProtein.subunit.cTerminalModification",                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. SubstanceProtein.sequenceType
        public ElementDefinitionInfo Element_SequenceType;                                                                                  // MakerGen.cs:217
        // 2. SubstanceProtein.numberOfSubunits
        public ElementDefinitionInfo Element_NumberOfSubunits;                                                                              // MakerGen.cs:217
        // 3. SubstanceProtein.disulfideLinkage
        public ElementDefinitionInfo Element_DisulfideLinkage;                                                                              // MakerGen.cs:217
        // 4. SubstanceProtein.subunit
        public ElementDefinitionInfo Element_Subunit;                                                                                       // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "SubstanceProtein",                                                                                                  // MakerGen.cs:393
                ElementId = "SubstanceProtein"                                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_SequenceType.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_NumberOfSubunits.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_DisulfideLinkage.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_Subunit.Write(sDef);                                                                                                    // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_SubstanceProtein()                                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. SubstanceProtein.sequenceType
                this.Element_SequenceType = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_SequenceType",                                                                                          // MakerGen.cs:236
                    Path= "SubstanceProtein.sequenceType",                                                                                  // MakerGen.cs:237
                    Id = "SubstanceProtein.sequenceType",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. SubstanceProtein.numberOfSubunits
                this.Element_NumberOfSubunits = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_NumberOfSubunits",                                                                                      // MakerGen.cs:236
                    Path= "SubstanceProtein.numberOfSubunits",                                                                              // MakerGen.cs:237
                    Id = "SubstanceProtein.numberOfSubunits",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. SubstanceProtein.disulfideLinkage
                this.Element_DisulfideLinkage = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DisulfideLinkage",                                                                                      // MakerGen.cs:236
                    Path= "SubstanceProtein.disulfideLinkage",                                                                              // MakerGen.cs:237
                    Id = "SubstanceProtein.disulfideLinkage",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. SubstanceProtein.subunit
                this.Element_Subunit = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subunit",                                                                                               // MakerGen.cs:236
                    Path= "SubstanceProtein.subunit",                                                                                       // MakerGen.cs:237
                    Id = "SubstanceProtein.subunit",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Subunit                                                                                                    // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "SubstanceProtein";                                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceProtein";                                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
