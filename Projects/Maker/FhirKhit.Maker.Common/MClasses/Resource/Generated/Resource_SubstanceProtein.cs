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
    #endregion
    /// <summary>
    /// Fhir resource 'SubstanceProtein'
    /// </summary>
    // 0. SubstanceProtein
    public partial class Resource_SubstanceProtein : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 4. SubstanceProtein.subunit
        public partial class Type_Subunit : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 5. SubstanceProtein.subunit.subunit
            public ElementDefinitionInfo Element_Subunit;
            // 6. SubstanceProtein.subunit.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 7. SubstanceProtein.subunit.length
            public ElementDefinitionInfo Element_Length;
            // 8. SubstanceProtein.subunit.sequenceAttachment
            public ElementDefinitionInfo Element_SequenceAttachment;
            // 9. SubstanceProtein.subunit.nTerminalModificationId
            public ElementDefinitionInfo Element_NTerminalModificationId;
            // 10. SubstanceProtein.subunit.nTerminalModification
            public ElementDefinitionInfo Element_NTerminalModification;
            // 11. SubstanceProtein.subunit.cTerminalModificationId
            public ElementDefinitionInfo Element_CTerminalModificationId;
            // 12. SubstanceProtein.subunit.cTerminalModification
            public ElementDefinitionInfo Element_CTerminalModification;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceProtein.subunit",
                    ElementId = "SubstanceProtein.subunit"
                });
                Element_Subunit.Write(sDef);
                Element_Sequence.Write(sDef);
                Element_Length.Write(sDef);
                Element_SequenceAttachment.Write(sDef);
                Element_NTerminalModificationId.Write(sDef);
                Element_NTerminalModification.Write(sDef);
                Element_CTerminalModificationId.Write(sDef);
                Element_CTerminalModification.Write(sDef);
            }
            
            public Type_Subunit()
            {
                {
                    // 5. SubstanceProtein.subunit.subunit
                    this.Element_Subunit = new ElementDefinitionInfo
                    {
                        Name = "Element_Subunit",
                        Path= "SubstanceProtein.subunit.subunit",
                        Id = "SubstanceProtein.subunit.subunit",
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
                    // 6. SubstanceProtein.subunit.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "SubstanceProtein.subunit.sequence",
                        Id = "SubstanceProtein.subunit.sequence",
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
                    // 7. SubstanceProtein.subunit.length
                    this.Element_Length = new ElementDefinitionInfo
                    {
                        Name = "Element_Length",
                        Path= "SubstanceProtein.subunit.length",
                        Id = "SubstanceProtein.subunit.length",
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
                    // 8. SubstanceProtein.subunit.sequenceAttachment
                    this.Element_SequenceAttachment = new ElementDefinitionInfo
                    {
                        Name = "Element_SequenceAttachment",
                        Path= "SubstanceProtein.subunit.sequenceAttachment",
                        Id = "SubstanceProtein.subunit.sequenceAttachment",
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
                    // 9. SubstanceProtein.subunit.nTerminalModificationId
                    this.Element_NTerminalModificationId = new ElementDefinitionInfo
                    {
                        Name = "Element_NTerminalModificationId",
                        Path= "SubstanceProtein.subunit.nTerminalModificationId",
                        Id = "SubstanceProtein.subunit.nTerminalModificationId",
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
                    // 10. SubstanceProtein.subunit.nTerminalModification
                    this.Element_NTerminalModification = new ElementDefinitionInfo
                    {
                        Name = "Element_NTerminalModification",
                        Path= "SubstanceProtein.subunit.nTerminalModification",
                        Id = "SubstanceProtein.subunit.nTerminalModification",
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
                    // 11. SubstanceProtein.subunit.cTerminalModificationId
                    this.Element_CTerminalModificationId = new ElementDefinitionInfo
                    {
                        Name = "Element_CTerminalModificationId",
                        Path= "SubstanceProtein.subunit.cTerminalModificationId",
                        Id = "SubstanceProtein.subunit.cTerminalModificationId",
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
                    // 12. SubstanceProtein.subunit.cTerminalModification
                    this.Element_CTerminalModification = new ElementDefinitionInfo
                    {
                        Name = "Element_CTerminalModification",
                        Path= "SubstanceProtein.subunit.cTerminalModification",
                        Id = "SubstanceProtein.subunit.cTerminalModification",
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
        // 1. SubstanceProtein.sequenceType
        public ElementDefinitionInfo Element_SequenceType;
        // 2. SubstanceProtein.numberOfSubunits
        public ElementDefinitionInfo Element_NumberOfSubunits;
        // 3. SubstanceProtein.disulfideLinkage
        public ElementDefinitionInfo Element_DisulfideLinkage;
        // 4. SubstanceProtein.subunit
        public ElementDefinitionInfo Element_Subunit;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceProtein",
                ElementId = "SubstanceProtein"
            });
            Element_SequenceType.Write(sDef);
            Element_NumberOfSubunits.Write(sDef);
            Element_DisulfideLinkage.Write(sDef);
            Element_Subunit.Write(sDef);
        }
        
        public Resource_SubstanceProtein()
        {
            {
                // 1. SubstanceProtein.sequenceType
                this.Element_SequenceType = new ElementDefinitionInfo
                {
                    Name = "Element_SequenceType",
                    Path= "SubstanceProtein.sequenceType",
                    Id = "SubstanceProtein.sequenceType",
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
                // 2. SubstanceProtein.numberOfSubunits
                this.Element_NumberOfSubunits = new ElementDefinitionInfo
                {
                    Name = "Element_NumberOfSubunits",
                    Path= "SubstanceProtein.numberOfSubunits",
                    Id = "SubstanceProtein.numberOfSubunits",
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
                // 3. SubstanceProtein.disulfideLinkage
                this.Element_DisulfideLinkage = new ElementDefinitionInfo
                {
                    Name = "Element_DisulfideLinkage",
                    Path= "SubstanceProtein.disulfideLinkage",
                    Id = "SubstanceProtein.disulfideLinkage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 4. SubstanceProtein.subunit
                this.Element_Subunit = new ElementDefinitionInfo
                {
                    Name = "Element_Subunit",
                    Path= "SubstanceProtein.subunit",
                    Id = "SubstanceProtein.subunit",
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
            this.Name = "SubstanceProtein";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceProtein";
        }
    }
}
