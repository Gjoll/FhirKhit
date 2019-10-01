using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
    {
      "resourceType": "StructureDefinition",
      "id": "SubstanceNucleicAcid",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid",
      "version": "4.0.0",
      "name": "SubstanceNucleicAcid",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Nucleic acids are defined by three distinct elements: the base, sugar and linkage. Individual substance/moiety IDs will be created for each of these elements. The nucleotide sequence will be always entered in the 5’-3’ direction.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceNucleicAcid",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceNucleicAcid",
            "path": "SubstanceNucleicAcid",
            "short": "Nucleic acids are defined by three distinct elements: the base, sugar and linkage. Individual substance/moiety IDs will be created for each of these elements. The nucleotide sequence will be always entered in the 5’-3’ direction",
            "definition": "Nucleic acids are defined by three distinct elements: the base, sugar and linkage. Individual substance/moiety IDs will be created for each of these elements. The nucleotide sequence will be always entered in the 5’-3’ direction.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceNucleicAcid.sequenceType",
            "path": "SubstanceNucleicAcid.sequenceType",
            "short": "The type of the sequence shall be specified based on a controlled vocabulary",
            "definition": "The type of the sequence shall be specified based on a controlled vocabulary.",
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
            "id": "SubstanceNucleicAcid.numberOfSubunits",
            "path": "SubstanceNucleicAcid.numberOfSubunits",
            "short": "The number of linear sequences of nucleotides linked through phosphodiester bonds shall be described. Subunits would be strands of nucleic acids that are tightly associated typically through Watson-Crick base pairing. NOTE: If not specified in the reference source, the assumption is that there is 1 subunit",
            "definition": "The number of linear sequences of nucleotides linked through phosphodiester bonds shall be described. Subunits would be strands of nucleic acids that are tightly associated typically through Watson-Crick base pairing. NOTE: If not specified in the reference source, the assumption is that there is 1 subunit.",
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
            "id": "SubstanceNucleicAcid.areaOfHybridisation",
            "path": "SubstanceNucleicAcid.areaOfHybridisation",
            "short": "The area of hybridisation shall be described if applicable for double stranded RNA or DNA. The number associated with the subunit followed by the number associated to the residue shall be specified in increasing order. The underscore “” shall be used as separator as follows: “Subunitnumber Residue”",
            "definition": "The area of hybridisation shall be described if applicable for double stranded RNA or DNA. The number associated with the subunit followed by the number associated to the residue shall be specified in increasing order. The underscore “” shall be used as separator as follows: “Subunitnumber Residue”.",
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
            "id": "SubstanceNucleicAcid.oligoNucleotideType",
            "path": "SubstanceNucleicAcid.oligoNucleotideType",
            "short": "(TBC)",
            "definition": "(TBC).",
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
            "id": "SubstanceNucleicAcid.subunit",
            "path": "SubstanceNucleicAcid.subunit",
            "short": "Subunits are listed in order of decreasing length; sequences of the same length will be ordered by molecular weight; subunits that have identical sequences will be repeated multiple times",
            "definition": "Subunits are listed in order of decreasing length; sequences of the same length will be ordered by molecular weight; subunits that have identical sequences will be repeated multiple times.",
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
            "id": "SubstanceNucleicAcid.subunit.subunit",
            "path": "SubstanceNucleicAcid.subunit.subunit",
            "short": "Index of linear sequences of nucleic acids in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts",
            "definition": "Index of linear sequences of nucleic acids in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts.",
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
            "id": "SubstanceNucleicAcid.subunit.sequence",
            "path": "SubstanceNucleicAcid.subunit.sequence",
            "short": "Actual nucleotide sequence notation from 5' to 3' end using standard single letter codes. In addition to the base sequence, sugar and type of phosphate or non-phosphate linkage should also be captured",
            "definition": "Actual nucleotide sequence notation from 5' to 3' end using standard single letter codes. In addition to the base sequence, sugar and type of phosphate or non-phosphate linkage should also be captured.",
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
            "id": "SubstanceNucleicAcid.subunit.length",
            "path": "SubstanceNucleicAcid.subunit.length",
            "short": "The length of the sequence shall be captured",
            "definition": "The length of the sequence shall be captured.",
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
            "id": "SubstanceNucleicAcid.subunit.sequenceAttachment",
            "path": "SubstanceNucleicAcid.subunit.sequenceAttachment",
            "short": "(TBC)",
            "definition": "(TBC).",
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
            "id": "SubstanceNucleicAcid.subunit.fivePrime",
            "path": "SubstanceNucleicAcid.subunit.fivePrime",
            "short": "The nucleotide present at the 5’ terminal shall be specified based on a controlled vocabulary. Since the sequence is represented from the 5' to the 3' end, the 5’ prime nucleotide is the letter at the first position in the sequence. A separate representation would be redundant",
            "definition": "The nucleotide present at the 5’ terminal shall be specified based on a controlled vocabulary. Since the sequence is represented from the 5' to the 3' end, the 5’ prime nucleotide is the letter at the first position in the sequence. A separate representation would be redundant.",
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
            "id": "SubstanceNucleicAcid.subunit.threePrime",
            "path": "SubstanceNucleicAcid.subunit.threePrime",
            "short": "The nucleotide present at the 3’ terminal shall be specified based on a controlled vocabulary. Since the sequence is represented from the 5' to the 3' end, the 5’ prime nucleotide is the letter at the last position in the sequence. A separate representation would be redundant",
            "definition": "The nucleotide present at the 3’ terminal shall be specified based on a controlled vocabulary. Since the sequence is represented from the 5' to the 3' end, the 5’ prime nucleotide is the letter at the last position in the sequence. A separate representation would be redundant.",
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
            "id": "SubstanceNucleicAcid.subunit.linkage",
            "path": "SubstanceNucleicAcid.subunit.linkage",
            "short": "The linkages between sugar residues will also be captured",
            "definition": "The linkages between sugar residues will also be captured.",
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
            "id": "SubstanceNucleicAcid.subunit.linkage.connectivity",
            "path": "SubstanceNucleicAcid.subunit.linkage.connectivity",
            "short": "The entity that links the sugar residues together should also be captured for nearly all naturally occurring nucleic acid the linkage is a phosphate group. For many synthetic oligonucleotides phosphorothioate linkages are often seen. Linkage connectivity is assumed to be 3’-5’. If the linkage is either 3’-3’ or 5’-5’ this should be specified",
            "definition": "The entity that links the sugar residues together should also be captured for nearly all naturally occurring nucleic acid the linkage is a phosphate group. For many synthetic oligonucleotides phosphorothioate linkages are often seen. Linkage connectivity is assumed to be 3’-5’. If the linkage is either 3’-3’ or 5’-5’ this should be specified.",
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
            "id": "SubstanceNucleicAcid.subunit.linkage.identifier",
            "path": "SubstanceNucleicAcid.subunit.linkage.identifier",
            "short": "Each linkage will be registered as a fragment and have an ID",
            "definition": "Each linkage will be registered as a fragment and have an ID.",
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
            "id": "SubstanceNucleicAcid.subunit.linkage.name",
            "path": "SubstanceNucleicAcid.subunit.linkage.name",
            "short": "Each linkage will be registered as a fragment and have at least one name. A single name shall be assigned to each linkage",
            "definition": "Each linkage will be registered as a fragment and have at least one name. A single name shall be assigned to each linkage.",
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
            "id": "SubstanceNucleicAcid.subunit.linkage.residueSite",
            "path": "SubstanceNucleicAcid.subunit.linkage.residueSite",
            "short": "Residues shall be captured as described in 5.3.6.8.3",
            "definition": "Residues shall be captured as described in 5.3.6.8.3.",
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
            "id": "SubstanceNucleicAcid.subunit.sugar",
            "path": "SubstanceNucleicAcid.subunit.sugar",
            "short": "5.3.6.8.1 Sugar ID (Mandatory)",
            "definition": "5.3.6.8.1 Sugar ID (Mandatory).",
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
            "id": "SubstanceNucleicAcid.subunit.sugar.identifier",
            "path": "SubstanceNucleicAcid.subunit.sugar.identifier",
            "short": "The Substance ID of the sugar or sugar-like component that make up the nucleotide",
            "definition": "The Substance ID of the sugar or sugar-like component that make up the nucleotide.",
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
            "id": "SubstanceNucleicAcid.subunit.sugar.name",
            "path": "SubstanceNucleicAcid.subunit.sugar.name",
            "short": "The name of the sugar or sugar-like component that make up the nucleotide",
            "definition": "The name of the sugar or sugar-like component that make up the nucleotide.",
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
            "id": "SubstanceNucleicAcid.subunit.sugar.residueSite",
            "path": "SubstanceNucleicAcid.subunit.sugar.residueSite",
            "short": "The residues that contain a given sugar will be captured. The order of given residues will be captured in the 5‘-3‘direction consistent with the base sequences listed above",
            "definition": "The residues that contain a given sugar will be captured. The order of given residues will be captured in the 5‘-3‘direction consistent with the base sequences listed above.",
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'SubstanceNucleicAcid'
    /// </summary>
    // 0. SubstanceNucleicAcid
    public class SubstanceNucleicAcid : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 5. SubstanceNucleicAcid.subunit
        public class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 12. SubstanceNucleicAcid.subunit.linkage
            public class Type_Linkage : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                public MakerElementInstance Element_Connectivity;                                                                           // MakerGen.cs:232
                // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                public MakerElementInstance Element_Identifier;                                                                             // MakerGen.cs:232
                // 15. SubstanceNucleicAcid.subunit.linkage.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                public MakerElementInstance Element_ResidueSite;                                                                            // MakerGen.cs:232
                public Type_Linkage()                                                                                                       // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    {                                                                                                                       // MakerGen.cs:243
                        // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                        this.Element_Connectivity = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Connectivity",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                        this.Element_Identifier = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Identifier",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Identifier                                                                // MakerGen.cs:343
                                {                                                                                                           // MakerGen.cs:344
                                }                                                                                                           // MakerGen.cs:345
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 15. SubstanceNucleicAcid.subunit.linkage.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                        this.Element_ResidueSite = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ResidueSite",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:389
            // 17. SubstanceNucleicAcid.subunit.sugar
            public class Type_Sugar : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                public MakerElementInstance Element_Identifier;                                                                             // MakerGen.cs:232
                // 19. SubstanceNucleicAcid.subunit.sugar.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                public MakerElementInstance Element_ResidueSite;                                                                            // MakerGen.cs:232
                public Type_Sugar()                                                                                                         // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    {                                                                                                                       // MakerGen.cs:243
                        // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                        this.Element_Identifier = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Identifier",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Identifier                                                                // MakerGen.cs:343
                                {                                                                                                           // MakerGen.cs:344
                                }                                                                                                           // MakerGen.cs:345
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 19. SubstanceNucleicAcid.subunit.sugar.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                        this.Element_ResidueSite = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ResidueSite",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:389
            // 6. SubstanceNucleicAcid.subunit.subunit
            public MakerElementInstance Element_Subunit;                                                                                    // MakerGen.cs:232
            // 7. SubstanceNucleicAcid.subunit.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 8. SubstanceNucleicAcid.subunit.length
            public MakerElementInstance Element_Length;                                                                                     // MakerGen.cs:232
            // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
            public MakerElementInstance Element_SequenceAttachment;                                                                         // MakerGen.cs:232
            // 10. SubstanceNucleicAcid.subunit.fivePrime
            public MakerElementInstance Element_FivePrime;                                                                                  // MakerGen.cs:232
            // 11. SubstanceNucleicAcid.subunit.threePrime
            public MakerElementInstance Element_ThreePrime;                                                                                 // MakerGen.cs:232
            public Type_Subunit()                                                                                                           // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 6. SubstanceNucleicAcid.subunit.subunit
                    this.Element_Subunit = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Subunit",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 7. SubstanceNucleicAcid.subunit.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 8. SubstanceNucleicAcid.subunit.length
                    this.Element_Length = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Length",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                    this.Element_SequenceAttachment = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SequenceAttachment",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 10. SubstanceNucleicAcid.subunit.fivePrime
                    this.Element_FivePrime = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_FivePrime",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 11. SubstanceNucleicAcid.subunit.threePrime
                    this.Element_ThreePrime = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ThreePrime",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. SubstanceNucleicAcid.sequenceType
        public MakerElementInstance Element_SequenceType;                                                                                   // MakerGen.cs:232
        // 2. SubstanceNucleicAcid.numberOfSubunits
        public MakerElementInstance Element_NumberOfSubunits;                                                                               // MakerGen.cs:232
        // 3. SubstanceNucleicAcid.areaOfHybridisation
        public MakerElementInstance Element_AreaOfHybridisation;                                                                            // MakerGen.cs:232
        // 4. SubstanceNucleicAcid.oligoNucleotideType
        public MakerElementInstance Element_OligoNucleotideType;                                                                            // MakerGen.cs:232
        public SubstanceNucleicAcid()                                                                                                       // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. SubstanceNucleicAcid.sequenceType
                this.Element_SequenceType = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SequenceType",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. SubstanceNucleicAcid.numberOfSubunits
                this.Element_NumberOfSubunits = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_NumberOfSubunits",                                                                                      // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Integer                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. SubstanceNucleicAcid.areaOfHybridisation
                this.Element_AreaOfHybridisation = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AreaOfHybridisation",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. SubstanceNucleicAcid.oligoNucleotideType
                this.Element_OligoNucleotideType = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_OligoNucleotideType",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
