using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "MolecularSequence",
      "url": "http://hl7.org/fhir/StructureDefinition/MolecularSequence",
      "version": "4.0.0",
      "name": "MolecularSequence",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Genomics)",
      "description": "Raw data describing a biological sequence.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MolecularSequence",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MolecularSequence",
            "path": "MolecularSequence",
            "short": "Information about a biological sequence",
            "definition": "Raw data describing a biological sequence.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MolecularSequence.identifier",
            "path": "MolecularSequence.identifier",
            "short": "Unique ID for this particular sequence. This is a FHIR-defined id",
            "definition": "A unique identifier for this particular sequence instance. This is a FHIR-defined id.",
            "requirements": "Allows sequences to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.type",
            "path": "MolecularSequence.type",
            "short": "aa | dna | rna",
            "definition": "Amino Acid Sequence/ DNA Sequence / RNA Sequence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "sequenceType"
                }
              ],
              "strength": "required",
              "description": "Type if a sequence -- DNA, RNA, or amino acid sequence.",
              "valueSet": "http://hl7.org/fhir/ValueSet/sequence-type|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.coordinateSystem",
            "path": "MolecularSequence.coordinateSystem",
            "short": "Base number of coordinate system (0 for 0-based numbering or coordinates, inclusive start, exclusive end, 1 for 1-based numbering, inclusive start, inclusive end)",
            "definition": "Whether the sequence is numbered starting at 0 (0-based numbering or coordinates, inclusive start, exclusive end) or starting at 1 (1-based numbering, inclusive start and inclusive end).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.patient",
            "path": "MolecularSequence.patient",
            "short": "Who and/or what this is about",
            "definition": "The patient whose sequencing results are described by this resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.specimen",
            "path": "MolecularSequence.specimen",
            "short": "Specimen used for sequencing",
            "definition": "Specimen used for sequencing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.device",
            "path": "MolecularSequence.device",
            "short": "The method for sequencing",
            "definition": "The method for sequencing, for example, chip information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.performer",
            "path": "MolecularSequence.performer",
            "short": "Who should be responsible for test result",
            "definition": "The organization or lab that should be responsible for this result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quantity",
            "path": "MolecularSequence.quantity",
            "short": "The number of copies of the sequence of interest.  (RNASeq)",
            "definition": "The number of copies of the sequence of interest. (RNASeq).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.referenceSeq",
            "path": "MolecularSequence.referenceSeq",
            "short": "A sequence used as reference",
            "definition": "A sequence that is used as a reference to describe variants that are present in a sequence analyzed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.referenceSeq.chromosome",
            "path": "MolecularSequence.referenceSeq.chromosome",
            "short": "Chromosome containing genetic finding",
            "definition": "Structural unit composed of a nucleic acid molecule which controls its own replication through the interaction of specific proteins at one or more origins of replication ([SO:0000340](http://www.sequenceontology.org/browser/current_svn/term/SO:0000340)).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "chromosome-human"
                }
              ],
              "strength": "example",
              "description": "Chromosome number for human.",
              "valueSet": "http://hl7.org/fhir/ValueSet/chromosome-human"
            }
          },
          {
            "id": "MolecularSequence.referenceSeq.genomeBuild",
            "path": "MolecularSequence.referenceSeq.genomeBuild",
            "short": "The Genome Build used for reference, following GRCh build versions e.g. 'GRCh 37'",
            "definition": "The Genome Build used for reference, following GRCh build versions e.g. 'GRCh 37'.  Version number must be included if a versioned release of a primary build was used.",
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
            "id": "MolecularSequence.referenceSeq.orientation",
            "path": "MolecularSequence.referenceSeq.orientation",
            "short": "sense | antisense",
            "definition": "A relative reference to a DNA strand based on gene orientation. The strand that contains the open reading frame of the gene is the \"sense\" strand, and the opposite complementary strand is the \"antisense\" strand.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "orientationType"
                }
              ],
              "strength": "required",
              "description": "Type for orientation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/orientation-type|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.referenceSeq.referenceSeqId",
            "path": "MolecularSequence.referenceSeq.referenceSeqId",
            "short": "Reference identifier",
            "definition": "Reference identifier of reference sequence submitted to NCBI. It must match the type in the MolecularSequence.type field. For example, the prefix, “NG_” identifies reference sequence for genes, “NM_” for messenger RNA transcripts, and “NP_” for amino acid sequences.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "sequenceReference"
                }
              ],
              "strength": "example",
              "description": "Reference identifier.",
              "valueSet": "http://hl7.org/fhir/ValueSet/sequence-referenceSeq"
            }
          },
          {
            "id": "MolecularSequence.referenceSeq.referenceSeqPointer",
            "path": "MolecularSequence.referenceSeq.referenceSeqPointer",
            "short": "A pointer to another MolecularSequence entity as reference sequence",
            "definition": "A pointer to another MolecularSequence entity as reference sequence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.referenceSeq.referenceSeqString",
            "path": "MolecularSequence.referenceSeq.referenceSeqString",
            "short": "A string to represent reference sequence",
            "definition": "A string like \"ACGT\".",
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
            "id": "MolecularSequence.referenceSeq.strand",
            "path": "MolecularSequence.referenceSeq.strand",
            "short": "watson | crick",
            "definition": "An absolute reference to a strand. The Watson strand is the strand whose 5'-end is on the short arm of the chromosome, and the Crick strand as the one whose 5'-end is on the long arm.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "strandType"
                }
              ],
              "strength": "required",
              "description": "Type for strand.",
              "valueSet": "http://hl7.org/fhir/ValueSet/strand-type|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.referenceSeq.windowStart",
            "path": "MolecularSequence.referenceSeq.windowStart",
            "short": "Start position of the window on the  reference sequence",
            "definition": "Start position of the window on the reference sequence. If the coordinate system is either 0-based or 1-based, then start position is inclusive.",
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
            "id": "MolecularSequence.referenceSeq.windowEnd",
            "path": "MolecularSequence.referenceSeq.windowEnd",
            "short": "End position of the window on the reference sequence",
            "definition": "End position of the window on the reference sequence. If the coordinate system is 0-based then end is exclusive and does not include the last position. If the coordinate system is 1-base, then end is inclusive and includes the last position.",
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
            "id": "MolecularSequence.variant",
            "path": "MolecularSequence.variant",
            "short": "Variant in sequence",
            "definition": "The definition of variant here originates from Sequence ontology ([variant_of](http://www.sequenceontology.org/browser/current_svn/term/variant_of)). This element can represent amino acid or nucleic sequence change(including insertion,deletion,SNP,etc.)  It can represent some complex mutation or segment variation with the assist of CIGAR string.",
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
            "id": "MolecularSequence.variant.start",
            "path": "MolecularSequence.variant.start",
            "short": "Start position of the variant on the  reference sequence",
            "definition": "Start position of the variant on the  reference sequence. If the coordinate system is either 0-based or 1-based, then start position is inclusive.",
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
            "id": "MolecularSequence.variant.end",
            "path": "MolecularSequence.variant.end",
            "short": "End position of the variant on the reference sequence",
            "definition": "End position of the variant on the reference sequence. If the coordinate system is 0-based then end is exclusive and does not include the last position. If the coordinate system is 1-base, then end is inclusive and includes the last position.",
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
            "id": "MolecularSequence.variant.observedAllele",
            "path": "MolecularSequence.variant.observedAllele",
            "short": "Allele that was observed",
            "definition": "An allele is one of a set of coexisting sequence variants of a gene ([SO:0001023](http://www.sequenceontology.org/browser/current_svn/term/SO:0001023)).  Nucleotide(s)/amino acids from start position of sequence to stop position of sequence on the positive (+) strand of the observed  sequence. When the sequence  type is DNA, it should be the sequence on the positive (+) strand. This will lay in the range between variant.start and variant.end.",
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
            "id": "MolecularSequence.variant.referenceAllele",
            "path": "MolecularSequence.variant.referenceAllele",
            "short": "Allele in the reference sequence",
            "definition": "An allele is one of a set of coexisting sequence variants of a gene ([SO:0001023](http://www.sequenceontology.org/browser/current_svn/term/SO:0001023)). Nucleotide(s)/amino acids from start position of sequence to stop position of sequence on the positive (+) strand of the reference sequence. When the sequence  type is DNA, it should be the sequence on the positive (+) strand. This will lay in the range between variant.start and variant.end.",
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
            "id": "MolecularSequence.variant.cigar",
            "path": "MolecularSequence.variant.cigar",
            "short": "Extended CIGAR string for aligning the sequence with reference bases",
            "definition": "Extended CIGAR string for aligning the sequence with reference bases. See detailed documentation [here](http://support.illumina.com/help/SequencingAnalysisWorkflow/Content/Vault/Informatics/Sequencing_Analysis/CASAVA/swSEQ_mCA_ExtendedCIGARFormat.htm).",
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
            "id": "MolecularSequence.variant.variantPointer",
            "path": "MolecularSequence.variant.variantPointer",
            "short": "Pointer to observed variant information",
            "definition": "A pointer to an Observation containing variant information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.observedSeq",
            "path": "MolecularSequence.observedSeq",
            "short": "Sequence that was observed",
            "definition": "Sequence that was observed. It is the result marked by referenceSeq along with variant records on referenceSeq. This shall start from referenceSeq.windowStart and end by referenceSeq.windowEnd.",
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
            "id": "MolecularSequence.quality",
            "path": "MolecularSequence.quality",
            "short": "An set of value as quality of sequence",
            "definition": "An experimental feature attribute that defines the quality of the feature in a quantitative way, such as a phred quality score ([SO:0001686](http://www.sequenceontology.org/browser/current_svn/term/SO:0001686)).",
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
            "id": "MolecularSequence.quality.type",
            "path": "MolecularSequence.quality.type",
            "short": "indel | snp | unknown",
            "definition": "INDEL / SNP / Undefined variant.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "qualityType"
                }
              ],
              "strength": "required",
              "description": "Type for quality report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/quality-type|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.quality.standardSequence",
            "path": "MolecularSequence.quality.standardSequence",
            "short": "Standard sequence for comparison",
            "definition": "Gold standard sequence used for comparing against.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "qualityStandardSequence"
                }
              ],
              "strength": "example",
              "description": "Reference identifier of the sequence that used to mark the quality of tested samples.",
              "valueSet": "http://hl7.org/fhir/ValueSet/sequence-quality-standardSequence"
            }
          },
          {
            "id": "MolecularSequence.quality.start",
            "path": "MolecularSequence.quality.start",
            "short": "Start position of the sequence",
            "definition": "Start position of the sequence. If the coordinate system is either 0-based or 1-based, then start position is inclusive.",
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
            "id": "MolecularSequence.quality.end",
            "path": "MolecularSequence.quality.end",
            "short": "End position of the sequence",
            "definition": "End position of the sequence. If the coordinate system is 0-based then end is exclusive and does not include the last position. If the coordinate system is 1-base, then end is inclusive and includes the last position.",
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
            "id": "MolecularSequence.quality.score",
            "path": "MolecularSequence.quality.score",
            "short": "Quality score for the comparison",
            "definition": "The score of an experimentally derived feature such as a p-value ([SO:0001685](http://www.sequenceontology.org/browser/current_svn/term/SO:0001685)).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.method",
            "path": "MolecularSequence.quality.method",
            "short": "Method to get quality",
            "definition": "Which method is used to get sequence quality.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "qualityMethod"
                }
              ],
              "strength": "example",
              "description": "The method used to evaluate the numerical quality of the observed sequence.",
              "valueSet": "http://hl7.org/fhir/ValueSet/sequence-quality-method"
            }
          },
          {
            "id": "MolecularSequence.quality.truthTP",
            "path": "MolecularSequence.quality.truthTP",
            "short": "True positives from the perspective of the truth data",
            "definition": "True positives, from the perspective of the truth data, i.e. the number of sites in the Truth Call Set for which there are paths through the Query Call Set that are consistent with all of the alleles at this site, and for which there is an accurate genotype call for the event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.queryTP",
            "path": "MolecularSequence.quality.queryTP",
            "short": "True positives from the perspective of the query data",
            "definition": "True positives, from the perspective of the query data, i.e. the number of sites in the Query Call Set for which there are paths through the Truth Call Set that are consistent with all of the alleles at this site, and for which there is an accurate genotype call for the event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.truthFN",
            "path": "MolecularSequence.quality.truthFN",
            "short": "False negatives",
            "definition": "False negatives, i.e. the number of sites in the Truth Call Set for which there is no path through the Query Call Set that is consistent with all of the alleles at this site, or sites for which there is an inaccurate genotype call for the event. Sites with correct variant but incorrect genotype are counted here.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.queryFP",
            "path": "MolecularSequence.quality.queryFP",
            "short": "False positives",
            "definition": "False positives, i.e. the number of sites in the Query Call Set for which there is no path through the Truth Call Set that is consistent with this site. Sites with correct variant but incorrect genotype are counted here.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.gtFP",
            "path": "MolecularSequence.quality.gtFP",
            "short": "False positives where the non-REF alleles in the Truth and Query Call Sets match",
            "definition": "The number of false positives where the non-REF alleles in the Truth and Query Call Sets match (i.e. cases where the truth is 1/1 and the query is 0/1 or similar).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.precision",
            "path": "MolecularSequence.quality.precision",
            "short": "Precision of comparison",
            "definition": "QUERY.TP / (QUERY.TP + QUERY.FP).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.recall",
            "path": "MolecularSequence.quality.recall",
            "short": "Recall of comparison",
            "definition": "TRUTH.TP / (TRUTH.TP + TRUTH.FN).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.fScore",
            "path": "MolecularSequence.quality.fScore",
            "short": "F-score",
            "definition": "Harmonic mean of Recall and Precision, computed as: 2 * precision * recall / (precision + recall).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc",
            "path": "MolecularSequence.quality.roc",
            "short": "Receiver Operator Characteristic (ROC) Curve",
            "definition": "Receiver Operator Characteristic (ROC) Curve  to give sensitivity/specificity tradeoff.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.score",
            "path": "MolecularSequence.quality.roc.score",
            "short": "Genotype quality score",
            "definition": "Invidual data point representing the GQ (genotype quality) score threshold.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.numTP",
            "path": "MolecularSequence.quality.roc.numTP",
            "short": "Roc score true positive numbers",
            "definition": "The number of true positives if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.numFP",
            "path": "MolecularSequence.quality.roc.numFP",
            "short": "Roc score false positive numbers",
            "definition": "The number of false positives if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.numFN",
            "path": "MolecularSequence.quality.roc.numFN",
            "short": "Roc score false negative numbers",
            "definition": "The number of false negatives if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.precision",
            "path": "MolecularSequence.quality.roc.precision",
            "short": "Precision of the GQ score",
            "definition": "Calculated precision if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.sensitivity",
            "path": "MolecularSequence.quality.roc.sensitivity",
            "short": "Sensitivity of the GQ score",
            "definition": "Calculated sensitivity if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.quality.roc.fMeasure",
            "path": "MolecularSequence.quality.roc.fMeasure",
            "short": "FScore of the GQ score",
            "definition": "Calculated fScore if the GQ score threshold was set to \"score\" field value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.readCoverage",
            "path": "MolecularSequence.readCoverage",
            "short": "Average number of reads representing a given nucleotide in the reconstructed sequence",
            "definition": "Coverage (read depth or depth) is the average number of reads representing a given nucleotide in the reconstructed sequence.",
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
            "id": "MolecularSequence.repository",
            "path": "MolecularSequence.repository",
            "short": "External repository which contains detailed report related with observedSeq in this resource",
            "definition": "Configurations of the external repository. The repository shall store target's observedSeq or records related with target's observedSeq.",
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
            "id": "MolecularSequence.repository.type",
            "path": "MolecularSequence.repository.type",
            "short": "directlink | openapi | login | oauth | other",
            "definition": "Click and see / RESTful API / Need login to see / RESTful API with authentication / Other ways to see resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "repositoryType"
                }
              ],
              "strength": "required",
              "description": "Type for access of external URI.",
              "valueSet": "http://hl7.org/fhir/ValueSet/repository-type|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.repository.url",
            "path": "MolecularSequence.repository.url",
            "short": "URI of the repository",
            "definition": "URI of an external repository which contains further details about the genetics data.",
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
            "id": "MolecularSequence.repository.name",
            "path": "MolecularSequence.repository.name",
            "short": "Repository's name",
            "definition": "URI of an external repository which contains further details about the genetics data.",
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
            "id": "MolecularSequence.repository.datasetId",
            "path": "MolecularSequence.repository.datasetId",
            "short": "Id of the dataset that used to call for dataset in repository",
            "definition": "Id of the variant in this external repository. The server will understand how to use this id to call for more info about datasets in external repository.",
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
            "id": "MolecularSequence.repository.variantsetId",
            "path": "MolecularSequence.repository.variantsetId",
            "short": "Id of the variantset that used to call for variantset in repository",
            "definition": "Id of the variantset in this external repository. The server will understand how to use this id to call for more info about variantsets in external repository.",
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
            "id": "MolecularSequence.repository.readsetId",
            "path": "MolecularSequence.repository.readsetId",
            "short": "Id of the read",
            "definition": "Id of the read in this external repository.",
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
            "id": "MolecularSequence.pointer",
            "path": "MolecularSequence.pointer",
            "short": "Pointer to next atomic sequence",
            "definition": "Pointer to next atomic sequence which at most contains one variant.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.structureVariant",
            "path": "MolecularSequence.structureVariant",
            "short": "Structural variant",
            "definition": "Information about chromosome structure variation.",
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
            "id": "MolecularSequence.structureVariant.variantType",
            "path": "MolecularSequence.structureVariant.variantType",
            "short": "Structural variant change type",
            "definition": "Information about chromosome structure variation DNA change type.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "LOINC LL379-9 answerlist"
                }
              ],
              "strength": "required",
              "description": "DNA change type.",
              "valueSet": "http://loinc.org/vs/LL379-9|4.0.0"
            }
          },
          {
            "id": "MolecularSequence.structureVariant.exact",
            "path": "MolecularSequence.structureVariant.exact",
            "short": "Does the structural variant have base pair resolution breakpoints?",
            "definition": "Used to indicate if the outer and inner start-end values have the same meaning.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.structureVariant.length",
            "path": "MolecularSequence.structureVariant.length",
            "short": "Structural variant length",
            "definition": "Length of the variant chromosome.",
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
            "id": "MolecularSequence.structureVariant.outer",
            "path": "MolecularSequence.structureVariant.outer",
            "short": "Structural variant outer",
            "definition": "Structural variant outer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.structureVariant.outer.start",
            "path": "MolecularSequence.structureVariant.outer.start",
            "short": "Structural variant outer start",
            "definition": "Structural variant outer start. If the coordinate system is either 0-based or 1-based, then start position is inclusive.",
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
            "id": "MolecularSequence.structureVariant.outer.end",
            "path": "MolecularSequence.structureVariant.outer.end",
            "short": "Structural variant outer end",
            "definition": "Structural variant outer end. If the coordinate system is 0-based then end is exclusive and does not include the last position. If the coordinate system is 1-base, then end is inclusive and includes the last position.",
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
            "id": "MolecularSequence.structureVariant.inner",
            "path": "MolecularSequence.structureVariant.inner",
            "short": "Structural variant inner",
            "definition": "Structural variant inner.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MolecularSequence.structureVariant.inner.start",
            "path": "MolecularSequence.structureVariant.inner.start",
            "short": "Structural variant inner start",
            "definition": "Structural variant inner start. If the coordinate system is either 0-based or 1-based, then start position is inclusive.",
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
            "id": "MolecularSequence.structureVariant.inner.end",
            "path": "MolecularSequence.structureVariant.inner.end",
            "short": "Structural variant inner end",
            "definition": "Structural variant inner end. If the coordinate system is 0-based then end is exclusive and does not include the last position. If the coordinate system is 1-base, then end is inclusive and includes the last position.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'MolecularSequence'
    /// </summary>
    // 0. MolecularSequence
    public class MolecularSequence : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MolecularSequence_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 9. MolecularSequence.referenceSeq
            public class Type_ReferenceSeq : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_ReferenceSeq_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 10. MolecularSequence.referenceSeq.chromosome
                    public ElementDefinitionInfo Chromosome;                                                                                // MakerGen.cs:216
                    // 11. MolecularSequence.referenceSeq.genomeBuild
                    public ElementDefinitionInfo GenomeBuild;                                                                               // MakerGen.cs:216
                    // 12. MolecularSequence.referenceSeq.orientation
                    public ElementDefinitionInfo Orientation;                                                                               // MakerGen.cs:216
                    // 13. MolecularSequence.referenceSeq.referenceSeqId
                    public ElementDefinitionInfo ReferenceSeqId;                                                                            // MakerGen.cs:216
                    // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                    public ElementDefinitionInfo ReferenceSeqPointer;                                                                       // MakerGen.cs:216
                    // 15. MolecularSequence.referenceSeq.referenceSeqString
                    public ElementDefinitionInfo ReferenceSeqString;                                                                        // MakerGen.cs:216
                    // 16. MolecularSequence.referenceSeq.strand
                    public ElementDefinitionInfo Strand;                                                                                    // MakerGen.cs:216
                    // 17. MolecularSequence.referenceSeq.windowStart
                    public ElementDefinitionInfo WindowStart;                                                                               // MakerGen.cs:216
                    // 18. MolecularSequence.referenceSeq.windowEnd
                    public ElementDefinitionInfo WindowEnd;                                                                                 // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_ReferenceSeq_Elements()                                                                                     // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. MolecularSequence.referenceSeq.chromosome
                            this.Chromosome = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Chromosome",                                                                                        // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.chromosome",                                                          // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.chromosome",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. MolecularSequence.referenceSeq.genomeBuild
                            this.GenomeBuild = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "GenomeBuild",                                                                                       // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.genomeBuild",                                                         // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.genomeBuild",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. MolecularSequence.referenceSeq.orientation
                            this.Orientation = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Orientation",                                                                                       // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.orientation",                                                         // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.orientation",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. MolecularSequence.referenceSeq.referenceSeqId
                            this.ReferenceSeqId = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ReferenceSeqId",                                                                                    // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.referenceSeqId",                                                      // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.referenceSeqId",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                            this.ReferenceSeqPointer = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ReferenceSeqPointer",                                                                               // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.referenceSeqPointer",                                                 // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.referenceSeqPointer",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                     // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. MolecularSequence.referenceSeq.referenceSeqString
                            this.ReferenceSeqString = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ReferenceSeqString",                                                                                // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.referenceSeqString",                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.referenceSeqString",                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. MolecularSequence.referenceSeq.strand
                            this.Strand = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Strand",                                                                                            // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.strand",                                                              // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.strand",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. MolecularSequence.referenceSeq.windowStart
                            this.WindowStart = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "WindowStart",                                                                                       // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.windowStart",                                                         // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.windowStart",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. MolecularSequence.referenceSeq.windowEnd
                            this.WindowEnd = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "WindowEnd",                                                                                         // MakerGen.cs:235
                                Path= "MolecularSequence.referenceSeq.windowEnd",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.referenceSeq.windowEnd",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Chromosome.Write(sDef);                                                                                             // MakerGen.cs:220
                        GenomeBuild.Write(sDef);                                                                                            // MakerGen.cs:220
                        Orientation.Write(sDef);                                                                                            // MakerGen.cs:220
                        ReferenceSeqId.Write(sDef);                                                                                         // MakerGen.cs:220
                        ReferenceSeqPointer.Write(sDef);                                                                                    // MakerGen.cs:220
                        ReferenceSeqString.Write(sDef);                                                                                     // MakerGen.cs:220
                        Strand.Write(sDef);                                                                                                 // MakerGen.cs:220
                        WindowStart.Write(sDef);                                                                                            // MakerGen.cs:220
                        WindowEnd.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_ReferenceSeq_Elements Elements                                                                                  // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_ReferenceSeq_Elements();                                                               // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_ReferenceSeq_Elements elements;                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_ReferenceSeq()                                                                                                  // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MolecularSequence.referenceSeq",                                                                            // MakerGen.cs:428
                        ElementId = "MolecularSequence.referenceSeq"                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 19. MolecularSequence.variant
            public class Type_Variant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Variant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 20. MolecularSequence.variant.start
                    public ElementDefinitionInfo Start;                                                                                     // MakerGen.cs:216
                    // 21. MolecularSequence.variant.end
                    public ElementDefinitionInfo End;                                                                                       // MakerGen.cs:216
                    // 22. MolecularSequence.variant.observedAllele
                    public ElementDefinitionInfo ObservedAllele;                                                                            // MakerGen.cs:216
                    // 23. MolecularSequence.variant.referenceAllele
                    public ElementDefinitionInfo ReferenceAllele;                                                                           // MakerGen.cs:216
                    // 24. MolecularSequence.variant.cigar
                    public ElementDefinitionInfo Cigar;                                                                                     // MakerGen.cs:216
                    // 25. MolecularSequence.variant.variantPointer
                    public ElementDefinitionInfo VariantPointer;                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Variant_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. MolecularSequence.variant.start
                            this.Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Start",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.variant.start",                                                                    // MakerGen.cs:236
                                Id = "MolecularSequence.variant.start",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. MolecularSequence.variant.end
                            this.End = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "End",                                                                                               // MakerGen.cs:235
                                Path= "MolecularSequence.variant.end",                                                                      // MakerGen.cs:236
                                Id = "MolecularSequence.variant.end",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. MolecularSequence.variant.observedAllele
                            this.ObservedAllele = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ObservedAllele",                                                                                    // MakerGen.cs:235
                                Path= "MolecularSequence.variant.observedAllele",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.variant.observedAllele",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. MolecularSequence.variant.referenceAllele
                            this.ReferenceAllele = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ReferenceAllele",                                                                                   // MakerGen.cs:235
                                Path= "MolecularSequence.variant.referenceAllele",                                                          // MakerGen.cs:236
                                Id = "MolecularSequence.variant.referenceAllele",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. MolecularSequence.variant.cigar
                            this.Cigar = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Cigar",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.variant.cigar",                                                                    // MakerGen.cs:236
                                Id = "MolecularSequence.variant.cigar",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. MolecularSequence.variant.variantPointer
                            this.VariantPointer = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "VariantPointer",                                                                                    // MakerGen.cs:235
                                Path= "MolecularSequence.variant.variantPointer",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.variant.variantPointer",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Observation"                                           // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Start.Write(sDef);                                                                                                  // MakerGen.cs:220
                        End.Write(sDef);                                                                                                    // MakerGen.cs:220
                        ObservedAllele.Write(sDef);                                                                                         // MakerGen.cs:220
                        ReferenceAllele.Write(sDef);                                                                                        // MakerGen.cs:220
                        Cigar.Write(sDef);                                                                                                  // MakerGen.cs:220
                        VariantPointer.Write(sDef);                                                                                         // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Variant_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Variant_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Variant_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Variant()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MolecularSequence.variant",                                                                                 // MakerGen.cs:428
                        ElementId = "MolecularSequence.variant"                                                                             // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 27. MolecularSequence.quality
            public class Type_Quality : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Quality_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 42. MolecularSequence.quality.roc
                    public class Type_Roc : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Roc_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 43. MolecularSequence.quality.roc.score
                            public ElementDefinitionInfo Score;                                                                             // MakerGen.cs:216
                            // 44. MolecularSequence.quality.roc.numTP
                            public ElementDefinitionInfo NumTP;                                                                             // MakerGen.cs:216
                            // 45. MolecularSequence.quality.roc.numFP
                            public ElementDefinitionInfo NumFP;                                                                             // MakerGen.cs:216
                            // 46. MolecularSequence.quality.roc.numFN
                            public ElementDefinitionInfo NumFN;                                                                             // MakerGen.cs:216
                            // 47. MolecularSequence.quality.roc.precision
                            public ElementDefinitionInfo Precision;                                                                         // MakerGen.cs:216
                            // 48. MolecularSequence.quality.roc.sensitivity
                            public ElementDefinitionInfo Sensitivity;                                                                       // MakerGen.cs:216
                            // 49. MolecularSequence.quality.roc.fMeasure
                            public ElementDefinitionInfo FMeasure;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Roc_Elements()                                                                                      // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 43. MolecularSequence.quality.roc.score
                                    this.Score = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Score",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.score",                                                        // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.score",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 44. MolecularSequence.quality.roc.numTP
                                    this.NumTP = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "NumTP",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.numTP",                                                        // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.numTP",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 45. MolecularSequence.quality.roc.numFP
                                    this.NumFP = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "NumFP",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.numFP",                                                        // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.numFP",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 46. MolecularSequence.quality.roc.numFN
                                    this.NumFN = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "NumFN",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.numFN",                                                        // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.numFN",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 47. MolecularSequence.quality.roc.precision
                                    this.Precision = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Precision",                                                                                 // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.precision",                                                    // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.precision",                                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 48. MolecularSequence.quality.roc.sensitivity
                                    this.Sensitivity = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Sensitivity",                                                                               // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.sensitivity",                                                  // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.sensitivity",                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 49. MolecularSequence.quality.roc.fMeasure
                                    this.FMeasure = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "FMeasure",                                                                                  // MakerGen.cs:235
                                        Path= "MolecularSequence.quality.roc.fMeasure",                                                     // MakerGen.cs:236
                                        Id = "MolecularSequence.quality.roc.fMeasure",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Score.Write(sDef);                                                                                          // MakerGen.cs:220
                                NumTP.Write(sDef);                                                                                          // MakerGen.cs:220
                                NumFP.Write(sDef);                                                                                          // MakerGen.cs:220
                                NumFN.Write(sDef);                                                                                          // MakerGen.cs:220
                                Precision.Write(sDef);                                                                                      // MakerGen.cs:220
                                Sensitivity.Write(sDef);                                                                                    // MakerGen.cs:220
                                FMeasure.Write(sDef);                                                                                       // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Roc_Elements Elements                                                                                   // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Roc_Elements();                                                                // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Roc_Elements elements;                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Roc()                                                                                                   // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "MolecularSequence.quality.roc",                                                                     // MakerGen.cs:428
                                ElementId = "MolecularSequence.quality.roc"                                                                 // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 28. MolecularSequence.quality.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 29. MolecularSequence.quality.standardSequence
                    public ElementDefinitionInfo StandardSequence;                                                                          // MakerGen.cs:216
                    // 30. MolecularSequence.quality.start
                    public ElementDefinitionInfo Start;                                                                                     // MakerGen.cs:216
                    // 31. MolecularSequence.quality.end
                    public ElementDefinitionInfo End;                                                                                       // MakerGen.cs:216
                    // 32. MolecularSequence.quality.score
                    public ElementDefinitionInfo Score;                                                                                     // MakerGen.cs:216
                    // 33. MolecularSequence.quality.method
                    public ElementDefinitionInfo Method;                                                                                    // MakerGen.cs:216
                    // 34. MolecularSequence.quality.truthTP
                    public ElementDefinitionInfo TruthTP;                                                                                   // MakerGen.cs:216
                    // 35. MolecularSequence.quality.queryTP
                    public ElementDefinitionInfo QueryTP;                                                                                   // MakerGen.cs:216
                    // 36. MolecularSequence.quality.truthFN
                    public ElementDefinitionInfo TruthFN;                                                                                   // MakerGen.cs:216
                    // 37. MolecularSequence.quality.queryFP
                    public ElementDefinitionInfo QueryFP;                                                                                   // MakerGen.cs:216
                    // 38. MolecularSequence.quality.gtFP
                    public ElementDefinitionInfo GtFP;                                                                                      // MakerGen.cs:216
                    // 39. MolecularSequence.quality.precision
                    public ElementDefinitionInfo Precision;                                                                                 // MakerGen.cs:216
                    // 40. MolecularSequence.quality.recall
                    public ElementDefinitionInfo Recall;                                                                                    // MakerGen.cs:216
                    // 41. MolecularSequence.quality.fScore
                    public ElementDefinitionInfo FScore;                                                                                    // MakerGen.cs:216
                    // 42. MolecularSequence.quality.roc
                    public ElementDefinitionInfo Roc;                                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Quality_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. MolecularSequence.quality.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "MolecularSequence.quality.type",                                                                     // MakerGen.cs:236
                                Id = "MolecularSequence.quality.type",                                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. MolecularSequence.quality.standardSequence
                            this.StandardSequence = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "StandardSequence",                                                                                  // MakerGen.cs:235
                                Path= "MolecularSequence.quality.standardSequence",                                                         // MakerGen.cs:236
                                Id = "MolecularSequence.quality.standardSequence",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. MolecularSequence.quality.start
                            this.Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Start",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.quality.start",                                                                    // MakerGen.cs:236
                                Id = "MolecularSequence.quality.start",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. MolecularSequence.quality.end
                            this.End = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "End",                                                                                               // MakerGen.cs:235
                                Path= "MolecularSequence.quality.end",                                                                      // MakerGen.cs:236
                                Id = "MolecularSequence.quality.end",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. MolecularSequence.quality.score
                            this.Score = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Score",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.quality.score",                                                                    // MakerGen.cs:236
                                Id = "MolecularSequence.quality.score",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. MolecularSequence.quality.method
                            this.Method = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Method",                                                                                            // MakerGen.cs:235
                                Path= "MolecularSequence.quality.method",                                                                   // MakerGen.cs:236
                                Id = "MolecularSequence.quality.method",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. MolecularSequence.quality.truthTP
                            this.TruthTP = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TruthTP",                                                                                           // MakerGen.cs:235
                                Path= "MolecularSequence.quality.truthTP",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.quality.truthTP",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. MolecularSequence.quality.queryTP
                            this.QueryTP = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "QueryTP",                                                                                           // MakerGen.cs:235
                                Path= "MolecularSequence.quality.queryTP",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.quality.queryTP",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. MolecularSequence.quality.truthFN
                            this.TruthFN = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TruthFN",                                                                                           // MakerGen.cs:235
                                Path= "MolecularSequence.quality.truthFN",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.quality.truthFN",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. MolecularSequence.quality.queryFP
                            this.QueryFP = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "QueryFP",                                                                                           // MakerGen.cs:235
                                Path= "MolecularSequence.quality.queryFP",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.quality.queryFP",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 38. MolecularSequence.quality.gtFP
                            this.GtFP = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "GtFP",                                                                                              // MakerGen.cs:235
                                Path= "MolecularSequence.quality.gtFP",                                                                     // MakerGen.cs:236
                                Id = "MolecularSequence.quality.gtFP",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 39. MolecularSequence.quality.precision
                            this.Precision = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Precision",                                                                                         // MakerGen.cs:235
                                Path= "MolecularSequence.quality.precision",                                                                // MakerGen.cs:236
                                Id = "MolecularSequence.quality.precision",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 40. MolecularSequence.quality.recall
                            this.Recall = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Recall",                                                                                            // MakerGen.cs:235
                                Path= "MolecularSequence.quality.recall",                                                                   // MakerGen.cs:236
                                Id = "MolecularSequence.quality.recall",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 41. MolecularSequence.quality.fScore
                            this.FScore = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "FScore",                                                                                            // MakerGen.cs:235
                                Path= "MolecularSequence.quality.fScore",                                                                   // MakerGen.cs:236
                                Id = "MolecularSequence.quality.fScore",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 42. MolecularSequence.quality.roc
                            this.Roc = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Roc",                                                                                               // MakerGen.cs:235
                                Path= "MolecularSequence.quality.roc",                                                                      // MakerGen.cs:236
                                Id = "MolecularSequence.quality.roc",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Roc                                                                                            // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        StandardSequence.Write(sDef);                                                                                       // MakerGen.cs:220
                        Start.Write(sDef);                                                                                                  // MakerGen.cs:220
                        End.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Score.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Method.Write(sDef);                                                                                                 // MakerGen.cs:220
                        TruthTP.Write(sDef);                                                                                                // MakerGen.cs:220
                        QueryTP.Write(sDef);                                                                                                // MakerGen.cs:220
                        TruthFN.Write(sDef);                                                                                                // MakerGen.cs:220
                        QueryFP.Write(sDef);                                                                                                // MakerGen.cs:220
                        GtFP.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Precision.Write(sDef);                                                                                              // MakerGen.cs:220
                        Recall.Write(sDef);                                                                                                 // MakerGen.cs:220
                        FScore.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Roc.Write(sDef);                                                                                                    // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Quality_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Quality_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Quality_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Quality()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MolecularSequence.quality",                                                                                 // MakerGen.cs:428
                        ElementId = "MolecularSequence.quality"                                                                             // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 51. MolecularSequence.repository
            public class Type_Repository : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Repository_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 52. MolecularSequence.repository.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 53. MolecularSequence.repository.url
                    public ElementDefinitionInfo Url;                                                                                       // MakerGen.cs:216
                    // 54. MolecularSequence.repository.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 55. MolecularSequence.repository.datasetId
                    public ElementDefinitionInfo DatasetId;                                                                                 // MakerGen.cs:216
                    // 56. MolecularSequence.repository.variantsetId
                    public ElementDefinitionInfo VariantsetId;                                                                              // MakerGen.cs:216
                    // 57. MolecularSequence.repository.readsetId
                    public ElementDefinitionInfo ReadsetId;                                                                                 // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Repository_Elements()                                                                                       // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 52. MolecularSequence.repository.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "MolecularSequence.repository.type",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.repository.type",                                                                   // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 53. MolecularSequence.repository.url
                            this.Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Url",                                                                                               // MakerGen.cs:235
                                Path= "MolecularSequence.repository.url",                                                                   // MakerGen.cs:236
                                Id = "MolecularSequence.repository.url",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 54. MolecularSequence.repository.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "MolecularSequence.repository.name",                                                                  // MakerGen.cs:236
                                Id = "MolecularSequence.repository.name",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 55. MolecularSequence.repository.datasetId
                            this.DatasetId = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DatasetId",                                                                                         // MakerGen.cs:235
                                Path= "MolecularSequence.repository.datasetId",                                                             // MakerGen.cs:236
                                Id = "MolecularSequence.repository.datasetId",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 56. MolecularSequence.repository.variantsetId
                            this.VariantsetId = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "VariantsetId",                                                                                      // MakerGen.cs:235
                                Path= "MolecularSequence.repository.variantsetId",                                                          // MakerGen.cs:236
                                Id = "MolecularSequence.repository.variantsetId",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 57. MolecularSequence.repository.readsetId
                            this.ReadsetId = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ReadsetId",                                                                                         // MakerGen.cs:235
                                Path= "MolecularSequence.repository.readsetId",                                                             // MakerGen.cs:236
                                Id = "MolecularSequence.repository.readsetId",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Url.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        DatasetId.Write(sDef);                                                                                              // MakerGen.cs:220
                        VariantsetId.Write(sDef);                                                                                           // MakerGen.cs:220
                        ReadsetId.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Repository_Elements Elements                                                                                    // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Repository_Elements();                                                                 // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Repository_Elements elements;                                                                                          // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Repository()                                                                                                    // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MolecularSequence.repository",                                                                              // MakerGen.cs:428
                        ElementId = "MolecularSequence.repository"                                                                          // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 59. MolecularSequence.structureVariant
            public class Type_StructureVariant : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_StructureVariant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 63. MolecularSequence.structureVariant.outer
                    public class Type_Outer : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Outer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 64. MolecularSequence.structureVariant.outer.start
                            public ElementDefinitionInfo Start;                                                                             // MakerGen.cs:216
                            // 65. MolecularSequence.structureVariant.outer.end
                            public ElementDefinitionInfo End;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Outer_Elements()                                                                                    // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 64. MolecularSequence.structureVariant.outer.start
                                    this.Start = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Start",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.structureVariant.outer.start",                                             // MakerGen.cs:236
                                        Id = "MolecularSequence.structureVariant.outer.start",                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 65. MolecularSequence.structureVariant.outer.end
                                    this.End = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "End",                                                                                       // MakerGen.cs:235
                                        Path= "MolecularSequence.structureVariant.outer.end",                                               // MakerGen.cs:236
                                        Id = "MolecularSequence.structureVariant.outer.end",                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Start.Write(sDef);                                                                                          // MakerGen.cs:220
                                End.Write(sDef);                                                                                            // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Outer_Elements Elements                                                                                 // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Outer_Elements();                                                              // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Outer_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Outer()                                                                                                 // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "MolecularSequence.structureVariant.outer",                                                          // MakerGen.cs:428
                                ElementId = "MolecularSequence.structureVariant.outer"                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 66. MolecularSequence.structureVariant.inner
                    public class Type_Inner : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Inner_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 67. MolecularSequence.structureVariant.inner.start
                            public ElementDefinitionInfo Start;                                                                             // MakerGen.cs:216
                            // 68. MolecularSequence.structureVariant.inner.end
                            public ElementDefinitionInfo End;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Inner_Elements()                                                                                    // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 67. MolecularSequence.structureVariant.inner.start
                                    this.Start = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Start",                                                                                     // MakerGen.cs:235
                                        Path= "MolecularSequence.structureVariant.inner.start",                                             // MakerGen.cs:236
                                        Id = "MolecularSequence.structureVariant.inner.start",                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 68. MolecularSequence.structureVariant.inner.end
                                    this.End = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "End",                                                                                       // MakerGen.cs:235
                                        Path= "MolecularSequence.structureVariant.inner.end",                                               // MakerGen.cs:236
                                        Id = "MolecularSequence.structureVariant.inner.end",                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Start.Write(sDef);                                                                                          // MakerGen.cs:220
                                End.Write(sDef);                                                                                            // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Inner_Elements Elements                                                                                 // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Inner_Elements();                                                              // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Inner_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Inner()                                                                                                 // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "MolecularSequence.structureVariant.inner",                                                          // MakerGen.cs:428
                                ElementId = "MolecularSequence.structureVariant.inner"                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 60. MolecularSequence.structureVariant.variantType
                    public ElementDefinitionInfo VariantType;                                                                               // MakerGen.cs:216
                    // 61. MolecularSequence.structureVariant.exact
                    public ElementDefinitionInfo Exact;                                                                                     // MakerGen.cs:216
                    // 62. MolecularSequence.structureVariant.length
                    public ElementDefinitionInfo Length;                                                                                    // MakerGen.cs:216
                    // 63. MolecularSequence.structureVariant.outer
                    public ElementDefinitionInfo Outer;                                                                                     // MakerGen.cs:216
                    // 66. MolecularSequence.structureVariant.inner
                    public ElementDefinitionInfo Inner;                                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_StructureVariant_Elements()                                                                                 // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 60. MolecularSequence.structureVariant.variantType
                            this.VariantType = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "VariantType",                                                                                       // MakerGen.cs:235
                                Path= "MolecularSequence.structureVariant.variantType",                                                     // MakerGen.cs:236
                                Id = "MolecularSequence.structureVariant.variantType",                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 61. MolecularSequence.structureVariant.exact
                            this.Exact = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Exact",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.structureVariant.exact",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.structureVariant.exact",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 62. MolecularSequence.structureVariant.length
                            this.Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Length",                                                                                            // MakerGen.cs:235
                                Path= "MolecularSequence.structureVariant.length",                                                          // MakerGen.cs:236
                                Id = "MolecularSequence.structureVariant.length",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 63. MolecularSequence.structureVariant.outer
                            this.Outer = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Outer",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.structureVariant.outer",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.structureVariant.outer",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Outer                                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 66. MolecularSequence.structureVariant.inner
                            this.Inner = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Inner",                                                                                             // MakerGen.cs:235
                                Path= "MolecularSequence.structureVariant.inner",                                                           // MakerGen.cs:236
                                Id = "MolecularSequence.structureVariant.inner",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Inner                                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        VariantType.Write(sDef);                                                                                            // MakerGen.cs:220
                        Exact.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Length.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Outer.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Inner.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_StructureVariant_Elements Elements                                                                              // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_StructureVariant_Elements();                                                           // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_StructureVariant_Elements elements;                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_StructureVariant()                                                                                              // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MolecularSequence.structureVariant",                                                                        // MakerGen.cs:428
                        ElementId = "MolecularSequence.structureVariant"                                                                    // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. MolecularSequence.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MolecularSequence.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 3. MolecularSequence.coordinateSystem
            public ElementDefinitionInfo CoordinateSystem;                                                                                  // MakerGen.cs:216
            // 4. MolecularSequence.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 5. MolecularSequence.specimen
            public ElementDefinitionInfo Specimen;                                                                                          // MakerGen.cs:216
            // 6. MolecularSequence.device
            public ElementDefinitionInfo Device;                                                                                            // MakerGen.cs:216
            // 7. MolecularSequence.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:216
            // 8. MolecularSequence.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:216
            // 9. MolecularSequence.referenceSeq
            public ElementDefinitionInfo ReferenceSeq;                                                                                      // MakerGen.cs:216
            // 19. MolecularSequence.variant
            public ElementDefinitionInfo Variant;                                                                                           // MakerGen.cs:216
            // 26. MolecularSequence.observedSeq
            public ElementDefinitionInfo ObservedSeq;                                                                                       // MakerGen.cs:216
            // 27. MolecularSequence.quality
            public ElementDefinitionInfo Quality;                                                                                           // MakerGen.cs:216
            // 50. MolecularSequence.readCoverage
            public ElementDefinitionInfo ReadCoverage;                                                                                      // MakerGen.cs:216
            // 51. MolecularSequence.repository
            public ElementDefinitionInfo Repository;                                                                                        // MakerGen.cs:216
            // 58. MolecularSequence.pointer
            public ElementDefinitionInfo Pointer;                                                                                           // MakerGen.cs:216
            // 59. MolecularSequence.structureVariant
            public ElementDefinitionInfo StructureVariant;                                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MolecularSequence_Elements()                                                                                             // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MolecularSequence.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MolecularSequence.identifier",                                                                               // MakerGen.cs:236
                        Id = "MolecularSequence.identifier",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MolecularSequence.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "MolecularSequence.type",                                                                                     // MakerGen.cs:236
                        Id = "MolecularSequence.type",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. MolecularSequence.coordinateSystem
                    this.CoordinateSystem = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CoordinateSystem",                                                                                          // MakerGen.cs:235
                        Path= "MolecularSequence.coordinateSystem",                                                                         // MakerGen.cs:236
                        Id = "MolecularSequence.coordinateSystem",                                                                          // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. MolecularSequence.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "MolecularSequence.patient",                                                                                  // MakerGen.cs:236
                        Id = "MolecularSequence.patient",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. MolecularSequence.specimen
                    this.Specimen = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Specimen",                                                                                                  // MakerGen.cs:235
                        Path= "MolecularSequence.specimen",                                                                                 // MakerGen.cs:236
                        Id = "MolecularSequence.specimen",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MolecularSequence.device
                    this.Device = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Device",                                                                                                    // MakerGen.cs:235
                        Path= "MolecularSequence.device",                                                                                   // MakerGen.cs:236
                        Id = "MolecularSequence.device",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MolecularSequence.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Performer",                                                                                                 // MakerGen.cs:235
                        Path= "MolecularSequence.performer",                                                                                // MakerGen.cs:236
                        Id = "MolecularSequence.performer",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. MolecularSequence.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Quantity",                                                                                                  // MakerGen.cs:235
                        Path= "MolecularSequence.quantity",                                                                                 // MakerGen.cs:236
                        Id = "MolecularSequence.quantity",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. MolecularSequence.referenceSeq
                    this.ReferenceSeq = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReferenceSeq",                                                                                              // MakerGen.cs:235
                        Path= "MolecularSequence.referenceSeq",                                                                             // MakerGen.cs:236
                        Id = "MolecularSequence.referenceSeq",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_ReferenceSeq                                                                                           // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. MolecularSequence.variant
                    this.Variant = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Variant",                                                                                                   // MakerGen.cs:235
                        Path= "MolecularSequence.variant",                                                                                  // MakerGen.cs:236
                        Id = "MolecularSequence.variant",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Variant                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 26. MolecularSequence.observedSeq
                    this.ObservedSeq = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ObservedSeq",                                                                                               // MakerGen.cs:235
                        Path= "MolecularSequence.observedSeq",                                                                              // MakerGen.cs:236
                        Id = "MolecularSequence.observedSeq",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 27. MolecularSequence.quality
                    this.Quality = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Quality",                                                                                                   // MakerGen.cs:235
                        Path= "MolecularSequence.quality",                                                                                  // MakerGen.cs:236
                        Id = "MolecularSequence.quality",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Quality                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 50. MolecularSequence.readCoverage
                    this.ReadCoverage = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReadCoverage",                                                                                              // MakerGen.cs:235
                        Path= "MolecularSequence.readCoverage",                                                                             // MakerGen.cs:236
                        Id = "MolecularSequence.readCoverage",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 51. MolecularSequence.repository
                    this.Repository = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Repository",                                                                                                // MakerGen.cs:235
                        Path= "MolecularSequence.repository",                                                                               // MakerGen.cs:236
                        Id = "MolecularSequence.repository",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Repository                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 58. MolecularSequence.pointer
                    this.Pointer = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Pointer",                                                                                                   // MakerGen.cs:235
                        Path= "MolecularSequence.pointer",                                                                                  // MakerGen.cs:236
                        Id = "MolecularSequence.pointer",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 59. MolecularSequence.structureVariant
                    this.StructureVariant = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StructureVariant",                                                                                          // MakerGen.cs:235
                        Path= "MolecularSequence.structureVariant",                                                                         // MakerGen.cs:236
                        Id = "MolecularSequence.structureVariant",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_StructureVariant                                                                                       // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                CoordinateSystem.Write(sDef);                                                                                               // MakerGen.cs:220
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                Specimen.Write(sDef);                                                                                                       // MakerGen.cs:220
                Device.Write(sDef);                                                                                                         // MakerGen.cs:220
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:220
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:220
                ReferenceSeq.Write(sDef);                                                                                                   // MakerGen.cs:220
                Variant.Write(sDef);                                                                                                        // MakerGen.cs:220
                ObservedSeq.Write(sDef);                                                                                                    // MakerGen.cs:220
                Quality.Write(sDef);                                                                                                        // MakerGen.cs:220
                ReadCoverage.Write(sDef);                                                                                                   // MakerGen.cs:220
                Repository.Write(sDef);                                                                                                     // MakerGen.cs:220
                Pointer.Write(sDef);                                                                                                        // MakerGen.cs:220
                StructureVariant.Write(sDef);                                                                                               // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MolecularSequence_Elements Elements                                                                                          // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MolecularSequence_Elements();                                                                       // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MolecularSequence_Elements elements;                                                                                                // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MolecularSequence()                                                                                                          // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "MolecularSequence";                                                                                                // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MolecularSequence";                                                         // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MolecularSequence",                                                                                                 // MakerGen.cs:428
                ElementId = "MolecularSequence"                                                                                             // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
