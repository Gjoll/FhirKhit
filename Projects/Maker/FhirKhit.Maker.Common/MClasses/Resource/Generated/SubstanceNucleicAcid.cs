using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'SubstanceNucleicAcid'
    /// </summary>
    // 0. SubstanceNucleicAcid
    public class SubstanceNucleicAcid : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class SubstanceNucleicAcid_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 5. SubstanceNucleicAcid.subunit
            public class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Subunit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 12. SubstanceNucleicAcid.subunit.linkage
                    public class Type_Linkage : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Linkage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                            public ElementDefinitionInfo Connectivity;                                                                      // MakerGen.cs:236
                            // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                            public ElementDefinitionInfo Identifier;                                                                        // MakerGen.cs:236
                            // 15. SubstanceNucleicAcid.subunit.linkage.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:236
                            // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                            public ElementDefinitionInfo ResidueSite;                                                                       // MakerGen.cs:236
                            public Type_Linkage_Elements()                                                                                  // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                                    this.Connectivity = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Connectivity",                                                                              // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.linkage.connectivity",                                          // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.linkage.connectivity",                                           // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                                    this.Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Identifier",                                                                                // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.linkage.identifier",                                            // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.linkage.identifier",                                             // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Identifier                                                    // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 15. SubstanceNucleicAcid.subunit.linkage.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Name",                                                                                      // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.linkage.name",                                                  // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.linkage.name",                                                   // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                                    this.ResidueSite = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ResidueSite",                                                                               // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.linkage.residueSite",                                           // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.linkage.residueSite",                                            // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Connectivity.Write(sDef);                                                                                   // MakerGen.cs:240
                                Identifier.Write(sDef);                                                                                     // MakerGen.cs:240
                                Name.Write(sDef);                                                                                           // MakerGen.cs:240
                                ResidueSite.Write(sDef);                                                                                    // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Linkage_Elements Elements { get; }                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Linkage()                                                                                               // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Linkage_Elements();                                                                    // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 17. SubstanceNucleicAcid.subunit.sugar
                    public class Type_Sugar : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Sugar_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                            public ElementDefinitionInfo Identifier;                                                                        // MakerGen.cs:236
                            // 19. SubstanceNucleicAcid.subunit.sugar.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:236
                            // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                            public ElementDefinitionInfo ResidueSite;                                                                       // MakerGen.cs:236
                            public Type_Sugar_Elements()                                                                                    // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                                    this.Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Identifier",                                                                                // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.sugar.identifier",                                              // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.sugar.identifier",                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Identifier                                                    // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 19. SubstanceNucleicAcid.subunit.sugar.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Name",                                                                                      // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.sugar.name",                                                    // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.sugar.name",                                                     // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                                    this.ResidueSite = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ResidueSite",                                                                               // MakerGen.cs:255
                                        Path= "SubstanceNucleicAcid.subunit.sugar.residueSite",                                             // MakerGen.cs:256
                                        Id = "SubstanceNucleicAcid.subunit.sugar.residueSite",                                              // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Identifier.Write(sDef);                                                                                     // MakerGen.cs:240
                                Name.Write(sDef);                                                                                           // MakerGen.cs:240
                                ResidueSite.Write(sDef);                                                                                    // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Sugar_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Sugar()                                                                                                 // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Sugar_Elements();                                                                      // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 6. SubstanceNucleicAcid.subunit.subunit
                    public ElementDefinitionInfo Subunit;                                                                                   // MakerGen.cs:236
                    // 7. SubstanceNucleicAcid.subunit.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 8. SubstanceNucleicAcid.subunit.length
                    public ElementDefinitionInfo Length;                                                                                    // MakerGen.cs:236
                    // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                    public ElementDefinitionInfo SequenceAttachment;                                                                        // MakerGen.cs:236
                    // 10. SubstanceNucleicAcid.subunit.fivePrime
                    public ElementDefinitionInfo FivePrime;                                                                                 // MakerGen.cs:236
                    // 11. SubstanceNucleicAcid.subunit.threePrime
                    public ElementDefinitionInfo ThreePrime;                                                                                // MakerGen.cs:236
                    public Type_Subunit_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 6. SubstanceNucleicAcid.subunit.subunit
                            this.Subunit = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Subunit",                                                                                           // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.subunit",                                                               // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.subunit",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 7. SubstanceNucleicAcid.subunit.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.sequence",                                                              // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.sequence",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. SubstanceNucleicAcid.subunit.length
                            this.Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Length",                                                                                            // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.length",                                                                // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.length",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                            this.SequenceAttachment = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SequenceAttachment",                                                                                // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.sequenceAttachment",                                                    // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.sequenceAttachment",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 10. SubstanceNucleicAcid.subunit.fivePrime
                            this.FivePrime = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "FivePrime",                                                                                         // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.fivePrime",                                                             // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.fivePrime",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. SubstanceNucleicAcid.subunit.threePrime
                            this.ThreePrime = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ThreePrime",                                                                                        // MakerGen.cs:255
                                Path= "SubstanceNucleicAcid.subunit.threePrime",                                                            // MakerGen.cs:256
                                Id = "SubstanceNucleicAcid.subunit.threePrime",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Subunit.Write(sDef);                                                                                                // MakerGen.cs:240
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        Length.Write(sDef);                                                                                                 // MakerGen.cs:240
                        SequenceAttachment.Write(sDef);                                                                                     // MakerGen.cs:240
                        FivePrime.Write(sDef);                                                                                              // MakerGen.cs:240
                        ThreePrime.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Subunit_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Subunit()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Subunit_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. SubstanceNucleicAcid.sequenceType
            public ElementDefinitionInfo SequenceType;                                                                                      // MakerGen.cs:236
            // 2. SubstanceNucleicAcid.numberOfSubunits
            public ElementDefinitionInfo NumberOfSubunits;                                                                                  // MakerGen.cs:236
            // 3. SubstanceNucleicAcid.areaOfHybridisation
            public ElementDefinitionInfo AreaOfHybridisation;                                                                               // MakerGen.cs:236
            // 4. SubstanceNucleicAcid.oligoNucleotideType
            public ElementDefinitionInfo OligoNucleotideType;                                                                               // MakerGen.cs:236
            public SubstanceNucleicAcid_Elements()                                                                                          // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. SubstanceNucleicAcid.sequenceType
                    this.SequenceType = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SequenceType",                                                                                              // MakerGen.cs:255
                        Path= "SubstanceNucleicAcid.sequenceType",                                                                          // MakerGen.cs:256
                        Id = "SubstanceNucleicAcid.sequenceType",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. SubstanceNucleicAcid.numberOfSubunits
                    this.NumberOfSubunits = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "NumberOfSubunits",                                                                                          // MakerGen.cs:255
                        Path= "SubstanceNucleicAcid.numberOfSubunits",                                                                      // MakerGen.cs:256
                        Id = "SubstanceNucleicAcid.numberOfSubunits",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. SubstanceNucleicAcid.areaOfHybridisation
                    this.AreaOfHybridisation = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AreaOfHybridisation",                                                                                       // MakerGen.cs:255
                        Path= "SubstanceNucleicAcid.areaOfHybridisation",                                                                   // MakerGen.cs:256
                        Id = "SubstanceNucleicAcid.areaOfHybridisation",                                                                    // MakerGen.cs:257
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
                    // 4. SubstanceNucleicAcid.oligoNucleotideType
                    this.OligoNucleotideType = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OligoNucleotideType",                                                                                       // MakerGen.cs:255
                        Path= "SubstanceNucleicAcid.oligoNucleotideType",                                                                   // MakerGen.cs:256
                        Id = "SubstanceNucleicAcid.oligoNucleotideType",                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                SequenceType.Write(sDef);                                                                                                   // MakerGen.cs:240
                NumberOfSubunits.Write(sDef);                                                                                               // MakerGen.cs:240
                AreaOfHybridisation.Write(sDef);                                                                                            // MakerGen.cs:240
                OligoNucleotideType.Write(sDef);                                                                                            // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public SubstanceNucleicAcid_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public SubstanceNucleicAcid()                                                                                                       // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new SubstanceNucleicAcid_Elements();                                                                            // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
