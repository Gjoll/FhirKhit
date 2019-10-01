using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'SubstanceNucleicAcid'
    /// </summary>
    // 0. SubstanceNucleicAcid
    public class Resource_SubstanceNucleicAcid : FhirKhit.Maker.Common.Resource.ResourceBase                                                // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_SubstanceNucleicAcid_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 5. SubstanceNucleicAcid.subunit
            public class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Subunit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 12. SubstanceNucleicAcid.subunit.linkage
                    public class Type_Linkage : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Linkage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                            public ElementDefinitionInfo Element_Connectivity;                                                              // MakerGen.cs:211
                            // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                            public ElementDefinitionInfo Element_Identifier;                                                                // MakerGen.cs:211
                            // 15. SubstanceNucleicAcid.subunit.linkage.name
                            public ElementDefinitionInfo Element_Name;                                                                      // MakerGen.cs:211
                            // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                            public ElementDefinitionInfo Element_ResidueSite;                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Linkage_Elements()                                                                                  // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                                    this.Element_Connectivity = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Connectivity",                                                                      // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.linkage.connectivity",                                          // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.linkage.connectivity",                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                                    this.Element_Identifier = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Identifier",                                                                        // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.linkage.identifier",                                            // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.linkage.identifier",                                             // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                               // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 15. SubstanceNucleicAcid.subunit.linkage.name
                                    this.Element_Name = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Name",                                                                              // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.linkage.name",                                                  // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.linkage.name",                                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                                    this.Element_ResidueSite = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_ResidueSite",                                                                       // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.linkage.residueSite",                                           // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.linkage.residueSite",                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Connectivity.Write(sDef);                                                                           // MakerGen.cs:215
                                Element_Identifier.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Name.Write(sDef);                                                                                   // MakerGen.cs:215
                                Element_ResidueSite.Write(sDef);                                                                            // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Linkage_Elements Elements                                                                               // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Linkage_Elements();                                                            // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Linkage_Elements elements;                                                                                     // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Linkage()                                                                                               // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SubstanceNucleicAcid.subunit.linkage",                                                              // MakerGen.cs:420
                                ElementId = "SubstanceNucleicAcid.subunit.linkage"                                                          // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 17. SubstanceNucleicAcid.subunit.sugar
                    public class Type_Sugar : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Sugar_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                            public ElementDefinitionInfo Element_Identifier;                                                                // MakerGen.cs:211
                            // 19. SubstanceNucleicAcid.subunit.sugar.name
                            public ElementDefinitionInfo Element_Name;                                                                      // MakerGen.cs:211
                            // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                            public ElementDefinitionInfo Element_ResidueSite;                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Sugar_Elements()                                                                                    // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                                    this.Element_Identifier = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Identifier",                                                                        // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.sugar.identifier",                                              // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.sugar.identifier",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                               // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 19. SubstanceNucleicAcid.subunit.sugar.name
                                    this.Element_Name = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Name",                                                                              // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.sugar.name",                                                    // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.sugar.name",                                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                                    this.Element_ResidueSite = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_ResidueSite",                                                                       // MakerGen.cs:230
                                        Path= "SubstanceNucleicAcid.subunit.sugar.residueSite",                                             // MakerGen.cs:231
                                        Id = "SubstanceNucleicAcid.subunit.sugar.residueSite",                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Identifier.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Name.Write(sDef);                                                                                   // MakerGen.cs:215
                                Element_ResidueSite.Write(sDef);                                                                            // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Sugar_Elements Elements                                                                                 // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Sugar_Elements();                                                              // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Sugar_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Sugar()                                                                                                 // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "SubstanceNucleicAcid.subunit.sugar",                                                                // MakerGen.cs:420
                                ElementId = "SubstanceNucleicAcid.subunit.sugar"                                                            // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 6. SubstanceNucleicAcid.subunit.subunit
                    public ElementDefinitionInfo Element_Subunit;                                                                           // MakerGen.cs:211
                    // 7. SubstanceNucleicAcid.subunit.sequence
                    public ElementDefinitionInfo Element_Sequence;                                                                          // MakerGen.cs:211
                    // 8. SubstanceNucleicAcid.subunit.length
                    public ElementDefinitionInfo Element_Length;                                                                            // MakerGen.cs:211
                    // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                    public ElementDefinitionInfo Element_SequenceAttachment;                                                                // MakerGen.cs:211
                    // 10. SubstanceNucleicAcid.subunit.fivePrime
                    public ElementDefinitionInfo Element_FivePrime;                                                                         // MakerGen.cs:211
                    // 11. SubstanceNucleicAcid.subunit.threePrime
                    public ElementDefinitionInfo Element_ThreePrime;                                                                        // MakerGen.cs:211
                    // 12. SubstanceNucleicAcid.subunit.linkage
                    public ElementDefinitionInfo Element_Linkage;                                                                           // MakerGen.cs:211
                    // 17. SubstanceNucleicAcid.subunit.sugar
                    public ElementDefinitionInfo Element_Sugar;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Subunit_Elements()                                                                                          // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 6. SubstanceNucleicAcid.subunit.subunit
                            this.Element_Subunit = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Subunit",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.subunit",                                                               // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.subunit",                                                                // MakerGen.cs:232
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
                            // 7. SubstanceNucleicAcid.subunit.sequence
                            this.Element_Sequence = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Sequence",                                                                                  // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.sequence",                                                              // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.sequence",                                                               // MakerGen.cs:232
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
                            // 8. SubstanceNucleicAcid.subunit.length
                            this.Element_Length = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Length",                                                                                    // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.length",                                                                // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.length",                                                                 // MakerGen.cs:232
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
                            // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                            this.Element_SequenceAttachment = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SequenceAttachment",                                                                        // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.sequenceAttachment",                                                    // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.sequenceAttachment",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment                                                       // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. SubstanceNucleicAcid.subunit.fivePrime
                            this.Element_FivePrime = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_FivePrime",                                                                                 // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.fivePrime",                                                             // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.fivePrime",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. SubstanceNucleicAcid.subunit.threePrime
                            this.Element_ThreePrime = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ThreePrime",                                                                                // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.threePrime",                                                            // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.threePrime",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. SubstanceNucleicAcid.subunit.linkage
                            this.Element_Linkage = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Linkage",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.linkage",                                                               // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.linkage",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Linkage                                                                                        // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. SubstanceNucleicAcid.subunit.sugar
                            this.Element_Sugar = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Sugar",                                                                                     // MakerGen.cs:230
                                Path= "SubstanceNucleicAcid.subunit.sugar",                                                                 // MakerGen.cs:231
                                Id = "SubstanceNucleicAcid.subunit.sugar",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Sugar                                                                                          // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Subunit.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_Sequence.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Length.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_SequenceAttachment.Write(sDef);                                                                             // MakerGen.cs:215
                        Element_FivePrime.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_ThreePrime.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Linkage.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_Sugar.Write(sDef);                                                                                          // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Subunit_Elements Elements                                                                                       // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Subunit_Elements();                                                                    // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Subunit_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Subunit()                                                                                                       // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "SubstanceNucleicAcid.subunit",                                                                              // MakerGen.cs:420
                        ElementId = "SubstanceNucleicAcid.subunit"                                                                          // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. SubstanceNucleicAcid.sequenceType
            public ElementDefinitionInfo Element_SequenceType;                                                                              // MakerGen.cs:211
            // 2. SubstanceNucleicAcid.numberOfSubunits
            public ElementDefinitionInfo Element_NumberOfSubunits;                                                                          // MakerGen.cs:211
            // 3. SubstanceNucleicAcid.areaOfHybridisation
            public ElementDefinitionInfo Element_AreaOfHybridisation;                                                                       // MakerGen.cs:211
            // 4. SubstanceNucleicAcid.oligoNucleotideType
            public ElementDefinitionInfo Element_OligoNucleotideType;                                                                       // MakerGen.cs:211
            // 5. SubstanceNucleicAcid.subunit
            public ElementDefinitionInfo Element_Subunit;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_SubstanceNucleicAcid_Elements()                                                                                 // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SubstanceNucleicAcid.sequenceType
                    this.Element_SequenceType = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_SequenceType",                                                                                      // MakerGen.cs:230
                        Path= "SubstanceNucleicAcid.sequenceType",                                                                          // MakerGen.cs:231
                        Id = "SubstanceNucleicAcid.sequenceType",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SubstanceNucleicAcid.numberOfSubunits
                    this.Element_NumberOfSubunits = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_NumberOfSubunits",                                                                                  // MakerGen.cs:230
                        Path= "SubstanceNucleicAcid.numberOfSubunits",                                                                      // MakerGen.cs:231
                        Id = "SubstanceNucleicAcid.numberOfSubunits",                                                                       // MakerGen.cs:232
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
                    // 3. SubstanceNucleicAcid.areaOfHybridisation
                    this.Element_AreaOfHybridisation = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_AreaOfHybridisation",                                                                               // MakerGen.cs:230
                        Path= "SubstanceNucleicAcid.areaOfHybridisation",                                                                   // MakerGen.cs:231
                        Id = "SubstanceNucleicAcid.areaOfHybridisation",                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SubstanceNucleicAcid.oligoNucleotideType
                    this.Element_OligoNucleotideType = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_OligoNucleotideType",                                                                               // MakerGen.cs:230
                        Path= "SubstanceNucleicAcid.oligoNucleotideType",                                                                   // MakerGen.cs:231
                        Id = "SubstanceNucleicAcid.oligoNucleotideType",                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. SubstanceNucleicAcid.subunit
                    this.Element_Subunit = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subunit",                                                                                           // MakerGen.cs:230
                        Path= "SubstanceNucleicAcid.subunit",                                                                               // MakerGen.cs:231
                        Id = "SubstanceNucleicAcid.subunit",                                                                                // MakerGen.cs:232
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
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_SequenceType.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_NumberOfSubunits.Write(sDef);                                                                                       // MakerGen.cs:215
                Element_AreaOfHybridisation.Write(sDef);                                                                                    // MakerGen.cs:215
                Element_OligoNucleotideType.Write(sDef);                                                                                    // MakerGen.cs:215
                Element_Subunit.Write(sDef);                                                                                                // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_SubstanceNucleicAcid_Elements Elements                                                                              // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_SubstanceNucleicAcid_Elements();                                                           // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_SubstanceNucleicAcid_Elements elements;                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_SubstanceNucleicAcid()                                                                                              // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "SubstanceNucleicAcid";                                                                                             // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid";                                                      // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "SubstanceNucleicAcid",                                                                                              // MakerGen.cs:420
                ElementId = "SubstanceNucleicAcid"                                                                                          // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
