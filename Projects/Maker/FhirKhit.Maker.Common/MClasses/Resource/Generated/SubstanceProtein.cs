using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'SubstanceProtein'
    /// </summary>
    // 0. SubstanceProtein
    public class SubstanceProtein : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class SubstanceProtein_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 4. SubstanceProtein.subunit
            public class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Subunit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 5. SubstanceProtein.subunit.subunit
                    public ElementDefinitionInfo Subunit;                                                                                   // MakerGen.cs:211
                    // 6. SubstanceProtein.subunit.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:211
                    // 7. SubstanceProtein.subunit.length
                    public ElementDefinitionInfo Length;                                                                                    // MakerGen.cs:211
                    // 8. SubstanceProtein.subunit.sequenceAttachment
                    public ElementDefinitionInfo SequenceAttachment;                                                                        // MakerGen.cs:211
                    // 9. SubstanceProtein.subunit.nTerminalModificationId
                    public ElementDefinitionInfo NTerminalModificationId;                                                                   // MakerGen.cs:211
                    // 10. SubstanceProtein.subunit.nTerminalModification
                    public ElementDefinitionInfo NTerminalModification;                                                                     // MakerGen.cs:211
                    // 11. SubstanceProtein.subunit.cTerminalModificationId
                    public ElementDefinitionInfo CTerminalModificationId;                                                                   // MakerGen.cs:211
                    // 12. SubstanceProtein.subunit.cTerminalModification
                    public ElementDefinitionInfo CTerminalModification;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Subunit_Elements()                                                                                          // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 5. SubstanceProtein.subunit.subunit
                            this.Subunit = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Subunit",                                                                                           // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.subunit",                                                                   // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.subunit",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. SubstanceProtein.subunit.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Sequence",                                                                                          // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.sequence",                                                                  // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.sequence",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 7. SubstanceProtein.subunit.length
                            this.Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Length",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.length",                                                                    // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.length",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. SubstanceProtein.subunit.sequenceAttachment
                            this.SequenceAttachment = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "SequenceAttachment",                                                                                // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.sequenceAttachment",                                                        // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.sequenceAttachment",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. SubstanceProtein.subunit.nTerminalModificationId
                            this.NTerminalModificationId = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "NTerminalModificationId",                                                                           // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.nTerminalModificationId",                                                   // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.nTerminalModificationId",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. SubstanceProtein.subunit.nTerminalModification
                            this.NTerminalModification = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "NTerminalModification",                                                                             // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.nTerminalModification",                                                     // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.nTerminalModification",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. SubstanceProtein.subunit.cTerminalModificationId
                            this.CTerminalModificationId = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "CTerminalModificationId",                                                                           // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.cTerminalModificationId",                                                   // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.cTerminalModificationId",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. SubstanceProtein.subunit.cTerminalModification
                            this.CTerminalModification = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "CTerminalModification",                                                                             // MakerGen.cs:230
                                Path= "SubstanceProtein.subunit.cTerminalModification",                                                     // MakerGen.cs:231
                                Id = "SubstanceProtein.subunit.cTerminalModification",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Subunit.Write(sDef);                                                                                                // MakerGen.cs:215
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:215
                        Length.Write(sDef);                                                                                                 // MakerGen.cs:215
                        SequenceAttachment.Write(sDef);                                                                                     // MakerGen.cs:215
                        NTerminalModificationId.Write(sDef);                                                                                // MakerGen.cs:215
                        NTerminalModification.Write(sDef);                                                                                  // MakerGen.cs:215
                        CTerminalModificationId.Write(sDef);                                                                                // MakerGen.cs:215
                        CTerminalModification.Write(sDef);                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Subunit_Elements Elements                                                                                       // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Subunit_Elements();                                                                    // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Subunit_Elements elements;                                                                                             // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Subunit()                                                                                                       // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceProtein.subunit",                                                                                  // MakerGen.cs:423
                        ElementId = "SubstanceProtein.subunit"                                                                              // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. SubstanceProtein.sequenceType
            public ElementDefinitionInfo SequenceType;                                                                                      // MakerGen.cs:211
            // 2. SubstanceProtein.numberOfSubunits
            public ElementDefinitionInfo NumberOfSubunits;                                                                                  // MakerGen.cs:211
            // 3. SubstanceProtein.disulfideLinkage
            public ElementDefinitionInfo DisulfideLinkage;                                                                                  // MakerGen.cs:211
            // 4. SubstanceProtein.subunit
            public ElementDefinitionInfo Subunit;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public SubstanceProtein_Elements()                                                                                              // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SubstanceProtein.sequenceType
                    this.SequenceType = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SequenceType",                                                                                              // MakerGen.cs:230
                        Path= "SubstanceProtein.sequenceType",                                                                              // MakerGen.cs:231
                        Id = "SubstanceProtein.sequenceType",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SubstanceProtein.numberOfSubunits
                    this.NumberOfSubunits = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "NumberOfSubunits",                                                                                          // MakerGen.cs:230
                        Path= "SubstanceProtein.numberOfSubunits",                                                                          // MakerGen.cs:231
                        Id = "SubstanceProtein.numberOfSubunits",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SubstanceProtein.disulfideLinkage
                    this.DisulfideLinkage = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "DisulfideLinkage",                                                                                          // MakerGen.cs:230
                        Path= "SubstanceProtein.disulfideLinkage",                                                                          // MakerGen.cs:231
                        Id = "SubstanceProtein.disulfideLinkage",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SubstanceProtein.subunit
                    this.Subunit = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subunit",                                                                                                   // MakerGen.cs:230
                        Path= "SubstanceProtein.subunit",                                                                                   // MakerGen.cs:231
                        Id = "SubstanceProtein.subunit",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Subunit                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                SequenceType.Write(sDef);                                                                                                   // MakerGen.cs:215
                NumberOfSubunits.Write(sDef);                                                                                               // MakerGen.cs:215
                DisulfideLinkage.Write(sDef);                                                                                               // MakerGen.cs:215
                Subunit.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public SubstanceProtein_Elements Elements                                                                                           // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new SubstanceProtein_Elements();                                                                        // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        SubstanceProtein_Elements elements;                                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public SubstanceProtein()                                                                                                           // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "SubstanceProtein";                                                                                                 // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceProtein";                                                          // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "SubstanceProtein",                                                                                                  // MakerGen.cs:423
                ElementId = "SubstanceProtein"                                                                                              // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
