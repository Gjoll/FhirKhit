using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
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
    #endregion
    /// <summary>
    /// Fhir resource 'SubstanceNucleicAcid'
    /// </summary>
    // 0. SubstanceNucleicAcid
    public partial class Resource_SubstanceNucleicAcid : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 5. SubstanceNucleicAcid.subunit
        public partial class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. SubstanceNucleicAcid.subunit.linkage
            public partial class Type_Linkage : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                public ElementDefinitionInfo Element_Connectivity;
                // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                public ElementDefinitionInfo Element_Identifier;
                // 15. SubstanceNucleicAcid.subunit.linkage.name
                public ElementDefinitionInfo Element_Name;
                // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                public ElementDefinitionInfo Element_ResidueSite;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceNucleicAcid.subunit.linkage",
                        ElementId = "SubstanceNucleicAcid.subunit.linkage"
                    });
                    Element_Connectivity.Write(sDef);
                    Element_Identifier.Write(sDef);
                    Element_Name.Write(sDef);
                    Element_ResidueSite.Write(sDef);
                }
                
                public Type_Linkage()
                {
                    {
                        // 13. SubstanceNucleicAcid.subunit.linkage.connectivity
                        this.Element_Connectivity = new ElementDefinitionInfo
                        {
                            Name = "Element_Connectivity",
                            Path= "SubstanceNucleicAcid.subunit.linkage.connectivity",
                            Id = "SubstanceNucleicAcid.subunit.linkage.connectivity",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 14. SubstanceNucleicAcid.subunit.linkage.identifier
                        this.Element_Identifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Identifier",
                            Path= "SubstanceNucleicAcid.subunit.linkage.identifier",
                            Id = "SubstanceNucleicAcid.subunit.linkage.identifier",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Identifier
                                {
                                }
                            }
                        };
                    }
                    {
                        // 15. SubstanceNucleicAcid.subunit.linkage.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "SubstanceNucleicAcid.subunit.linkage.name",
                            Id = "SubstanceNucleicAcid.subunit.linkage.name",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 16. SubstanceNucleicAcid.subunit.linkage.residueSite
                        this.Element_ResidueSite = new ElementDefinitionInfo
                        {
                            Name = "Element_ResidueSite",
                            Path= "SubstanceNucleicAcid.subunit.linkage.residueSite",
                            Id = "SubstanceNucleicAcid.subunit.linkage.residueSite",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 17. SubstanceNucleicAcid.subunit.sugar
            public partial class Type_Sugar : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                public ElementDefinitionInfo Element_Identifier;
                // 19. SubstanceNucleicAcid.subunit.sugar.name
                public ElementDefinitionInfo Element_Name;
                // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                public ElementDefinitionInfo Element_ResidueSite;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceNucleicAcid.subunit.sugar",
                        ElementId = "SubstanceNucleicAcid.subunit.sugar"
                    });
                    Element_Identifier.Write(sDef);
                    Element_Name.Write(sDef);
                    Element_ResidueSite.Write(sDef);
                }
                
                public Type_Sugar()
                {
                    {
                        // 18. SubstanceNucleicAcid.subunit.sugar.identifier
                        this.Element_Identifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Identifier",
                            Path= "SubstanceNucleicAcid.subunit.sugar.identifier",
                            Id = "SubstanceNucleicAcid.subunit.sugar.identifier",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Identifier
                                {
                                }
                            }
                        };
                    }
                    {
                        // 19. SubstanceNucleicAcid.subunit.sugar.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "SubstanceNucleicAcid.subunit.sugar.name",
                            Id = "SubstanceNucleicAcid.subunit.sugar.name",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                    {
                        // 20. SubstanceNucleicAcid.subunit.sugar.residueSite
                        this.Element_ResidueSite = new ElementDefinitionInfo
                        {
                            Name = "Element_ResidueSite",
                            Path= "SubstanceNucleicAcid.subunit.sugar.residueSite",
                            Id = "SubstanceNucleicAcid.subunit.sugar.residueSite",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 6. SubstanceNucleicAcid.subunit.subunit
            public ElementDefinitionInfo Element_Subunit;
            // 7. SubstanceNucleicAcid.subunit.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 8. SubstanceNucleicAcid.subunit.length
            public ElementDefinitionInfo Element_Length;
            // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
            public ElementDefinitionInfo Element_SequenceAttachment;
            // 10. SubstanceNucleicAcid.subunit.fivePrime
            public ElementDefinitionInfo Element_FivePrime;
            // 11. SubstanceNucleicAcid.subunit.threePrime
            public ElementDefinitionInfo Element_ThreePrime;
            // 12. SubstanceNucleicAcid.subunit.linkage
            public ElementDefinitionInfo Element_Linkage;
            // 17. SubstanceNucleicAcid.subunit.sugar
            public ElementDefinitionInfo Element_Sugar;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceNucleicAcid.subunit",
                    ElementId = "SubstanceNucleicAcid.subunit"
                });
                Element_Subunit.Write(sDef);
                Element_Sequence.Write(sDef);
                Element_Length.Write(sDef);
                Element_SequenceAttachment.Write(sDef);
                Element_FivePrime.Write(sDef);
                Element_ThreePrime.Write(sDef);
                Element_Linkage.Write(sDef);
                Element_Sugar.Write(sDef);
            }
            
            public Type_Subunit()
            {
                {
                    // 6. SubstanceNucleicAcid.subunit.subunit
                    this.Element_Subunit = new ElementDefinitionInfo
                    {
                        Name = "Element_Subunit",
                        Path= "SubstanceNucleicAcid.subunit.subunit",
                        Id = "SubstanceNucleicAcid.subunit.subunit",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
                {
                    // 7. SubstanceNucleicAcid.subunit.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "SubstanceNucleicAcid.subunit.sequence",
                        Id = "SubstanceNucleicAcid.subunit.sequence",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 8. SubstanceNucleicAcid.subunit.length
                    this.Element_Length = new ElementDefinitionInfo
                    {
                        Name = "Element_Length",
                        Path= "SubstanceNucleicAcid.subunit.length",
                        Id = "SubstanceNucleicAcid.subunit.length",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
                {
                    // 9. SubstanceNucleicAcid.subunit.sequenceAttachment
                    this.Element_SequenceAttachment = new ElementDefinitionInfo
                    {
                        Name = "Element_SequenceAttachment",
                        Path= "SubstanceNucleicAcid.subunit.sequenceAttachment",
                        Id = "SubstanceNucleicAcid.subunit.sequenceAttachment",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            }
                        }
                    };
                }
                {
                    // 10. SubstanceNucleicAcid.subunit.fivePrime
                    this.Element_FivePrime = new ElementDefinitionInfo
                    {
                        Name = "Element_FivePrime",
                        Path= "SubstanceNucleicAcid.subunit.fivePrime",
                        Id = "SubstanceNucleicAcid.subunit.fivePrime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 11. SubstanceNucleicAcid.subunit.threePrime
                    this.Element_ThreePrime = new ElementDefinitionInfo
                    {
                        Name = "Element_ThreePrime",
                        Path= "SubstanceNucleicAcid.subunit.threePrime",
                        Id = "SubstanceNucleicAcid.subunit.threePrime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 12. SubstanceNucleicAcid.subunit.linkage
                    this.Element_Linkage = new ElementDefinitionInfo
                    {
                        Name = "Element_Linkage",
                        Path= "SubstanceNucleicAcid.subunit.linkage",
                        Id = "SubstanceNucleicAcid.subunit.linkage",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Linkage
                            {
                            }
                        }
                    };
                }
                {
                    // 17. SubstanceNucleicAcid.subunit.sugar
                    this.Element_Sugar = new ElementDefinitionInfo
                    {
                        Name = "Element_Sugar",
                        Path= "SubstanceNucleicAcid.subunit.sugar",
                        Id = "SubstanceNucleicAcid.subunit.sugar",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Sugar
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. SubstanceNucleicAcid.sequenceType
        public ElementDefinitionInfo Element_SequenceType;
        // 2. SubstanceNucleicAcid.numberOfSubunits
        public ElementDefinitionInfo Element_NumberOfSubunits;
        // 3. SubstanceNucleicAcid.areaOfHybridisation
        public ElementDefinitionInfo Element_AreaOfHybridisation;
        // 4. SubstanceNucleicAcid.oligoNucleotideType
        public ElementDefinitionInfo Element_OligoNucleotideType;
        // 5. SubstanceNucleicAcid.subunit
        public ElementDefinitionInfo Element_Subunit;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceNucleicAcid",
                ElementId = "SubstanceNucleicAcid"
            });
            Element_SequenceType.Write(sDef);
            Element_NumberOfSubunits.Write(sDef);
            Element_AreaOfHybridisation.Write(sDef);
            Element_OligoNucleotideType.Write(sDef);
            Element_Subunit.Write(sDef);
        }
        
        public Resource_SubstanceNucleicAcid()
        {
            {
                // 1. SubstanceNucleicAcid.sequenceType
                this.Element_SequenceType = new ElementDefinitionInfo
                {
                    Name = "Element_SequenceType",
                    Path= "SubstanceNucleicAcid.sequenceType",
                    Id = "SubstanceNucleicAcid.sequenceType",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 2. SubstanceNucleicAcid.numberOfSubunits
                this.Element_NumberOfSubunits = new ElementDefinitionInfo
                {
                    Name = "Element_NumberOfSubunits",
                    Path= "SubstanceNucleicAcid.numberOfSubunits",
                    Id = "SubstanceNucleicAcid.numberOfSubunits",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        }
                    }
                };
            }
            {
                // 3. SubstanceNucleicAcid.areaOfHybridisation
                this.Element_AreaOfHybridisation = new ElementDefinitionInfo
                {
                    Name = "Element_AreaOfHybridisation",
                    Path= "SubstanceNucleicAcid.areaOfHybridisation",
                    Id = "SubstanceNucleicAcid.areaOfHybridisation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 4. SubstanceNucleicAcid.oligoNucleotideType
                this.Element_OligoNucleotideType = new ElementDefinitionInfo
                {
                    Name = "Element_OligoNucleotideType",
                    Path= "SubstanceNucleicAcid.oligoNucleotideType",
                    Id = "SubstanceNucleicAcid.oligoNucleotideType",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 5. SubstanceNucleicAcid.subunit
                this.Element_Subunit = new ElementDefinitionInfo
                {
                    Name = "Element_Subunit",
                    Path= "SubstanceNucleicAcid.subunit",
                    Id = "SubstanceNucleicAcid.subunit",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Subunit
                        {
                        }
                    }
                };
            }
            this.Name = "SubstanceNucleicAcid";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid";
        }
    }
}
