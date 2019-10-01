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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'MolecularSequence'
    /// </summary>
    // 0. MolecularSequence
    public class Resource_MolecularSequence : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_MolecularSequence_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 9. MolecularSequence.referenceSeq
            public class Type_ReferenceSeq : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_ReferenceSeq_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 10. MolecularSequence.referenceSeq.chromosome
                    public ElementDefinitionInfo Element_Chromosome;                                                                        // MakerGen.cs:211
                    // 11. MolecularSequence.referenceSeq.genomeBuild
                    public ElementDefinitionInfo Element_GenomeBuild;                                                                       // MakerGen.cs:211
                    // 12. MolecularSequence.referenceSeq.orientation
                    public ElementDefinitionInfo Element_Orientation;                                                                       // MakerGen.cs:211
                    // 13. MolecularSequence.referenceSeq.referenceSeqId
                    public ElementDefinitionInfo Element_ReferenceSeqId;                                                                    // MakerGen.cs:211
                    // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                    public ElementDefinitionInfo Element_ReferenceSeqPointer;                                                               // MakerGen.cs:211
                    // 15. MolecularSequence.referenceSeq.referenceSeqString
                    public ElementDefinitionInfo Element_ReferenceSeqString;                                                                // MakerGen.cs:211
                    // 16. MolecularSequence.referenceSeq.strand
                    public ElementDefinitionInfo Element_Strand;                                                                            // MakerGen.cs:211
                    // 17. MolecularSequence.referenceSeq.windowStart
                    public ElementDefinitionInfo Element_WindowStart;                                                                       // MakerGen.cs:211
                    // 18. MolecularSequence.referenceSeq.windowEnd
                    public ElementDefinitionInfo Element_WindowEnd;                                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_ReferenceSeq_Elements()                                                                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. MolecularSequence.referenceSeq.chromosome
                            this.Element_Chromosome = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Chromosome",                                                                                // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.chromosome",                                                          // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.chromosome",                                                           // MakerGen.cs:232
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
                            // 11. MolecularSequence.referenceSeq.genomeBuild
                            this.Element_GenomeBuild = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_GenomeBuild",                                                                               // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.genomeBuild",                                                         // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.genomeBuild",                                                          // MakerGen.cs:232
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
                            // 12. MolecularSequence.referenceSeq.orientation
                            this.Element_Orientation = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Orientation",                                                                               // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.orientation",                                                         // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.orientation",                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. MolecularSequence.referenceSeq.referenceSeqId
                            this.Element_ReferenceSeqId = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReferenceSeqId",                                                                            // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.referenceSeqId",                                                      // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.referenceSeqId",                                                       // MakerGen.cs:232
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
                            // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                            this.Element_ReferenceSeqPointer = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReferenceSeqPointer",                                                                       // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.referenceSeqPointer",                                                 // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.referenceSeqPointer",                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                     // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. MolecularSequence.referenceSeq.referenceSeqString
                            this.Element_ReferenceSeqString = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReferenceSeqString",                                                                        // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.referenceSeqString",                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.referenceSeqString",                                                   // MakerGen.cs:232
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
                            // 16. MolecularSequence.referenceSeq.strand
                            this.Element_Strand = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Strand",                                                                                    // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.strand",                                                              // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.strand",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. MolecularSequence.referenceSeq.windowStart
                            this.Element_WindowStart = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_WindowStart",                                                                               // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.windowStart",                                                         // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.windowStart",                                                          // MakerGen.cs:232
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
                            // 18. MolecularSequence.referenceSeq.windowEnd
                            this.Element_WindowEnd = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_WindowEnd",                                                                                 // MakerGen.cs:230
                                Path= "MolecularSequence.referenceSeq.windowEnd",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.referenceSeq.windowEnd",                                                            // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Chromosome.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_GenomeBuild.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_Orientation.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_ReferenceSeqId.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_ReferenceSeqPointer.Write(sDef);                                                                            // MakerGen.cs:215
                        Element_ReferenceSeqString.Write(sDef);                                                                             // MakerGen.cs:215
                        Element_Strand.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_WindowStart.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_WindowEnd.Write(sDef);                                                                                      // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_ReferenceSeq_Elements Elements                                                                                  // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_ReferenceSeq_Elements();                                                               // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_ReferenceSeq_Elements elements;                                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_ReferenceSeq()                                                                                                  // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MolecularSequence.referenceSeq",                                                                            // MakerGen.cs:420
                        ElementId = "MolecularSequence.referenceSeq"                                                                        // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 19. MolecularSequence.variant
            public class Type_Variant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Variant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 20. MolecularSequence.variant.start
                    public ElementDefinitionInfo Element_Start;                                                                             // MakerGen.cs:211
                    // 21. MolecularSequence.variant.end
                    public ElementDefinitionInfo Element_End;                                                                               // MakerGen.cs:211
                    // 22. MolecularSequence.variant.observedAllele
                    public ElementDefinitionInfo Element_ObservedAllele;                                                                    // MakerGen.cs:211
                    // 23. MolecularSequence.variant.referenceAllele
                    public ElementDefinitionInfo Element_ReferenceAllele;                                                                   // MakerGen.cs:211
                    // 24. MolecularSequence.variant.cigar
                    public ElementDefinitionInfo Element_Cigar;                                                                             // MakerGen.cs:211
                    // 25. MolecularSequence.variant.variantPointer
                    public ElementDefinitionInfo Element_VariantPointer;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Variant_Elements()                                                                                          // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. MolecularSequence.variant.start
                            this.Element_Start = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Start",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.variant.start",                                                                    // MakerGen.cs:231
                                Id = "MolecularSequence.variant.start",                                                                     // MakerGen.cs:232
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
                            // 21. MolecularSequence.variant.end
                            this.Element_End = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_End",                                                                                       // MakerGen.cs:230
                                Path= "MolecularSequence.variant.end",                                                                      // MakerGen.cs:231
                                Id = "MolecularSequence.variant.end",                                                                       // MakerGen.cs:232
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
                            // 22. MolecularSequence.variant.observedAllele
                            this.Element_ObservedAllele = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ObservedAllele",                                                                            // MakerGen.cs:230
                                Path= "MolecularSequence.variant.observedAllele",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.variant.observedAllele",                                                            // MakerGen.cs:232
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
                            // 23. MolecularSequence.variant.referenceAllele
                            this.Element_ReferenceAllele = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReferenceAllele",                                                                           // MakerGen.cs:230
                                Path= "MolecularSequence.variant.referenceAllele",                                                          // MakerGen.cs:231
                                Id = "MolecularSequence.variant.referenceAllele",                                                           // MakerGen.cs:232
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
                            // 24. MolecularSequence.variant.cigar
                            this.Element_Cigar = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Cigar",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.variant.cigar",                                                                    // MakerGen.cs:231
                                Id = "MolecularSequence.variant.cigar",                                                                     // MakerGen.cs:232
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
                            // 25. MolecularSequence.variant.variantPointer
                            this.Element_VariantPointer = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_VariantPointer",                                                                            // MakerGen.cs:230
                                Path= "MolecularSequence.variant.variantPointer",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.variant.variantPointer",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Observation"                                           // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Start.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_End.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_ObservedAllele.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_ReferenceAllele.Write(sDef);                                                                                // MakerGen.cs:215
                        Element_Cigar.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_VariantPointer.Write(sDef);                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Variant_Elements Elements                                                                                       // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Variant_Elements();                                                                    // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Variant_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Variant()                                                                                                       // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MolecularSequence.variant",                                                                                 // MakerGen.cs:420
                        ElementId = "MolecularSequence.variant"                                                                             // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 27. MolecularSequence.quality
            public class Type_Quality : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Quality_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 42. MolecularSequence.quality.roc
                    public class Type_Roc : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Roc_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 43. MolecularSequence.quality.roc.score
                            public ElementDefinitionInfo Element_Score;                                                                     // MakerGen.cs:211
                            // 44. MolecularSequence.quality.roc.numTP
                            public ElementDefinitionInfo Element_NumTP;                                                                     // MakerGen.cs:211
                            // 45. MolecularSequence.quality.roc.numFP
                            public ElementDefinitionInfo Element_NumFP;                                                                     // MakerGen.cs:211
                            // 46. MolecularSequence.quality.roc.numFN
                            public ElementDefinitionInfo Element_NumFN;                                                                     // MakerGen.cs:211
                            // 47. MolecularSequence.quality.roc.precision
                            public ElementDefinitionInfo Element_Precision;                                                                 // MakerGen.cs:211
                            // 48. MolecularSequence.quality.roc.sensitivity
                            public ElementDefinitionInfo Element_Sensitivity;                                                               // MakerGen.cs:211
                            // 49. MolecularSequence.quality.roc.fMeasure
                            public ElementDefinitionInfo Element_FMeasure;                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Roc_Elements()                                                                                      // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 43. MolecularSequence.quality.roc.score
                                    this.Element_Score = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Score",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.score",                                                        // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.score",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 44. MolecularSequence.quality.roc.numTP
                                    this.Element_NumTP = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_NumTP",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.numTP",                                                        // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.numTP",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 45. MolecularSequence.quality.roc.numFP
                                    this.Element_NumFP = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_NumFP",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.numFP",                                                        // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.numFP",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 46. MolecularSequence.quality.roc.numFN
                                    this.Element_NumFN = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_NumFN",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.numFN",                                                        // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.numFN",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 47. MolecularSequence.quality.roc.precision
                                    this.Element_Precision = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Precision",                                                                         // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.precision",                                                    // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.precision",                                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 48. MolecularSequence.quality.roc.sensitivity
                                    this.Element_Sensitivity = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Sensitivity",                                                                       // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.sensitivity",                                                  // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.sensitivity",                                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 49. MolecularSequence.quality.roc.fMeasure
                                    this.Element_FMeasure = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_FMeasure",                                                                          // MakerGen.cs:230
                                        Path= "MolecularSequence.quality.roc.fMeasure",                                                     // MakerGen.cs:231
                                        Id = "MolecularSequence.quality.roc.fMeasure",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
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
                                Element_Score.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_NumTP.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_NumFP.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_NumFN.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_Precision.Write(sDef);                                                                              // MakerGen.cs:215
                                Element_Sensitivity.Write(sDef);                                                                            // MakerGen.cs:215
                                Element_FMeasure.Write(sDef);                                                                               // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Roc_Elements Elements                                                                                   // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Roc_Elements();                                                                // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Roc_Elements elements;                                                                                         // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Roc()                                                                                                   // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "MolecularSequence.quality.roc",                                                                     // MakerGen.cs:420
                                ElementId = "MolecularSequence.quality.roc"                                                                 // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 28. MolecularSequence.quality.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 29. MolecularSequence.quality.standardSequence
                    public ElementDefinitionInfo Element_StandardSequence;                                                                  // MakerGen.cs:211
                    // 30. MolecularSequence.quality.start
                    public ElementDefinitionInfo Element_Start;                                                                             // MakerGen.cs:211
                    // 31. MolecularSequence.quality.end
                    public ElementDefinitionInfo Element_End;                                                                               // MakerGen.cs:211
                    // 32. MolecularSequence.quality.score
                    public ElementDefinitionInfo Element_Score;                                                                             // MakerGen.cs:211
                    // 33. MolecularSequence.quality.method
                    public ElementDefinitionInfo Element_Method;                                                                            // MakerGen.cs:211
                    // 34. MolecularSequence.quality.truthTP
                    public ElementDefinitionInfo Element_TruthTP;                                                                           // MakerGen.cs:211
                    // 35. MolecularSequence.quality.queryTP
                    public ElementDefinitionInfo Element_QueryTP;                                                                           // MakerGen.cs:211
                    // 36. MolecularSequence.quality.truthFN
                    public ElementDefinitionInfo Element_TruthFN;                                                                           // MakerGen.cs:211
                    // 37. MolecularSequence.quality.queryFP
                    public ElementDefinitionInfo Element_QueryFP;                                                                           // MakerGen.cs:211
                    // 38. MolecularSequence.quality.gtFP
                    public ElementDefinitionInfo Element_GtFP;                                                                              // MakerGen.cs:211
                    // 39. MolecularSequence.quality.precision
                    public ElementDefinitionInfo Element_Precision;                                                                         // MakerGen.cs:211
                    // 40. MolecularSequence.quality.recall
                    public ElementDefinitionInfo Element_Recall;                                                                            // MakerGen.cs:211
                    // 41. MolecularSequence.quality.fScore
                    public ElementDefinitionInfo Element_FScore;                                                                            // MakerGen.cs:211
                    // 42. MolecularSequence.quality.roc
                    public ElementDefinitionInfo Element_Roc;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Quality_Elements()                                                                                          // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. MolecularSequence.quality.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "MolecularSequence.quality.type",                                                                     // MakerGen.cs:231
                                Id = "MolecularSequence.quality.type",                                                                      // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. MolecularSequence.quality.standardSequence
                            this.Element_StandardSequence = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_StandardSequence",                                                                          // MakerGen.cs:230
                                Path= "MolecularSequence.quality.standardSequence",                                                         // MakerGen.cs:231
                                Id = "MolecularSequence.quality.standardSequence",                                                          // MakerGen.cs:232
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
                            // 30. MolecularSequence.quality.start
                            this.Element_Start = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Start",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.quality.start",                                                                    // MakerGen.cs:231
                                Id = "MolecularSequence.quality.start",                                                                     // MakerGen.cs:232
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
                            // 31. MolecularSequence.quality.end
                            this.Element_End = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_End",                                                                                       // MakerGen.cs:230
                                Path= "MolecularSequence.quality.end",                                                                      // MakerGen.cs:231
                                Id = "MolecularSequence.quality.end",                                                                       // MakerGen.cs:232
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
                            // 32. MolecularSequence.quality.score
                            this.Element_Score = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Score",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.quality.score",                                                                    // MakerGen.cs:231
                                Id = "MolecularSequence.quality.score",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. MolecularSequence.quality.method
                            this.Element_Method = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Method",                                                                                    // MakerGen.cs:230
                                Path= "MolecularSequence.quality.method",                                                                   // MakerGen.cs:231
                                Id = "MolecularSequence.quality.method",                                                                    // MakerGen.cs:232
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
                            // 34. MolecularSequence.quality.truthTP
                            this.Element_TruthTP = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_TruthTP",                                                                                   // MakerGen.cs:230
                                Path= "MolecularSequence.quality.truthTP",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.quality.truthTP",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 35. MolecularSequence.quality.queryTP
                            this.Element_QueryTP = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_QueryTP",                                                                                   // MakerGen.cs:230
                                Path= "MolecularSequence.quality.queryTP",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.quality.queryTP",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 36. MolecularSequence.quality.truthFN
                            this.Element_TruthFN = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_TruthFN",                                                                                   // MakerGen.cs:230
                                Path= "MolecularSequence.quality.truthFN",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.quality.truthFN",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 37. MolecularSequence.quality.queryFP
                            this.Element_QueryFP = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_QueryFP",                                                                                   // MakerGen.cs:230
                                Path= "MolecularSequence.quality.queryFP",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.quality.queryFP",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 38. MolecularSequence.quality.gtFP
                            this.Element_GtFP = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_GtFP",                                                                                      // MakerGen.cs:230
                                Path= "MolecularSequence.quality.gtFP",                                                                     // MakerGen.cs:231
                                Id = "MolecularSequence.quality.gtFP",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 39. MolecularSequence.quality.precision
                            this.Element_Precision = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Precision",                                                                                 // MakerGen.cs:230
                                Path= "MolecularSequence.quality.precision",                                                                // MakerGen.cs:231
                                Id = "MolecularSequence.quality.precision",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 40. MolecularSequence.quality.recall
                            this.Element_Recall = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Recall",                                                                                    // MakerGen.cs:230
                                Path= "MolecularSequence.quality.recall",                                                                   // MakerGen.cs:231
                                Id = "MolecularSequence.quality.recall",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 41. MolecularSequence.quality.fScore
                            this.Element_FScore = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_FScore",                                                                                    // MakerGen.cs:230
                                Path= "MolecularSequence.quality.fScore",                                                                   // MakerGen.cs:231
                                Id = "MolecularSequence.quality.fScore",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 42. MolecularSequence.quality.roc
                            this.Element_Roc = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Roc",                                                                                       // MakerGen.cs:230
                                Path= "MolecularSequence.quality.roc",                                                                      // MakerGen.cs:231
                                Id = "MolecularSequence.quality.roc",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Roc                                                                                            // MakerGen.cs:254
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
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_StandardSequence.Write(sDef);                                                                               // MakerGen.cs:215
                        Element_Start.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_End.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_Score.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Method.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_TruthTP.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_QueryTP.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_TruthFN.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_QueryFP.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_GtFP.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Precision.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_Recall.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_FScore.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Roc.Write(sDef);                                                                                            // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Quality_Elements Elements                                                                                       // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Quality_Elements();                                                                    // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Quality_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Quality()                                                                                                       // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MolecularSequence.quality",                                                                                 // MakerGen.cs:420
                        ElementId = "MolecularSequence.quality"                                                                             // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 51. MolecularSequence.repository
            public class Type_Repository : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Repository_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 52. MolecularSequence.repository.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 53. MolecularSequence.repository.url
                    public ElementDefinitionInfo Element_Url;                                                                               // MakerGen.cs:211
                    // 54. MolecularSequence.repository.name
                    public ElementDefinitionInfo Element_Name;                                                                              // MakerGen.cs:211
                    // 55. MolecularSequence.repository.datasetId
                    public ElementDefinitionInfo Element_DatasetId;                                                                         // MakerGen.cs:211
                    // 56. MolecularSequence.repository.variantsetId
                    public ElementDefinitionInfo Element_VariantsetId;                                                                      // MakerGen.cs:211
                    // 57. MolecularSequence.repository.readsetId
                    public ElementDefinitionInfo Element_ReadsetId;                                                                         // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Repository_Elements()                                                                                       // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 52. MolecularSequence.repository.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "MolecularSequence.repository.type",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.repository.type",                                                                   // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 53. MolecularSequence.repository.url
                            this.Element_Url = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Url",                                                                                       // MakerGen.cs:230
                                Path= "MolecularSequence.repository.url",                                                                   // MakerGen.cs:231
                                Id = "MolecularSequence.repository.url",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 54. MolecularSequence.repository.name
                            this.Element_Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Name",                                                                                      // MakerGen.cs:230
                                Path= "MolecularSequence.repository.name",                                                                  // MakerGen.cs:231
                                Id = "MolecularSequence.repository.name",                                                                   // MakerGen.cs:232
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
                            // 55. MolecularSequence.repository.datasetId
                            this.Element_DatasetId = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DatasetId",                                                                                 // MakerGen.cs:230
                                Path= "MolecularSequence.repository.datasetId",                                                             // MakerGen.cs:231
                                Id = "MolecularSequence.repository.datasetId",                                                              // MakerGen.cs:232
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
                            // 56. MolecularSequence.repository.variantsetId
                            this.Element_VariantsetId = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_VariantsetId",                                                                              // MakerGen.cs:230
                                Path= "MolecularSequence.repository.variantsetId",                                                          // MakerGen.cs:231
                                Id = "MolecularSequence.repository.variantsetId",                                                           // MakerGen.cs:232
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
                            // 57. MolecularSequence.repository.readsetId
                            this.Element_ReadsetId = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReadsetId",                                                                                 // MakerGen.cs:230
                                Path= "MolecularSequence.repository.readsetId",                                                             // MakerGen.cs:231
                                Id = "MolecularSequence.repository.readsetId",                                                              // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Url.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_Name.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_DatasetId.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_VariantsetId.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_ReadsetId.Write(sDef);                                                                                      // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Repository_Elements Elements                                                                                    // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Repository_Elements();                                                                 // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Repository_Elements elements;                                                                                          // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Repository()                                                                                                    // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MolecularSequence.repository",                                                                              // MakerGen.cs:420
                        ElementId = "MolecularSequence.repository"                                                                          // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 59. MolecularSequence.structureVariant
            public class Type_StructureVariant : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_StructureVariant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 63. MolecularSequence.structureVariant.outer
                    public class Type_Outer : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Outer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 64. MolecularSequence.structureVariant.outer.start
                            public ElementDefinitionInfo Element_Start;                                                                     // MakerGen.cs:211
                            // 65. MolecularSequence.structureVariant.outer.end
                            public ElementDefinitionInfo Element_End;                                                                       // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Outer_Elements()                                                                                    // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 64. MolecularSequence.structureVariant.outer.start
                                    this.Element_Start = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Start",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.structureVariant.outer.start",                                             // MakerGen.cs:231
                                        Id = "MolecularSequence.structureVariant.outer.start",                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 65. MolecularSequence.structureVariant.outer.end
                                    this.Element_End = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_End",                                                                               // MakerGen.cs:230
                                        Path= "MolecularSequence.structureVariant.outer.end",                                               // MakerGen.cs:231
                                        Id = "MolecularSequence.structureVariant.outer.end",                                                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
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
                                Element_Start.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_End.Write(sDef);                                                                                    // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Outer_Elements Elements                                                                                 // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Outer_Elements();                                                              // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Outer_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Outer()                                                                                                 // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "MolecularSequence.structureVariant.outer",                                                          // MakerGen.cs:420
                                ElementId = "MolecularSequence.structureVariant.outer"                                                      // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 66. MolecularSequence.structureVariant.inner
                    public class Type_Inner : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Inner_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 67. MolecularSequence.structureVariant.inner.start
                            public ElementDefinitionInfo Element_Start;                                                                     // MakerGen.cs:211
                            // 68. MolecularSequence.structureVariant.inner.end
                            public ElementDefinitionInfo Element_End;                                                                       // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Inner_Elements()                                                                                    // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 67. MolecularSequence.structureVariant.inner.start
                                    this.Element_Start = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Start",                                                                             // MakerGen.cs:230
                                        Path= "MolecularSequence.structureVariant.inner.start",                                             // MakerGen.cs:231
                                        Id = "MolecularSequence.structureVariant.inner.start",                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 68. MolecularSequence.structureVariant.inner.end
                                    this.Element_End = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_End",                                                                               // MakerGen.cs:230
                                        Path= "MolecularSequence.structureVariant.inner.end",                                               // MakerGen.cs:231
                                        Id = "MolecularSequence.structureVariant.inner.end",                                                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
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
                                Element_Start.Write(sDef);                                                                                  // MakerGen.cs:215
                                Element_End.Write(sDef);                                                                                    // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Inner_Elements Elements                                                                                 // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Inner_Elements();                                                              // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Inner_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Inner()                                                                                                 // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "MolecularSequence.structureVariant.inner",                                                          // MakerGen.cs:420
                                ElementId = "MolecularSequence.structureVariant.inner"                                                      // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 60. MolecularSequence.structureVariant.variantType
                    public ElementDefinitionInfo Element_VariantType;                                                                       // MakerGen.cs:211
                    // 61. MolecularSequence.structureVariant.exact
                    public ElementDefinitionInfo Element_Exact;                                                                             // MakerGen.cs:211
                    // 62. MolecularSequence.structureVariant.length
                    public ElementDefinitionInfo Element_Length;                                                                            // MakerGen.cs:211
                    // 63. MolecularSequence.structureVariant.outer
                    public ElementDefinitionInfo Element_Outer;                                                                             // MakerGen.cs:211
                    // 66. MolecularSequence.structureVariant.inner
                    public ElementDefinitionInfo Element_Inner;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_StructureVariant_Elements()                                                                                 // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 60. MolecularSequence.structureVariant.variantType
                            this.Element_VariantType = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_VariantType",                                                                               // MakerGen.cs:230
                                Path= "MolecularSequence.structureVariant.variantType",                                                     // MakerGen.cs:231
                                Id = "MolecularSequence.structureVariant.variantType",                                                      // MakerGen.cs:232
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
                            // 61. MolecularSequence.structureVariant.exact
                            this.Element_Exact = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Exact",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.structureVariant.exact",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.structureVariant.exact",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 62. MolecularSequence.structureVariant.length
                            this.Element_Length = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Length",                                                                                    // MakerGen.cs:230
                                Path= "MolecularSequence.structureVariant.length",                                                          // MakerGen.cs:231
                                Id = "MolecularSequence.structureVariant.length",                                                           // MakerGen.cs:232
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
                            // 63. MolecularSequence.structureVariant.outer
                            this.Element_Outer = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Outer",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.structureVariant.outer",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.structureVariant.outer",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Outer                                                                                          // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 66. MolecularSequence.structureVariant.inner
                            this.Element_Inner = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Inner",                                                                                     // MakerGen.cs:230
                                Path= "MolecularSequence.structureVariant.inner",                                                           // MakerGen.cs:231
                                Id = "MolecularSequence.structureVariant.inner",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Inner                                                                                          // MakerGen.cs:254
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
                        Element_VariantType.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_Exact.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Length.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Outer.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Inner.Write(sDef);                                                                                          // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_StructureVariant_Elements Elements                                                                              // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_StructureVariant_Elements();                                                           // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_StructureVariant_Elements elements;                                                                                    // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_StructureVariant()                                                                                              // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "MolecularSequence.structureVariant",                                                                        // MakerGen.cs:420
                        ElementId = "MolecularSequence.structureVariant"                                                                    // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. MolecularSequence.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. MolecularSequence.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 3. MolecularSequence.coordinateSystem
            public ElementDefinitionInfo Element_CoordinateSystem;                                                                          // MakerGen.cs:211
            // 4. MolecularSequence.patient
            public ElementDefinitionInfo Element_Patient;                                                                                   // MakerGen.cs:211
            // 5. MolecularSequence.specimen
            public ElementDefinitionInfo Element_Specimen;                                                                                  // MakerGen.cs:211
            // 6. MolecularSequence.device
            public ElementDefinitionInfo Element_Device;                                                                                    // MakerGen.cs:211
            // 7. MolecularSequence.performer
            public ElementDefinitionInfo Element_Performer;                                                                                 // MakerGen.cs:211
            // 8. MolecularSequence.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:211
            // 9. MolecularSequence.referenceSeq
            public ElementDefinitionInfo Element_ReferenceSeq;                                                                              // MakerGen.cs:211
            // 19. MolecularSequence.variant
            public ElementDefinitionInfo Element_Variant;                                                                                   // MakerGen.cs:211
            // 26. MolecularSequence.observedSeq
            public ElementDefinitionInfo Element_ObservedSeq;                                                                               // MakerGen.cs:211
            // 27. MolecularSequence.quality
            public ElementDefinitionInfo Element_Quality;                                                                                   // MakerGen.cs:211
            // 50. MolecularSequence.readCoverage
            public ElementDefinitionInfo Element_ReadCoverage;                                                                              // MakerGen.cs:211
            // 51. MolecularSequence.repository
            public ElementDefinitionInfo Element_Repository;                                                                                // MakerGen.cs:211
            // 58. MolecularSequence.pointer
            public ElementDefinitionInfo Element_Pointer;                                                                                   // MakerGen.cs:211
            // 59. MolecularSequence.structureVariant
            public ElementDefinitionInfo Element_StructureVariant;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_MolecularSequence_Elements()                                                                                    // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MolecularSequence.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "MolecularSequence.identifier",                                                                               // MakerGen.cs:231
                        Id = "MolecularSequence.identifier",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. MolecularSequence.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "MolecularSequence.type",                                                                                     // MakerGen.cs:231
                        Id = "MolecularSequence.type",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. MolecularSequence.coordinateSystem
                    this.Element_CoordinateSystem = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_CoordinateSystem",                                                                                  // MakerGen.cs:230
                        Path= "MolecularSequence.coordinateSystem",                                                                         // MakerGen.cs:231
                        Id = "MolecularSequence.coordinateSystem",                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
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
                    // 4. MolecularSequence.patient
                    this.Element_Patient = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Patient",                                                                                           // MakerGen.cs:230
                        Path= "MolecularSequence.patient",                                                                                  // MakerGen.cs:231
                        Id = "MolecularSequence.patient",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MolecularSequence.specimen
                    this.Element_Specimen = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Specimen",                                                                                          // MakerGen.cs:230
                        Path= "MolecularSequence.specimen",                                                                                 // MakerGen.cs:231
                        Id = "MolecularSequence.specimen",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"                                                      // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. MolecularSequence.device
                    this.Element_Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Device",                                                                                            // MakerGen.cs:230
                        Path= "MolecularSequence.device",                                                                                   // MakerGen.cs:231
                        Id = "MolecularSequence.device",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. MolecularSequence.performer
                    this.Element_Performer = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Performer",                                                                                         // MakerGen.cs:230
                        Path= "MolecularSequence.performer",                                                                                // MakerGen.cs:231
                        Id = "MolecularSequence.performer",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. MolecularSequence.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:230
                        Path= "MolecularSequence.quantity",                                                                                 // MakerGen.cs:231
                        Id = "MolecularSequence.quantity",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. MolecularSequence.referenceSeq
                    this.Element_ReferenceSeq = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReferenceSeq",                                                                                      // MakerGen.cs:230
                        Path= "MolecularSequence.referenceSeq",                                                                             // MakerGen.cs:231
                        Id = "MolecularSequence.referenceSeq",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_ReferenceSeq                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. MolecularSequence.variant
                    this.Element_Variant = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Variant",                                                                                           // MakerGen.cs:230
                        Path= "MolecularSequence.variant",                                                                                  // MakerGen.cs:231
                        Id = "MolecularSequence.variant",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Variant                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. MolecularSequence.observedSeq
                    this.Element_ObservedSeq = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ObservedSeq",                                                                                       // MakerGen.cs:230
                        Path= "MolecularSequence.observedSeq",                                                                              // MakerGen.cs:231
                        Id = "MolecularSequence.observedSeq",                                                                               // MakerGen.cs:232
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
                    // 27. MolecularSequence.quality
                    this.Element_Quality = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Quality",                                                                                           // MakerGen.cs:230
                        Path= "MolecularSequence.quality",                                                                                  // MakerGen.cs:231
                        Id = "MolecularSequence.quality",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Quality                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 50. MolecularSequence.readCoverage
                    this.Element_ReadCoverage = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReadCoverage",                                                                                      // MakerGen.cs:230
                        Path= "MolecularSequence.readCoverage",                                                                             // MakerGen.cs:231
                        Id = "MolecularSequence.readCoverage",                                                                              // MakerGen.cs:232
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
                    // 51. MolecularSequence.repository
                    this.Element_Repository = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Repository",                                                                                        // MakerGen.cs:230
                        Path= "MolecularSequence.repository",                                                                               // MakerGen.cs:231
                        Id = "MolecularSequence.repository",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Repository                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 58. MolecularSequence.pointer
                    this.Element_Pointer = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Pointer",                                                                                           // MakerGen.cs:230
                        Path= "MolecularSequence.pointer",                                                                                  // MakerGen.cs:231
                        Id = "MolecularSequence.pointer",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                             // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 59. MolecularSequence.structureVariant
                    this.Element_StructureVariant = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_StructureVariant",                                                                                  // MakerGen.cs:230
                        Path= "MolecularSequence.structureVariant",                                                                         // MakerGen.cs:231
                        Id = "MolecularSequence.structureVariant",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_StructureVariant                                                                                       // MakerGen.cs:254
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
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_CoordinateSystem.Write(sDef);                                                                                       // MakerGen.cs:215
                Element_Patient.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Specimen.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Device.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Performer.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_ReferenceSeq.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Variant.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_ObservedSeq.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Quality.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_ReadCoverage.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Repository.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Pointer.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_StructureVariant.Write(sDef);                                                                                       // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_MolecularSequence_Elements Elements                                                                                 // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_MolecularSequence_Elements();                                                              // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_MolecularSequence_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_MolecularSequence()                                                                                                 // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "MolecularSequence";                                                                                                // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MolecularSequence";                                                         // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "MolecularSequence",                                                                                                 // MakerGen.cs:420
                ElementId = "MolecularSequence"                                                                                             // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
